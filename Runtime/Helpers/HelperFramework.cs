using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public static unsafe class HelperFramework
  {
    static readonly FastString fstr = new FastString(500);

    public static bool Every(this float step, float time)
    {
      return step % time == 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Conditional("ACTORS_DEBUG")]
    public static void RenameGameobject(this ent entity)
    {
      if (!LayerKernel.Settings.DebugNames) return;
      var tr = ProcessorEcs.EntitiesManaged[entity.id].transform;
      if (tr != null)
      {
        var name             = tr.name;
        var index            = tr.name.LastIndexOf(':');
        if (index > -1) name = tr.name.Remove(0, index + 1);
        var id               = entity.id;

        name = name.Trim();
        fstr.Clear();
        fstr.Append($"{id.ToString().PadLeft(4, '0')}: ");

        fstr.Append("[ ");
        var ptr = ProcessorEcs.Entities.Get<EntityMeta>(entity.id);
        for (var j = 0; j < ptr->componentsAmount; j++)
        {
          var storage = Storage.All[ptr->components[j]];
          var lex     = j < ptr->componentsAmount - 1 ? " " : "";
          fstr.Append($"{storage.GetComponentType().Name.Remove(0, 9)}{lex}");
        }

        fstr.Append(" ]: ");


        fstr.Append(name);

        tr.name = fstr.ToString();
      }
    }

    public static ent GetEntity(this GameObject obj)
    {
      var actor = obj.GetComponent<Actor>();
#if UNITY_EDITOR
      if (actor == null)
      {
        throw new Exception("You can receive entity from a gameobject that have an actor component.");
      }
#endif
      return actor.entity;
    }

    internal static bool IsSubsetOf(this bool[] signature, EntityMeta* meta)
    {
      int match = 0;
      for (int i = 0; i < meta->componentsAmount; i++)
      {
        if (signature[meta->components[i]])
          match++;
      }

      return meta->componentsAmount == match;
    }

    internal static bool IsSubsetOf(this ComponentMask[] signature, ref EntityManagedMeta managed)
    {
      ref var generations = ref managed.signature;

      for (var i = 0; i < signature.Length; i++)
      {
        if ((generations[signature[i].generation] & signature[i].mask) != signature[i].mask)
          return false;
      }

      return true;
    }

    internal static bool Overlaps(this ComponentMask[] signature, ref EntityManagedMeta managed)
    {
      ref var generations = ref managed.signature;

      for (var i = 0; i < signature.Length; i++)
      {
        if ((generations[signature[i].generation] & signature[i].mask) == signature[i].mask)
          return true;
      }

      return false;
    }

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