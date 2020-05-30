//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  internal sealed class ProcessorUpdate : MonoBehaviour, IDisposable, IKernel
  {
    internal static ProcessorUpdate Default;

    internal static List<time> times = new List<time>();
    internal static int timesLen = 0;

    internal List<Updates> updates = new List<Updates>();
    internal static readonly Updates updatesKernel = new Updates();

    void Awake()
    {
      updates.Add(new Updates());
      Default = this;
      gameObject.name = "Actors Updates";
    }

    internal int GetTicksCount()
    {
      int total = 0;
      foreach (var storage in updates)
      {
        total += storage.GetTicksCount;
      }

      total += updatesKernel.GetTicksCount;

      return total;
    }

    public static void AddTick(object updateble, int index = 0) => Default.updates[index].AddTick(updateble);
    public static void RemoveTick(object updateble, int index = 0) => Default.updates[index].RemoveTick(updateble);

    public static void AddTickFixed(object updateble, int index = 0) => Default.updates[index].AddTickFixed(updateble);
    public static void RemoveTickFixed(object updateble, int index = 0) => Default.updates[index].RemoveTickFixed(updateble);

    public static void AddTickLate(object updateble, int index = 0) => Default.updates[index].AddTickLate(updateble);
    public static void RemoveTickLate(object updateble, int index = 0) => Default.updates[index].RemoveTickLate(updateble);

    public static void AddProc(object updateble, int index = 0) => Default.updates[index].AddProc(updateble);
    public static void RemoveProc(object updateble, int index = 0) => Default.updates[index].RemoveProc(updateble);

    public static void Add(object updateble, int index = 0) => Default.updates[index].Add(updateble);
    public static void Remove(object updateble, int index = 0) => Default.updates[index].Remove(updateble);

    public static void AddKernel(object updateble) => updatesKernel.Add(updateble);

    void Update()
    {
      var delta = time.delta;

      routines.Global.Tick(time.deltaUnscaled);

      if (Kernel.ChangingScene) return;


      for (var i = 0; i < timesLen; i++)
      {
        times[i].Tick();
      }


      updatesKernel.Update(delta);

      for (int i = 0; i < updates.Count; i++)
      {
        updates[i].Update(delta);
      }


      for (var i = 0; i < ProcessorCoroutines.coroutine_handlers.Count; i++)
      {
        ProcessorCoroutines.coroutine_handlers[i].Tick(delta);
      }
    }

    void FixedUpdate()
    {
      if (Kernel.ChangingScene) return;
      var delta = time.deltaFixed;

      for (int i = 0; i < updates.Count; i++)
      {
        updates[i].FixedUpdate(delta);
      }
    }

    void LateUpdate()
    {
      if (Kernel.ChangingScene) return;
      var delta = time.delta;

      for (int i = 0; i < updates.Count; i++)
      {
        updates[i].LateUpdate(delta);
      }
    }


    public void Dispose()
    {
      // for (int i = 0; i < updates.Count; i++)
      // {
      //   updates[i].Dispose();
      // }
    }

    public static void Create()
    {
      var obj = new GameObject("ActorsUpdate");
      DontDestroyOnLoad(obj);
      Default = obj.AddComponent<ProcessorUpdate>();
    }
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