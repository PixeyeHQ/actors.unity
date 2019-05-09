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

		public ushort tag0;
		public ushort tag1;
		public ushort tag2;
		public ushort tag3;
		public ushort tag4;
		public ushort tag5;
		public ushort tag6;
		public ushort tag7;
		public ushort tag8;
		public ushort tag9;
		public ushort tag10;
		public ushort tag11;
		public ushort tag12;
		public ushort tag13;
		public ushort tag14;
		public ushort tag15;
		public ushort tag16;
		public ushort tag17;
		public ushort tag18;
		public ushort tag19;
		public ushort tag20;
		public ushort tag21;
		public ushort tag22;
		public ushort tag23;
		#elif ACTORS_TAGS_12
		public const int Capacity = 12;

		public ushort tag0;
		public ushort tag1;
		public ushort tag2;
		public ushort tag3;
		public ushort tag4;
		public ushort tag5;
		public ushort tag6;
		public ushort tag7;
		public ushort tag8;
		public ushort tag9;
		public ushort tag10;
		public ushort tag11;
		#elif ACTORS_TAGS_6
		public const int Capacity = 6;

		public ushort tag0;
		public ushort tag1;
		public ushort tag2;
		public ushort tag3;
		public ushort tag4;
		public ushort tag5;
		#endif

		public byte length;

		#if ACTORS_TAGS_24 || ACTORS_TAGS_DEFAULT
		public byte tag0Len;
		public byte tag1Len;
		public byte tag2Len;
		public byte tag3Len;
		public byte tag4Len;
		public byte tag5Len;
		public byte tag6Len;
		public byte tag7Len;
		public byte tag8Len;
		public byte tag9Len;
		public byte tag10Len;
		public byte tag11Len;
		public byte tag12Len;
		public byte tag13Len;
		public byte tag14Len;
		public byte tag15Len;
		public byte tag16Len;
		public byte tag17Len;
		public byte tag18Len;
		public byte tag19Len;
		public byte tag20Len;
		public byte tag21Len;
		public byte tag22Len;
		public byte tag23Len;
		#elif ACTORS_TAGS_12
		public byte tag0Len;
		public byte tag1Len;
		public byte tag2Len;
		public byte tag3Len;
		public byte tag4Len;
		public byte tag5Len;
		public byte tag6Len;
		public byte tag7Len;
		public byte tag8Len;
		public byte tag9Len;
		public byte tag10Len;
		public byte tag11Len;
		#elif ACTORS_TAGS_6
		public byte tag0Len;
		public byte tag1Len;
		public byte tag2Len;
		public byte tag3Len;
		public byte tag4Len;
		public byte tag5Len;
		#endif

		public ref ushort this[int index] => ref GetElementByRef(index);
		public int Length => length;

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

		public bool HasAny(params int[] tagsID)
		{
			if (length == 0) return false;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				for (int j = 0; j < length; j++)
				{
					fixed (ushort* elements = &tag0)
						if (elements[j] == tID)
							return true;
				}
			}

			return false;
		}

		public bool Has(params int[] tagsID)
		{
			if (length == 0) return false;
			var match = 0;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				for (int j = 0; j < length; j++)
				{
					fixed (ushort* elements = &tag0)
						if (elements[j] == tID)
							match++;
				}
			}
			return match == tagsID.Length;
		}

		public bool Has(int tagID)
		{
			for (int i = 0; i < length; i++)
			{
				fixed (ushort* elements = &tag0)
					if (elements[i] == tagID)
						return true;
			}
			return false;
		}

	}

	public static class HelperTags
	{

		internal static DictionaryGroupTags inUseGroups = new DictionaryGroupTags();
		internal static DictionaryGroupTags inUseGroupsTypes = new DictionaryGroupTags();

		public static void ClearTags(in this ent entity)
		{
			Entity.tags[entity.id].Clear();
		}

		public static void Clear(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var len = tags.Length;
			for (int i = 0; i < len; i++)
			{
				tags[i] = 0;
			}
		}

		public unsafe static void Add(in this ent entity, int tagID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;
			var tID = (ushort) tagID;
			for (int index = 0; index < len; index++)
			{
				fixed (ushort* elements = &tags.tag0)
				{
					if (elements[index] == tID)
					{
						fixed (byte* elementsLen = &tags.tag0Len)
							unchecked
							{
								elementsLen[index] += 1;
							}

						return;
					}
				}
			}

			#if UNITY_EDITOR
			if (len == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif
 
			tags.SetElement(tags.Length, tagID);
			HandleChange(entity, tagID);
		}

		public unsafe static void Add(in this ent entity, params int[] tagsID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				var allowToAdd = true;
				for (int index = 0; index < len; index++)
				{
					fixed (ushort* elements = &tags.tag0)
					{
						if (elements[index] == tID)
						{
							fixed (byte* elementsLen = &tags.tag0Len)
								unchecked
								{
									elementsLen[index] += 1;
								}
							allowToAdd = false;
							break;
						}
					}
				}
				if (!allowToAdd) continue;

				#if UNITY_EDITOR
				if (len == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				tags.SetElement(tags.Length, tID);
				HandleChange(entity, tID);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void AddLater(in this ent entity, int tagID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;
			var tID = (ushort) tagID;
			for (int index = 0; index < len; index++)
			{
				fixed (ushort* elements = &tags.tag0)
				{
					if (elements[index] == tID)
					{
						fixed (byte* elementsLen = &tags.tag0Len)
							unchecked
							{
								elementsLen[index] += 1;
							}

						return;
					}
				}
			}

			#if UNITY_EDITOR
			if (len == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif

			tags.SetElement(tags.Length, tagID);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void AddLater(in this ent entity, params int[] tagsID)
		{
			ref var tags = ref Entity.tags[entity.id];

			var len = tags.Length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				var allowToAdd = true;
				for (int index = 0; index < len; index++)
				{
					fixed (ushort* elements = &tags.tag0)
					{
						if (elements[index] == tID)
						{
							fixed (byte* elementsLen = &tags.tag0Len)
								unchecked
								{
									elementsLen[index] += 1;
								}
							allowToAdd = false;
							break;
						}
					}
				}
				if (!allowToAdd) continue;

				#if UNITY_EDITOR
				if (len == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				tags.SetElement(tags.Length, tID);
			}
		}

		public unsafe static void Remove(in this ent entity, int tagID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;
			for (int index = 0; index < len; index++)
			{
				fixed (ushort* elements = &tags.tag0)
					if (elements[index] == tagID)
					{
						fixed (byte* elementsLengths = &tags.tag0Len)
							if (--elementsLengths[index] == 0)
							{
								tags.RemoveAt(index);
								HandleChange(entity, tagID);
							}
						return;
					}
			}
		}

		public unsafe static void RemoveAll(in this ent entity, params int[] tagsID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				for (int index = 0; index < len; index++)
				{
					fixed (ushort* elements = &tags.tag0)
						if (elements[index] == tID)
						{
							fixed (byte* elementsLen = &tags.tag0Len)
							{
								elementsLen[index] = 0;
								tags.RemoveAt(index);
								HandleChange(entity, tID);
								break;
							}
						}
				}
			}
		}

		public unsafe static void RemoveAll(in this ent entity, int tagID)
		{
			ref var tags = ref Entity.tags[entity.id];
			var len = tags.Length;
			var tID = (ushort) tagID;

			for (int index = 0; index < len; index++)
			{
				fixed (ushort* elements = &tags.tag0)
				{
					if (elements[index] == tID)
					{
						fixed (byte* elementsLen = &tags.tag0Len)
							elementsLen[index] = 0;
						tags.RemoveAt(index);
						HandleChange(entity, tID);
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Has(in this ent entity, int tagID)
		{
			return Entity.tags[entity.id].Has(tagID);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Has(in this ent entity, params int[] tagsID)
		{
			return Entity.tags[entity.id].Has(tagsID);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasAny(in this ent entity, params int[] tagsID)
		{
			return Entity.tags[entity.id].HasAny(tagsID);
		}

		internal static void Add(GroupCore groupCore)
		{
			DictionaryGroups container;
			var filter = groupCore.composition;

			foreach (var tagID in filter.tagsToInclude)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(groupCore)) continue;

					container.Add(groupCore);
				}
				else
				{
					container = new DictionaryGroups();

					container.Add(groupCore);
					inUseGroups.Add(tagID, container);
				}
			}

			foreach (var tagID in filter.tagsToExclude)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(groupCore)) continue;
					container.Add(groupCore);
				}
				else
				{
					container = new DictionaryGroups();
					container.Add(groupCore);
					inUseGroups.Add(tagID, container);
				}
			}

			int index = -1;
			foreach (var typeID in filter.typesToExclude)
			{
				index++;
				if (!typeID) continue;

				if (inUseGroupsTypes.TryGetValue(index, out container))
				{
					if (container.Contain(groupCore)) continue;
					container.Add(groupCore);
				}
				else
				{
					container = new DictionaryGroups();
					container.Add(groupCore);
					inUseGroupsTypes.Add(index, container);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void HandleChange(in ent entity, int tagID)
		{
			var indexGroup = inUseGroups.TryGetValue(tagID);
		 
			if (indexGroup == -1) return;
			Entity.Delayed.Set(entity, indexGroup, Entity.Delayed.Action.ChangeTag);
		}

	}
}