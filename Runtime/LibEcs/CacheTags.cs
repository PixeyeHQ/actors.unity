//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#define ACTORS_TAGS_DEFAULT
#if ACTORS_TAGS_6 || ACTORS_TAGS_12
#undef ACTORS_TAGS_DEFAULT
#endif

using System.Collections.Generic;
using System.Reflection;
#if! ACTORS_TAGS_0
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct CacheTags
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

    internal ref ushort GetElementByRef(int index)
    {
      return ref tags[index];
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

  public static unsafe class HelperTags
  {
    internal static void ClearAll()
    {
      for (var i = 0; i < Entity.lengthTotal; i++)
      {
        Entity.Tags[i].length = 0;
      }
    }

    public static void ClearTags(in this ent entity)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      var     len    = buffer.length;

      for (var i = 0; i < len; i++)
      {
        var tID = (ushort) buffer.tags[i];
        buffer.size[i] = 0;
        buffer.tags[i] = 0;
        buffer.length--;
        HandleChange(entity, tID);
      }
    }

    public static int TagsAmount(in this ent entity, int tagID)
    {
      return Actors.Entity.Tags[entity.id].GetAmount(tagID);
    }

    public static void Add(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      int     len    = buffer.length;
      var     tID    = (ushort) tagID;

      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tID)
        {
          unchecked
          {
            buffer.size[index] += 1;
          }

          return;
        }
      }

#if UNITY_EDITOR
      if (len == CacheTags.Capacity)
      {
        Framework.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
        return;
      }
#endif

      buffer.SetElement(buffer.length, tagID);
      if (!Entity.entities[entity.id].isDirty)
        HandleChange(entity, tagID);
    }

    public static void Add(in this ent entity, params int[] tagsID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      int     len    = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID        = (ushort) tagsID[i];
        var allowToAdd = true;

        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            unchecked
            {
              buffer.size[index] += 1;
            }

            allowToAdd = false;
            break;
          }
        }

        if (!allowToAdd) continue;

#if UNITY_EDITOR
        if (len == CacheTags.Capacity)
        {
          Framework.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
          return;
        }
#endif

        buffer.SetElement(buffer.length, tID);
        HandleChange(entity, tID);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      int     len    = buffer.length;
      var     tID    = (ushort) tagID;
      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tID)
        {
          unchecked
          {
            buffer.size[index] += 1;
          }

          return;
        }
      }

#if UNITY_EDITOR
      if (len == CacheTags.Capacity)
      {
        Framework.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
        return;
      }
#endif

      buffer.SetElement(buffer.length, tagID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(in this ent entity, params int[] tagsID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];

      int len = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID        = (ushort) tagsID[i];
        var allowToAdd = true;
        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            unchecked
            {
              buffer.size[index] += 1;
            }

            allowToAdd = false;
            break;
          }
        }

        if (!allowToAdd) continue;

#if UNITY_EDITOR
        if (len == CacheTags.Capacity)
        {
          Framework.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
          return;
        }
#endif

        buffer.SetElement(buffer.length, tID);
      }
    }

    public static void Remove(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      int     len    = buffer.length;

      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tagID)
        {
          if (--buffer.size[index] == 0)
          {
            buffer.RemoveAt(index);
            HandleChange(entity, tagID);
          }

          return;
        }
      }
    }

    public static void RemoveAll(in this ent entity, params int[] tagsID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      var     len    = buffer.length;

      for (var i = 0; i < tagsID.Length; i++)
      {
        var tID = (ushort) tagsID[i];
        for (var index = 0; index < len; index++)
        {
          if (buffer.tags[index] == tID)
          {
            buffer.size[index] = 0;
            buffer.RemoveAt(index);
            HandleChange(entity, tID);
            break;
          }
        }
      }
    }

    public static void RemoveAll(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.Entity.Tags[entity.id];
      int     len    = buffer.length;
      var     tID    = (ushort) tagID;

      for (var index = 0; index < len; index++)
      {
        if (buffer.tags[index] == tID)
        {
          buffer.size[index] = 0;
          buffer.RemoveAt(index);
          HandleChange(entity, tID);
          return;
        }
      }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(in this ent entity, int tagID)
    {
      return Actors.Entity.Tags[entity.id].Has(tagID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(in this ent entity, params int[] tagsID)
    {
      return Actors.Entity.Tags[entity.id].Has(tagsID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasAny(in this ent entity, params int[] tagsID)
    {
      return Actors.Entity.Tags[entity.id].HasAny(tagsID);
    }

    internal static void Add(GroupCore groupCore)
    {
      CacheGroup container;
      var        composition = groupCore.composition;
      foreach (var tagID in composition.includeTags)
      {
        if (groups.ByTag.TryGetValue(tagID, out container))
        {
          if (container.Contain(groupCore)) continue;

          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();

          container.Add(groupCore);
          groups.ByTag.Add(tagID, container);
        }
      }

      foreach (var tagID in composition.excludeTags)
      {
        if (groups.ByTag.TryGetValue(tagID, out container))
        {
          if (container.Contain(groupCore)) continue;
          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();
          container.Add(groupCore);
          groups.ByTag.Add(tagID, container);
        }
      }

      var index = -1;
      foreach (var typeID in composition.excludeComponents)
      {
        index++;
        if (!typeID) continue;

        if (groups.ByType.TryGetValue(index, out container))
        {
          if (container.Contain(groupCore)) continue;
          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();
          container.Add(groupCore);
          groups.ByType.Add(index, container);
        }
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void HandleChange(in ent entity, int tagID)
    {
#if ACTORS_TAGS_CHECKS
      var indexGroup = groups.ByTag.TryGetValue(tagID);
      if (indexGroup == -1) return;
      EntityOperations.Set(entity, indexGroup, EntityOperations.Action.ChangeTag);
#endif
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Type GetTypeTag()
    {
      Type typeTag    = default;
      var  assemblies = AppDomain.CurrentDomain.GetAssemblies();
      var  executing  = Assembly.GetExecutingAssembly();
      for (var i = 0; i < assemblies.Length; i++)
      {
        var a = assemblies[i];
        if (a != executing)
        {
          var types = a.GetTypes();
          foreach (var type in types)
          {
            if (typeof(ITag).IsAssignableFrom(type)) typeTag = type;
          }
        }
      }

      return typeTag;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static object GetFieldId(this string fieldName, Type typeTag)
    {
      object    value;
      var info = typeTag.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
      value = info.GetValue(null);

      return value;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static List<string> GetMembersString()
    {
      var typeTag     = GetTypeTag();
      var  memberArray = typeTag.GetMembers();

      var memberString = new List<string>();
      foreach (var member in memberArray)
      {
        if (member.DeclaringType.ToString() == typeTag.FullName)
        {
          memberString.Add(member.Name);
        }
      }

      return memberString;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string TagToName(in this int tag)
    {
      var listTagName = GetMembersString();

      var typeTag = GetTypeTag();

      for (var i = 1; i < listTagName.Count; i++)
      {
        var tagId = (int) GetFieldId(listTagName[i], typeTag);

        if (tag == tagId)
        {
          return listTagName[i];
        }
      }

      return default;
    }
  }
}
#endif