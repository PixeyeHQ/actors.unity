/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
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

 

		internal GroupCore[] groups = new GroupCore[8];
		internal GroupCore[] groupsToRemove = new GroupCore[8];
		internal int lenOfGroups;
		internal int lenOfGroupsToRemove;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract int GetComponentID();
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract void DisposeComponent(int entityID);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract void RemoveNoCheck(int entityID);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract void AddGroupExclude(GroupCore groupCore);
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract object GetComponent(int entityID);
		

	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public sealed class Storage<T> : Storage
	{

		public Func<T> Creator;
		public Action<T> DisposeAction = delegate { };

		public static int componentID;
		public static int componentMask;
		public static int generation;

		public static readonly Storage<T> Instance = new Storage<T>();

		public int len = 0;

		public T[] components = new T[SettingsEngine.SizeEntities];

		public T this[int index] => components[index];

		public void Add(GroupCore groupCore)
		{
			if (lenOfGroups == groups.Length)
				Array.Resize(ref groups, lenOfGroups << 1);

			groups[lenOfGroups++] = groupCore;
		}

		internal override void AddGroupExclude(GroupCore groupCore)
		{
			if (lenOfGroupsToRemove == groupsToRemove.Length)
				Array.Resize(ref groupsToRemove, lenOfGroupsToRemove << 1);

			groupsToRemove[lenOfGroupsToRemove++] = groupCore;
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

			var type = typeof(T);
			allDict.Add(type.GetHashCode(), this);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int GetComponentID()
		{
			return componentID;
		}
    
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override void DisposeComponent(int entityID)
		{
			DisposeAction(components[entityID]);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override void RemoveNoCheck(int entityID)
		{
			Entity.generations[entityID, generation] &= ~componentMask;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override object GetComponent(int entityID)
		{
			return components[entityID];
		}
 

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T TryGet(int entityID)
		{
			return (Entity.generations[entityID, generation] & componentMask) == componentMask ? components[entityID] : default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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