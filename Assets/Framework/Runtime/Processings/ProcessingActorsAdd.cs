//  Project : ecs.examples
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 


namespace Pixeye
{
	public class ProcessingActorsAdd : ProcessingBase, ITick
	{
		public static bool valid = true;
		public static int lenAddEvents;
		public static DelayAddEvent[] addEvents = new DelayAddEvent[10];

		public static int lenGroupsToChange;
		public static DelayChangeGroup[] groupsToChange = new DelayChangeGroup[10];


		public void Tick()
		{
			if (!valid)
			{
				for (int i = 0; i < lenGroupsToChange; i++)
				{
					var ev = groupsToChange[i];
					ev.groupToChange.HandleAddEntityFinalize(ev.entity);
				}

				for (int i = 0; i < lenAddEvents; i++)
				{
					var ev = addEvents[i];
					ev.action(ev.entity);
				}

				lenAddEvents = 0;
				lenGroupsToChange = 0;
				valid = true;
			}
		}
	}

	public struct DelayAddEvent
	{
		public int entity;
		public ActionEntity action;
	}

	public struct DelayChangeGroup
	{
		public int entity;
		public GroupBase groupToChange;
	}
}