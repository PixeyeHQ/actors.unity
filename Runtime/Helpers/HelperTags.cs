//  Project : ecs
// Contacts : Pix - ask@pixeye.games
// Author : Geobrain

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public static unsafe class HelperTags
  {
    public static int TagsAmount(in this ent entity, int tagID) => entity.meta->tags.GetAmount(tagID);

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

    internal static void RegisterGroup(GroupCore groupCore)
    {
      CacheGroup container;
      var        composition = groupCore.composition;
      var        ecs         = groupCore.processorEcs;
      foreach (var tagID in composition.includedTags)
      {
        if (ecs.familyTags.TryGetValue(tagID, out container))
        {
          if (container.Contain(groupCore)) continue;

          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();

          container.Add(groupCore);
          ecs.familyTags.Add(tagID, container);
        }
      }

      foreach (var tagID in composition.excludedTags)
      {
        if (ecs.familyTags.TryGetValue(tagID, out container))
        {
          if (container.Contain(groupCore)) continue;
          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();
          container.Add(groupCore);
          ecs.familyTags.Add(tagID, container);
        }
      }

      var index = -1;

      for (var i = 0; i < composition.excluded.Length; i++)
      {
        ref var signature = ref composition.excluded[i];
        if (ecs.familyTypes.TryGetValue(signature.id, out container))
        {
          if (container.Contain(groupCore)) continue;
          container.Add(groupCore);
        }
        else
        {
          container = new CacheGroup();
          container.Add(groupCore);
          ecs.familyTypes.Add(index, container);
        }
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool Overlaps(this int[] tags, EntityMeta* meta)
    {
      ref var entityTags    = ref meta->tags;
      int     entityLenTags = entityTags.length;

      for (int l = 0; l < tags.Length; l++)
      {
        var next = tags[l];
        for (int i = 0; i < entityLenTags; i++)
        {
          var tag = entityTags.GetElement(i);
          if (tag == next) return true;
        }
      }

      return false;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool IsSubsetOf(this int[] tags, EntityMeta* meta)
    {
      ref var entityTags    = ref meta->tags;
      int     entityLenTags = entityTags.length;

      var match = 0;
      for (var l = 0; l < tags.Length; l++)
      {
        var next = tags[l];
        for (int i = 0; i < entityLenTags; i++)
        {
          var tag = entityTags.GetElement(i);
          if (tag == next) match++;
        }
      }

      return match == tags.Length;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static Type GetTypeTag()
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
    static object GetFieldId(this string fieldName, Type typeTag)
    {
      object value;
      var    info = typeTag.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
      value = info.GetValue(null);

      return value;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static List<string> GetMembersString()
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
  }
}