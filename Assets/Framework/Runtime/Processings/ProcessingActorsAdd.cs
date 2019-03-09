//  Project : ecs.examples
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using System.Collections;
using System.Collections.Generic;
namespace Pixeye
{
	public class ProcessingActorsAdd : ProcessingBase, ITick
	{
		public static int lenTagsToChange;
		public static DelayTagEvent[] tagsToChange = new DelayTagEvent[10];
		static List<GroupBase> groups;
		public void Tick()
		{
			for (int i = 0; i < lenTagsToChange; i++)
			{
				var ev = tagsToChange[i];
				var e = ev.entity;
				var t = ev.tag;

				 if (Tags.groupsInclude.TryGetValue(t, out groups))
				{
					var len = groups.Count;

					for (int j = 0; j < len; j++)
					{
						 groups[j].TagsHaveChanged(e);
					}
				}

				if (Tags.groupsDeclude.TryGetValue(t, out groups))
				{
					var len = groups.Count;
					for (int j = 0; j < len; j++)
					{
						 groups[j].TagsHaveChanged(e);
					}
				}

			}
			lenTagsToChange = 0;
		}
	}

	public struct DelayTagEvent
	{
		public int entity;
		public int tag;
	}
	

}