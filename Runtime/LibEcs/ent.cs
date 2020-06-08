//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/16/2019 

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  public unsafe partial struct ent
  {
    //===============================//
    // Released entities
    //===============================//

    internal static ents Released = new ents(LayerKernel.Settings.SizeEntities);
    internal static int Size = sizeof(ent);
    internal static int NextID = 1;

    //===============================//
    // Entity
    //===============================//

    internal byte age;

    /// do not change
    public byte byte1;

    /// do not change
    public byte byte2;

    /// do not change
    public byte byte3;

    public int id
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => byte1 | (byte2 << 0x8) | (byte3 << 0x10);
      // [MethodImpl(MethodImplOptions.AggressiveInlining)]
      // set
      // {
      //   byte1 = (byte) value;
      //   byte2 = (byte) (value >> 0x8);
      //   byte3 = (byte) (value >> 0x10);
      // }
    }

    public ref readonly Transform transform
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => ref ProcessorEcs.EntitiesManaged[byte1 | (byte2 << 0x8) | (byte3 << 0x10)].transform;
    }

    public bool exist
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get
      {
        var _meta = meta;
        return (byte1 | (byte2 << 0x8) | (byte3 << 0x10)) > 0 && _meta->isAlive && _meta->age == age;
      }
    }

    public ent(int value)
    {
      byte1 = (byte) value;
      byte2 = (byte) (value >> 0x8);
      byte3 = (byte) (value >> 0x10);
      age   = 0;
    }

    public override int GetHashCode()
    {
      var _id = byte1 | (byte2 << 0x8) | (byte3 << 0x10);
      return ((_id << 5) + _id) ^ age;
    }

    public override string ToString()
    {
      return (byte1 | (byte2 << 0x8) | (byte3 << 0x10)).ToString();
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(ent other)
    {
      return (byte1 | (byte2 << 0x8) | (byte3 << 0x10)) == (other.byte1 | (other.byte2 << 0x8) | (other.byte3 << 0x10)) && age == other.age;
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
      return value.byte1 | (value.byte2 << 0x8) | (value.byte3 << 0x10);
    }

    public static implicit operator ent(int value)
    {
      var e = new ent(value);
      return e;
    }

    public static bool operator ==(ent arg1, ent arg2)
    {
       
      return (arg1.byte1 | (arg1.byte2 << 0x8) | (arg1.byte3 << 0x10)) == (arg2.byte1 | (arg2.byte2 << 0x8) | (arg2.byte3 << 0x10)) && arg1.age == arg2.age;
    }

    public static bool operator !=(ent arg1, ent arg2)
    {
      return !(arg1 == arg2);
    }

    //===============================//
    // Utils
    //===============================//

    internal ref EntityManagedMeta managed => ref ProcessorEcs.EntitiesManaged[byte1 | (byte2 << 0x8) | (byte3 << 0x10)];
    internal EntityMeta* meta => ProcessorEcs.Entities.Get<EntityMeta>(byte1 | (byte2 << 0x8) | (byte3 << 0x10));

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
      DebugMoveTo<T>();
      managed.layer.processorEcs.SwapLayer(this, Layer<T>.LayerTyped);
    }

    [Conditional("ACTORS_DEBUG")]
    void DebugMoveTo<T>()
    {
      if (Layer<T>.LayerTyped == null)
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
    }
  }
}