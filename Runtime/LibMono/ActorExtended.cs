//  Project : ecs.sandbox
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	[Obsolete]
	public class ActorExtended : Actor
	{

		public override void Launch()
		{
			base.Launch();
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}
		#if UNITY_EDITOR
		protected override void OnEnable()
		{
			if (!manualRemoved) return;
			manualRemoved = false;

			Entity.isAlive[entity.id] = true;
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}

		protected override void OnDisable()
		{
			if (Toolbox.applicationIsQuitting || !Entity.isAlive[entity.id]) return;

			Entity.isAlive[entity] = false;
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Deactivate);
			ProcessorUpdate.Default.Remove(this);
			ProcessorSignals.Default.Remove(this);
		}
		#else
    protected virtual void OnEnable()
		{
			if (!Starter.initialized) return;

	 
			ProcessorUpdate.Default.Add(this);
			ProcessorSignals.Default.Add(this);
		}

		protected virtual void OnDisable()
		{
			if (Toolbox.applicationIsQuitting || !Entity.isAlive[entity.id]) return;

 
			ProcessorUpdate.Default.Remove(this);
			ProcessorSignals.Default.Remove(this);
		}
		#endif

	}
}