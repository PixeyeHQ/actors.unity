//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  public struct ComponentMask
  {
    public int generation;
    public int mask;
    public int id;
  }

  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public unsafe class Composition : IEquatable<Composition>
  {
    internal ComponentMask[] included = new ComponentMask[0];
    internal ComponentMask[] excluded = new ComponentMask[0];

    internal int[] includedTags = new int[0];
    internal int[] excludedTags = new int[0];

    internal bool[] includeComponents = new bool[Kernel.Settings.SizeComponents];
    // internal bool[] excludeComponents = new bool[Kernel.Settings.SizeComponents];

    internal HashCode hash;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool IsSubsetOf(EntityMeta* meta)
    {
      int match = 0;
      for (int i = 0; i < meta->componentsAmount; i++)
      {
        if (includeComponents[meta->components[i]])
          match++;
      }
      return included.Length == match;
    }
    
    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // internal bool OverlapComponents(in CacheEntityOld cache)
    // {
    //   int match = 0;
    //   for (int i = 0; i < cache.componentsAmount; i++)
    //   {
    //     if (includeComponents[cache.componentsIds[i]])
    //       match++;
    //   }
    //
    //   return componentsMask.Length == match;
    // }

    internal void GenerateExclude(int[] types)
    {
      if (types != null)
      {
        excluded = new ComponentMask[types.Length];

        for (int i = 0; i < types.Length; i++)
        {
          var t = types[i];
          excluded[i].generation = Storage.Generations[t];
          excluded[i].mask       = Storage.Masks[t];
          excluded[i].id         = t;
        }
      }
    }


#if !ACTORS_TAGS_0
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool IncludeTags(int entityID)
    {
      ref var tags = ref EntityImplOld.Tags[entityID];
      int     len  = tags.length;

      if (len == 0) return false;
      var match = 0;

      for (int l = 0; l < this.includedTags.Length; l++)
      {
        var tagToInclude = this.includedTags[l];
        for (int i = 0; i < len; i++)
        {
          ref var tag = ref tags.GetElementByRef(i);
          if (tag == tagToInclude) match++;
        }
      }

      return match == this.includedTags.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool ExcludeTags(int entityID)
    {
      ref var tags = ref EntityImplOld.Tags[entityID];
      int     len  = tags.length;
      if (len == 0) return true;

      for (int l = 0; l < excludedTags.Length; l++)
      {
        var tagToExclude = excludedTags[l];
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