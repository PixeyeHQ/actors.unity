//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{

	sealed class ProcessorObserver : Processor, ITick
	{

		public Group<ComponentObserver> groupObservers = new Group<ComponentObserver>();

		public void Tick(float delta)
		{
			for (int i = 0; i < groupObservers.length; i++)
			{
				var cObserver = groupObservers.entities[i].ComponentObserver();
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			}
		}

	}

 

}