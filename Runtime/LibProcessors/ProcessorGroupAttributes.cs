//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Reflection;

namespace Pixeye.Framework
{
	public class ProcessorGroupAttributes
	{

		public static void Setup(object b)
		{
			var type         = b.GetType();
			var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
			int length       = objectFields.Length;

			var groupType = typeof(GroupCore);

			for (int i = 0; i < length; i++)
			{
				var myFieldInfo = objectFields[i];

				var groupByAttribute =
						Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
				var groupExcludeAttribute =
						Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupExcludeAttribute)) as
								GroupExcludeAttribute;

				if (myFieldInfo.FieldType.IsSubclassOf(groupType))
				{
					var excludeFilter = groupExcludeAttribute != null ? groupExcludeAttribute.filter : new int[0];
					var includeFilter = groupByAttribute != null ? groupByAttribute.filter : new int[0];

					var filter = new Composition();
					filter.tagsToExclude = excludeFilter;
					filter.tagsToInclude = includeFilter;

					myFieldInfo.SetValue(b, ProcessorGroups.SetupGroup(myFieldInfo.FieldType, filter));
				}
			}
		}

	}
}