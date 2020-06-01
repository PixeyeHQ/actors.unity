using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
  public static unsafe partial class HelperEcs
  {
    [Conditional("ACTORS_DEBUG")]
    static void DebugCheckNull(ent entity, Type type)
    {
      if (entity.id != 0) return;
      Kernel.Debugger.Log(LogType.NULL_ENTITY, entity, type.Name);
      throw new ArgumentException();
    }


    /// Used in Models and Actors for setting up components to Storage. Doesn't send the component to systems.
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T Set<T>(in this ent entity)
    {
      var entityID = entity.id;
      DebugCheckNull(entity, typeof(T));

      if (entityID >= Storage<T>.components.Length)
        Array.Resize(ref Storage<T>.components, entityID << 1);

      entity.meta->AddComponent(Storage<T>.componentId);
      entity.managed.generationsInstant[Storage<T>.Generation] |= Storage<T>.ComponentMask;

      ref var val = ref Storage<T>.components[entityID];
#if !ACTORS_COMPONENTS_STRUCTS
      if (val == null)
        val = Storage<T>.Instance.Create();
#endif
      return ref val;
    }

    //     /// Used in Models and Actors for setting up components to Storage. Doesn't send the component to systems.
    //     [MethodImpl(MethodImplOptions.AggressiveInlining)]
    //     public static ref T Set<T>(in this ent entity)
    //     {
    //       var id = entity.id;
    // #if UNITY_EDITOR
    //       if (entity.id == 0)
    //       {
    //         Kernel.Debugger.Log(LogType.NULL_ENTITY, entity, typeof(T).Name);
    //         return ref Storage<T>.Get(id);
    //       }
    // #endif
    //       if (id >= Storage<T>.components.Length)
    //         Array.Resize(ref Storage<T>.components, id << 1);
    //       entities[id].Add(Storage<T>.componentId);
    //       GenerationsInstant[id, Storage<T>.Generation] |= Storage<T>.ComponentMask;
    //
    //       ref var val = ref Storage<T>.components[id];
    // #if !ACTORS_COMPONENTS_STRUCTS
    //       if (val == null)
    //         val = Storage<T>.Instance.Create();
    // #endif
    //       return ref val;
    //     }
  }
}