//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{

	sealed class ProcessorObserver : Processor, ITick
	{

		public GroupObservers groupObservers;

		public void Tick(float delta)
		{
			for (int i = 0; i < groupObservers.length; i++)
			{
				var cObserver = groupObservers.componentObserver[i];
				for (int j = 0; j < cObserver.length; j++)
					cObserver.wrappers[j].Check();
			}
		}

	}

	sealed class GroupObservers : Group<ComponentObserver>
	{

		public ComponentObserver[] componentObserver = new ComponentObserver[SettingsEngine.SizeEntities];

		public override void UpdateComponents(int pointer)
		{
			if (pointer >= componentObserver.Length)
				Array.Resize(ref componentObserver, pointer << 1);

			componentObserver[pointer] = Storage<ComponentObserver>.Instance.components[entities[pointer].id];
		}

	}

}