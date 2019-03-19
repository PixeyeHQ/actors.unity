//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using UnityEngine;

namespace Pixeye
{
	/// <summary>
	/// <para>An extended class of mono entity composer with update and signals.</para>
	/// </summary>
	public abstract class ActorExtended : Actor
	{
		bool conditionSignals;


		protected override void Awake()
		{
			conditionSignals = ProcSignals.Check(this);
			conditionManualDeploy = this is IManualDeploy;

			var entityID = ProcEntities.Create();
			entity = entityID;
			entity.AddReference(transform);
			 
	
			#if UNITY_EDITOR
			_entity = entity;
			#endif

			if (pool > 0)
				entity.AddPool(pool);

			conditionManualDeploy = this is IManualDeploy;

			if (Starter.initialized == false) return;
			Setup();
		}

		public override void OnEnable()
		{
			if (Starter.initialized == false) return;
			if (conditionManualDeploy)
				return;


			RefEntity.isAlive[entity] = true;
			ProcEntities.Default.CheckGroups(entity, true);
			ProcUpdate.Default.Add(this);

			if (conditionSignals)
				ProcSignals.Default.Add(this);
		}

		public override void OnDisable()
		{
			if (conditionSignals)
				ProcSignals.Default.Remove(this);

			RefEntity.isAlive[entity] = false;
			ProcUpdate.Default.Remove(this);
			ProcEntities.Default.CheckGroups(entity, false);
		}
	}
}