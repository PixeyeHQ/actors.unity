using System.Collections.Generic;

namespace Pixeye.Actors
{
  internal partial class Layer
  {
    internal void Update(float delta)
    {
      // for (var i = 0; i < countTicks; i++)
      // {
      //   ticks[i].Tick(delta);
      // }
      //
      // ProcessorEntities.Execute();
      //
      // for (var i = 0; i < countTicksProc; i++)
      // {
      //   ticksProc[i].Tick(delta);
      //   ProcessorEntities.Execute();
      // }
    }

    internal void FixedUpdate(float delta)
    {
      // for (var i = 0; i < countTicksFixed; i++)
      // {
      //   ticksFixed[i].TickFixed(delta);
      // }
    }

    internal void LateUpdate(float delta)
    {
      // for (var i = 0; i < countTicksLate; i++)
      // {
      //   ticksLate[i].TickLate(delta);
      // }
    }


    internal class Updates
    {
      internal readonly List<ITick> ticks = new List<ITick>(128);
      internal readonly List<ITick> ticksProc = new List<ITick>(64);
      internal readonly List<ITickFixed> ticksFixed = new List<ITickFixed>();
      internal readonly List<ITickLate> ticksLate = new List<ITickLate>();

      internal int countTicksProc;
      internal int countTicks;
      internal int countTicksFixed;
      internal int countTicksLate;

      internal int GetTicksCount => countTicks + countTicksFixed + countTicksLate + countTicksProc;

      internal void AddTick(object updateble)
      {
        ticks.Add(updateble as ITick);
        countTicks++;
      }

      internal void RemoveTick(object updateble)
      {
        if (ticks.Remove(updateble as ITick))
        {
          countTicks--;
        }
      }

      internal void AddTickFixed(object updateble)
      {
        ticksFixed.Add(updateble as ITickFixed);
        countTicksFixed++;
      }

      internal void RemoveTickFixed(object updateble)
      {
        if (ticksFixed.Remove(updateble as ITickFixed))
        {
          countTicksFixed--;
        }
      }

      internal void AddTickLate(object updateble)
      {
        ticksLate.Add(updateble as ITickLate);
        countTicksLate++;
      }

      internal void RemoveTickLate(object updateble)
      {
        if (ticksLate.Remove(updateble as ITickLate))
        {
          countTicksLate--;
        }
      }

      internal void AddProc(object updateble)
      {
        if (updateble is ITick tickable)
        {
          ticksProc.Add(tickable);
          countTicksProc++;
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

      internal void RemoveProc(object updateble)
      {
        if (ticksProc.Remove(updateble as ITick))
        {
          countTicksProc--;
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

      internal void Add(object updateble)
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

      internal void Remove(object updateble)
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

      internal void Update(float delta)
      {
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
        for (var i = 0; i < countTicksFixed; i++)
        {
          ticksFixed[i].TickFixed(delta);
        }
      }

      internal void LateUpdate(float delta)
      {
        for (var i = 0; i < countTicksLate; i++)
        {
          ticksLate[i].TickLate(delta);
        }
      }

      internal void Dispose()
      {
        countTicks = 0;
        countTicksFixed = 0;
        countTicksLate = 0;
        countTicksProc = 0;

        ticks.Clear();
        ticksFixed.Clear();
        ticksLate.Clear();
        ticksProc.Clear();

        countTicks = ticks.Count;
      }
    }
  }
}