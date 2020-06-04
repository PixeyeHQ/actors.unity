//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static unsafe partial class EntityImplOld
  {
 

    //===============================//
    // Initialize 
    //===============================//

 
    internal static void Start()
    {
      var t = Resources.Load<TextAsset>("SettingsFramework");
      if (t != null)
        JsonUtility.FromJsonOverwrite(t.text, Kernel.Settings);

      Kernel.Settings.SizeGenerations = Kernel.Settings.SizeComponents / 32;

      lengthTotal = Kernel.Settings.SizeEntities;
      Generations = new int[Kernel.Settings.SizeEntities, Kernel.Settings.SizeGenerations];
      GenerationsInstant = new int[Kernel.Settings.SizeEntities, Kernel.Settings.SizeGenerations];


      Transforms = new Transform[Kernel.Settings.SizeEntities];

      entities = (CacheEntityOld*) UnmanagedMemory.Alloc(sizeEntityCache * Kernel.Settings.SizeEntities);
 
      Tags = (CacheTags*) UnmanagedMemory.Alloc(sizeBufferTags * Kernel.Settings.SizeEntities);
 


      for (var i = 0; i < Kernel.Settings.SizeEntities; i++)
      {
 
        Tags[i] = new CacheTags();
 
        entities[i] = new CacheEntityOld(6);
      }

      alive = new ents(Kernel.Settings.SizeEntities);
    }

    // Use for other libraries
    public static int GetLiveEntities()
    {
      return alive.length;
    }
 
    internal static void Dispose()
    {
      for (var i = 0; i < lengthTotal; i++)
        Marshal.FreeHGlobal((IntPtr) entities[i].componentsIds);

      UnmanagedMemory.Cleanup();
    }

    public static readonly int sizeEntityCache = UnsafeUtility.SizeOf<CacheEntityOld>();
    internal static int lengthTotal;
    public static ents alive;
  }
}