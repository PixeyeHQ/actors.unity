using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  sealed public class debug
  {
    [Conditional("ACTORS_DEBUG")]
    public static void log(object context)
    {
      Debug.Log(context);
    }
  }

  public static class Random
  {
    public static void Bootstrap()
    {
      var hash = Guid.NewGuid().GetHashCode();
      UnityEngine.Random.InitState(hash);
      Source = new System.Random(Guid.NewGuid().GetHashCode());
    }

    public static System.Random Source = new System.Random(Guid.NewGuid().GetHashCode());

    public static float Range(float minimum, float maximum)
    {
      return (float) (Source.NextDouble() * (maximum - minimum) + minimum);
    }

    public static int Range(int minimum, int maximum)
    {
      return (int) (Source.NextDouble() * (maximum - minimum) + minimum);
    }

    public static bool NextBool(int truePercentage = 50)
    {
      return Source.NextDouble() < truePercentage / 100.0;
    }

    public static class Unity
    {
      public static float value
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => UnityEngine.Random.value;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static float Range(float min, float max) => UnityEngine.Random.Range(min, max);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static float Range(int min, int max) => UnityEngine.Random.Range(min, max);

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Quaternion rotation() => UnityEngine.Random.rotation;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Quaternion rotationUniform() => UnityEngine.Random.rotationUniform;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Color ColorHSV() => UnityEngine.Random.ColorHSV();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Vector2 insideUnitCircle() => UnityEngine.Random.insideUnitCircle;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Vector2 insideUnitSphere() => UnityEngine.Random.insideUnitSphere;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public static Vector2 onUnitSphere() => UnityEngine.Random.onUnitSphere;
    }
  }
}