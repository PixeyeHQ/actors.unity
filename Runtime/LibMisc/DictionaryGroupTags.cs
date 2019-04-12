//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using UnityEngine;

namespace Pixeye.Framework
{
	internal class DictionaryGroupTags
	{

		internal DictionaryGroups[] groups = new DictionaryGroups[10];
		internal int[] tagsID = new int[10];

		internal int len;

		internal bool TryGetValue(int tagID, out DictionaryGroups groups)
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

			//var id = HelperArray.BinarySearch(ref tagsID, tagID, 0, len);
			//	Debug.Log(id + "_"+tagID);
			if (id > -1)
			{
				groups = this.groups[id];
				return true;
			}

			groups = default;
			return false;
		}

		internal int TryGetValue(int tagID)
		{
			return HelperArray.BinarySearch(ref tagsID, tagID, 0, len);
		}

		internal void Add(int tagID, DictionaryGroups group)
		{
			if (len >= groups.Length)
			{
				var l = len << 1;
				Array.Resize(ref groups, l);
				Array.Resize(ref tagsID, l);
			}

			var pointer = len++;
			var indexLast = pointer;
			var index = pointer - 1;
 
			if (index >= 0)
			{
				if (tagID < tagsID[index])
				{
					var startIndex = 0;
					var endIndex = indexLast;

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
							pointer = startIndex;
						}
						else
						{
							endIndex = middleIndex;
							pointer = endIndex;
						}
					}
				}
			}

			for (int i = indexLast; i >= pointer; i--)
			{
				tagsID[i + 1] = tagsID[i];
				groups[i + 1] = groups[i];
			}

			groups[pointer] = group;
			tagsID[pointer] = tagID;
		}

	}
}