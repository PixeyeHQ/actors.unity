//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  sealed class ProcessorTimer : ITick, IKernel
  {
    internal static ProcessorTimer Default;
    internal static List<StorageTimers> timers = new List<StorageTimers>();

    public void Tick(float delta)
    {
      for (int i = 0; i < timers.Count; i++)
      {
        timers[i].Tick(delta);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void RemoveAt(int index)
    {
      //  RemoveAt(index, Starter.ActiveLayer.id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void RemoveAt(int index, int sceneIndex)
    {
      timers[sceneIndex].RemoveAt(index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void SetElement(int index, int sceneIndex, ref Timer arg)
    {
      timers[sceneIndex].SetElement(index, ref arg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void SetElement(int index, ref Timer arg)
    {
      // timers[Starter.ActiveLayer.id].SetElement(index, ref arg);
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // internal static ref Timer Add(float t, Action action)
    // {
    //   return default;
    //   // return ref Add(t, action, Starter.ActiveLayer.id);
    // }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static ref Timer Add(float t, Action action, int sceneIndex)
    {
      return ref timers[sceneIndex].Add(t, action, sceneIndex);
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // internal int Restart(float t, Action action)
    // {
    //   return Restart(t, action, Starter.ActiveLayer.id);
    // }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static int Restart(float t, Action action, int sceneIndex)
    {
      return timers[sceneIndex].Restart(t, action, sceneIndex);
    }

    internal static int GetLength(int sceneIndex)
    {
      return timers[sceneIndex].length;
    }

    internal static void Dispose()
    {
      for (int i = 0; i < timers.Count; i++)
      {
        timers[i].Dispose();
      }
    }
  }

  internal class StorageTimers
  {
    internal Timer[] source = new Timer[10];
    internal int length;

    public void Tick(float delta)
    {
      for (int i = 0; i < length; i++)
      {
        ref var timer = ref source[i];
        ref var t = ref timer.t;

        if ((t -= delta) > delta) continue;

        timer.action();
        RemoveAt(i);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void RemoveAt(int index)
    {
      if (length == 0) return;
      --length;
      for (int i = index; i < length; ++i)
        SetElement(i, ref source[i + 1]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void SetElement(int index, ref Timer arg)
    {
      source[index] = arg;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal ref Timer Add(float t, Action action, int sceneIndex)
    {
      if (length >= source.Length)
        Array.Resize(ref source, length << 1);

      var index = length++;
      Timer timer;
      timer.action = action;
      timer.t = t;
      timer.pointer = index;
      timer.sceneIndex = sceneIndex;
      source[index] = timer;
      return ref source[index];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal int Restart(float t, Action action, int sceneIndex)
    {
      if (length >= source.Length)
        Array.Resize(ref source, length << 1);

      var index = length++;
      Timer timer;
      timer.action = action;
      timer.t = t;
      timer.pointer = index;
      timer.sceneIndex = sceneIndex;
      source[index] = timer;
      return index;
    }

    internal void Dispose()
    {
      for (int i = 0; i < length; i++)
      {
        source[i].action = null;
      }
      length = 0;
    }
  }
}