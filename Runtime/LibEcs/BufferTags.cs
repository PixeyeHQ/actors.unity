//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#define ACTORS_TAGS_DEFAULT

#if ACTORS_TAGS_6 || ACTORS_TAGS_12
#undef ACTORS_TAGS_DEFAULT
#endif

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferTags
	{

		// tags
		#if ACTORS_TAGS_24 || ACTORS_TAGS_DEFAULT
		public const int Capacity = 24;

		private ushort tag0;
		private ushort tag1;
		private ushort tag2;
		private ushort tag3;
		private ushort tag4;
		private ushort tag5;
		private ushort tag6;
		private ushort tag7;
		private ushort tag8;
		private ushort tag9;
		private ushort tag10;
		private ushort tag11;
		private ushort tag12;
		private ushort tag13;
		private ushort tag14;
		private ushort tag15;
		private ushort tag16;
		private ushort tag17;
		private ushort tag18;
		private ushort tag19;
		private ushort tag20;
		private ushort tag21;
		private ushort tag22;
		private ushort tag23;
		#elif ACTORS_TAGS_12
		public const int Capacity = 12;

		private ushort tag0;
		private ushort tag1;
		private ushort tag2;
		private ushort tag3;
		private ushort tag4;
		private ushort tag5;
		private ushort tag6;
		private ushort tag7;
		private ushort tag8;
		private ushort tag9;
		private ushort tag10;
		private ushort tag11;
		#elif ACTORS_TAGS_6
		public const int Capacity = 6;

		private ushort tag0;
		private ushort tag1;
		private ushort tag2;
		private ushort tag3;
		private ushort tag4;
		private ushort tag5;
		#endif

		private byte length;

		#if ACTORS_TAGS_24 || ACTORS_TAGS_DEFAULT
		private byte tag0Len;
		private byte tag1Len;
		private byte tag2Len;
		private byte tag3Len;
		private byte tag4Len;
		private byte tag5Len;
		private byte tag6Len;
		private byte tag7Len;
		private byte tag8Len;
		private byte tag9Len;
		private byte tag10Len;
		private byte tag11Len;
		private byte tag12Len;
		private byte tag13Len;
		private byte tag14Len;
		private byte tag15Len;
		private byte tag16Len;
		private byte tag17Len;
		private byte tag18Len;
		private byte tag19Len;
		private byte tag20Len;
		private byte tag21Len;
		private byte tag22Len;
		private byte tag23Len;
		#elif ACTORS_TAGS_12
		private byte tag0Len;
		private byte tag1Len;
		private byte tag2Len;
		private byte tag3Len;
		private byte tag4Len;
		private byte tag5Len;
		private byte tag6Len;
		private byte tag7Len;
		private byte tag8Len;
		private byte tag9Len;
		private byte tag10Len;
		private byte tag11Len;
		#elif ACTORS_TAGS_6
		private byte tag0Len;
		private byte tag1Len;
		private byte tag2Len;
		private byte tag3Len;
		private byte tag4Len;
		private byte tag5Len;
		#endif

		public ref ushort this[int index] => ref GetElementByRef(index);

		public int Length => length;

		public int GetLength()
		{
			return length;
		}

		public void Clear()
		{
			fixed (ushort* elements = &tag0)
				for (int i = 0; i < length; i++)
					elements[i] = 0;

			fixed (byte* elements = &tag0Len)
				for (int i = 0; i < length; i++)
					elements[i] = 0;

			length = 0;
		}

		public byte GetTagSize(int index)
		{
			fixed (byte* elements = &tag0Len)
			{
				return elements[index];
			}
		}
		public void RemoveAt(int index)
		{
			for (int i = index; i < length - 1; ++i)
				SetElem(i, GetElement(i + 1));

			length--;
		}

		public void SetElement(int index, int arg)
		{
			fixed (ushort* elements = &tag0)
				elements[index] = (ushort) arg;

			fixed (byte* elements = &tag0Len)
				elements[index] = 1;

			length++;
		}

		public void Increase(int index)
		{
			fixed (byte* elements = &tag0Len)
				unchecked
				{
					elements[index] += 1;
				}
		}

		public bool Decrease(int index)
		{
			fixed (byte* elements = &tag0Len)
			{
				if (--elements[index] == 0)
				{
					RemoveAt(index);
					return true;
				}

				return false;
			}
		}

		public void ClearAt(int index)
		{
			fixed (byte* elements = &tag0Len)
			{
				elements[index] = 0;
				RemoveAt(index);
			}
		}

		internal ref ushort GetElementByRef(int index)
		{
			fixed (ushort* elements = &tag0)
				return ref elements[index];
		}

		private void SetElem(int index, int arg)
		{
			fixed (ushort* elements = &tag0)
				elements[index] = (ushort) arg;

			fixed (byte* elements = &tag0Len)
				elements[index] = 1;
		}

		private ushort GetElement(int index)
		{
			fixed (ushort* elements = &tag0)
				return elements[index];
		}

	}

	public static class HelperTags
	{

		internal static DictionaryGroupTags inUseGroups = new DictionaryGroupTags();

		public static void ClearTags(in this ent entity)
		{
			CoreEntity.tags[entity.id].Clear();
		}

		public static void Clear(int entityID)
		{
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			for (int i = 0; i < length; i++)
			{
				tags[i] = 0;
			}
		}

		public static void Add(in this ent entity, int tagID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];

			for (int i = 0; i < tags.Length; i++)
			{
				if (tags[i] == tagID)
				{
					tags.Increase(i);
					return;
				}
			}

			#if UNITY_EDITOR
			if (tags.Length == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif

			var fistAvailable = tags.Length;
			tags.SetElement(fistAvailable, tagID);

			HandleChange(entity, tagID);
		}
		public static void Add(in this ent entity, params int[] tagsID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var len = tags.GetLength();

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tagID = tagsID[i];
				var needToAdd = true;
				for (int l = 0; l < len; l++)
				{
					if (tags[l] == tagID)
					{
						tags.Increase(l);
						needToAdd = false;
						break;
					}
				}

				if (!needToAdd) continue;

				#if UNITY_EDITOR
				if (tags.Length == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				var fistAvailable = tags.GetLength();
				tags.SetElement(fistAvailable, tagID);
				HandleChange(entity, tagID);
			}
		}

		public static void AddLater(in this ent entity, int tagID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];

			for (int i = 0; i < tags.Length; i++)
			{
				if (tags[i] == tagID)
				{
					tags.Increase(i);
					return;
				}
			}

			#if UNITY_EDITOR
			if (tags.Length == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif

			var fistAvailable = tags.Length;
			tags.SetElement(fistAvailable, tagID);
		}

		public static void AddLater(in this ent entity, params int[] tagsID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];

			var len = tags.GetLength();

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tagID = tagsID[i];
				var needToAdd = true;
				for (int l = 0; l < len; l++)
				{
					if (tags[l] == tagID)
					{
						tags.Increase(l);
						needToAdd = false;
						break;
					}
				}

				if (!needToAdd) continue;

				#if UNITY_EDITOR
				if (tags.Length == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				var fistAvailable = tags.GetLength();
				tags.SetElement(fistAvailable, tagID);
			}
		}

		public static void Remove(in this ent entity, int tagID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			for (int i = 0; i < length; i++)
			{
				if (tags.GetElementByRef(i) == tagID)
				{
					if (tags.Decrease(i))
					{
						HandleChange(entity, tagID);
					}

					return;
				}
			}
		}

		public static void RemoveAll(in this ent entity, params int[] tagsID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();

			for (int l = 0; l < tagsID.Length; l++)
			{
				var tagID = tagsID[l];
				for (int i = 0; i < length; i++)
				{
					if (tags.GetElementByRef(i) == tagID)
					{
						tags.ClearAt(i);
						HandleChange(entity, tagID);
						break;
					}
				}
			}
		}

		public static void RemoveAll(in this ent entity, int tagID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			for (int i = 0; i < length; i++)
			{
				if (tags.GetElementByRef(i) == tagID)
				{
					tags.ClearAt(i);
					HandleChange(entity, tagID);
					return;
				}
			}
		}

		public static bool Has(in this ent entity, int tagID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			for (int i = 0; i < length; i++)
			{
				if (tags.GetElementByRef(i) == tagID)
					return true;
			}

			return false;
		}

		public static bool Has(in this ent entity, params int[] tagsID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			if (length == 0) return false;

			var match = 0;

			for (int l = 0; l < tagsID.Length; l++)
			{
				var tagToLook = tagsID[l];
				for (int i = 0; i < length; i++)
				{
					if (tags.GetElementByRef(i) == tagToLook) match++;
				}
			}

			return match == tagsID.Length;
		}

		public static bool HasAny(in this ent entity, params int[] tagsID)
		{
			var entityID = entity.id;
			ref var tags = ref CoreEntity.tags[entityID];
			var length = tags.GetLength();
			if (length == 0) return false;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tagID = tagsID[i];
				for (int l = 0; l < length; l++)
				{
					if (tags.GetElementByRef(l) == tagID)
						return true;
				}
			}

			return false;
		}

		internal static void Add(GroupCore group)
		{
			DictionaryGroups container;
			var filter = group.composition;

			foreach (var tagID in filter.tagsToInclude)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(group)) continue;

					container.Add(group);
				}
				else
				{
					container = new DictionaryGroups();

					container.Add(group);
					inUseGroups.Add(tagID, container);
				}
			}

			foreach (var tagID in filter.tagsToExclude)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(group)) continue;
					container.Add(group);
				}
				else
				{
					container = new DictionaryGroups();
					container.Add(group);
					inUseGroups.Add(tagID, container);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void HandleChange(in ent entity, int tagID)
		{
			var indexGroup = inUseGroups.TryGetValue(tagID);
			if (indexGroup == -1) return;
			var en = entity;
			CoreEntity.Delayed.Set(en, indexGroup, CoreEntity.Delayed.Action.ChangeTag);
		}

	}
}