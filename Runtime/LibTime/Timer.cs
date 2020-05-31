/*===============================================================
Product:    ecs
Developer:  Dimitry Pixeye - pixeye@hbrew.store
================================================================*/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  public struct Timer
  {
    public Action action;
    public float t;
    internal int pointer;
    internal int sceneIndex;

    /// Create a new timer. Timers a great for adding delayed actions.
    public Timer(float finishTime, Action a)
    {
      t = finishTime;
      action = a;
      pointer = -1;
      sceneIndex = Starter.ActiveLayer.id;
    }

    public Timer(float finishTime, Action a, int sceneIndex)
    {
      t = finishTime;
      action = a;
      pointer = -1;
      this.sceneIndex = sceneIndex;
    }

    /// Create a new timer and pass it to the processor. Timers a great for adding delayed actions.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref Timer Add(float finishTime, Action action, int sceneIndex)
    {
      return ref ProcessorTimer.Add(finishTime, action, sceneIndex);
    }

    /// Create a new timer and pass it to the processor. Timers a great for adding delayed actions.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref Timer Add(float finishTime, Action action)
    {
      return ref ProcessorTimer.Add(finishTime, action);
    }

    public void Stop()
    {
#if UNITY_EDITOR

      if (pointer == -1 || pointer > ProcessorTimer.GetLength(sceneIndex))
      {
        Debug.LogError("Can't stop the timer that is not in the system.");
        return;
      }

#endif

      ProcessorTimer.RemoveAt(pointer, sceneIndex);
      pointer = -1;
    }

    /// Pass timer to the processor
    public void Restart()
    {
      pointer = ProcessorTimer.Restart(t, action, sceneIndex);
    }
  }
}