using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  internal partial class ProcessorEcs
  {
    static int GroupNextID;

    internal static List<GroupCore> Groups = new List<GroupCore>();

    internal FamilyGroup familyTags = new FamilyGroup();
    internal FamilyGroup familyTypes = new FamilyGroup();

    internal List<GroupCore> groups = new List<GroupCore>();
    internal Dictionary<int, GroupCore> bindings = new Dictionary<int, GroupCore>(FastComparable.Default);

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
        // if (inner == null)
        // {
        groupEv = Attribute.GetCustomAttribute(myFieldInfo, typeof(EventsAttribute)) as EventsAttribute;
        //}
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

        var types = myFieldInfo.FieldType.GetGenericArguments();

        composition.included = new ComponentMask[types.Length];
        var nextIndex = 0;
        foreach (var nextType in types)
        {
          var componentID = Storage.TypeNames[nextType.GetHashCode()];
          composition.included[nextIndex].generation = Storage.Generations[componentID];
          composition.included[nextIndex].mask       = Storage.Masks[componentID];
          composition.included[nextIndex].id         = componentID;
          composition.includeComponents[componentID] = true;
          nextIndex++;
        }

        composition.hash = HashCode.OfEach(myFieldInfo.FieldType.GetGenericArguments())
          .AndEach(composition.includedTags).And(17).AndEach(composition.excludedTags).And(31)
          .AndEach(excludeCompFilter);

        var group = SetupGroup(myFieldInfo.FieldType, myFieldInfo.GetValue(obj), composition, layer);
        myFieldInfo.SetValue(obj, group);

        if (bindAttribute != null)
        {
          bindings.Add(bindAttribute.id, group);
        }


#if ACTORS_EVENTS_MANUAL
        if (groupEv != null)
        {
          group.SetSelf(groupEv.op, obj as Processor);
        }
#endif
      }
    }

    GroupCore SetupGroup(Type groupType, object fieldObj, Composition composition, Layer layer)
    {
      foreach (var groupNext in Groups)
      {
        if (groupNext.composition.hash.value == composition.hash.value && groupNext.layer.id == layer.id)
        {
          if (!groupNext.initialized)
          {
            groups.Add(groupNext);
            groupNext.Initialize(composition, layer);
            groupNext.initialized = true;
          }

          return groupNext;
        }
      }

      var group = CreateGroup();

      groups.Add(group);
      Groups.Add(group);
      return group;

      GroupCore CreateGroup()
      {
        if (fieldObj != null)
        {
          var gr = fieldObj as GroupCore;
          gr.id = GroupNextID++;

          gr.Initialize(composition, layer);
          return gr;
        }
        else
        {
          var gr = Activator.CreateInstance(groupType, true) as GroupCore;

          gr.Initialize(composition, layer);
          gr.id = GroupNextID++;
          return gr;
        }
      }
    }

    #endregion
  }
}