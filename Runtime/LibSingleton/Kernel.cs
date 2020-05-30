using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public class Kernel : MonoBehaviour
  {
    static Kernel instance_local;

    static Kernel instance
    {
      get
      {
        if (applicationIsQuitting)
        {
          Debug.LogWarning("[Kernel] Instance '" + typeof(Kernel) +
                           "' already destroyed on application quit." +
                           " Won't create again - returning null.");
          return null;
        }

        if (instance_local != null) return instance_local;
        instance_local = (Kernel) FindObjectOfType(typeof(Kernel));

        if (FindObjectsOfType(typeof(Kernel)).Length > 1)
        {
          Debug.LogError("[Kernel] Something went really wrong " +
                         " - there should never be more than 1 singleton!" +
                         " Reopening the scene might fix it.");
          return instance_local;
        }

        if (instance_local != null) return instance_local;
        var singleton = new GameObject();
        instance_local = singleton.AddComponent<Kernel>();
        singleton.name = nameof(Kernel);

        DontDestroyOnLoad(singleton);

        return instance_local;
      }
    }

    public static bool changingScene;
    public static bool applicationIsQuitting;
    public static bool isQuittingOrChangingScene() => applicationIsQuitting || changingScene;

    public static void AwakeObject(object obj)
    {
      if (obj is IAwake awakeble) awakeble.OnAwake();
      ProcessorUpdate.Add(obj);
    }

    internal static T Add<T>(Dictionary<int, object> storage, Type type = null) where T : new()
    {
      var hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
      if (storage.TryGetValue(hash, out var o))
      {
        AwakeObject(o);
        return (T) o;
      }
      var created = new T();
      var proc = typeof(T).IsSubclassOf(typeof(Processor));
      if (!proc)
      {
        AwakeObject(created);
      }
      storage.Add(hash, created);
      return created;
    }
  }
}