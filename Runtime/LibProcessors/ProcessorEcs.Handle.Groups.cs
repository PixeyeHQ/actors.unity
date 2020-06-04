using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pixeye.Actors
{
  internal partial class ProcessorEcs
  {
    static int GroupNextID;

    internal static List<GroupCore> Groups = new List<GroupCore>();
    internal FamilyGroup familyTags = new FamilyGroup();
    internal FamilyGroup familyTypes = new FamilyGroup();

    #region BindGroups

    internal void Add(object obj)
    {
      var type = obj.GetType();
      var objectFields =
        type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
      var length = objectFields.Length;

      var groupType = typeof(GroupCore);
#if ACTORS_EVENTS_MANUAL
      var groupEv = Attribute.GetCustomAttribute(type, typeof(EventsAttribute)) as EventsAttribute;
#endif

      for (var i = 0; i < length; i++)
      {
        var myFieldInfo = objectFields[i];
        if (!myFieldInfo.FieldType.IsSubclassOf(groupType)) continue;

#if ACTORS_EVENTS_MANUAL
          // in case we are looking at the group of the derived processor we want to check it's events
          if (inner == null)
          {
            groupEv = Attribute.GetCustomAttribute(myFieldInfo, typeof(EventsAttribute)) as EventsAttribute;
          }
#endif

        var groupByAttribute = Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
        var groupExcludeAttribute =
          Attribute.GetCustomAttribute(myFieldInfo, typeof(ExcludeByAttribute)) as ExcludeByAttribute;
        var bindAttribute = Attribute.GetCustomAttribute(myFieldInfo, typeof(BindAttribute)) as BindAttribute;

        var includeTagsFilter = groupByAttribute != null ? groupByAttribute.filter : new int[0];
        var excludeTagsFilter = new int[0];
        var excludeCompFilter = new int[0];

        if (groupExcludeAttribute != null)
        {
          excludeTagsFilter = groupExcludeAttribute.filter;
          excludeCompFilter = groupExcludeAttribute.filterType;
        }

        var composition = new Composition();
        composition.excludedTags = excludeTagsFilter;
        composition.includedTags = includeTagsFilter;
        composition.GenerateExclude(excludeCompFilter);

        composition.hash = HashCode.OfEach(myFieldInfo.FieldType.GetGenericArguments())
          .AndEach(composition.includedTags).And(17).AndEach(composition.excludedTags).And(31)
          .AndEach(excludeCompFilter);

        var group = SetupGroup(myFieldInfo.FieldType, composition, layer);
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

    GroupCore SetupGroup(Type groupType, Composition composition, LayerCore layer)
    {
      foreach (var groupNext in Groups)
      {
        if (groupNext.composition.hash.value == composition.hash.value && groupNext.layer == layer)
        {
          return groupNext;
        }
      }

      var group = CreateGroup();
      // Groups.Add(group);
      Groups.Add(group);
      return group;

      GroupCore CreateGroup()
      {
        var gr = (Activator.CreateInstance(groupType, true) as GroupCore).Initialize(composition, layer);
        gr.id = GroupNextID++;
        return gr;
      }
    }

    #endregion
  }
}