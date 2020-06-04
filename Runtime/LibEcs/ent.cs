//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 


using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  public unsafe partial struct ent
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
      return (managed.signature[Storage<T>.Generation] & Storage<T>.ComponentMask) ==
             Storage<T>.ComponentMask;
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;

      return (managed.signature[Storage<T>.Generation] & mask) == mask &&
             (managed.signature[Storage<T>.Generation] & mask2) == mask2;
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y, U>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;
      var mask3 = Storage<U>.ComponentMask;

      return (managed.signature[Storage<T>.Generation] & mask) == mask &&
             (managed.signature[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.signature[Storage<T>.Generation] & mask3) == mask3;
    }


    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Has<T, Y, U, I>()
    {
      var mask  = Storage<T>.ComponentMask;
      var mask2 = Storage<Y>.ComponentMask;
      var mask3 = Storage<U>.ComponentMask;
      var mask4 = Storage<I>.ComponentMask;

      return (managed.signature[Storage<T>.Generation] & mask) == mask &&
             (managed.signature[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.signature[Storage<T>.Generation] & mask3) == mask3 &&
             (managed.signature[Storage<T>.Generation] & mask4) == mask4;
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

      return (managed.signature[Storage<T>.Generation] & mask) == mask &&
             (managed.signature[Storage<T>.Generation] & mask2) == mask2 &&
             (managed.signature[Storage<T>.Generation] & mask3) == mask3 &&
             (managed.signature[Storage<T>.Generation] & mask4) == mask4 &&
             (managed.signature[Storage<T>.Generation] & mask5) == mask5;
    }

    public void SetParent(ent entity)
    {
      var _managed = managed;
      _managed.parent = entity;
      entity.managed.childs.Add(this);
    }

    public void Unparent()
    {
      var _managed = managed;
      _managed.parent.managed.childs.Remove(this);
      _managed.parent = default;
    }

    public void MoveTo<T>() where T : LayerCore
    {
      var nextLayer = Layer<T>.LayerTyped;

#if ACTORS_DEBUG
      if (nextLayer == null)
      {
        Debug.Log($"Layer {typeof(T)} doesn't exist in the game.");
        throw new Exception();
      }

      if (managed.parent.exist)
      {
        Debug.Log(
          $"You are trying to send child entity. This is not allowed. Send parent [{managed.parent.id}] {managed.transform} instead.");
        throw new Exception();
      }
#endif
      managed.layer.processorEcs.SwapLayer(this, nextLayer);
    }
  }
}