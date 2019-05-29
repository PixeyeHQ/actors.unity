//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Object = UnityEngine.Object;

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
			this.arg = arg;
			this.action = action;
		}

	}

	public struct Utils
	{

		public bool isAlive;
		public bool isPooled;
		public byte ageCache; // caching age of entity for retrivieng it in future. ( ParseBy method )

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
	public static unsafe class Entity
	{

		public static int entitiesDebugCount;

		public static Transform[] transforms = new Transform[SettingsEngine.SizeEntities];
		public static DBCore[] db = new DBCore[SettingsEngine.SizeEntities];

		static readonly int sizeBufferTags = UnsafeUtility.SizeOf<BufferTags>();
		static readonly int sizeUtils = UnsafeUtility.SizeOf<Utils>();

		internal static int counter = SettingsEngine.SizeEntities;
		internal static readonly int self = "self".GetHashCode();
		
		internal static int[,] generations = new int[SettingsEngine.SizeEntities, SettingsEngine.SizeGenerations];
	
		internal static BufferComponents[] components;
		internal static BufferTags* tags;
		internal static Utils* utils;
		//	internal static BufferComponents* components;
		//===============================//
		// Initialize 
		//===============================//

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		internal static void Start()
		{
			components = new BufferComponents[SettingsEngine.SizeEntities];
			tags = (BufferTags*) UnmanagedMemory.Alloc(sizeBufferTags * SettingsEngine.SizeEntities);
			utils = (Utils*) UnmanagedMemory.Alloc(sizeUtils * SettingsEngine.SizeEntities);

			for (int i = 0; i < SettingsEngine.SizeEntities; i++)
			{
				tags[i] = new BufferTags();
				utils[i] = new Utils();
				components[i] = new BufferComponents(1);
			}

			#if UNITY_EDITOR
			Toolbox.OnDestroyAction += Dispose;
			#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ent Setup(int id, byte age)
		{
			if (id >= counter)
			{
				var l = id << 1;
				HelperArray.ResizeInt(ref generations, l, SettingsEngine.SizeGenerations);
				Array.Resize(ref db, l);

				Array.Resize(ref transforms, l);
				Array.Resize(ref components, l);
				tags = (BufferTags*) UnmanagedMemory.ReAlloc(tags, sizeBufferTags * l);
				utils = (Utils*) UnmanagedMemory.ReAlloc(utils, sizeUtils * l);

				for (int i = counter; i < l; i++)
				{
					tags[i] = new BufferTags();
					utils[i] = new Utils();
					components[i] = new BufferComponents(1);
				}

				counter = l;
			}

			components[id].length = 0;

			utils[id].ageCache = age;
			utils[id].isAlive = true;
			utils[id].isPooled = false;

			entitiesDebugCount++;
			return new ent(id, age);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetupWithTransform(int id, bool pooled, byte age)
		{
			if (id >= counter)
			{
				var l = id << 1;

				HelperArray.ResizeInt(ref generations, l, SettingsEngine.SizeGenerations);
				Array.Resize(ref db, l);

				Array.Resize(ref transforms, l);
				Array.Resize(ref components, l);

				tags = (BufferTags*) UnmanagedMemory.ReAlloc(tags, sizeBufferTags * l);
				utils = (Utils*) UnmanagedMemory.ReAlloc(utils, sizeUtils * l);

				for (int i = counter; i < l; i++)
				{
					tags[i] = new BufferTags();
					utils[i] = new Utils();
					components[i] = new BufferComponents(1);
				}

				counter = l;
			}

			components[id].length = 0;

			utils[id].ageCache = age;
			utils[id].isAlive = true;
			utils[id].isPooled = pooled;

			entitiesDebugCount++;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Link(in this ent entity, db db)
		{
			Entity.db[entity.id] = db;
		}

		public static ent Create()
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			return Setup(id, age);
		}

		#if ODIN_INSPECTOR
		public static ent Create(BlueprintEntity bpAsset)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			var entity = Setup(id, age);
			bpAsset.Execute(entity);
			return entity;
		}
		#endif

		public static ent Create(HandleEntityComposer model)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			EntityComposer.Default.entity = Setup(id, age);
			ref var entity = ref EntityComposer.Default.entity;

			model(EntityComposer.Default);
			Delayed.Set(entity, 0, Delayed.Action.Activate);

			return entity;
		}

		public static ent Bind(GameObject prefab, HandleEntityComposer model, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = prefab.transform;
			EntityComposer.Default.entity = new ent(id, age);

			ref var entity = ref EntityComposer.Default.entity;

			model(EntityComposer.Default);
			Delayed.Set(entity, 0, Delayed.Action.Activate);

			return entity;
		}

		public static ent Create(string prefabID, Vector3 position, HandleEntityComposer model, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;
			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);

			EntityComposer.Default.entity = new ent(id, age);

			ref var entity = ref EntityComposer.Default.entity;

			model(EntityComposer.Default);
			Delayed.Set(entity, 0, Delayed.Action.Activate);

			return entity;
		}

		public static ent Create(string prefabID, HandleEntityComposer model, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			EntityComposer.Default.entity = new ent(id, age);
			ref var entity = ref EntityComposer.Default.entity;

			model(EntityComposer.Default);
			Delayed.Set(entity, 0, Delayed.Action.Activate);

			return entity;
		}

		public static ent Create(GameObject prefab, HandleEntityComposer model, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);

			EntityComposer.Default.entity = new ent(id, age);
			ref var entity = ref EntityComposer.Default.entity;

			model(EntityComposer.Default);
			Delayed.Set(entity, 0, Delayed.Action.Activate);

			return entity;
		}

		public static ent Create(string prefabID, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			return new ent(id, age);
		}

		public static ent Create(GameObject prefab, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);

			return new ent(id, age);
		}

		#if ODIN_INSPECTOR
		public static ent Create(string prefabID, BlueprintEntity bpAsset, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var entity = new ent(id, age);
			bpAsset.Execute(entity);
			return entity;
		}

		public static ent Create(GameObject prefab, BlueprintEntity bpAsset, bool pooled = false)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			SetupWithTransform(id, pooled, age);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var entity = new ent(id, age);
			bpAsset.Execute(entity);
			return entity;
		}
		#endif

		public static void RenameGameobject(this ent entity)
		{
			var tr = transforms[entity.id];
			#if UNITY_EDITOR
			tr.name = $"{entity.id} {tr.name}";
			#else
			tr.name = entity.id.ToString();
			#endif
		}

		#if UNITY_EDITOR
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ent ParseBy(string name)
		{
			var index = 0;
			#if UNITY_EDITOR
			var len = name.Split(' ')[0].Length;
			for (int i = 0; i < len; i++)
				index = index * 10 + (name[i] - '0');
			#else
			for (int i = 0; i < name.Length; i++)
				index = index * 10 + (name[i] - '0');
			#endif

			return new ent(index, utils[index].ageCache);
		}
		#endif

		#region ADD/REMOVE

		public static void SetMonoReference(in this ent entity)
		{
			var entityID = entity.id;
			var mono = transforms[entityID].AddGetActor();
			#if UNITY_EDITOR
			mono._entity = entityID;
			#endif
			mono.entity = entity;
		}

		internal static void Add(in this ent entity, Transform instance)
		{
			ref var transforms = ref Entity.transforms;
			var entityID = entity.id;
			if (entityID >= transforms.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref transforms, l);
			}
			transforms[entityID] = instance;
		}

		public static T AddLater<T>(in this ent entity)
		{
			var storage = Storage<T>.Instance;
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

		public static void AddLater<T>(in this ent entity, T component)
		{
			var storage = Storage<T>.Instance;
			var entityID = entity.id;
			if (entityID >= storage.components.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref storage.components, l);
			}
			ref T val = ref storage.components[entityID];
//			if (val != null)
//			{
//				val.Dispose();
//			}

			val = component;
		}

		public static T Add<T>(in this ent entity)
		{
			var storage = Storage<T>.Instance;
			var entityID = entity.id;

			#if UNITY_EDITOR
			if (!utils[entity.id].isAlive)
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

			if ((generations[entityID, Storage<T>.generation] & Storage<T>.componentMask) == Storage<T>.componentMask)
				return storage.components[entityID];

			generations[entityID, Storage<T>.generation] |= Storage<T>.componentMask;

			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Add);
			return val;
		}

		public static void Add<T>(in this ent entity, T component)
		{
			var storage = Storage<T>.Instance;
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
		public static void Remove<T>(this in ent entity)
		{
			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Remove);
		}

		#endregion

		#region COMPONENTS

		/// <summary>
		/// <para>Returns the transform linked to the entity.</para>
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
			{
				transform = transform.GetChild(sibling);
			}
			return transform.GetComponent<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Component Get(this in ent entity, in int[] path, Type t)
		{
			var transform = transforms[entity];
			foreach (var sibling in path)
			{
				transform = transform.GetChild(sibling);
			}
			return transform.GetComponent(t);
		}

		#endregion

		#region TRANSFORMS

		/// <summary>
		/// <para>Returns the transform linked to the entity.</para>
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>Returns the transform linked to the entity.</returns>
		public static Transform transform(this in ent entity, int index)
		{
			return transforms[entity].GetChild(index);
		}

		public static Transform transform(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2);
		}

		public static Transform transform(this in ent entity, int index1, int index2, int index3)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3);
		}

		public static Transform transform(this in ent entity, int index1, int index2, int index3, int index4)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4);
		}

		public static Transform transform(this in ent entity, int[] siblings)
		{
			var transform = transforms[entity];
			foreach (var sibling in siblings)
			{
				transform = transform.GetChild(sibling);
			}
			return transform;
		}

		#endregion

		static void Dispose()
		{
			UnmanagedMemory.Cleanup();
		}

		public static class Delayed
		{

			public enum Action : byte
			{

				Add,
				ChangeTag,
				Remove,
				Kill,
				KillFinalize,
				Activate,
				Deactivate,
				Unbind,

			}
			public static EntityOperation[] operations = new EntityOperation[SettingsEngine.SizeEntities];
			public static int len;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static void Set(in ent entity, int arg, Action action)
			{
				if (len >= operations.Length)
				{
					var l = len << 1;
					Array.Resize(ref operations, l);
				}
				var pointer = len++;
				ref var operation = ref operations[pointer];
				operation = new EntityOperation(entity, arg, action);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static void Set(in ent entity, Action action)
			{
				if (len >= operations.Length)
				{
					var l = len << 1;
					Array.Resize(ref operations, l);
				}
				var pointer = len++;
				ref var operation = ref operations[pointer];
				operation = new EntityOperation(entity, 0, action);
			}

		}

	}
}