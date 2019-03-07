//  Project : ecs.examples
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

namespace Pixeye
{
	public class ProcessingActorsAdd : ProcessingBase, ITick
	{
		public static bool valid = true;
		public static int AddEventsLength;
		public static DelayAddEvent[] AddEvents = new DelayAddEvent[10];


		public void Tick()
		{
			if (!valid)
			{
				for (int i = 0; i < AddEventsLength; i++)
				{
					var ev = AddEvents[i];
					ev.action(ev.entity);
				}

				AddEventsLength = 0;
				valid = true;
			}
		}
	}

	public struct DelayAddEvent
	{
		public int entity;
		public ActionEntity action;
	}
}