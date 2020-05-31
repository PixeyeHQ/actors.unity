//  Project : ecs.examples
// Contacts : Pix - ask@pixeye.games


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class ProcessorCoroutines
  {
    public bool timescaled = false;
    public float period = -1;

    internal static List<ProcessorCoroutines> coroutine_handlers = new List<ProcessorCoroutines>();
    internal static List<ProcessorCoroutines> coroutine_handlers_global = new List<ProcessorCoroutines>();

    IEnumerator[] running = new IEnumerator[36];
    internal float[] delays = new float[36];

    internal int currentIndex;
    int length;

    public coroutine Run(float delay, IEnumerator routine)
    {
      if (length == running.Length)
      {
        Array.Resize(ref running, length << 1);
        Array.Resize(ref delays, length << 1);
      }

      running[length] = routine;

      delays[length++] = delay;


      return new coroutine(this, routine);
    }

    public coroutine Run(IEnumerator routine)
    {
      if (length == running.Length)
      {
        Array.Resize(ref running, length << 1);
        Array.Resize(ref delays, length << 1);
      }

      running[length] = routine;

      delays[length++] = 0;

      return new coroutine(this, routine);
    }

    public coroutine run(IEnumerator routine)
    {
      return Run(0, routine);
    }

    public bool Stop(IEnumerator routine)
    {
      var i = 0;

      for (; i < length; i++)
      {
        if (routine == running[i]) break;
      }

      if (i < 0)
        return false;

      running[i] = null;
      delays[i] = 0f;
      return true;
    }


    public bool Stop(coroutine routine)
    {
      return routine.stop();
    }


    public void StopAll()
    {
      length = 0;
    }


    public bool IsRunning(IEnumerator routine)
    {
      for (var i = 0; i < length; i++)
      {
        if (routine == running[i]) return true;
      }

      return false;
    }

    public bool IsRunning(coroutine routine)
    {
      return routine.isRunning;
    }

    internal float accum;

    public void Tick(float d)
    {
      if (timescaled == false)
      {
        d = time.Default.deltaTimeUnscaled;
      }

      if (period > -1)
      {
        accum += d;
        if (accum >= period)
        {
          for (var i = length - 1; i >= 0; i--)
          {
            if (delays[i] > 0f)
              delays[i] -= accum;

            else if (running[i] == null || !MoveNext(running[i], i))
            {
              if (i < --length)
              {
                Array.Copy(running, i + 1, running, i, length - i);
                Array.Copy(delays, i + 1, delays, i, length - i);
              }
            }
          }

          accum -= period;
        }
      }
      else
      {
        for (var i = length - 1; i >= 0; i--)
        {
          if (delays[i] > 0f)
            delays[i] -= d;

          else if (running[i] == null || !MoveNext(running[i], i))
          {
            if (i < --length)
            {
              Array.Copy(running, i + 1, running, i, length - i);
              Array.Copy(delays, i + 1, delays, i, length - i);
            }
          }
        }
      }
    }

    bool MoveNext(IEnumerator routine, int index)
    {
      currentIndex = index;
      if (routine.Current is IEnumerator current)
      {
        if (MoveNext(current, index))
          return true;

        delays[index] = 0f;
      }


      return routine.MoveNext();
    }
  }

  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class ProcessorRoutine
  {
    ProcessorCoroutines Local;
    public App app;

    bool timescaled = true;
    float period = -1;

    public ProcessorRoutine()
    {
      app = new App();
      app.Global = new ProcessorCoroutines();

      app.Global.timescaled = true;
      app.Global.period = -1;

      ProcessorCoroutines.coroutine_handlers_global.Add(app.Global);
    }

    public void addLocalRoutines()
    {
      Local = new ProcessorCoroutines();
      Local.timescaled = timescaled;
      Local.period = period;
      Local.accum = period;
      ProcessorCoroutines.coroutine_handlers.Add(Local);
    }

    public ProcessorRoutine ignoreTimescale()
    {
      timescaled = false;
      app.Global.timescaled = false;
      return this;
    }

    public ProcessorRoutine setUpdatePeriod(float arg)
    {
      period = arg;
      app.Global.period = arg;
      app.Global.accum = arg;
      return this;
    }

    /// <summary>
    /// Local coroutines that work only on main scene.
    /// </summary>
    public coroutine run(float delay, IEnumerator routine)
    {
      return Local.Run(delay, routine);
    }

    /// <summary>
    /// Local coroutines that work only on main scene.
    /// </summary>
    public coroutine run(IEnumerator routine)
    {
      return Local.Run(0, routine);
    }


    public bool stop(IEnumerator routine)
    {
      return Local.Stop(routine);
    }


    public IEnumerator waitFrame => null;

    public IEnumerator wait(float t)
    {
      Local.delays[Local.currentIndex] = t;
      return null;
    }

    /// <summary>
    /// Coroutines that runs globally and are not affected by scene changes.
    /// </summary>
    public class App
    {
      internal ProcessorCoroutines Global;

      public coroutine run(float delay, IEnumerator routine)
      {
        return Global.Run(delay, routine);
      }

      public coroutine run(IEnumerator routine)
      {
        return Global.Run(0, routine);
      }


      public bool stop(IEnumerator routine)
      {
        return Global.Stop(routine);
      }
    }
  }


  public static class routines
  {
    internal static ProcessorCoroutines Local;
    internal static ProcessorCoroutines Global;

    internal static void Init()
    {
      Local = new ProcessorCoroutines();
      Global = new ProcessorCoroutines();

      Local.timescaled = true;
      Global.timescaled = true;

      Local.period = -1;
      Global.period = -1;

      ProcessorCoroutines.coroutine_handlers.Add(Local);
      ProcessorCoroutines.coroutine_handlers_global.Add(Global);
    }


    /// Local coroutines that work only on main scene.
    public static coroutine run(float delay, IEnumerator routine)
    {
      return Local.Run(delay, routine);
    }


    /// Local coroutines that work only on main scene.
    public static coroutine run(IEnumerator routine)
    {
      return Local.Run(0, routine);
    }


    public static bool stop(IEnumerator routine)
    {
      return Local.Stop(routine);
    }


    public static IEnumerator waitFrame => null;

    public static IEnumerator wait(float t)
    {
      Local.delays[Local.currentIndex] = t;
      return null;
    }


    /// Coroutines that runs globally and are not affected by scene changes.
    public static class app
    {
      public static coroutine run(float delay, IEnumerator routine)
      {
        return Global.Run(delay, routine);
      }

      public static coroutine run(IEnumerator routine)
      {
        return Global.Run(0, routine);
      }


      public static bool stop(IEnumerator routine)
      {
        return Global.Stop(routine);
      }
    }
  }


  public class WaitFrame : IEnumerator
  {
    public object Current => null;

    public bool MoveNext() => true;

    public void Reset()
    {
    }
  }


   
}