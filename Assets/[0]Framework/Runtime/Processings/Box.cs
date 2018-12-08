/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       17/09/2017 11:58
================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Homebrew
{
    public class Box: IKernel, IDisposable
    {
        public static Box Default;


          Dictionary<int, Object> items = new Dictionary<int, Object>(20, new FastComparable());
          Dictionary<int, string> itemsPaths = new Dictionary<int, string>(20, new FastComparable());


        public static int StringToHash(string val)
        {
            var hash = val.GetHashCode();
            Default.itemsPaths.Add(hash, val);
            return hash;
        }

        public static T Get<T>(string id) where T : Object
        {
            #if HOMEBREW_EDIT
			return Resources.Load<T>(id);
#else
            Object obj;
            var key = id.GetHashCode();
            var hasValue = Default.items.TryGetValue(key, out obj);
            if (hasValue == false)
            {
                obj = Resources.Load<T>(id);
                Default.items.Add(key, obj);
            }

            return obj as T;
            #endif
        }

        public static T GetPrefab<T>(string id) where T : Object
        {
            Object obj;
            var key = id.GetHashCode();
            var hasValue = Default.items.TryGetValue(key, out obj);
            if (hasValue) return obj as T;
            obj = Resources.Load("Prefabs/" + id) as GameObject;
            Default.items.Add(key, obj);
            return obj as T;
        }

        public static T GetPrefab<T>(int id) where T : Object
        {
            Object obj;
            var hasValue = Default.items.TryGetValue(id, out obj);
            if (hasValue) return obj as T;
            obj = Resources.Load(Default.itemsPaths[id]) as GameObject;
            Default.items.Add(id, obj);
            return obj as T;
        }

        public void Dispose()
        {
            items.Clear();
            itemsPaths.Clear();
        }
    }
}