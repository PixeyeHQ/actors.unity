using System;
using System.Collections;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public sealed class ProcessorCoroutine : ITick, IDisposable, IRequireActorsLayer
  {
    internal bool timescaled = true;
    internal float period = -1;

    IEnumerator[] running = new IEnumerator[36];
    internal float[] delays = new float[36];

    internal int currentIndex;
    int length;

    Layer layer;

    public void Bootstrap(Layer layer)
    {
      this.layer = layer;
      layer.Engine.Add(this);
    }

    internal RoutineCall Run(float delay, IEnumerator routine)
    {
      if (length == running.Length)
      {
        Array.Resize(ref running, length << 1);
        Array.Resize(ref delays, length << 1);
      }

      running[length] = routine;

      delays[length++] = delay;


      return new RoutineCall(this, routine);
    }

    internal RoutineCall Run(IEnumerator routine)
    {
      if (length == running.Length)
      {
        Array.Resize(ref running, length << 1);
        Array.Resize(ref delays, length << 1);
      }

      running[length] = routine;

      delays[length++] = 0;

      return new RoutineCall(this, routine);
    }

    internal bool Stop(IEnumerator routine)
    {
      var i = 0;

      for (; i < length; i++)
      {
        if (routine == running[i]) break;
      }

      if (i < 0)
        return false;

      running[i] = null;
      delays[i]  = 0f;
      return true;
    }

    internal bool Stop(RoutineCall routineCall)
    {
      return routineCall.Stop();
    }

    internal void StopAll()
    {
      length = 0;
    }

    internal bool IsRunning(IEnumerator routine)
    {
      for (var i = 0; i < length; i++)
      {
        if (routine == running[i]) return true;
      }

      return false;
    }

    internal bool IsRunning(RoutineCall routineCall)
    {
      return routineCall.IsRunning;
    }

    internal float accum;

    public void Tick(float dt)
    {
      if (timescaled == false)
      {
        dt = layer.Time.deltaTimeUnscaled;
      }
      
      if (period > -1)
      {
        accum += dt;
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
            delays[i] -= dt;

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

    public void Dispose()
    {
      StopAll();
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

  /// A handle to a (potentially running) coroutine.
  public struct RoutineCall
  {
    /// Reference to the routine's runner.
    internal ProcessorCoroutine processorCoroutines;


    /// Reference to the routine's enumerator.
    public IEnumerator enumerator;


    /// Construct a coroutine. Never call this manually, only use return values from Coroutines.Run().
    internal RoutineCall(ProcessorCoroutine processorCoroutines, IEnumerator enumerator)
    {
      this.processorCoroutines = processorCoroutines;
      this.enumerator          = enumerator;
    }


    /// Stop this coroutine if it is running.
    public bool Stop()
    {
      return IsRunning && processorCoroutines.Stop(enumerator);
    }


    /// A routine to wait until this coroutine has finished running.
    public IEnumerator Wait()
    {
      if (enumerator != null)
        while (processorCoroutines.IsRunning(enumerator))
          yield return null;
    }


    /// True if the enumerator is currently running.
    public bool IsRunning => enumerator != null && processorCoroutines.IsRunning(enumerator);
  }
}