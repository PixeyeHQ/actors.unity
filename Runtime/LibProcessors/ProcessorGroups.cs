//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  sealed class ProcessorGroups
  {
    public static void Add(object b)
    {
      Add(b,Starter.ActiveLayer.id);
    }

    public static void Add(object b, int index)
    {
      var type         = b.GetType();
      var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var length       = objectFields.Length;

      var groupType = typeof(GroupCore);
#if ACTORS_EVENTS_MANUAL
      var groupEv = Attribute.GetCustomAttribute(type, typeof(EventsAttribute)) as EventsAttribute;
#endif
      var groupByProcAttribute      = Attribute.GetCustomAttribute(type, typeof(GroupByAttribute)) as GroupByAttribute;
      var groupExcludeProcAttribute = Attribute.GetCustomAttribute(type, typeof(ExcludeAttribute)) as ExcludeAttribute;
      var groupBindProcAttribute    = Attribute.GetCustomAttribute(type, typeof(BindAttribute)) as BindAttribute;


      for (var i = 0; i < length; i++)
      {
        var myFieldInfo = objectFields[i];

        if (myFieldInfo.FieldType.IsSubclassOf(groupType))
        {
          // check if the group located inside of the base processor
          var inner = Attribute.GetCustomAttribute(myFieldInfo, typeof(InnerGroupAttribute)) as InnerGroupAttribute;

#if ACTORS_EVENTS_MANUAL
          // in case we are looking at the group of the derived processor we want to check it's events
          if (inner == null)
          {
            groupEv = Attribute.GetCustomAttribute(myFieldInfo, typeof(EventsAttribute)) as EventsAttribute;
          }
#endif
          // if group is located inside of the base processor use processor filtering 
          var groupByAttribute      = inner != null ? groupByProcAttribute : Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
          var groupExcludeAttribute = inner != null ? groupExcludeProcAttribute : Attribute.GetCustomAttribute(myFieldInfo, typeof(ExcludeAttribute)) as ExcludeAttribute;
          var bindAttribute         = inner != null ? groupBindProcAttribute : Attribute.GetCustomAttribute(myFieldInfo, typeof(BindAttribute)) as BindAttribute;


          var includeTagsFilter = groupByAttribute != null ? groupByAttribute.filter : new int[0];
          var excludeTagsFilter = new int[0];
          var excludeCompFilter = new int[0];

          if (groupExcludeAttribute != null)
          {
            excludeTagsFilter = groupExcludeAttribute.filter;
            excludeCompFilter = groupExcludeAttribute.filterType;
          }

          var composition = new Composition();
          composition.excludeTags = excludeTagsFilter;
          composition.includeTags = includeTagsFilter;
          composition.AddTypesExclude(excludeCompFilter);


          composition.hash = HashCode.OfEach(myFieldInfo.FieldType.GetGenericArguments()).AndEach(composition.includeTags).And(17).AndEach(composition.excludeTags).And(31).AndEach(excludeCompFilter);

          var group = SetupGroup(myFieldInfo.FieldType, composition, myFieldInfo.GetValue(b));
          myFieldInfo.SetValue(b, group);

          if (bindAttribute != null)
          {
            if (bindAttribute.id >= groups.globals.Length)
              Array.Resize(ref groups.globals, bindAttribute.id + 5);

            groups.globals[bindAttribute.id] = group;
          }

#if ACTORS_EVENTS_MANUAL
          if (groupEv != null)
          {
            group.SetSelf(groupEv.op, b as Processor);
          }
#endif
        }
      }
    }

    internal static GroupCore SetupGroup(Type groupType, Composition composition, object fieldObj)
    {
      if (groups.All.TryGetValue(groupType, composition, out GroupCore group))
      {
        return group;
      }

      if (fieldObj != null)
      {
        group = fieldObj as GroupCore;
        return groups.All.Add(CreateGroup(groupType, composition));
      }

      return groups.All.Add(CreateGroup(groupType, composition));
    }

    internal static GroupCore CreateGroup(Type groupType, Composition composition)
    {
      var gr = (Activator.CreateInstance(groupType, true) as GroupCore).Initialize(composition);
      gr.id = groups.All.length;
      return gr;
    }
  }
}