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
	public class ProcessingAttributes
	{
		public static ProcessingAttributes Default;


		public void Setup(ProcessingBase b)
		{
		 
			var type = b.GetType();
			var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var length = objectFields.Length;
			FilterMask mask;
			var hasAtr = false;
			for (var i = 0; i < length; i++)
			{
				var myFieldInfo = objectFields[i];

				var groupByAttribute = Attribute.GetCustomAttribute(objectFields[i], typeof(GroupByAttribute)) as GroupByAttribute;

				mask = new FilterMask();

				if (groupByAttribute != null)
				{
					hasAtr = true;
					mask.groupFilter = groupByAttribute.filter;
				}

				var groupExcludeAttribute =
					Attribute.GetCustomAttribute(objectFields[i], typeof(GroupExcludeAttribute)) as GroupExcludeAttribute;
				if (groupExcludeAttribute != null)
				{
					hasAtr = true;
					mask.groupFilterExclude = groupExcludeAttribute.filter;
				}


				if (hasAtr)
				{
					Group g = ProcessingEntities.Default.AddGetgroup(mask);
					myFieldInfo.SetValue(b, g);
				}

				hasAtr = false;
			}
		}
	}
}