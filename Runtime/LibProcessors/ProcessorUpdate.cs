//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public sealed class ProcessorUpdate : MonoBehaviour, IDisposable, IKernel
  {
    public static ProcessorUpdate Default;

    internal static List<time> times = new List<time>();
    internal static int timesLen = 0;

    readonly List<ITick> ticks = new List<ITick>(128);
    readonly List<ITick> ticksProc = new List<ITick>(64);
    readonly List<ITickFixed> ticksFixed = new List<ITickFixed>();
    readonly List<ITickLate> ticksLate = new List<ITickLate>();

    int countTicksProc;
    int countTicks;
    int countTicksFixed;
    int countTicksLate;

    void Awake()
    {
      Default = this;
    }

    public int GetTicksCount()
    {
      return countTicks + countTicksProc + countTicksFixed + countTicksLate;
    }

    public static void AddTick(object updateble)
    {
      Default.ticks.Add(updateble as ITick);
      Default.countTicks++;
    }

    public static void RemoveTick(object updateble)
    {
      if (Default.ticks.Remove(updateble as ITick))
      {
        Default.countTicks--;
      }
    }


    public static void AddTickFixed(object updateble)
    {
      Default.ticksFixed.Add(updateble as ITickFixed);
      Default.countTicksFixed++;
    }

    public static void RemoveTickFixed(object updateble)
    {
      if (Default.ticksFixed.Remove(updateble as ITickFixed))
      {
        Default.countTicksFixed--;
      }
    }


    public static void AddTickLate(object updateble)
    {
      Default.ticksLate.Add(updateble as ITickLate);
      Default.countTicksLate++;
    }

    public static void RemoveTickLate(object updateble)
    {
      if (Default.ticksLate.Remove(updateble as ITickLate))
      {
        Default.countTicksLate--;
      }
    }

    public static void AddProc(object updateble)
    {
      var tickable = updateble as ITick;

      if (tickable != null)
      {
        Default.ticksProc.Add(tickable);
        Default.countTicksProc++;
      }

      var tickableFixed = updateble as ITickFixed;
      if (tickableFixed != null)
      {
        Default.ticksFixed.Add(tickableFixed);
        Default.countTicksFixed++;
      }

      var tickableLate = updateble as ITickLate;
      if (tickableLate != null)
      {
        Default.ticksLate.Add(tickableLate);
        Default.countTicksLate++;
      }
    }


    public static void RemoveProc(object updateble)
    {
      if (Default.ticksProc.Remove(updateble as ITick))
      {
        Default.countTicksProc--;
      }

      if (Default.ticksFixed.Remove(updateble as ITickFixed))
      {
        Default.countTicksFixed--;
      }

      if (Default.ticksLate.Remove(updateble as ITickLate))
      {
        Default.countTicksLate--;
      }
    }


    public static void Add(object updateble)
    {
      var tickable = updateble as ITick;
      if (tickable != null)
      {
        Default.ticks.Add(tickable);

        Default.countTicks++;
      }

      var tickableFixed = updateble as ITickFixed;
      if (tickableFixed != null)
      {
        Default.ticksFixed.Add(tickableFixed);
        Default.countTicksFixed++;
      }

      var tickableLate = updateble as ITickLate;
      if (tickableLate != null)
      {
        Default.ticksLate.Add(tickableLate);
        Default.countTicksLate++;
      }
    }

    public static void Remove(object updateble)
    {
      if (Default.ticks.Remove(updateble as ITick))
      {
        Default.countTicks--;
      }

      if (Default.ticksFixed.Remove(updateble as ITickFixed))
      {
        Default.countTicksFixed--;
      }

      if (Default.ticksLate.Remove(updateble as ITickLate))
      {
        Default.countTicksLate--;
      }
    }

    void Update()
    {
      var delta = time.delta;
     

      routines.Global.Tick(time.deltaUnscaled);

      if (Toolbox.changingScene) return;

      for (var i = 0; i < timesLen; i++)
      {
        times[i].Tick();
      }

      ProcessorEntities.Execute();

      for (var i = 0; i < countTicks; i++)
      {
        ticks[i].Tick(delta);
      }

      for (var i = 0; i < countTicksProc; i++)
      {
        ticksProc[i].Tick(delta);
      }

      for (var i = 0; i < ProcessorCoroutines.coroutine_handlers.Count; i++)
      {
        ProcessorCoroutines.coroutine_handlers[i].Tick(delta);
      }
    }

    void FixedUpdate()
    {
      if (Toolbox.changingScene) return;
      var delta = time.deltaFixed;
      for (var i = 0; i < countTicksFixed; i++)
      {
        ticksFixed[i].TickFixed(delta);
      }
    }

    void LateUpdate()
    {
      if (Toolbox.changingScene) return;
      var delta = time.delta;
      for (var i = 0; i < countTicksLate; i++)
      {
        ticksLate[i].TickLate(delta);
      }
    }


    public void Dispose()
    {
      countTicks      = 0;
      countTicksFixed = 0;
      countTicksLate  = 0;
      countTicksProc  = 0;
      ticks.RemoveAll(t => t is IKernel == false);

      ticksFixed.Clear();
      ticksLate.Clear();
      ticksProc.Clear();

      countTicks = ticks.Count;
    }

    public static void Create()
    {
      var obj = new GameObject("ActorsUpdate");
      DontDestroyOnLoad(obj);
      Default = obj.AddComponent<ProcessorUpdate>();
    }
  }
}