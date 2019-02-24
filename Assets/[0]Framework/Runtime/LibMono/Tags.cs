//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Collections.Generic;
using UnityEngine;


namespace Homebrew
{
	/// <summary>
	/// <para>Tags of the entities.</para>
	/// </summary>
	public static class Tags
	{
		internal static Dictionary<int, int>[] tags = new Dictionary<int, int>[EngineSettings.MinEntities];
		internal static Dictionary<int, List<GroupBase>> groupsInclude = new Dictionary<int, List<GroupBase>>(10, new FastComparable());

		internal static Dictionary<int, List<GroupBase>> groupsDeclude = new Dictionary<int, List<GroupBase>>(10, new FastComparable());
		 
		static internal int length = -1;

		static internal void Add(int entityID)
		{
			if (length > entityID) return;

			if (entityID >= tags.Length)
			{
				int l = entityID << 1;

				Array.Resize(ref tags, l);
			}

			length++;
			tags[entityID] = new Dictionary<int, int>(4, new FastComparable());
		}

		public static void Clear(int id) { tags[id].Clear(); }

		static internal void HandleChange(int entity, int tag)
		{
			if (Toolbox.isQuittingOrChangingScene()) return;

			if (!entity.CheckMonoConditions()) return;

			List<GroupBase> groups;
			if (groupsInclude.TryGetValue(tag, out groups))
			{
				var len = groups.Count;

				for (int i = 0; i < len; i++)
				{
					groups[i].TagsHaveChanged(entity);
				}
			}

			if (groupsDeclude.TryGetValue(tag, out groups))
			{
				var len = groups.Count;
				for (int i = 0; i < len; i++)
				{
					groups[i].TagsHaveChanged(entity);
				}
			}
		}


		#region TAGS

		
		
		public static void Remove(this int entityID, int tagID)
		{
			var dict = tags[entityID];
			int val;
			if (!dict.TryGetValue(tagID, out val)) return;
			val = Math.Max(0, val - 1);

			if (val == 0)
			{
				dict.Remove(tagID);

				HandleChange(entityID, tagID);
			}
			else dict[tagID] = val;
		}

		public static void Remove(this int entityID, params int[] tagIds)
		{
			var dict = tags[entityID];

			foreach (int index in tagIds)
			{
				int val;
				if (!dict.TryGetValue(index, out val)) continue;
				val = Math.Max(0, val - 1);

				if (val == 0)
				{
					dict.Remove(index);
					HandleChange(entityID, index);
				}
				else dict[index] = val;
			}
		}

		public static void RemoveAll(this int entityID, params int[] tagIds)
		{
			var dict = tags[entityID];
			foreach (int index in tagIds)
			{
				if (!dict.ContainsKey(index)) continue;
				dict.Remove(index);
				HandleChange(entityID, index);
			}
		}

 
		public static void Add(this int entityID, int tagId)
		{
			var dict = tags[entityID];
			if (dict.ContainsKey(tagId))
			{
				dict[tagId] += 1;
				return;
			}

			dict.Add(tagId, 1);


			HandleChange(entityID, tagId);
		}

		public static void Add(this int entityID, params int[] tagIds)
		{
			var dict = tags[entityID];
			foreach (int index in tagIds)
			{
				if (dict.ContainsKey(index))
				{
					dict[index] += 1;
					continue;
				}


				dict.Add(index, 1);
				HandleChange(entityID, index);
			}
		}

		public static void AddTagsRaw(this int entityID, params int[] tagIds)
		{
			var dict = tags[entityID];
			foreach (int index in tagIds)
			{
				if (dict.ContainsKey(index))
				{
					dict[index] += 1;
					continue;
				}


				dict.Add(index, 1);
			}
		}

		internal static void RemoveTagsRaw(this int entityID, params int[] tagIds)
		{
			var dict = tags[entityID];
			foreach (int index in tagIds)
			{
				if (!dict.ContainsKey(index)) continue;
				dict.Remove(index);
			}
		}


		public static bool Has(this int entityID, int filter)
		{
			var container = tags[entityID];
			return container.ContainsKey(filter);
		}


		public static bool Has(this int entityID, params int[] filter)
		{
			var container = tags[entityID];

			for (int i = 0; i < filter.Length; i++)
			{
				if (!container.ContainsKey(filter[i])) return false;
			}

			return true;
		}

		public static bool HasAny(this int entityID, params int[] filter)
		{
			var container = tags[entityID];

			for (int i = 0; i < filter.Length; i++)
			{
				if (container.ContainsKey(filter[i]))
					return true;
			}

			return false;
		}

		#endregion
	}
}