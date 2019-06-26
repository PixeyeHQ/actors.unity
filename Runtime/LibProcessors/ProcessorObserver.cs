//  Project : ecs
// Contacts : Pix - ask@pixeye.games


namespace Pixeye.Framework
{

	sealed class ProcessorObserver : Processor, ITick
	{

		public Group<ComponentObserver> groupObservers = new Group<ComponentObserver>();

		public ProcessorObserver()
		{
			groupObservers.onAdd += (in ent entity) =>
			{
				var cObserver = entity.ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].FirstTime();
			};
	
			groupObservers.onRemove +=(in ent entity) => 
			{
     		var cObserver = entity.ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			} ;


		}
		
		public unsafe void Tick(float delta)
		{
			for (int i = 0; i < groupObservers.length; i++)
			{
				ref var cObserver = ref groupObservers.entities[i].ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			}
		}

	}

 

}