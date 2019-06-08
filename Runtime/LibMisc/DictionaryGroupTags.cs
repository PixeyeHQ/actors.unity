//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
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
				tagsID[i + 1]            = tagsID[i];
				this.groupStorage[i + 1] = groupStorage[i];
			}

			this.groupStorage[pointer] = anotherGroupStorage;
			tagsID[pointer]            = tagID;
		}
	}
}