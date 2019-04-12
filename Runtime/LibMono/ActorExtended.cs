//  Project : ecs.sandbox
// Contacts : Pix - ask@pixeye.games


namespace Pixeye.Framework
{
	public class ActorExtended : Actor
	{

		protected override void OnEnable()
		{
			if (Starter.initialized == false) return;

			EntityCore.isAlive[entity.id] = true;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}

		protected override void OnDisable()
		{
			if (!EntityCore.isAlive[entity.id]) return;

			EntityCore.isAlive[entity] = false;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Deactivate);
			ProcessorUpdate.Default.Remove(this);
			ProcessorSignals.Default.Remove(this);
		}

	}
}