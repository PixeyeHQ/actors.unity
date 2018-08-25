/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:42 PM
================================================================*/


using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


namespace Homebrew
{
    public class ProcessingGroupAttributes
    {

     
        public static void Setup(object b)
        {
            var type = b.GetType();
            var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var length = objectFields.Length;

            var groupType = typeof(GroupBase);

      
            for (var i = 0; i < length; i++)
            {
                var myFieldInfo = objectFields[i];

                var groupByAttribute =
                    Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupByAttribute)) as GroupByAttribute;
                var groupExcludeAttribute =
                    Attribute.GetCustomAttribute(myFieldInfo, typeof(GroupExcludeAttribute)) as
                        GroupExcludeAttribute;

 
 
                if (!myFieldInfo.FieldType.IsSubclassOf(groupType) || myFieldInfo.IsStatic) continue;
                
                
                
                var excludeFilter = new int[0];
                if (groupExcludeAttribute!=null)
                excludeFilter = groupExcludeAttribute.filter;

                var includeFilter   = new int[0];
                if (groupByAttribute!=null)
                includeFilter = groupByAttribute.filter;
 
                
                
                var filter = new Composition();
                filter.exclude = excludeFilter;
                filter.include = includeFilter;
              
          
                
                myFieldInfo.SetValue(b,
                    ProcessingEntities.Default.AddGetGroup(myFieldInfo.FieldType,filter));
            }
        }
    }
}