//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  internal struct ComponentMask
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal bool Check(EntityMeta* meta, ref EntityManagedMeta managed)
    {
#if ACTORS_TAGS_CHECKS
      return IsSubsetOf(meta) // @! maybe
             && !excluded.Overlaps(ref managed)
             && includedTags.IsSubsetOf(meta)
             && !excludedTags.Overlaps(meta);
#else
      return IsSubsetOf(meta) // @! maybe
             && !excluded.Overlaps(ref managed);
#endif
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Composition other) => GetHashCode() == other.GetHashCode();

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