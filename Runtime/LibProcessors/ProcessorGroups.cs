//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	// TODO: refactor.
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public sealed class ProcessorGroups
	{
		internal static DictionaryGroup container = new DictionaryGroup();

		public static void Setup(object b)
		{
			var type         = b.GetType();
			var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
			int length       = objectFields.Length;

			var groupType = typeof(GroupCore);

			for (int i = 0; i < length; i++)
			{
				var myFieldInfo = objectFields[i];

				if (myFieldInfo.FieldType.IsSubclassOf(groupType))
				{
					var groupByAttribute      = Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
					var groupExcludeAttribute = Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupExcludeAttribute)) as GroupExcludeAttribute;

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
					myFieldInfo.SetValue(b, SetupGroup(myFieldInfo.FieldType, composition, myFieldInfo.GetValue(b)));
				}
			}
		}

		internal static GroupCore SetupGroup(Type groupType, Composition filter, object fieldObj)
		{
			if (container.TryGetValue(groupType, filter, out GroupCore group))
			{
				return group;
			}


			if (fieldObj != null)
			{
				group = fieldObj as GroupCore;
				return container.Add((Activator.CreateInstance(groupType, true) as GroupCore).Start(filter));
			}

			return container.Add((Activator.CreateInstance(groupType, true) as GroupCore).Start(filter));
		}

		public static void Dispose()
		{
			container.Dispose();
		}
	}
}