//  Project : ecs.sandbox
// Contacts : Pix - ask@pixeye.games


namespace Pixeye.Framework
{
	public class ActorExtended : Actor
	{

		public override void AwakeAfterStarter()
		{
			base.AwakeAfterStarter();
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
			 
		}
		
		protected override void OnEnable()
		{
			if (!Starter.initialized) return;

			EntityCore.isAlive[entity.id] = true;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}

		protected override void OnDisable()
		{
			if (Toolbox.applicationIsQuitting||!EntityCore.isAlive[entity.id]) return;

			EntityCore.isAlive[entity] = false;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Deactivate);
			ProcessorUpdate.Default.Remove(this);
			ProcessorSignals.Default.Remove(this);
		}

	}
}