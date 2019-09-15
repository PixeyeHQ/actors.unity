/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public abstract class Storage
	{
		internal static int[] masks = new int[32];
		internal static int[] generations = new int[32];
		internal static Storage[] all = new Storage[32];
		internal static Dictionary<int, int> typeNames = new Dictionary<int, int>(FastComparable.Default);

		internal static int lastID;

		internal GroupCore[] groups = new GroupCore[8];
		internal int groupsLen;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract void AddGroupExclude(GroupCore groupCore);


		internal static void Wipe()
		{
			for (int i = 0; i < lastID; i++)
				all[i].groupsLen = 0;
		}


		public int[] disposed = new int[Entity.settings.SizeEntities];
		public int disposedLen;


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void Dispose()
		{
		}

		internal abstract Type GetComponentType();
	}


	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class Storage<T> : Storage
	{
		public static Storage<T> Instance;

		public static int componentID;
		public static int componentMask;
		public static int generation;

		internal int componentsLen = 0;

		public static T[] components = new T[Entity.settings.SizeEntities];


		public Storage()
		{
			if (lastID == all.Length)
			{
				var l = lastID << 1;
				Array.Resize(ref all, l);
				Array.Resize(ref masks, l);
				Array.Resize(ref generations, l);
			}

			componentID      = lastID++;
			all[componentID] = this;

			masks[componentID]       = componentMask = 1 << (componentID % 32);
			generations[componentID] = generation    = componentID / 32;

			var type = typeof(T);
			typeNames.Add(type.GetHashCode(), componentID);
			Instance = this;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual T Create()
		{
			return default;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override Type GetComponentType()
		{
			return typeof(T);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Get(int entityID)
		{
			if (entityID >= components.Length)
				Array.Resize(ref components, entityID << 1);


			#if !ACTORS_COMPONENTS_STRUCTS
			ref var val = ref components[entityID];
			if (val == null)
				val = Instance.Create();
			#endif

			return ref components[entityID];
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Add(GroupCore groupCore)
		{
			if (groupsLen == groups.Length)
				Array.Resize(ref groups, groupsLen << 1);

			groups[groupsLen++] = groupCore;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override void AddGroupExclude(GroupCore groupCore)
		{
			if (groupsLen == groups.Length)
				Array.Resize(ref groups, groupsLen << 1);

			groups[groupsLen++] = groupCore;
		}


		#if !ACTORS_COMPONENTS_STRUCTS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T TryGet(int entityID)
		{
			return (Entity.generations[entityID, generation] & componentMask) == componentMask ? components[entityID] : default;
		}
		#endif
	}
}