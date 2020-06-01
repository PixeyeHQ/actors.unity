//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System.Collections.Generic;


namespace Pixeye.Actors
{
  internal class ProcessorUpdate
  {
    internal readonly List<ITick> ticks = new List<ITick>(128);
    internal readonly List<ITick> ticksProc = new List<ITick>(64);
    internal readonly List<ITickFixed> ticksFixed = new List<ITickFixed>();
    internal readonly List<ITickLate> ticksLate = new List<ITickLate>();


    internal int GetTicksCount => ticks.Count + ticksProc.Count + ticksFixed.Count + ticksLate.Count;

    internal void AddTick(object updateble)
    {
      ticks.Add(updateble as ITick);
    }

    internal void RemoveTick(object updateble)
    {
      if (ticks.Remove(updateble as ITick))
      {
      }
    }

    internal void AddTickFixed(object updateble)
    {
      ticksFixed.Add(updateble as ITickFixed);
    }

    internal void RemoveTickFixed(object updateble)
    {
      if (ticksFixed.Remove(updateble as ITickFixed))
      {
      }
    }

    internal void AddTickLate(object updateble)
    {
      ticksLate.Add(updateble as ITickLate);
    }

    internal void RemoveTickLate(object updateble)
    {
      if (ticksLate.Remove(updateble as ITickLate))
      {
      }
    }

    internal void AddProc(object updateble)
    {
      if (updateble is ITick tickable)
      {
        ticksProc.Add(tickable);
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

    internal void RemoveProc(object updateble)
    {
      if (ticksProc.Remove(updateble as ITick))
      {
      }

      if (ticksFixed.Remove(updateble as ITickFixed))
      {
      }

      if (ticksLate.Remove(updateble as ITickLate))
      {
      }
    }

    internal void Add(object updateble)
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

    internal void Remove(object updateble)
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

      ProcessorEntities.Execute();

      for (var i = 0; i < countTicksProc; i++)
      {
        ticksProc[i].Tick(delta);
        ProcessorEntities.Execute();
      }
    }

    internal void FixedUpdate(float delta)
    {
      var countTicksFixed = ticksFixed.Count;

      for (var i = 0; i < countTicksFixed; i++)
      {
        ticksFixed[i].TickFixed(delta);
      }
    }

    internal void LateUpdate(float delta)
    {
      var countTicksLate = ticksLate.Count;

      for (var i = 0; i < countTicksLate; i++)
      {
        ticksLate[i].TickLate(delta);
      }
    }

    internal void Dispose()
    {
      ticks.Clear();
      ticksFixed.Clear();
      ticksLate.Clear();
      ticksProc.Clear();
    }
  }
}