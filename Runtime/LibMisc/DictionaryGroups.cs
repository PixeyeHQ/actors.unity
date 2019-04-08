//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	internal class DictionaryGroups : IDisposable
	{

		internal GroupCore[] storage = new GroupCore[3];
		internal int len;

		internal void Add(GroupCore group)
		{
			if (len == storage.Length)
			{
				var l = len << 1;
				Array.Resize(ref storage, l);
			}

			storage[len++] = group;
		}

		internal bool Contain(GroupCore group)
		{
			for (int i = 0; i < len; i++)
			{
				var groupAdded = storage[i];
				if (groupAdded.Equals(group)) return true;
			}

			return false;
		}

		internal bool TryGet(Type t, Composition composition, out GroupCore group)
		{
			for (int i = 0; i < len; i++)
			{
				var instance            = storage[i];
				var instanceType        = instance.GetType();
				var instanceComposition = instance.composition;

				if (t != instanceType) continue;
				if (!instanceComposition.Equals(composition)) continue;
				group = instance;
				return true;
			}

			group = default;
			return false;
		}

		public void Dispose()
		{
			for (int i = 0; i < len; i++)
			{
				storage[i].Dispose();
			}

			len = 0;
		}

	}
}