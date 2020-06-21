using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  public unsafe partial struct ent
  {
    [Conditional("ACTORS_DEBUG")]
    static void DebugCheckActive<T>(ent entity)
    {
#if UNITY_EDITOR

      if (!entity.exist)
      {
        LayerKernel.Debugger.Log(LogType.NOT_ACTIVE, entity, typeof(T).Name);
      }
#endif
    }

    [Conditional("ACTORS_DEBUG")]
    static void DebugCheckNull(ent entity, Type type)
    {
      if (entity.id != 0) return;
      LayerKernel.Debugger.Log(LogType.NULL_ENTITY, entity, type.Name);
      throw new ArgumentException();
    }

    [Conditional("ACTORS_DEBUG")]
    static void DebugDestroyed(ent entity)
    {
#if UNITY_EDITOR
      if (!entity.exist)
      {
        LayerKernel.Debugger.Log(LogType.DESTROYED, entity, entity.transform);
      }
#endif
    }

    [Conditional("ACTORS_DEBUG")]
    static void DebugNoComponent<T>(ent entity)
    {
      var     generation = Storage<T>.Generation;
      var     mask       = Storage<T>.ComponentMask;
      ref var _managed   = ref entity.managed;

      if ((_managed.signature[generation] & mask) != mask)
      {
        LayerKernel.Debugger.Log(LogType.NO_COMPONENT, entity, typeof(T));
        throw new Exception();
      }
    }

    [Conditional("ACTORS_DEBUG")]
    void DebugAlreadyHave<T>(ent entity)
    {
      var generation = Storage<T>.Generation;
      var mask       = Storage<T>.ComponentMask;
      if ((entity.managed.signature[generation] & mask) == mask)
      {
        Debug.Log($"{entity.transform}");
        LayerKernel.Debugger.Log(LogType.ALREADY_HAVE, entity.id, Storage<T>.Instance.GetComponentType().Name);
      }
    }


    /// Creates the component for entity.
    /// Use this only in the initialization.
    public ref T Set<T>()
    {
      DebugCheckNull(this, typeof(T));
      DebugAlreadyHave<T>(this);

      if (id >= Storage<T>.components.Length)
        Array.Resize(ref Storage<T>.components, id + id / 2);

      meta->AddComponent(Storage<T>.componentId);
      managed.signature[Storage<T>.Generation] |= Storage<T>.ComponentMask;

      ref var val = ref Storage<T>.components[id];
#if !ACTORS_COMPONENTS_STRUCTS
      if (val == null)
        val = Storage<T>.Instance.Create();
#endif
      return ref val;
    }


    /// Creates the component for entity.
    /// Use this only in the initialization.
    public void Set<T>(T component)
    {
      DebugCheckNull(this, typeof(T));
      DebugAlreadyHave<T>(this);

      if (id >= Storage<T>.components.Length)
        Array.Resize(ref Storage<T>.components, id + id / 2);

      meta->AddComponent(Storage<T>.componentId);
      managed.signature[Storage<T>.Generation] |= Storage<T>.ComponentMask;

      ref var componentInStorage = ref Storage<T>.components[id];
      componentInStorage = component;
    }

    /// Returns the component from entity. Creates the component if entity doesn't have one.
    public ref T Get<T>()
    {
      DebugCheckActive<T>(this);
      if (id >= Storage<T>.components.Length)
        Array.Resize(ref Storage<T>.components, id + id / 2);

      var     generation = Storage<T>.Generation;
      var     mask       = Storage<T>.ComponentMask;
      var     _meta      = meta; // POINTER
      ref var _managed   = ref managed;
      if ((_managed.signature[generation] & mask) != mask)
      {
        var componentID = Storage<T>.componentId;

        _meta->AddComponent(componentID);
        _managed.signature[generation] |= mask;

        if (!_meta->isDirty)
        {
          _managed.layer.processorEcs.SetOperation(this, componentID, ProcessorEcs.Action.Add);
        }
      }

      ref var val = ref Storage<T>.components[id];

#if !ACTORS_COMPONENTS_STRUCTS
      if (val == null)
        val = Storage<T>.Instance.Create();
#endif

      return ref val;
    }


    /// Removes the component from entity.
    public void Remove<T>()
    {
      DebugDestroyed(this);
      DebugNoComponent<T>(this);
      
      ref var _managed = ref managed;
      _managed.signature[Storage<T>.Generation] &= ~Storage<T>.ComponentMask;
      _managed.layer.processorEcs.SetOperation(this, Storage<T>.componentId, ProcessorEcs.Action.Remove);
     
      // var     generation = Storage<T>.Generation;
      // var     mask       = Storage<T>.ComponentMask;
      // ref var _managed   = ref managed;
      // if ((_managed.signature[generation] & mask) == mask)
      // {
      //   _managed.signature[generation] &= ~mask;
      //   _managed.layer.processorEcs.SetOperation(this, Storage<T>.componentId, ProcessorEcs.Action.Remove);
      // }
    }

#if !ACTORS_COMPONENTS_STRUCTS
    /// <summary>
    /// <para>Safely gets the component by type from the entity.</para>
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="arg0"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>Returns true if the entity has this component.</returns>
    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGet<T>(out T arg0)
    {
      return (arg0 = (managed.signature[Storage<T>.Generation] & Storage<T>.ComponentMask) ==
                     Storage<T>.ComponentMask
        ? Storage<T>.components[id]
        : default) != null;
    }

    /// <summary>
    /// <para>Safely gets the components by type from the entity.</para>
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="arg0"></param>
    /// <param name="arg1"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <returns>Returns true if the entity has these components.</returns>
    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    public bool TryGet<T, Y>(out T arg0, out Y arg1)
    {
      arg0 = default;
      arg1 = default;
      if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
      return (arg1 = Storage<Y>.Instance.TryGet(id)) != null;
    }

    /// <summary>
    /// <para>Safely gets the components by type from the entity.</para>
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="arg0"></param>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <returns>Returns true if the entity has these components.</returns>
    [Il2CppSetOption(Option.NullChecks, false)]
    public bool TryGet<T, Y, U>(out T arg0, out Y arg1, out U arg2)
    {
      arg0 = default;
      arg1 = default;
      arg2 = default;
      if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
      if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
      return (arg2 = Storage<U>.Instance.TryGet(id)) != null;
    }

    /// <summary>
    /// <para>Safely gets the components by type from the entity.</para>
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="arg0"></param>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    /// <param name="arg3"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="I"></typeparam>
    /// <returns>Returns true if the entity has these components.</returns>
    [Il2CppSetOption(Option.NullChecks, false)]
    public bool TryGet<T, Y, U, I>(out T arg0, out Y arg1, out U arg2, out I arg3)
    {
      arg0 = default;
      arg1 = default;
      arg2 = default;
      arg3 = default;
      if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
      if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
      if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;
      return (arg3 = Storage<I>.Instance.TryGet(id)) != null;
    }

    /// <summary>
    /// Safely gets the components by type from the entity.
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="arg0"></param>
    /// <param name="arg1"></param>
    /// <param name="arg2"></param>
    /// <param name="arg3"></param>
    /// <param name="arg4"></param>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    /// <typeparam name="U"></typeparam>
    /// <typeparam name="I"></typeparam>
    /// <typeparam name="O"></typeparam>
    /// <returns>Returns true if the entity has these components.</returns>
    [Il2CppSetOption(Option.NullChecks, false)]
    public bool TryGet<T, Y, U, I, O>(out T arg0, out Y arg1, out U arg2, out I arg3, out O arg4)
    {
      arg0 = default;
      arg1 = default;
      arg2 = default;
      arg3 = default;
      arg4 = default;
      if ((arg0 = Storage<T>.Instance.TryGet(id)) == null) return false;
      if ((arg1 = Storage<Y>.Instance.TryGet(id)) == null) return false;
      if ((arg2 = Storage<U>.Instance.TryGet(id)) == null) return false;
      if ((arg3 = Storage<I>.Instance.TryGet(id)) == null) return false;
      return (arg4 = Storage<O>.Instance.TryGet(id)) != null;
    }
#endif

    public void Release()
    {
      DebugDestroyed(this);
      meta->isAlive = false;
      ref var _managed = ref managed;
      foreach (var child in _managed.childs)
        child.Release();
      _managed.layer.processorEcs.SetOperation(this, 0, ProcessorEcs.Action.Kill);
    }
  }
}