//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


namespace Pixeye
{
	public class ProcessingActors : ProcessingBase, ITick
	{
		public static bool valid = true;
		public static int AddEventsLength;
		public static DelayAddEvent[] AddEvents = new DelayAddEvent[10];


		public Group<ComponentRelease> groupRelease;


		public ProcessingActors()
		{
			groupRelease.Add += entity => {
				ComponentObject cObject;


				if (entity.Get(out cObject))
				{
					var mono = cObject.transform.GetComponent<MonoEntity>();
					if (mono != null)
					{
						mono.Release();
						return;
					}

					cObject.transform.gameObject.Release(cObject.poolType);
				}

				Release(entity);
			};
		}

		void Release(int entity)
		{
			int len = Storage.all.Count;
			for (int j = 0; j < len; j++)
			{
				Storage.all[j].Remove(entity, false);
			}

			Tags.Clear(entity);
			ProcessingEntities.prevID.Push(entity);
		}

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