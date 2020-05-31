//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  internal sealed class ProcessorUpdateOld : MonoBehaviour, IDisposable, IKernel
  {
    internal static ProcessorUpdateOld Default;

    internal static List<time> times = new List<time>();
    internal static int timesLen = 0;

    internal List<ProcessorUpdate> updates = new List<ProcessorUpdate>();
    internal static readonly ProcessorUpdate ProcessorUpdateKernel = new ProcessorUpdate();

    void Awake()
    {
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

      total += ProcessorUpdateKernel.GetTicksCount;

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

    public static void AddKernel(object updateble) => ProcessorUpdateKernel.Add(updateble);

    void Update()
    {
      var delta = time.delta;

      //routines.Global.Tick(time.deltaUnscaled);

      if (Kernel.ChangingScene)
      {
        ProcessorUpdateKernel.Update(delta);
        return;
      }

      for (var i = 0; i < timesLen; i++)
      {
        times[i].Tick();
      }


      ProcessorUpdateKernel.Update(delta);

      for (int i = 0; i < updates.Count; i++)
      {
        updates[i].Update(delta);
      }


      // for (var i = 0; i < ProcessorCoroutines.coroutine_handlers.Count; i++)
      // {
      //   ProcessorCoroutines.coroutine_handlers[i].Tick(delta);
      // }
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
      Default = obj.AddComponent<ProcessorUpdateOld>();
    }
  }

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
      var countTicks = ticks.Count;
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