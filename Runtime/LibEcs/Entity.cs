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
	public readonly struct EntityOperation
	{
		public readonly ent entity;
		public readonly int arg;
		public readonly Entity.Delayed.Action action;

		public EntityOperation(in ent entity, int arg, Entity.Delayed.Action action)
		{
			this.entity = entity;
			this.arg    = arg;
			this.action = action;
		}
	}

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
		public static ent ParseBy(string name)
		{
			var index = 0;

			for (int i = 0; i < name.Length; i++)
				index = index * 10 + (name[i] - '0');

			return new ent(index, cache[index].age);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ParseByIn(string name)
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
		/// Use in Model classes for setting up components to Storage. Doesn't send the component to systems.
		/// </summary>
		/// <param name="entity"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Set<T>(in this ent entity)
		{
			components[entity.id].Add(Storage<T>.componentID);
			return Storage<T>.Instance.GetFromStorage(entity.id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Add<T>(in this ent entity)
		{
			var storage  = Storage<T>.Instance;
			var entityID = entity.id;

			#if UNITY_EDITOR
			if (!cache[entity.id].isAlive)
			{
				Debug.LogError($"-> Entity with id: [{entityID}] is not active. You should not add components to inactive entity. ");
				return default;
			}
			#endif

			if (entityID >= storage.components.Length)
				Array.Resize(ref storage.components, entityID << 1);

			ref T val = ref storage.components[entityID];

			if (val == null)
				val = storage.Creator();


			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Add);
			return val;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Add<T>(in this ent entity, T component)
		{
			var storage  = Storage<T>.Instance;
			var entityID = entity.id;
			if (entityID >= storage.components.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref storage.components, l);
			}

			ref T val = ref storage.components[entityID];

			if (val != null)
				Storage<T>.Instance.DisposeAction(val);

			val = component;

			generations[entityID, Storage<T>.generation] |= Storage<T>.componentMask;

			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Add);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Add(in this ent entity, Transform instance)
		{
			ref var transforms = ref Entity.transforms;
			var     entityID   = entity.id;
			if (entityID >= transforms.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref transforms, l);
			}

			transforms[entityID] = instance;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T AddLater<T>(in this ent entity)
		{
			var storage  = Storage<T>.Instance;
			var entityID = entity.id;
			if (entityID >= storage.components.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref storage.components, l);
			}

			ref T val = ref storage.components[entityID];
			if (val == null)
			{
				val = storage.Creator();
			}

			return val;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddLater<T>(in this ent entity, T component)
		{
			var storage  = Storage<T>.Instance;
			var entityID = entity.id;
			if (entityID >= storage.components.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref storage.components, l);
			}

			ref T val = ref storage.components[entityID];

			val = component;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Remove<T>(this in ent entity)
		{
			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Remove);
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
		public static T Get<T>(this in ent entity)
		{
			return transforms[entity].GetComponentInChildren<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, int index1)
		{
			return transforms[entity].GetChild(index1).GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, int index1, int index2, int index3)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, int index1, int index2, int index3, int index4)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4).GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, string path)
		{
			return transforms[entity].Find(path).GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this in ent entity, in int[] path)
		{
			var transform = transforms[entity];
			foreach (var sibling in path)
				transform = transform.GetChild(sibling);

			return transform.GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Component Get(this in ent entity, in int[] path, Type t)
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