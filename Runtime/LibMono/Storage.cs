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
		internal int lenOfGroups;


		public Type componentType;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal abstract void AddGroupExclude(GroupCore groupCore);


		internal static void Dispose()
		{
			for (int i = 0; i < lastID; i++)
			{
				all[i].lenOfGroups = 0;
			}
		}


		internal int[] toDispose = new int[Entity.settings.SizeEntities];
		internal int toDisposeLen;

		internal SetupBase setupBase;

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
		public abstract class SetupBase
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public virtual void Dispose(int[] id, int len)
			{
			}
		}
	}


	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public sealed class Storage<T> : Storage
	{
		public static readonly Storage<T> Instance = new Storage<T>();

		public static int componentID;
		public static int componentMask;
		public static int generation;

		public int len = 0;

		public static T[] components = new T[Entity.settings.SizeEntities];

		//public ref T this[int index] => ref components[index];

		internal static Setup setup;

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
			componentType = type;


			//	var t = components[0];
		}


		// public void Dispose()
		// {
		// 	lenOfGroups = 0;
		// }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Get(int entityID)
		{
			if (entityID >= components.Length)
				Array.Resize(ref components, entityID << 1);


			#if !ACTORS_COMPONENTS_STRUCTS
			ref var val = ref components[entityID];
			if (val == null)
				val = setup.Create();
			#endif

			return ref components[entityID];
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Add(GroupCore groupCore)
		{
			if (lenOfGroups == groups.Length)
				Array.Resize(ref groups, lenOfGroups << 1);

			groups[lenOfGroups++] = groupCore;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override void AddGroupExclude(GroupCore groupCore)
		{
			if (lenOfGroups == groups.Length)
				Array.Resize(ref groups, lenOfGroups << 1);

			groups[lenOfGroups++] = groupCore;
		}


		#if !ACTORS_COMPONENTS_STRUCTS
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T TryGet(int entityID)
		{
			return (Entity.generations[entityID, generation] & componentMask) == componentMask ? components[entityID] : default;
		}
		#endif


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
		public abstract class Setup : SetupBase
		{
			protected T[] components;

			public Setup()
			{
				Instance.setupBase = this;
				setup              = this;
				components         = Storage<T>.components;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public abstract T Create();
		}
	}
}