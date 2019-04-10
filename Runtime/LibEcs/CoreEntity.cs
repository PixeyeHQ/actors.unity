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
	public struct EntityOperation
	{

		public ent entity;
		public int arg;
		public CoreEntity.Delayed.Action action;

	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static class CoreEntity
	{

		public static int entitiesCount;
		internal static int counter = SettingsEngine.SizeEntities;
  
		internal static readonly int self = "self".GetHashCode();

		internal static BitArray isAlive = new BitArray(SettingsEngine.SizeEntities);
		internal static BitArray isPooled = new BitArray(SettingsEngine.SizeEntities);
		internal static Transform[] transforms = new Transform[SettingsEngine.SizeEntities];

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
				counter = l;
			}

			components[id].Setup();
			isAlive[id] = true;
			isPooled[id] = pooled;
			entitiesCount++;
		}

		#endregion

		#region ADD/REMOVE

		public static void AddMonoReference(in this ent entity)
		{
			var entityID = entity.id;
			var mono = transforms[entityID].AddGet<MonoEntity>();
			#if UNITY_EDITOR
			mono._entity = entityID;
			#endif
			mono.entity = entity;
		}

		internal static void Add(in this ent entity, Transform instance)
		{
			ref var transforms = ref CoreEntity.transforms;
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
				operation.action = action;
				operation.entity = entity;
				operation.arg = arg;
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
				operation.action = action;
				operation.entity = entity;
				operation.arg = 0;
			}

		}

	}
}