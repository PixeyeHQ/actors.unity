//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed class DictionaryGroup
	{
		internal GroupCore[] storage = new GroupCore[10];
		internal int len;
	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed class DictionaryGroupTags
	{
		internal DictionaryGroup[] groupStorage = new DictionaryGroup[10];
		internal int[] tagsID = new int[10];

		internal int len;

		internal bool TryGetValue(int tagID, out DictionaryGroup groupOld)
		{
			var id = -1;
			for (int i = 0; i < len; i++)
			{
				if (tagsID[i] == tagID)
				{
					id = i;
					break;
				}

				id = -1;
			}

			if (id > -1)
			{
				groupOld = groupStorage[id];
				return true;
			}

			groupOld = default;
			return false;
		}

		internal int TryGetValue(int tagID)
		{
			return len == 0 ? -1 : HelperArray.BinarySearch(ref tagsID, tagID, 0, len);
		}

		internal void Add(int tagID, DictionaryGroup anotherGroupStorage)
		{
			if (len == groupStorage.Length - 1)
			{
				var l = len << 1;
				Array.Resize(ref groupStorage, l);
				Array.Resize(ref tagsID, l);
			}

			var pointer   = len++;
			var indexLast = pointer;
			var index     = pointer - 1;

			if (index >= 0)
			{
				if (tagID < tagsID[index])
				{
					var startIndex = 0;
					var endIndex   = indexLast;

					while (endIndex > startIndex)
					{
						var middleIndex = (endIndex + startIndex) / 2;
						var middleValue = tagsID[middleIndex];

						if (middleValue == tagID)
						{
							pointer = middleIndex;

							break;
						}

						if (middleValue < tagID)
						{
							startIndex = middleIndex + 1;
							pointer    = startIndex;
						}
						else
						{
							endIndex = middleIndex;
							pointer  = endIndex;
						}
					}
				}
			}

			for (int i = indexLast; i >= pointer; i--)
			{
				tagsID[i + 1]       = tagsID[i];
				groupStorage[i + 1] = groupStorage[i];
			}

			groupStorage[pointer] = anotherGroupStorage;
			tagsID[pointer]       = tagID;
		}
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
				if (t != instance.GetType()) continue;

				if (instance.composition.hash.value == composition.hash.value)
				{
					group = instance;
					return true;
				}
			}

			group = default;
			return false;
		}

		public static GroupCore Add(this DictionaryGroup container, GroupCore group)
		{
			ref var len     = ref container.len;
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