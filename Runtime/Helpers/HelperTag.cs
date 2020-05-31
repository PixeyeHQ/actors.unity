//  Project : ecs
// Contacts : Pix - ask@pixeye.games
// Author : Geobrain

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static class HelperTag
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Type GetTypeTag()
    {
      Type typeTag = default;
      var assemblies = AppDomain.CurrentDomain.GetAssemblies();
      var executing = Assembly.GetExecutingAssembly();
      for (int i = 0; i < assemblies.Length; i++)
      {
        var a = assemblies[i];
        if (a != executing)
        {
          var types = a.GetTypes();
          foreach (Type type in types)
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
      var info = typeTag.GetField(fieldName, BindingFlags.Public | BindingFlags.Static);
      var value = info.GetValue(null);

      return value;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static List<string> GetMembersString()
    {
      var typeTag = GetTypeTag();
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

      for (int i = 1; i < listTagName.Count; i++)
      {
        int tagId = (int) GetFieldId(listTagName[i], typeTag);

        if (tag == tagId)
        {
          return listTagName[i];
        }
      }

      return default;
    }
  }
}