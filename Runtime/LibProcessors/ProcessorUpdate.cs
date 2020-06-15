//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class ProcessorUpdate
  {
    internal readonly List<IReceiveEcsEvent> processors = new List<IReceiveEcsEvent>(64);
    internal readonly List<ITick> ticks = new List<ITick>(128);
    internal readonly List<ITick> ticksProc = new List<ITick>(64);
    internal readonly List<ITickFixed> ticksFixedProc = new List<ITickFixed>(64);
    internal readonly List<ITickLate> ticksLateProc = new List<ITickLate>(64);
    internal readonly List<ITickFixed> ticksFixed = new List<ITickFixed>();
    internal readonly List<ITickLate> ticksLate = new List<ITickLate>();

    // counting manually allows to instantly shut down everything when scene releasing without waiting one frame.
    int countTicksProc;
    int countTicksProcFixed;
    int countTicksProcLate;
    int countTicks;
    int countTicksFixed;
    int countTicksLate;

    internal Layer layer;

    internal int GetTicksCount => countTicks + countTicksFixed + countTicksLate
                                  + countTicksProc + countTicksProcFixed + countTicksProcLate;

    public void AddTick(object updateble)
    {
      ticks.Add(updateble as ITick);
      countTicks++;
    }

    public void RemoveTick(object updateble)
    {
      if (ticks.Remove(updateble as ITick))
      {
        countTicks--;
      }
    }

    public void AddTickFixed(object updateble)
    {
      ticksFixed.Add(updateble as ITickFixed);
      countTicksFixed++;
    }

    public void RemoveTickFixed(object updateble)
    {
      if (ticksFixed.Remove(updateble as ITickFixed))
      {
        countTicksFixed--;
      }
    }

    public void AddTickLate(object updateble)
    {
      ticksLate.Add(updateble as ITickLate);
      countTicksLate++;
    }

    public void RemoveTickLate(object updateble)
    {
      if (ticksLate.Remove(updateble as ITickLate))
      {
        countTicksLate--;
      }
    }

    internal void AddProc(Processor updateble)
    {
      if (updateble is IReceiveEcsEvent receiver)
      {
        processors.Add(receiver);
      }

      if (updateble is ITick tickable)
      {
        ticksProc.Add(tickable);
        countTicksProc += 1;
      }
      else
      {
        ticksProc.Add(new Dummy());
        countTicksProc += 1;
      }

      if (updateble is ITickFixed tickableFixed)
      {
        ticksFixedProc.Add(tickableFixed);
        countTicksProcFixed++;
      }

      if (updateble is ITickLate tickableLate)
      {
        ticksLateProc.Add(tickableLate);
        countTicksProcLate++;
      }
    }

    internal void RemoveProc(object updateble)
    {
      processors.Remove(updateble as IReceiveEcsEvent);

      if (ticksProc.Remove(updateble as ITick))
      {
        countTicksProc--;
      }

      if (ticksFixedProc.Remove(updateble as ITickFixed))
      {
        countTicksProcFixed--;
      }

      if (ticksLateProc.Remove(updateble as ITickLate))
      {
        countTicksProcLate--;
      }
    }

    public void Add(object updateble)
    {
      if (updateble is ITick tickable)
      {
        ticks.Add(tickable);
        countTicks++;
      }

      if (updateble is ITickFixed tickableFixed)
      {
        ticksFixed.Add(tickableFixed);
        countTicksFixed++;
      }

      if (updateble is ITickLate tickableLate)
      {
        ticksLate.Add(tickableLate);
        countTicksLate++;
      }
    }

    public void Remove(object updateble)
    {
      if (ticks.Remove(updateble as ITick))
      {
        countTicks--;
      }

      if (ticksFixed.Remove(updateble as ITickFixed))
      {
        countTicksFixed--;
      }

      if (ticksLate.Remove(updateble as ITickLate))
      {
        countTicksLate--;
      }
    }

    public void Update()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (layer.isReleasing) return;
      layer.Time.Tick();
      var delta = layer.Time.deltaTime;

      for (var i = 0; i < countTicks; i++)
      {
        ticks[i].Tick(delta);
      }

      layer.processorEcs.Execute();

      // dirty. we are using Dummy class for making all processors work here.
      // this is need for receiving ecs events.
      for (var i = 0; i < countTicksProc; i++)
      {
        processors[i].Receive();
        ticksProc[i].Tick(delta);
        layer.processorEcs.Execute();
      }
    }

    public void FixedUpdate()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (layer.isReleasing) return;
      var delta = layer.Time.deltaTimeFixed;

      for (var i = 0; i < countTicksFixed; i++)
      {
        ticksFixed[i].TickFixed(delta);
      }

      for (var i = 0; i < countTicksProcFixed; i++)
      {
        ticksFixedProc[i].TickFixed(delta);
      }
    }

    public void LateUpdate()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (layer.isReleasing) return;
      var delta = layer.Time.deltaTime;


      for (var i = 0; i < countTicksLate; i++)
      {
        ticksLate[i].TickLate(delta);
      }

      for (var i = 0; i < countTicksProcLate; i++)
      {
        ticksLateProc[i].TickLate(delta);
      }
    }

    internal void Dispose()
    {
      countTicks          = 0;
      countTicksLate      = 0;
      countTicksFixed     = 0;
      countTicksProc      = 0;
      countTicksProcFixed = 0;
      countTicksProcLate  = 0;

      ticks.Clear();
      ticksFixed.Clear();
      ticksLate.Clear();
      ticksProc.Clear();
      ticksFixedProc.Clear();
      ticksLateProc.Clear();
    }
  }
}