//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye
{
	public class ProcessingRelease : ProcessingBase, ITick
	{
		public static Action HandleTagEvents;
		public static bool valid = true;

		public Group<ComponentRelease> groupRelease;


		public ProcessingRelease()
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
				HandleTagEvents();
				valid = true;
			}
		}
	}
}