/*===============================================================
Product:    Shoot off their lumps
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       18/01/2018 10:57
================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Pixeye.Framework
{
	public class ProcessorSystemAttributes
	{

		public static readonly Dictionary<Type, CachedType> cached = new Dictionary<Type, CachedType>();

		public static void Setup(object b)
		{
//			var        type = b.GetType();
//			CachedType o;
//			bool       isCached = cached.TryGetValue(type, out o);
//
//			if (!isCached)
//			{
//				o = new CachedType();
//
//				var objectFields = type.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public |
//				                                  BindingFlags.NonPublic);
//				int length = objectFields.Length;
//				cached.Add(type, o);
//				for ( int i = 0; i < length; i++ )
//				{
//					var myFieldInfo = objectFields[i];
//					var attribute =
//							Attribute.GetCustomAttribute(objectFields[i], typeof(BindAttribute)) as BindAttribute;
//
//					if (attribute == null) continue;
//					var fieldType = myFieldInfo.FieldType;
//
//					switch (attribute.bindType)
//					{
//						case 0:
//
//							break;
//
//						case 1:
//							myFieldInfo.SetValue(b, Toolbox.Get(fieldType));
//							o.cachedToolboxFields.Add(myFieldInfo);
//							break;
//
//						case 2:
//
//							break;
//
//						case 3:
//
//							break;
//					}
//				}
//			}
//			else
//			{
//				o.GetFromToolbox(b);
//			}
		}

		public class CachedType
		{

			public readonly List<FieldInfo> cachedToolboxFields = new List<FieldInfo>();

			public void GetFromToolbox(object behavior)
			{
				for ( int i = 0; i < cachedToolboxFields.Count; i++ )
				{
					var myFieldInfo = cachedToolboxFields[i];
					var fieldType   = myFieldInfo.FieldType;
					myFieldInfo.SetValue(behavior, Toolbox.Get(fieldType));
				}
			}

		}

	}
}