//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static class HelperArray
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, int start, int end)
    {
      var len = end - start;

      // Return new array.
      var res = new T[len];
      for (var i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, string from, int end) where T : UnityEngine.Object
    {
      Predicate<T> predicate = s => s.name == from;
      var          start     = -1;

      for (var i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = start + end - start;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, Predicate<T> predicate, int end)
    {
      var start = -1;

      for (var i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      var len = start + end - start;

      // Return new array.
      var res = new T[len];
      for (var i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (var i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      var len = (start + end - start) * times;

      // Return new array.
      var res = new T[len];
      for (var i = 0; i < len; i++)
      {
        res[i] = source[i / times + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] SliceFlip<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (var i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      var len = (start + end - start - 1) * times;

      // Return new array.
      var res = new T[len];
      for (var i = 0; i < len; i++)
      {
        res[i] = source[(len - i) / times + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] SliceLastIsNull<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (var i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      var len = (start + end - start) * times;
      // Return new array.
      var res = new T[len + 1];
      for (var i = 0; i < len; i++)
      {
        res[i] = source[i / times + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int BinarySearch(ref int[] entries, int value, int left, int right)
    {
      while (left <= right)
      {
        var m = (left + right) / 2;
        if (entries[m] == value) return m;
        if (entries[m] < value) left = m + 1;
        else right                   = m - 1;
      }

      return -1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int BinarySearch(ref ent[] entries, int value, int left, int right)
    {
      while (left <= right)
      {
        var m = (left + right) / 2;
        if (entries[m].id == value) return m;
        if (entries[m].id < value) left = m + 1;
        else right                      = m - 1;
      }

      return -1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FindIndex<T>(this T[] array, Predicate<T> predicate)
    {
      return Array.FindIndex(array, predicate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FindIndexFast<T>(this T[] array, Predicate<T> predicate)
    {
      for (var i = 0; i < array.Length; i++)
      {
        ref var val = ref array[i];
        if (predicate(val)) return i;
      }

      return -1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this T[] array, Predicate<T> predicate)
    {
      for (var index = 0; index < array.Length; ++index)
      {
        ref var local = ref array[index];
        if (predicate(local))
          return local;
      }

      return default;
    }
  }
}