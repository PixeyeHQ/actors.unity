using System;
using System.Reflection;

namespace Pixeye.Actors
{
  internal partial class ProcessorEcs
  {
    static int groupNextID;

    #region BindGroups

    public void Add(object obj)
    {
      var type = obj.GetType();
      var objectFields =
        type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var length = objectFields.Length;

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
        if (!myFieldInfo.FieldType.IsSubclassOf(groupType)) continue;

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
        var groupByAttribute = inner != null
          ? groupByProcAttribute
          : Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
        var groupExcludeAttribute = inner != null
          ? groupExcludeProcAttribute
          : Attribute.GetCustomAttribute(myFieldInfo, typeof(ExcludeAttribute)) as ExcludeAttribute;
        var bindAttribute = inner != null
          ? groupBindProcAttribute
          : Attribute.GetCustomAttribute(myFieldInfo, typeof(BindAttribute)) as BindAttribute;

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

        composition.hash = HashCode.OfEach(myFieldInfo.FieldType.GetGenericArguments())
          .AndEach(composition.includeTags).And(17).AndEach(composition.excludeTags).And(31)
          .AndEach(excludeCompFilter);

        var group = SetupGroup(myFieldInfo.FieldType, composition, myFieldInfo.GetValue(obj));
        myFieldInfo.SetValue(obj, group);

        ///TODO: ACTORS: BINDATTR
        if (bindAttribute != null)
        {
          // if (bindAttribute != null)
          // {
          //   if (bindAttribute.id >= groups.globals.Length)
          //     Array.Resize(ref groups.globals, bindAttribute.id + 5);
          //
          //   groups.globals[bindAttribute.id] = group;
          // }
        }


#if ACTORS_EVENTS_MANUAL
          if (groupEv != null)
          {
            group.SetSelf(groupEv.op, b as Processor);
          }
#endif
      }
    }

    GroupCore SetupGroup(Type groupType, Composition composition, object fieldObj)
    {
      foreach (var groupNext in groups)
      {
        if (groupNext.composition.hash.value == composition.hash.value)
        {
          return groupNext;
        }
      }

      var group = CreateGroup();
      groups.Add(group);
      return group;

      GroupCore CreateGroup()
      {
        var gr = (Activator.CreateInstance(groupType, true) as GroupCore).Initialize(composition);
        gr.id = groupNextID++;
        return gr;
      }
    }

    #endregion
  }
}