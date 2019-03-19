//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


namespace Pixeye
{
	public class ProcActorsRemove : ProcBase, ITick
	{
		public Group<ComponentRelease> groupRelease;


		public ProcActorsRemove()
		{
			groupRelease.Add += Release;
		}

		void Release(ent entity)
		{
			RefEntity.isAlive[entity] = false; //&= ~ent.isAlive;

			if (entity < RefEntity.transforms.Length)
			{
				var tr = RefEntity.transforms[entity];

				if (tr != null)
				{
					var poolID = RefEntity.poolIDS[entity];
					var isMono = tr.GetComponent<MonoEntity>(); //RefEntity.states[entity].BitCheck(ent.isMono);
					tr.gameObject.Release(poolID);
					if (isMono) return;
				}
			}


			for (int j = 0; j < Storage.lastID; j++)
				Storage.all[j].Remove(entity);

			Tags.Clear(entity);
			ProcEntities.prevID.Push(entity);
		}

		float t;

		public void Tick()
		{
//			t += Time.delta;
//			if (t >= Time.delta)
//			{
//				if (groupRelease.length > 0)
//					ReleaseFinal(groupRelease.entities[0]);
//
//				t -= Time.delta;
//			}
		}

		void ReleaseFinal(ent entity)
		{
			if (entity < RefEntity.transforms.Length)
			{
				var tr = RefEntity.transforms[entity];

				if (tr != null)
				{
					var poolID = RefEntity.poolIDS[entity];
					var isMono = tr.GetComponent<MonoEntity>();
					tr.gameObject.Release(poolID);
					if (isMono) return;
				}
			}


			for (int j = 0; j < Storage.lastID; j++)
				Storage.all[j].Remove(entity);

			Tags.Clear(entity);
			ProcEntities.prevID.Push(entity);
		}
	}
}