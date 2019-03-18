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
			conditionSignals = ProcessingSignals.Check(this);
			conditionManualDeploy = this is IManualDeploy;

			var entityID = ProcessingEntities.Create();
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
			ProcessingEntities.Default.CheckGroups(entity, true);
			ProcessingUpdate.Default.Add(this);

			if (conditionSignals)
				ProcessingSignals.Default.Add(this);
		}

		public override void OnDisable()
		{
			if (conditionSignals)
				ProcessingSignals.Default.Remove(this);

			RefEntity.isAlive[entity] = false;
			ProcessingUpdate.Default.Remove(this);
			ProcessingEntities.Default.CheckGroups(entity, false);
		}
	}
}