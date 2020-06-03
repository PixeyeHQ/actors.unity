//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  public unsafe struct ent
  {
    //===============================//
    // Released entities
    //===============================//

    internal static ents Released = new ents(Kernel.Settings.SizeEntities);
    internal static int Size = sizeof(ent);
    internal static int NextID = 1;

    //===============================//
    // Groups
    //===============================//
    //public static readonly groups groups = new groups();


    //===============================//
    // Entity
    //===============================//
    public int id;
    internal byte age;

    public ref readonly Transform transform
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => ref ProcessorEcs.EntitiesManaged[id].transform;
    }

    public bool exist
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get
      {
        var m = meta;
        return id > 0 && m->isAlive && m->age == age;
      }
    }

    public ent(int value)
    {
      id  = value;
      age = 0;
    }

    public override int GetHashCode()
    {
      return ((id << 5) + id) ^ age;
    }

    public override string ToString()
    {
      return id.ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Release()
    {
#if UNITY_EDITOR
      if (!exist)
      {
        Kernel.Debugger.Log(LogType.DESTROYED, this, transform);
        return;
      }
#endif


      EntityImplOld.entities[id].CleanMask(id);
      ProcessorEcs.SetOld(this, 0, ProcessorEcs.Action.Kill);
      EntityImplOld.entities[id].isAlive = false;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(ent other)
    {
      return id == other.id && age == other.age;
    }

    public override bool Equals(object obj)
    {
      return obj is ent other && Equals(other);
    }

    //===============================//
    // Operators
    //===============================//
    public static implicit operator int(ent value)
    {
      return value.id;
    }

    public static implicit operator ent(int value)
    {
      var e = new ent(value);
      return e;
    }

    public static bool operator ==(ent arg1, ent arg2)
    {
      return arg1.id == arg2.id && arg1.age == arg2.age;
    }

    public static bool operator !=(ent arg1, ent arg2)
    {
      return !(arg1 == arg2);
    }

    //===============================//
    // Utils
    //===============================//

    internal ref EntityManagedMeta managed => ref ProcessorEcs.EntitiesManaged[id];
    internal EntityMeta* meta => ProcessorEcs.Entities.Get<EntityMeta>(id);

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T>()
    {
      return (managed.generationsInstant[Storage<T>.Generation] & Storage<T>.ComponentMask) ==
             Storage<T>.ComponentMask;
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;

      return (managed.generationsInstant[Storage<T>.Generation] & mask) == mask &&
             (managed.generationsInstant[Storage<T>.Generation] & mask2) == mask2;
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y, U>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;
      var mask3 = Storage<U>.ComponentMask;

      return (managed.generationsInstant[Storage<T>.Generation] & mask) == mask &&
             (managed.generationsInstant[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask3) == mask3;
    }


    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y, U, I>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;
      var mask3 = Storage<U>.ComponentMask;
      var mask4 = Storage<I>.ComponentMask;

      return (managed.generationsInstant[Storage<T>.Generation] & mask) == mask &&
             (managed.generationsInstant[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask3) == mask3 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask4) == mask4;
    }


    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y, U, I, O>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;
      var mask3 = Storage<U>.ComponentMask;
      var mask4 = Storage<I>.ComponentMask;
      var mask5 = Storage<O>.ComponentMask;

      return (managed.generationsInstant[Storage<T>.Generation] & mask) == mask &&
             (managed.generationsInstant[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask3) == mask3 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask4) == mask4 &&
             (managed.generationsInstant[Storage<T>.Generation] & mask5) == mask5;
    }

    public void MoveTo<T>() where T : LayerCore
    {
      var nextLayer = Layer<T>.layer;

#if UNITY_EDITOR
      if (nextLayer == null)
      {
        Debug.Log("You are trying to send entity to a layer that doesn't exist in the game.");
        throw new Exception();
      }
#endif
      managed.layer.processorEcs.SwapWorld(this, nextLayer);
      SceneManager.MoveGameObjectToScene(managed.transform.gameObject, nextLayer.gameObject.scene);
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
    public bool Get<T>(out T arg0)
    {
      return (arg0 = (managed.generationsInstant[Storage<T>.Generation] & Storage<T>.ComponentMask) ==
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
    public bool Get<T, Y>(out T arg0, out Y arg1)
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
    public bool Get<T, Y, U>(out T arg0, out Y arg1, out U arg2)
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
    public bool Get<T, Y, U, I>(out T arg0, out Y arg1, out U arg2, out I arg3)
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
    public bool Get<T, Y, U, I, O>(out T arg0, out Y arg1, out U arg2, out I arg3, out O arg4)
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
  }
}