//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye
{
	public class ProcessingRelease : ProcessingBase
	{
		public Group<ComponentRelease> groupRelease;


		public ProcessingRelease()
		{
			groupRelease.Add += entity =>
			{
				ComponentObject cObject;

				var isActor = false;

				if (entity.Get(out cObject))
				{
					var obj = cObject.transform.GetComponent<MonoCached>();
					isActor = obj;

					if (!isActor)
					{
						cObject.transform.gameObject.Release(cObject.poolType);
					}
				}

			 
				entity.ReleaseFinal(isActor);
				;
			};
		}
	}
}