using System;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  sealed class CacheGroup
  {
    internal GroupCore[] Elements = new GroupCore[10];
    internal int length;
  }

  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  sealed class FamilyGroup
  {
    internal CacheGroup[] cache = new CacheGroup[10];
    internal int[] tagsID = new int[10];

    internal int len;

    internal bool TryGetValue(int tagID, out CacheGroup groupOld)
    {
      var id = -1;
      for (int i = 0; i < len; i++)
      {
        if (tagsID[i] == tagID)
        {
          id = i;
          break;
        }

        id = -1;
      }

      if (id > -1)
      {
        groupOld = cache[id];
        return true;
      }

      groupOld = default;
      return false;
    }

    internal int TryGetValue(int tagID)
    {
      return len == 0 ? -1 : HelperArray.BinarySearch(ref tagsID, tagID, 0, len - 1);
    }

    internal void Add(int tagID, CacheGroup anotherGroupStorage)
    {
      if (len == cache.Length - 1)
      {
        var l = len << 1;
        Array.Resize(ref cache, l);
        Array.Resize(ref tagsID, l);
      }

      var pointer   = len++;
      var indexLast = pointer;
      var index     = pointer - 1;

      if (index >= 0)
      {
        if (tagID < tagsID[index])
        {
          var startIndex = 0;
          var endIndex   = indexLast;

          while (endIndex > startIndex)
          {
            var middleIndex = (endIndex + startIndex) / 2;
            var middleValue = tagsID[middleIndex];

            if (middleValue == tagID)
            {
              pointer = middleIndex;

              break;
            }

            if (middleValue < tagID)
            {
              startIndex = middleIndex + 1;
              pointer    = startIndex;
            }
            else
            {
              endIndex = middleIndex;
              pointer  = endIndex;
            }
          }
        }
      }

      for (int i = indexLast; i >= pointer; i--)
      {
        tagsID[i + 1] = tagsID[i];
        cache[i + 1]  = cache[i];
      }

      cache[pointer]  = anotherGroupStorage;
      tagsID[pointer] = tagID;
    }
  }

  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  static class HelperCacheGroup
  {
    internal static bool Contain(this CacheGroup container, GroupCore groupCore)
    {
      var len = container.length;
      for (int i = 0; i < len; i++)
      {
        var groupAdded = container.Elements[i];
        if (groupAdded.Equals(groupCore)) return true;
      }

      return false;
    }
    
    internal static void Add(this CacheGroup container, GroupCore group)
    {
      ref var len     = ref container.length;
      ref var storage = ref container.Elements;

      if (len == storage.Length)
      {
        var l = container.length << 1;
        Array.Resize(ref storage, l);
      }

      storage[len++] = group;
      // return group;
    }

    internal static void Remove(this CacheGroup container, GroupCore group)
    {
      ref var len     = ref container.length;
      ref var storage = ref container.Elements;

      var index = -1;
      for (int i = 0; i < len; i++)
      {
        if (storage[i] == group)
        {
          index = i;
          break;
        }
      }

      if (index < --len)
        Array.Copy(storage, index + 1, storage, index, len - index);
    }
  }
}