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

namespace Homebrew
{
    //TODO: deprecated
//    public class ProcessingBehaviorAttributes
//    {
//        public static ProcessingBehaviorAttributes Default;
//
//        public static readonly Dictionary<Type, CachedType> cached = new Dictionary<Type, CachedType>();
//
//        public static void Setup(IComponent b, Actor a)
//        {
//            var type = b.GetType();
//            CachedType o;
//            var isCached = cached.TryGetValue(type, out o);
//
//            if (!isCached)
//            {
//                o = new CachedType();
//
//                var objectFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
//                var length = objectFields.Length;
//                cached.Add(type, o);
//                for (var i = 0; i < length; i++)
//                {
//                    var myFieldInfo = objectFields[i];
//                    var attribute =
//                        Attribute.GetCustomAttribute(objectFields[i], typeof(BindAttribute)) as BindAttribute;
//
//                    if (attribute == null) continue;
//                    var fieldType = myFieldInfo.FieldType;
//
//
//                    switch (attribute.bindType)
//                    {
//                        case 0:
//
//
//                            //var isStorage =	typeof(IStorage).IsAssignableFrom(fieldType);
//                            //isStorage ? ComponentType.STORAGE : ComponentType.LOCAL)
//                            myFieldInfo.SetValue(b, a.Get(fieldType));
//                            o.cachedBindFields.Add(myFieldInfo);
//                            break;
//
//                        case 1:
//                            myFieldInfo.SetValue(b, Toolbox.Get(fieldType));
//                            o.cachedToolboxFields.Add(myFieldInfo);
//                            break;
//
//                        case 2:
//
//                            myFieldInfo.SetValue(b, a.selfTransform.GetComponentInChildren(fieldType));
//                            o.cachedFromObjFields.Add(myFieldInfo);
//                            break;
//
//                        case 3:
//                            var blueprint = a.Get<DataBlueprint>().blueprint;
//                            myFieldInfo.SetValue(b, blueprint.Get(fieldType));
//                            o.cachedFromBlueprintFields.Add(myFieldInfo);
//                            break;
//                    }
//                }
//            }
//            else
//            {
//                o.Bind(b, a);
//
//                o.GetFromToolbox(b);
//                o.GetFromObject(b, a);
//                o.GetFromBlueprint(b, a);
//            }
//        }
//
//        public class CachedType
//        {
//            public readonly List<FieldInfo> cachedBindFields = new List<FieldInfo>();
//
//            public readonly List<FieldInfo> cachedToolboxFields = new List<FieldInfo>();
//            public readonly List<FieldInfo> cachedFromObjFields = new List<FieldInfo>();
//            public readonly List<FieldInfo> cachedFromBlueprintFields = new List<FieldInfo>();
//
//            public void Bind(IComponent behavior, Actor a)
//            {
//                for (var i = 0; i < cachedBindFields.Count; i++)
//                {
//                    var myFieldInfo = cachedBindFields[i];
//                    var fieldType = myFieldInfo.FieldType;
//
//                    //	var isStorage =	typeof(IStorage).IsAssignableFrom(fieldType);
//
//                    //myFieldInfo.SetValue(b, a.Get(fieldType, isStorage ? ComponentType.STORAGE : ComponentType.LOCAL));
//                    //, isStorage ? ComponentType.STORAGE : ComponentType.LOCAL)
//                    myFieldInfo.SetValue(behavior, a.Get(fieldType));
//                }
//            }
//
//
//            public void GetFromToolbox(IComponent behavior)
//            {
//                for (var i = 0; i < cachedToolboxFields.Count; i++)
//                {
//                    var myFieldInfo = cachedToolboxFields[i];
//                    var fieldType = myFieldInfo.FieldType;
//                    myFieldInfo.SetValue(behavior, Toolbox.Get(fieldType));
//                }
//            }
//
//            public void GetFromObject(IComponent behavior, Actor a)
//            {
//                for (var i = 0; i < cachedFromObjFields.Count; i++)
//                {
//                    var myFieldInfo = cachedFromObjFields[i];
//                    var fieldType = myFieldInfo.FieldType;
//
//
//                    myFieldInfo.SetValue(behavior, a.selfTransform.GetComponentInChildren(fieldType));
//                }
//            }
//
//            public void GetFromBlueprint(IComponent behavior, Actor a)
//            {
//                for (var i = 0; i < cachedFromBlueprintFields.Count; i++)
//                {
//                    var myFieldInfo = cachedFromBlueprintFields[i];
//                    var fieldType = myFieldInfo.FieldType;
//                    var blueprint = a.Get<DataBlueprint>().blueprint;
//
//                    myFieldInfo.SetValue(behavior, blueprint.Get(fieldType));
//                }
//            }
//        }
//    }

//    public class ProcessingBehaviorAttributes
//    {
//        public static readonly Dictionary<int, CachedType> cached = new Dictionary<int, CachedType>(10,new FastDict());
//        public static void Setup(Behavior b)
//        {
//            var type = b.GetType();
//            var hash = type.GetHashCode();
//        }
//        public class CachedType
//        {
//            public readonly List<FieldInfo> cachedToolboxFields = new List<FieldInfo>();
//
// 
//        }
//    }
    
    public class ProcessingSystemAttributes
    {
        public static readonly Dictionary<Type, CachedType> cached = new Dictionary<Type, CachedType>();

        public static void Setup(object b)
        {
            var type = b.GetType();
            CachedType o;
            bool isCached = cached.TryGetValue(type, out o);

            if (!isCached)
            {
                o = new CachedType();

                var objectFields = type.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public |
                                                  BindingFlags.NonPublic);
                int length = objectFields.Length;
                cached.Add(type, o);
                for (int i = 0; i < length; i++)
                {
                    var myFieldInfo = objectFields[i];
                    var attribute =
                        Attribute.GetCustomAttribute(objectFields[i], typeof(BindAttribute)) as BindAttribute;

                    if (attribute == null) continue;
                    var fieldType = myFieldInfo.FieldType;


                    switch (attribute.bindType)
                    {
                        case 0:


                            break;

                        case 1:
                            myFieldInfo.SetValue(b, Toolbox.Get(fieldType));
                            o.cachedToolboxFields.Add(myFieldInfo);
                            break;

                        case 2:


                            break;

                        case 3:

                            break;
                    }
                }
            }
            else
            {
                o.GetFromToolbox(b);
            }
        }

        public class CachedType
        {
            public readonly List<FieldInfo> cachedToolboxFields = new List<FieldInfo>();


            public void GetFromToolbox(object behavior)
            {
                for (int i = 0; i < cachedToolboxFields.Count; i++)
                {
                    var myFieldInfo = cachedToolboxFields[i];
                    var fieldType = myFieldInfo.FieldType;
                    myFieldInfo.SetValue(behavior, Toolbox.Get(fieldType));
                }
            }
        }
    }
}