using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static partial class EntityImplOld
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this in ent entity, int index)
    {
      return Transforms[entity.id].GetChild(index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this in ent entity, int index1, int index2)
    {
      return Transforms[entity.id].GetChild(index1).GetChild(index2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this in ent entity, int index1, int index2, int index3)
    {
      return Transforms[entity.id].GetChild(index1).GetChild(index2).GetChild(index3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this in ent entity, int index1, int index2, int index3, int index4)
    {
      return Transforms[entity.id].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Transform transform(this in ent entity, int[] siblings)
    {
      var transform = Transforms[entity.id];
      foreach (var sibling in siblings)
      {
        transform = transform.GetChild(sibling);
      }

      return transform;
    }


    //===============================//
    // Get Mono From Entity
    //===============================//

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetMono<T>(in this ent entity)
    {
      return Transforms[entity.id].GetComponentInChildren<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetMono<T>(in this ent entity, int index1) where T : Component
    {
      return Transforms[entity.id].GetChild(index1).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetMono<T>(in this ent entity, int index1, int index2) where T : Component
    {
      return Transforms[entity.id].GetChild(index1).GetChild(index2).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetMono<T>(in this ent entity, string path)
    {
      return Transforms[entity.id].Find(path).GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T GetMono<T>(in this ent entity, params int[] path) where T : Component
    {
      var transform = Transforms[entity.id];
      foreach (var sibling in path)
        transform = transform.GetChild(sibling);

      return transform.GetComponent<T>();
    }

    /// <summary>
    /// Returns the transform linked to the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the transform linked to the entity.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Component GetMono(in this ent entity, Type t, params int[] path)
    {
      var transform = Transforms[entity.id];
      foreach (var sibling in path)
        transform = transform.GetChild(sibling);


      return transform.GetComponent(t);
    }

    public const bool Pooled = true;
    public static unsafe CacheEntityOld* entities;
    internal static int[,] GenerationsInstant;
 
    public static unsafe CacheTags* Tags;
 
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static unsafe void Create(ent entity, bool isPooled = false, bool isNested = false)
    {
      if (entity.id >= EntityImplOld.lengthTotal)
      {
        var l = entity.id << 1;

        HelperArray.ResizeInt(ref EntityImplOld.Generations, l, Kernel.Settings.SizeGenerations);
        HelperArray.ResizeInt(ref EntityImplOld.GenerationsInstant, l, Kernel.Settings.SizeGenerations);
        Array.Resize(ref EntityImplOld.Transforms, l);

 
        EntityImplOld.entities =
          (CacheEntityOld*) UnmanagedMemory.ReAlloc(EntityImplOld.entities, EntityImplOld.sizeEntityCache * l);
        EntityImplOld.Tags = (CacheTags*) UnmanagedMemory.ReAlloc(EntityImplOld.Tags, EntityImplOld.sizeBufferTags * l);
        for (var i = EntityImplOld.lengthTotal; i < l; i++)
        {
          EntityImplOld.Tags[i]     = new CacheTags();
          EntityImplOld.entities[i] = new CacheEntityOld(5);
        }
 
        EntityImplOld.lengthTotal = l;
      }

      EntityImplOld.entities[entity.id].componentsAmount = 0;

      var ptrCache = &EntityImplOld.entities[entity.id];
      ptrCache->age      = entity.age;
      ptrCache->isNested = isNested;
      ptrCache->isPooled = isPooled;

      ptrCache->isDirty = true;
      ptrCache->isAlive = true;

      EntityImplOld.alive.Add(entity);
    }
  }
}