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
			GroupCore group;

			if (container.TryGet(groupType, filter, out group))
				return group;

			group = Activator.CreateInstance(groupType, true) as GroupCore;
			group.composition = filter;
			group.Initialize();

			container.Add(group);
			HelperTags.Add(group);

			return group;
		}

		public static void Dispose()
		{
			container.Dispose();
		}

	}

	public enum RefType
	{

		Entity,
		EntityMono,

	}
}