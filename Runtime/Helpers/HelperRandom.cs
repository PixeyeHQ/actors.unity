using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Linq;

namespace Pixeye.Actors
{
  public static class HelperRandom
  {
    public static int Select(this float[] vals)
    {
      var total = 0f;
      var probs = new float[vals.Length];

      for (int i = 0; i < probs.Length; i++)
      {
        probs[i] = vals[i];
        total += probs[i];
      }

      var randomPoint = (float) Actors.Random.Source.NextDouble() * total;

      for (int i = 0; i < probs.Length; i++)
      {
        if (randomPoint < probs[i])
          return i;
        randomPoint -= probs[i];
      }

      return 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Between(this Vector2 v)
    {
      return Actors.Random.Source.Next(2) > 0 ? v.x : v.y;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Or(this float arg0, float arg1, float chance = 0.5f)
    {
      return Actors.Random.Source.NextDouble() > chance ? arg0 : arg1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Or(this int arg0, int arg1, float chance = 0.5f)
    {
      return Actors.Random.Source.NextDouble() > chance ? arg0 : arg1;
    }
 
    public static int Between(this object o, int a, int b, float chance = 0.5f)
    {
      return UnityEngine.Random.value > chance ? a : b;
    }

    public static float Between(this object o, float a, float b, float chance = 0.5f)
    {
      return UnityEngine.Random.value > chance ? a : b;
    }

    public static T RandomExcept<T>(this T[] list, T exceptVal)
    {
      var val = list[UnityEngine.Random.Range(0, list.Length)];

      while (val.Equals(exceptVal))
        val = list[UnityEngine.Random.Range(0, list.Length)];

      return val;
    }

    public static T RandomExcept<T>(this List<T> list, T exceptVal)
    {
      var val = list[UnityEngine.Random.Range(0, list.Count)];

      while (val.Equals(exceptVal))
        val = list[UnityEngine.Random.Range(0, list.Count)];

      return val;
    }

    public static ref T RandomRef<T>(this T[] vals)
    {
      return ref vals[UnityEngine.Random.Range(0, vals.Length)];
    }
 
    public static T Random<T>(this List<T> list, T[] itemsToExclude)
    {
      var val = list[UnityEngine.Random.Range(0, list.Count)];

      while (itemsToExclude.Contains(val))
        val = list[UnityEngine.Random.Range(0, list.Count)];

      return val;
    }

    public static T Random<T>(this List<T> list)
    {
      var val = list[UnityEngine.Random.Range(0, list.Count)];
      return val;
    }

    public static T Select<T>(this List<T> vals) where T : IRandom
    {
      float total = 0f;

      var probs = new float[vals.Count];

      for (int i = 0; i < probs.Length; i++)
      {
        probs[i] = vals[i].returnChance;
        total += probs[i];
      }

      float randomPoint = (float) Actors.Random.Source.NextDouble() * total;

      for (int i = 0; i < probs.Length; i++)
      {
        if (randomPoint < probs[i])
          return vals[i];
        randomPoint -= probs[i];
      }

      return vals[0];
    }

    public static T Select<T>(this T[] vals) where T : IRandom
    {
      var total = 0f;
      var probs = new float[vals.Length];

      for (int i = 0; i < probs.Length; i++)
      {
        probs[i] = vals[i].returnChance;
        total += probs[i];
      }

      var randomPoint = (float) Actors.Random.Source.NextDouble() * total;

      for (int i = 0; i < probs.Length; i++)
      {
        if (randomPoint < probs[i])
          return vals[i];
        randomPoint -= probs[i];
      }

      return vals[0];
    }

    public static T Select<T>(this T[] vals, out int index) where T : IRandom
    {
      index = -1;

      if (vals == null || vals.Length == 0) return default(T);

      float total = 0f;

      float[] probs = new float[vals.Length];

      for (int i = 0; i < probs.Length; i++)
      {
        probs[i] = vals[i].returnChance;
        total += probs[i];
      }

      float randomPoint = (float) Actors.Random.Source.NextDouble() * total;

      for (int i = 0; i < probs.Length; i++)
      {
        if (randomPoint < probs[i])
        {
          index = i;
          return vals[i];
        }

        randomPoint -= probs[i];
      }

      return vals[0];
    }

    public static T Random<T>(this T[] vals)
    {
      return vals[UnityEngine.Random.Range(0, vals.Length)];
    }

    public static T RandomDequeue<T>(this List<T> vals)
    {
      var index = UnityEngine.Random.Range(0, vals.Count);
      var val = vals[index];
      vals.RemoveAt(index);
      return val;
    }
  }
}