//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static class Entity
	{

		public static int entitiesCount;

		internal static int counter = SettingsEngine.SizeEntities;
		internal static readonly int self = "self".GetHashCode();

		internal static BitArray isAlive = new BitArray(SettingsEngine.SizeEntities);
		internal static BitArray isPooled = new BitArray(SettingsEngine.SizeEntities);

		public static Transform[] transforms = new Transform[SettingsEngine.SizeEntities];
		public static int[] db = new int[SettingsEngine.SizeEntities];

		internal static int[,] generations = new int[SettingsEngine.SizeEntities, SettingsEngine.SizeGenerations];
		internal static BufferTags[] tags = new BufferTags[SettingsEngine.SizeEntities];
		internal static BufferComponents[] components = new BufferComponents[SettingsEngine.SizeEntities];

		#region SETUP

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Setup(int id)
		{
			if (id >= counter)
			{
				var l = id << 1;
				isAlive.Length = l;
				HelperArray.ResizeInt(ref generations, l, SettingsEngine.SizeGenerations);
				Array.Resize(ref tags, l);
				Array.Resize(ref components, l);
				Array.Resize(ref db, l);

				counter = l;
			}

			components[id].Setup();
			isAlive[id] = true;
			entitiesCount++;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetupWithTransform(int id, bool pooled)
		{
			if (id >= counter)
			{
				var l = id << 1;
				isAlive.Length = l;
				isPooled.Length = l;

				HelperArray.ResizeInt(ref generations, l, SettingsEngine.SizeGenerations);
				Array.Resize(ref tags, l);
				Array.Resize(ref transforms, l);
				Array.Resize(ref components, l);
				Array.Resize(ref db, l);

				counter = l;
			}

			components[id].Setup();
			isAlive[id] = true;
			isPooled[id] = pooled;

			entitiesCount++;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void BindDB(int id, int db)
		{
			Entity.db[id] = db;
		}

		#endregion

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

			Setup(id);

			return new ent(id, age);
		}

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

			Setup(id);
			var entity = new ent(id, age);
			bpAsset.Populate(entity);
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

			SetupWithTransform(id, pooled);
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

			SetupWithTransform(id, pooled);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);

			return new ent(id, age);
		}

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

			SetupWithTransform(id, pooled);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var entity = new ent(id, age);
			bpAsset.Populate(entity);
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

			SetupWithTransform(id, pooled);
			transforms[id] = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var entity = new ent(id, age);
			bpAsset.Populate(entity);
			return entity;
		}

//		[MethodImpl(MethodImplOptions.AggressiveInlining)]
//		public static void EntityIdFromName(this string name, ref int index)
//		{
//			for (int l = 0; l < name.Length; l++)
//				index *= 10 + (name[l] - '0');
//		}

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

		#if ODIN_INSPECTOR
		public static void Set(in this ent entity, db dbID)
		{
			db[entity.id] = dbID.hash;
		}
		#endif

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

		public static T AddLater<T>(in this ent entity) where T : IComponent, new()
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

		public static void AddLater<T>(in this ent entity, T component) where T : IComponent, new()
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
			{
				val.Dispose();
			}

			val = component;
		}

		public static T Add<T>(in this ent entity) where T : IComponent, new()
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

			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Add);
			return val;
		}

		public static void Add<T>(in this ent entity, T component) where T : IComponent, new()
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
				val.Dispose();

			val = component;
			Delayed.Set(entity, Storage<T>.componentID, Delayed.Action.Add);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Remove<T>(this in ent entity) where T : IComponent, new()
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

		public static T Get<T>(this in ent entity, string path)
		{
			return transforms[entity].Find(path).GetComponent<T>();
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
		public static T Get<T>(this in ent entity, in int[] path)
		{
			var transform = transforms[entity];
			foreach (var sibling in path)
			{
				transform = transform.GetChild(sibling);
			}
			return transform.GetComponent<T>();
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
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
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
		public static Transform transform(this in ent entity, int index)
		{
			return transforms[entity].GetChild(index);
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
		public static Transform transform(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2);
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
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
				Deactivate

			}
			public static EntityOperation[] operations = new EntityOperation[SettingsEngine.SizeEntities];
			public static int len;

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