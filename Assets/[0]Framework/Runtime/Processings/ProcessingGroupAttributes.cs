/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:42 PM
================================================================*/


using System;
using System.Reflection;


namespace Homebrew
{
	public class ProcessingGroupAttributes
	{
		public static void Setup(object b)
		{
			var type         = b.GetType();
			var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
			int length       = objectFields.Length;

			var groupType = typeof(GroupBase);


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
					filter.exclude = excludeFilter;
					filter.include = includeFilter;


					myFieldInfo.SetValue(b, ProcessingEntities.Default.SetupGroup(myFieldInfo.FieldType, filter));
				}
			}


			// continue;
		}
	}
}