//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	static internal class ProcessorGroups
	{

		internal static DictionaryGroups container = new DictionaryGroups();

		internal static GroupCore SetupGroup(Type groupType, Composition filter)
		{
			GroupCore groupCore;

			if (container.TryGet(groupType, filter, out groupCore))
				return groupCore;

			groupCore = Activator.CreateInstance(groupType, true) as GroupCore;
			groupCore.composition = filter;
			groupCore.Initialize();

			container.Add(groupCore);
			HelperTags.Add(groupCore);

			return groupCore;
		}

		public static void Dispose()
		{
			container.Dispose();
		}

	}

	public enum RefType
	{

		Entity,
		EntityMono
	

	}
}