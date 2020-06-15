//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#define ACTORS_TAGS_DEFAULT
#if ACTORS_TAGS_6 || ACTORS_TAGS_12
#undef ACTORS_TAGS_DEFAULT
#endif


using System.Runtime.InteropServices;

namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct EcsTags
  {
#if ACTORS_TAGS_24 || ACTORS_TAGS_DEFAULT
    public const int Capacity = 24;
    public fixed ushort tags[Capacity];
    public fixed byte size[Capacity];
#elif ACTORS_TAGS_12
    public const int Capacity = 12;
    public fixed ushort tags[Capacity];
    public fixed byte size[Capacity];
#elif ACTORS_TAGS_6
    public const int Capacity = 6;
    public fixed ushort tags[Capacity];
    public fixed byte size[Capacity];
#endif


    public byte length;

    //    public byte length;

    public void Clear()
    {
      for (var i = 0; i < Capacity; i++)
      {
        tags[i] = 0;
        size[i] = 0;
      }

      length = 0;
    }

    public byte GetTagSize(int index)
    {
      return size[index];
    }

    public void RemoveAt(int index)
    {
      for (var i = index; i < length; ++i)
      {
        tags[i] = tags[i + 1];
        size[i] = size[i + 1];
      }

      length--;
    }

    public void SetElement(int index, int arg)
    {
      tags[index] = (ushort) arg;
      size[index] = 1;
      length++;
    }

    public void Increase(int index)
    {
      unchecked
      {
        size[index] += 1;
      }
    }

    public bool Decrease(int index)
    {
      if (--size[index] == 0)
      {
        RemoveAt(index);
        return true;
      }

      return false;
    }

    public void ClearAt(int index)
    {
      size[index] = 0;
      RemoveAt(index);
    }

    internal ushort GetElement(int index)
    {
      return tags[index];
    }


    public bool HasAny(params int[] tagsID)
    {
      if (length == 0) return false;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID = (ushort) tagsID[i];
        for (var j = 0; j < length; j++)
          if (tags[j] == tID)
            return true;
      }

      return false;
    }

    public bool Has(params int[] tagsID)
    {
      if (length == 0) return false;
      var match = 0;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID = (ushort) tagsID[i];
        for (var j = 0; j < length; j++)
        {
          if (tags[j] == tID)
            match++;
        }
      }

      return match == tagsID.Length;
    }

    public bool Has(int tagID)
    {
      for (var i = 0; i < length; i++)
      {
        if (tags[i] == tagID)
          return true;
      }

      return false;
    }


    public int GetAmount(int tagID)
    {
      for (var i = 0; i < length; i++)
      {
        if (tags[i] == tagID)
          return size[i];
      }

      return -1;
    }
  }
}