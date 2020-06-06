//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System.Collections.Generic;



namespace Pixeye.Actors
{
  public class ProcessorUpdate
  {
    internal readonly List<IReceiveEcsEvent> processors = new List<IReceiveEcsEvent>(64);
    internal readonly List<ITick> ticks = new List<ITick>(128);
    internal readonly List<ITick> ticksProc = new List<ITick>(64);
    internal readonly List<ITickFixed> ticksFixedProc = new List<ITickFixed>(64);
    internal readonly List<ITickLate> ticksLateProc = new List<ITickLate>(64);
    internal readonly List<ITickFixed> ticksFixed = new List<ITickFixed>();
    internal readonly List<ITickLate> ticksLate = new List<ITickLate>();

    internal LayerCore layer;

    internal int GetTicksCount => ticks.Count + ticksProc.Count + ticksFixed.Count + ticksLate.Count;

    public void AddTick(object updateble)
    {
      ticks.Add(updateble as ITick);
    }

    public void RemoveTick(object updateble)
    {
      if (ticks.Remove(updateble as ITick))
      {
      }
    }

    public void AddTickFixed(object updateble)
    {
      ticksFixed.Add(updateble as ITickFixed);
    }

    public void RemoveTickFixed(object updateble)
    {
      if (ticksFixed.Remove(updateble as ITickFixed))
      {
      }
    }

    public void AddTickLate(object updateble)
    {
      ticksLate.Add(updateble as ITickLate);
    }

    public void RemoveTickLate(object updateble)
    {
      if (ticksLate.Remove(updateble as ITickLate))
      {
      }
    }

    public void AddProc(Processor updateble)
    {
      if (updateble is IReceiveEcsEvent receiver)
      {
        processors.Add(receiver);
      }

      if (updateble is ITick tickable)
      {
        ticksProc.Add(tickable);
      }
      else
      {
        ticksProc.Add(new Dummy());
      }

      if (updateble is ITickFixed tickableFixed)
        ticksFixedProc.Add(tickableFixed);

      if (updateble is ITickLate tickableLate)
      {
        ticksLateProc.Add(tickableLate);
      }
    }

    public void RemoveProc(object updateble)
    {
      processors.Remove(updateble as IReceiveEcsEvent);

      if (ticksProc.Remove(updateble as ITick))
      {
      }

      if (ticksFixedProc.Remove(updateble as ITickFixed))
      {
      }

      if (ticksLateProc.Remove(updateble as ITickLate))
      {
      }
    }

    public void Add(object updateble)
    {
      if (updateble is ITick tickable)
      {
        ticks.Add(tickable);
      }

      if (updateble is ITickFixed tickableFixed)
      {
        ticksFixed.Add(tickableFixed);
      }

      if (updateble is ITickLate tickableLate)
      {
        ticksLate.Add(tickableLate);
      }
    }

    public void Remove(object updateble)
    {
      if (ticks.Remove(updateble as ITick))
      {
      }

      if (ticksFixed.Remove(updateble as ITickFixed))
      {
      }

      if (ticksLate.Remove(updateble as ITickLate))
      {
      }
    }

    internal void Update(float delta)
    {
      var countTicks     = ticks.Count;
      var countTicksProc = ticksProc.Count;

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
      }
    }

    internal void FixedUpdate(float delta)
    {
      var countTicksFixed = ticksFixed.Count;
      var countTicksProc  = ticksFixedProc.Count;

      for (var i = 0; i < countTicksFixed; i++)
      {
        ticksFixed[i].TickFixed(delta);
      }

      for (var i = 0; i < countTicksProc; i++)
      {
        ticksFixedProc[i].TickFixed(delta);
        //processorEcs.Execute();
      }
    }

    internal void LateUpdate(float delta)
    {
      var countTicksLate = ticksLate.Count;
      var countTicksProc = ticksLateProc.Count;
      for (var i = 0; i < countTicksLate; i++)
      {
        ticksLate[i].TickLate(delta);
      }

      for (var i = 0; i < countTicksProc; i++)
      {
        ticksLateProc[i].TickLate(delta);
        //processorEcs.Execute();
      }
    }

    internal void Dispose()
    {
      ticks.Clear();
      ticksFixed.Clear();
      ticksLate.Clear();
      ticksProc.Clear();
      ticksFixedProc.Clear();
      ticksLateProc.Clear();
    }
  }
}