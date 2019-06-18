//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#define ACTORS_TAGS_DEFAULT
#if ACTORS_TAGS_6 || ACTORS_TAGS_12
#undef ACTORS_TAGS_DEFAULT
#endif

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferTags
	{

		#if ACTORS_TAGS_24 || ACTORS_TAGS_DEFAULT
		public const int Capacity = 24;
		public fixed ushort tags[Capacity];
		public fixed byte size[Capacity];
		#elif ACTORS_TAGS_12
		public const int Capacity = 12;
  	public fixed ushort tags[Capacity];
		public fixed byte size[Capacity];
		#elif ACTORS_TAGS_6
		public const int Capacity = 6;
		public fixed ushort tags[Capacity];
		public fixed byte size[Capacity];
		#endif

		public byte length;

		public int Length => length;

		public void Clear()
		{
			for (int i = 0; i < length; i++)
			{
				tags[i] = 0;
				size[i] = 0;
			}

			length = 0;
		}

		public byte GetTagSize(int index)
		{
			return size[index];
		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < length - 1; ++i)
				SetElem(i, GetElement(i + 1));

			length--;
		}

		public void SetElement(int index, int arg)
		{
			tags[index] = (ushort) arg;
			size[index] = 1;

			length++;
		}

		public void Increase(int index)
		{
			unchecked
			{
				size[index] += 1;
			}
		}

		public bool Decrease(int index)
		{
			if (--size[index] == 0)
			{
				RemoveAt(index);
				return true;
			}

			return false;
		}

		public void ClearAt(int index)
		{
			size[index] = 0;
			RemoveAt(index);
		}

		internal ref ushort GetElementByRef(int index)
		{
			return ref tags[index];
		}

		void SetElem(int index, int arg)
		{
			tags[index] = (ushort) arg;
			size[index] = 1;
		}

		ushort GetElement(int index)
		{
			return tags[index];
		}

		public bool HasAny(params int[] tagsID)
		{
			if (length == 0) return false;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				for (int j = 0; j < length; j++)
					if (tags[j] == tID)
						return true;
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
					if (tags[j] == tID)
						match++;
				}
			}
			return match == tagsID.Length;
		}

		public bool Has(int tagID)
		{
			for (int i = 0; i < length; i++)
			{
				if (tags[i] == tagID)
					return true;
			}
			return false;
		}

	}

	public unsafe static class HelperTags
	{

		internal static DictionaryGroupTags inUseGroups = new DictionaryGroupTags();
		internal static DictionaryGroupTags inUseGroupsTypes = new DictionaryGroupTags();

		public static void ClearTags(in this ent entity)
		{
			Entity.tags[entity.id].Clear();
		}

		public static void Add(in this ent entity, int tagID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			int     len    = buffer.length;
			var     tID    = (ushort) tagID;

			for (int index = 0; index < len; index++)
			{
				if (buffer.tags[index] == tID)
				{
					unchecked
					{
						buffer.size[index] += 1;
					}

					return;
				}
			}

			#if UNITY_EDITOR
			if (len == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif

			buffer.SetElement(buffer.length, tagID);
			HandleChange(entity, tagID);
		}

		public static void Add(in this ent entity, params int[] tagsID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			int     len    = buffer.length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID        = (ushort) tagsID[i];
				var allowToAdd = true;

				for (int index = 0; index < len; index++)
				{
					if (buffer.tags[index] == tID)
					{
						unchecked
						{
							buffer.size[index] += 1;
						}
						allowToAdd = false;
						break;
					}
				}
				if (!allowToAdd) continue;

				#if UNITY_EDITOR
				if (len == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				buffer.SetElement(buffer.length, tID);
				HandleChange(entity, tID);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(in this ent entity, int tagID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			int     len    = buffer.length;
			var     tID    = (ushort) tagID;
			for (int index = 0; index < len; index++)
			{
				if (buffer.tags[index] == tID)
				{
					unchecked
					{
						buffer.size[index] += 1;
					}

					return;
				}
			}

			#if UNITY_EDITOR
			if (len == BufferTags.Capacity)
			{
				throw new Exception("Tags limit reached!");
			}
			#endif

			buffer.SetElement(buffer.length, tagID);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(in this ent entity, params int[] tagsID)
		{
			ref var buffer = ref Entity.tags[entity.id];

			int len = buffer.length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID        = (ushort) tagsID[i];
				var allowToAdd = true;
				for (int index = 0; index < len; index++)
				{
					if (buffer.tags[index] == tID)
					{
						unchecked
						{
							buffer.size[index] += 1;
						}
						allowToAdd = false;
						break;
					}
				}
				if (!allowToAdd) continue;

				#if UNITY_EDITOR
				if (len == BufferTags.Capacity)
				{
					throw new Exception("Tags limit reached!");
				}
				#endif

				buffer.SetElement(buffer.length, tID);
			}
		}

		public static void Remove(in this ent entity, int tagID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			int     len    = buffer.length;
			for (int index = 0; index < len; index++)
			{
				if (buffer.tags[index] == tagID)
				{
					if (--buffer.size[index] == 0)
					{
						buffer.RemoveAt(index);
						HandleChange(entity, tagID);
					}
					return;
				}
			}
		}

		public static void RemoveAll(in this ent entity, params int[] tagsID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			var     len    = buffer.length;

			for (int i = 0; i < tagsID.Length; i++)
			{
				var tID = (ushort) tagsID[i];
				for (int index = 0; index < len; index++)
				{
					if (buffer.tags[index] == tID)
					{
						buffer.size[index] = 0;
						buffer.RemoveAt(index);
						HandleChange(entity, tID);
						break;
					}
				}
			}
		}

		public static void RemoveAll(in this ent entity, int tagID)
		{
			ref var buffer = ref Entity.tags[entity.id];
			int     len    = buffer.length;
			var     tID    = (ushort) tagID;

			for (int index = 0; index < len; index++)
			{
				if (buffer.tags[index] == tID)
				{
					buffer.size[index] = 0;
					buffer.RemoveAt(index);
					HandleChange(entity, tID);
					return;
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
			DictionaryGroup container;
			var             composition = groupCore.composition;
			foreach (var tagID in composition.includeTags)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(groupCore)) continue;

					container.Add(groupCore);
				}
				else
				{
					container = new DictionaryGroup();

					container.Add(groupCore);
					inUseGroups.Add(tagID, container);
				}
			}

			foreach (var tagID in composition.excludeTags)
			{
				if (inUseGroups.TryGetValue(tagID, out container))
				{
					if (container.Contain(groupCore)) continue;
					container.Add(groupCore);
				}
				else
				{
					container = new DictionaryGroup();
					container.Add(groupCore);
					inUseGroups.Add(tagID, container);
				}
			}

			int index = -1;
			foreach (var typeID in composition.excludeComponents)
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
					container = new DictionaryGroup();
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
		  EntityOperations.Set(entity, indexGroup, EntityOperations.Action.ChangeTag);
		}

	}

}