//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Debug = UnityEngine.Debug;


namespace Pixeye.Actors
{
  public struct ComponentMask
  {
    public int generation;
    public int mask;
  }

  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public unsafe class Composition : IEquatable<Composition>
  {
    internal ComponentMask[] included = new ComponentMask[0];
    internal ComponentMask[] excluded = new ComponentMask[0];

    internal int[] generations = new int[0];
    internal int[] componentsMask = new int[0];
    internal int[] componentsExclude = new int[0];

    internal int[] tags = new int[0];
    internal int[] tagsExclude = new int[0];

    internal bool[] includeComponents = new bool[Kernel.Settings.SizeComponents];
    internal bool[] excludeComponents = new bool[Kernel.Settings.SizeComponents];

    internal HashCode hash;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool OverlapComponents(in CacheEntityOld cache)
    {
      int match = 0;
      for (int i = 0; i < cache.componentsAmount; i++)
      {
        if (includeComponents[cache.componentsIds[i]])
          match++;
      }

      return componentsMask.Length == match;
    }

    internal void AddTypesExclude(int[] types)
    {
      if (types != null)
      {
        excluded = new ComponentMask[types.Length];

        for (int i = 0; i < types.Length; i++)
        {
          var t = Storage.typeNames[types[i]];
     
          excluded[i].generation = Storage.Generations[t];
          excluded[i].mask       = Storage.Masks[t];
          excludeComponents[t]   = true;
          //componentsExclude[i]   = t;
        }
      }
    }

    internal void SetupExcludeTypes(GroupCore g)
    {
      for (int i = 0; i < Storage.lastID; i++)
      {
        var t = excludeComponents[i];
        if (t) Storage.All[i].groups.Add(g);
      }
    }


    // internal bool Check(int entityID)
    // {
    //   
    //   return false;
    // }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool CheckThatWork(int entityID)
    {
      // #if ACTORS_TAGS_CHECKS && !ACTORS_TAGS_0
      //       return CanProceed(entityID) && !ExcludeTypes(entityID) && (tags.Length == 0 || IncludeTags(entityID)) &
      //         (tagsExclude.Length == 0 || ExcludeTags(entityID));
      // #else

      // for (int ll = 0; ll < ids.Length; ll++)
      //         if ((Entity.Generations[entityID, generations[ll]] & ids[ll]) != ids[ll])
      //         {
      //           return false;
      //         }
      //
      //       ref var components = ref Entity.entities[entityID];
      //
      //       for (int i = 0; i < components.componentsAmount; i++)
      //       {
      //         if (excludeComponents[components.componentsIds[i]])
      //         {
      //           return false;
      //         }
      //       }

      return true;
      //#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool CanProceed(int entityID)
    {
      for (var ll = 0; ll < componentsMask.Length; ll++)
        if ((EntityImplOld.Generations[entityID, generations[ll]] & componentsMask[ll]) != componentsMask[ll])
          return false;

      return true;
    }
#if !ACTORS_TAGS_0
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool IncludeTags(int entityID)
    {
      ref var tags = ref EntityImplOld.Tags[entityID];
      int     len  = tags.length;

      if (len == 0) return false;
      var match = 0;

      for (int l = 0; l < this.tags.Length; l++)
      {
        var tagToInclude = this.tags[l];
        for (int i = 0; i < len; i++)
        {
          ref var tag = ref tags.GetElementByRef(i);
          if (tag == tagToInclude) match++;
        }
      }

      return match == this.tags.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool ExcludeTags(int entityID)
    {
      ref var tags = ref EntityImplOld.Tags[entityID];
      int     len  = tags.length;
      if (len == 0) return true;

      for (int l = 0; l < tagsExclude.Length; l++)
      {
        var tagToExclude = tagsExclude[l];
        for (int i = 0; i < len; i++)
        {
          ref var tag = ref tags.GetElementByRef(i);
          if (tag == tagToExclude) return false;
        }
      }

      return true;
    }
#endif


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Composition other)
    {
      return GetHashCode() == other.GetHashCode();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode() => hash;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object obj)
    {
      var other = obj as Composition;
      return other != null && Equals(other);
    }
  }
}