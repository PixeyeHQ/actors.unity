//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using UnityEngine;

namespace Pixeye.Actors
{
  sealed class ProcessorObserver : Processor, ITick
  {
#if ACTORS_EVENTS_MANUAL
  [Events(Op.Add | Op.Remove)]
#endif
    public Group<ComponentObserver> source = default;

    public override void HandleEcsEvents()
    {
      foreach (var entity in source.removed)
      {
        ref var cObserver = ref entity.ComponentObserver();

        for (var j = 0; j < cObserver.length; j++)
          cObserver.wrappers[j].Check();
      }

      foreach (var entity in source.added)
      {
        ref var cObserver = ref entity.ComponentObserver();
        for (var j = 0; j < cObserver.length; j++)
          cObserver.wrappers[j].FirstTime();
      }
    }

    public void Tick(float dt)
    {
      for (var i = 0; i < source.length; i++)
      {
        ref var cObserver = ref source.entities[i].ComponentObserver();
        for (var j = 0; j < cObserver.length; j++)
          cObserver.wrappers[j].Check();
      }
    }
  }
}