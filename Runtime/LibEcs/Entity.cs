//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	public struct Utils
	{
		public int id;
		public bool isAlive;
		public bool isPooled;
		public byte age; // caching age of entity for retrivieng it in future. ( ParseBy method )
	}

	public readonly struct bitBool
	{
		public readonly byte Arg;

		public bitBool(int val)
		{
			Arg = (byte) val;
		}

		static public implicit operator bool(bitBool value)
		{
			return value.Arg == 1;
		}

		static public implicit operator bitBool(bool value)
		{
			return new bitBool(value ? 1 : 0);
		}
	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static unsafe partial class Entity
	{
		public static int Count;

		public static Transform[] transforms = new Transform[SettingsEngine.SizeEntities];

		static readonly int sizeBufferTags = UnsafeUtility.SizeOf<BufferTags>();
		static readonly int sizeUtils = UnsafeUtility.SizeOf<Utils>();

		internal static int counter = SettingsEngine.SizeEntities;
		internal static int[,] generations = new int[SettingsEngine.SizeEntities, SettingsEngine.SizeGenerations];

		internal static BufferComponents[] components;

		internal static BufferTags* tags;
		internal static Utils* cache;

		//===============================//
		// Initialize 
		//===============================//

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		internal static void Start()
		{
			components = new BufferComponents[SettingsEngine.SizeEntities];
			tags       = (BufferTags*) UnmanagedMemory.Alloc(sizeBufferTags * SettingsEngine.SizeEntities);
			cache      = (Utils*) UnmanagedMemory.Alloc(sizeUtils * SettingsEngine.SizeEntities);

			for (int i = 0; i < SettingsEngine.SizeEntities; i++)
			{
				tags[i]       = new BufferTags();
				cache[i]      = new Utils();
				components[i] = new BufferComponents(1);
			}

			#if UNITY_EDITOR
			Toolbox.OnDestroyAction += Dispose;
			#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Initialize(int id, byte age, bool pooled = false)
		{
			if (id >= counter)
			{
				var l = id << 1;
				HelperArray.ResizeInt(ref generations, l, SettingsEngine.SizeGenerations);

				Array.Resize(ref transforms, l);
				Array.Resize(ref components, l);
				tags  = (BufferTags*) UnmanagedMemory.ReAlloc(tags, sizeBufferTags * l);
				cache = (Utils*) UnmanagedMemory.ReAlloc(cache, sizeUtils * l);

				for (int i = counter; i < l; i++)
				{
					tags[i]       = new BufferTags();
					cache[i]      = new Utils();
					components[i] = new BufferComponents(1);
				}

				counter = l;
			}

			components[id].length = 0;

			var ptrCache = &cache[id];
			ptrCache->id       = id;
			ptrCache->age      = age;
			ptrCache->isAlive  = true;
			ptrCache->isPooled = pooled;

			Count++;
		}


		//===============================//
		// Naming
		//===============================//

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenameGameobject(this ent entity)
		{
			var tr = transforms[entity.id];
			tr.name = entity.id.ToString();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ParseBy(string name)
		{
			var index = 0;

			for (int i = 0; i < name.Length; i++)
				index = index * 10 + (name[i] - '0');

			return index;
		}


		//===============================//
		// Add & Set
		//===============================//

		/// <summary>
		/// Used in Models and Actors for setting up components to Storage. Doesn't send the component to systems.
		/// </summary>
		/// <param name="entity"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Set<T>(in this ent entity)
		{
			components[entity.id].Add(Storage<T>.componentID);
			return Storage<T>.Get(entity.id);
		}
		/// <summary>
		/// Used in Models and Actors for setting up components to Storage. Doesn't send the component to systems.
		/// </summary>
		/// <param name="entity"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set<T>(in this ent entity, T component)
		{
			components[entity.id].Add(Storage<T>.componentID);

			ref var componentInStorage = ref Storage<T>.Instance.components[entity.id];
			if (componentInStorage != null)
				Storage<T>.Instance.DisposeComponent(entity.id);

			componentInStorage = component;
		}
		/// <summary>
		/// Deploy entity components to systems.
		/// Note: components from Models and Actors are deployed automatically.
		/// </summary>
		/// <param name="entity"></param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Deploy(in this ent entity)
		{
			EntityOperations.Set(entity, 0, EntityOperations.Action.Activate);
		}
		/// <summary>
		/// Attach component to an entity and systems.
		/// </summary>
		/// <param name="entity"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Add<T>(in this ent entity)
		{
			#if UNITY_EDITOR
			var entityID = entity.id;
			if (!cache[entity.id].isAlive)
			{
				Debug.LogError($"-> Entity with id: [{entityID}] is not active. You should not add components to inactive entity. ");
				return default;
			}
			#endif

			EntityOperations.Set(entity, Storage<T>.componentID, EntityOperations.Action.Add);
			return Storage<T>.Get(entity.id);
		}

		// [MethodImpl(MethodImplOptions.AggressiveInlining)]
		// public static ref T AddRef<T>(in this ent entity)
		// {
		// 	#if UNITY_EDITOR
		// 	var entityID = entity.id;
		// 	if (!cache[entity.id].isAlive)
		// 	{
		// 		Debug.LogError($"-> Entity with id: [{entityID}] is not active. You should not add components to inactive entity. ");
		// 		 
		// 	}
		// 	#endif
		//
		// 	EntityOperations.Set(entity, Storage<T>.componentID, EntityOperations.Action.Add);
		// 	return  Storage<T>.Get(entity.id);
		// }

		/// <summary>
		/// Attach component to an entity and systems.
		/// </summary>
		/// <param name="entity"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Add<T>(in this ent entity, T component)
		{
			EntityOperations.Set(entity, Storage<T>.componentID, EntityOperations.Action.Add);
			Storage<T>.Get(entity.id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Remove<T>(in this ent entity)
		{
			EntityOperations.Set(entity, Storage<T>.componentID, EntityOperations.Action.Remove);
		}

		//===============================//
		// Get
		//===============================//

		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity) where T : Component
		{
			return transforms[entity].GetComponentInChildren<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, int index1) where T : Component
		{
			return transforms[entity].GetChild(index1).GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, int index1, int index2) where T : Component
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, int index1, int index2, int index3) where T : Component
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, int index1, int index2, int index3, int index4) where T : Component
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4).GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, string path) where T : Component
		{
			return transforms[entity].Find(path).GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetMono<T>(in this ent entity, in int[] path) where T : Component
		{
			var transform = transforms[entity];
			foreach (var sibling in path)
				transform = transform.GetChild(sibling);

			return transform.GetComponent<T>();
		}
		/// <summary>
		/// Returns the transform linked to the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Component GetMono(in this ent entity, in int[] path, Type t)
		{
			var transform = transforms[entity];
			foreach (var sibling in path)
				transform = transform.GetChild(sibling);


			return transform.GetComponent(t);
		}

		static void Dispose()
		{
			UnmanagedMemory.Cleanup();
		}
	}
}