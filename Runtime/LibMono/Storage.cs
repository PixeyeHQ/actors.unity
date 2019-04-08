/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Object = System.Object;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public abstract class Storage
	{

		internal static int[] masks = new int[32];
		internal static int[] generations = new int[32];
		internal static Storage[] all = new Storage[32];
		internal static Dictionary<int, Storage> allDict = new Dictionary<int, Storage>(new FastComparable());

		internal static int lastID;

		internal ArrayEntities entitiesToPopulate = new ArrayEntities();
		internal ArrayEntities entitiesToRemove = new ArrayEntities();

		internal abstract int GetComponentID();
	
		internal GroupCore[] groupsOfInterest = new GroupCore[8];
		internal int lenOfGroups;

	//	public abstract void AddNoCheckAbstract(int entityID);

		public abstract void RemoveNoCheck(int entityID);

		//internal static List<Storage> all = new List<Storage>(40);

		//	internal abstract void Add(in ent entity);
		//	internal abstract void Remove(in ent entity);
		//public abstract void Deploy(in ent entity);

	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public sealed class Storage<T> : Storage where T : IComponent, new()
	{

		public Func<T> Creator;

		//	public static int componentHash;
		public static int componentID;
		public static int componentMask;
		public static int generation;

		public static readonly Storage<T> Instance = new Storage<T>();

		public int len = 0;

		public T[] components = new T[SettingsEngine.SizeComponents];

		public T this[int index] => components[index];

		public void Add(GroupCore group)
		{
			if (lenOfGroups == groupsOfInterest.Length)
				Array.Resize(ref groupsOfInterest, lenOfGroups << 1);

			groupsOfInterest[lenOfGroups++] = group;
		}

		public Storage()
		{
			if (lastID == all.Length)
			{
				var l = lastID << 1;
				Array.Resize(ref all, l);
				Array.Resize(ref masks, l);
				Array.Resize(ref generations, l);
			}

			componentID = lastID++;
			all[componentID] = this;

			componentMask = 1 << (componentID % 32);
			generation = componentID / 32;

			masks[componentID] = componentMask;
			generations[componentID] = generation;
			 
			allDict.Add(typeof(T).GetHashCode(), this);
		}

		internal override int GetComponentID()
		{
			return componentID;
		}
//		public override void AddNoCheckAbstract(int entityID)
//		{
//			CoreEntity.generations[entityID, generation] |= componentMask;
//		}

		public override void RemoveNoCheck(int entityID)
		{
			CoreEntity.generations[entityID, generation] &= ~componentMask;
		}

		public T TryGet(int entityID)
		{
			return HelperFramework.BitCheck(CoreEntity.generations[entityID, generation], componentMask) ? components[entityID] : default;
		}

		public T GetFromStorage(int entityID)
		{
			T val;
			if (entityID >= components.Length)
			{
				var l = entityID << 1;
				Array.Resize(ref components, l);
			}

			val = components[entityID];
			if (val == null)
			{
				val = Creator();
				components[entityID] = val;
			}

			return val;
		}

	}
}