//  Project : ecs
// Contacts : Pix - ask@pixeye.games
// Author : Geobrain

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static unsafe class HelperTags
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool Overlaps(this int[] tags, EntityMeta* meta)
    {
      ref var entityTags = ref meta->tags;
      int     len        = entityTags.length;

      for (int l = 0; l < tags.Length; l++)
      {
        var next = tags[l];
        for (int i = 0; i < len; i++)
        {
          ref var tag = ref entityTags.GetElementByRef(i);
          if (tag == next) return true;
        }
      }

      return false;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool IsSubsetOf(this int[] tags, EntityMeta* meta)
    {
      ref var entityTags = ref meta->tags;
      int     len        = tags.Length;

      var match = 0;
      for (int l = 0; l < tags.Length; l++)
      {
        var next = tags[l];
        for (int i = 0; i < len; i++)
        {
          ref var tag = ref entityTags.GetElementByRef(i);
          if (tag == next) match++;
        }
      }

      return match == tags.Length;
    }

    internal static void ClearAll()
    {
      for (var i = 0; i < EntityImplOld.lengthTotal; i++)
      {
        EntityImplOld.Tags[i].length = 0;
      }
    }

    public static void ClearTags(in this ent entity)
    {
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
      return Actors.EntityImplOld.Tags[entity.id].GetAmount(tagID);
    }

    public static void Add(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
        Kernel.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
        return;
      }
#endif

      buffer.SetElement(buffer.length, tagID);
      if (!EntityImplOld.entities[entity.id].isDirty)
        HandleChange(entity, tagID);
    }

    public static void Add(in this ent entity, params int[] tagsID)
    {
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
          Kernel.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
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
      ref var buffer = ref entity.meta->tags;

      int len = buffer.length;
      var tID = (ushort) tagID;
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
        Kernel.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
        return;
      }
#endif


      buffer.SetElement(buffer.length, tagID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Set(in this ent entity, params int[] tagsID)
    {
      ref var buffer = ref entity.meta->tags;

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
          Kernel.Debugger.Log(LogType.TAGS_LIMIT_REACHED, entity, CacheTags.Capacity);
          return;
        }
#endif

        buffer.SetElement(buffer.length, tID);
      }
    }

    public static void Remove(in this ent entity, int tagID)
    {
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
      ref var buffer = ref Actors.EntityImplOld.Tags[entity.id];
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
      return entity.meta->tags.Has(tagID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Has(in this ent entity, params int[] tagsID)
    {
      return entity.meta->tags.Has(tagsID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasAny(in this ent entity, params int[] tagsID)
    {
      return entity.meta->tags.HasAny(tagsID);
    }

    internal static void Add(GroupCore groupCore)
    {
      CacheGroup container;
      var        composition = groupCore.composition;
      foreach (var tagID in composition.includedTags)
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

      foreach (var tagID in composition.excludedTags)
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
      ProcessorEcs.SetOld(entity, indexGroup, ProcessorEcs.Action.ChangeTag);
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
      object value;
      var    info = typeTag.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
      value = info.GetValue(null);

      return value;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static List<string> GetMembersString()
    {
      var typeTag     = GetTypeTag();
      var memberArray = typeTag.GetMembers();

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