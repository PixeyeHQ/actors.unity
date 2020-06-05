using System.Runtime.CompilerServices;
using Pixeye.Actors;
using UnityEngine;

namespace Actors.Runtime.Helpers
{
  public static class HelperEntity
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this ent entity, int index)
    {
      return entity.managed.transform.GetChild(index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this ent entity, int index1, int index2)
    {
      return entity.managed.transform.GetChild(index1).GetChild(index2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this ent entity, int index1, int index2, int index3)
    {
      return entity.managed.transform.GetChild(index1).GetChild(index2).GetChild(index3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this ent entity, int index1, int index2, int index3, int index4)
    {
      return entity.managed.transform.GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this ent entity, int[] siblings)
    {
      var transform = entity.managed.transform;
      foreach (var sibling in siblings)
      {
        transform = transform.GetChild(sibling);
      }

      return transform;
    }
  }
}