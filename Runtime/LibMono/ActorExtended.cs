//  Project : ecs.sandbox
// Contacts : Pix - ask@pixeye.games


namespace Pixeye.Framework
{
	public class ActorExtended : Actor
	{

		protected override void OnEnable()
		{
			if (Starter.initialized == false) return;

			CoreEntity.isAlive[entity.id] = true;
			CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.Activate);
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}

		protected override void OnDisable()
		{
			if (!CoreEntity.isAlive[entity.id]) return;

			CoreEntity.isAlive[entity] = false;
			CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.Deactivate);
			ProcessorUpdate.Default.Remove(this);
			ProcessorSignals.Default.Remove(this);
		}

	}
}