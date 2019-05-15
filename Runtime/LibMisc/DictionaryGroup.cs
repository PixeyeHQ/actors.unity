//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed class DictionaryGroup
	{

		internal GroupCore[] storage = new GroupCore[10];
		internal int len;

	}
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	static class HelperDictionary
	{

		public static bool Contain(this DictionaryGroup container, GroupCore groupCore)
		{
			var len = container.len;
			for (int i = 0; i < len; i++)
			{
				var groupAdded = container.storage[i];
				if (groupAdded.Equals(groupCore)) return true;
			}
			return false;
		}

		public static bool TryGetValue(this DictionaryGroup container, Type t, Composition composition, out GroupCore group)
		{
			var len = container.len;
			for (int i = 0; i < len; i++)
			{
				var instance = container.storage[i];
				var instanceType = instance.GetType();
				var instanceComposition = instance.composition;

				if (t != instanceType) continue;
				if (!instanceComposition.Equals(composition)) continue;
				group = instance;
				return true;
			}

			group = default;
			return false;
		}

		public static GroupCore Add(this DictionaryGroup container, GroupCore group)
		{
			ref var len = ref container.len;
			ref var storage = ref container.storage;
			if (len == storage.Length)
			{
				var l = container.len << 1;
				Array.Resize(ref storage, l);
			}

			storage[len++] = group;
			return group;
		}

		public static void Dispose(this DictionaryGroup container)
		{
			for (int i = 0; i < container.len; i++)
			{
				container.storage[i].Dispose();
			}

			container.len = 0;
		}

	}
}