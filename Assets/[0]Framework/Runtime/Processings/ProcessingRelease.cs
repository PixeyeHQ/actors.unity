//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 11/1/2018

namespace Homebrew
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

				Storage<ComponentRelease>.Instance.RemoveNoCheck(entity);
				entity.ReleaseFinal(isActor);
				;
			};
		}
	}
}