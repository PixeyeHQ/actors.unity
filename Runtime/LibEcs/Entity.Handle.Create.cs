using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static partial class EntityImplOld
  {
    public static Transform[] Transforms;
    internal static int[,] Generations;
    public static readonly int sizeBufferTags = UnsafeUtility.SizeOf<CacheTags>();
  }
}