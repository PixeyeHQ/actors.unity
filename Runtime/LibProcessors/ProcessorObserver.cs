//  Project : ecs
// Contacts : Pix - ask@pixeye.games


 
namespace Pixeye.Framework
{
	[WantEvent(Op.Add | Op.Remove)]
	sealed class ProcessorObserver : Processor<ComponentObserver>, ITick
	{
		public void Tick(float delta)
		{
			for (int i = 0; i < source.length; i++)
			{
				ref var cObserver = ref source.entities[i].ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			}
		}

		public override void OnAdd(ent[] entities, int length)
		{
			for (int i = 0; i < length; i++)
			{
				ref var cObserver = ref entities[i].ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].FirstTime();
			}
		}
		public override void OnRemove(ent[] entities, int length)
		{
			for (int i = 0; i < length; i++)
			{
				ref var cObserver = ref entities[i].ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			}
		}
	}
}