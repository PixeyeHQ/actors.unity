/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public abstract class Storage
  {
    internal static Dictionary<int, int> TypeNames = new Dictionary<int, int>(FastComparable.Default);
    internal static int lastID;
    internal static int[] Masks = new int[32];
    internal static int[] Generations = new int[32];
    internal static Storage[] All = new Storage[32];

    internal CacheGroup[] groups = new CacheGroup[LayerKernel.LAYERS_AMOUNT_TOTAL];

    internal indexes toDispose = new indexes(LayerKernel.Settings.SizeEntities);

    internal abstract Type GetComponentType();

    public abstract void Dispose(indexes disposed);

    internal abstract void RemoveComponent(ent entity);
    internal abstract void AddComponent(object component, ent entity);
    internal abstract void SetComponent(object component, ent entity);
 
  }


  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public abstract class Storage<T> : Storage
  {
    public static Storage<T> Instance;

    public static int componentId;
    internal static int ComponentMask;
    internal static int Generation;

    public static T[] components = new T[LayerKernel.Settings.SizeEntities / 2];
    internal int componentsLen = 0;

    internal override void RemoveComponent(ent entity)
    {
      ref var _managed = ref entity.managed;
      entity.managed.signature[Generation] &= ~ComponentMask;
      _managed.layer.processorEcs.SetOperation(entity, Storage<T>.componentId, ProcessorEcs.Action.Remove);
    }

    // internal override object GetComponent(ent entity)
    // {
    //   ref var _managed = ref entity.managed;
    //   if ((_managed.signature[Generation] & ComponentMask) == ComponentMask)
    //   {
    //     return components[entity.id];
    //   }
    //
    //   return null;
    //   // return (_managed.signature[Generation] & ComponentMask) == ComponentMask;
    // }

    internal override unsafe void SetComponent(object component, ent entity)
    {
      if (entity.id >= components.Length)
        Array.Resize(ref components, entity.id + entity.id / 2);

      ref var _managed = ref entity.managed;
      entity.meta->AddComponent(componentId);
      _managed.signature[Generation] |= ComponentMask;

      ref var componentInStorage = ref components[entity.id];
      componentInStorage = (T) component;
    }
 
    internal override unsafe void AddComponent(object component, ent entity)
    {
      if (entity.id >= components.Length)
        Array.Resize(ref components, entity.id + entity.id / 2);

      ref var _managed = ref entity.managed;
      entity.meta->AddComponent(componentId);
      _managed.signature[Generation] |= ComponentMask;

      ref var componentInStorage = ref components[entity.id];
      componentInStorage = (T) component;
      _managed.layer.processorEcs.SetOperation(entity, Storage<T>.componentId, ProcessorEcs.Action.Add);
    }
    // internal void AddComponent(T obj, ent entity)
    // {
    //    
    //   if (id >= Storage<T>.components.Length)
    //     Array.Resize(ref Storage<T>.components, id + id / 2);
    //
    //   
    //   meta->AddComponent(Storage<T>.componentId);
    //   managed.signature[Storage<T>.Generation] |= Storage<T>.ComponentMask;
    //
    //   ref var componentInStorage = ref Storage<T>.components[id];
    //   componentInStorage = component;
    // }

    public Storage()
    {
      Instance = this;

      for (var i = 0; i < groups.Length; i++)
      {
        groups[i] = new CacheGroup();
      }

      if (lastID == All.Length)
      {
        var l = lastID << 1;
        Array.Resize(ref All, l);
        Array.Resize(ref Masks, l);
        Array.Resize(ref Generations, l);
      }

      componentId      = lastID++;
      All[componentId] = this;

      Masks[componentId]       = ComponentMask = 1 << (componentId % 32);
      Generations[componentId] = Generation    = componentId / 32;

      TypeNames.Add(typeof(T).GetHashCode(), componentId);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public virtual T Create()
    {
      return Activator.CreateInstance<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal override Type GetComponentType()
    {
      return typeof(T);
    }


#if !ACTORS_COMPONENTS_STRUCTS
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T TryGet(int entityID)
    {
      return (ProcessorEcs.EntitiesManaged[entityID].signature[Generation] & ComponentMask) == ComponentMask
        ? components[entityID]
        : default;
    }
#endif
  }
}