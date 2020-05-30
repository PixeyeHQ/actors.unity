using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public class Kernel : MonoBehaviour
  {
    static Kernel instanceLocal;

    public static Kernel Instance
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

        if (instanceLocal != null) return instanceLocal;
        instanceLocal = (Kernel) FindObjectOfType(typeof(Kernel));
        if (FindObjectsOfType(typeof(Kernel)).Length > 1)
        {
          Debug.LogError("[Kernel] Something went really wrong " +
                         " - there should never be more than 1 singleton!" +
                         " Reopening the scene might fix it.");
          return instanceLocal;
        }

        if (instanceLocal != null) return instanceLocal;
        var singleton = new GameObject();
        instanceLocal = singleton.AddComponent<Kernel>();
        singleton.name = "Actors Kernel";
        DontDestroyOnLoad(singleton);
        return instanceLocal;
      }
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void SetKernel() => Instance.gameObject.SetActive(true);


    public static bool changingScene;
    public static bool applicationIsQuitting;
    public static bool isQuittingOrChangingScene() => applicationIsQuitting || changingScene;


    internal static Dictionary<int, object> objectStorage = new Dictionary<int, object>(5, new FastComparable());

    internal static T Add<T>(Dictionary<int, object> objectStorage, Type type = null) where T : new()
    {
      var hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
      if (objectStorage.TryGetValue(hash, out var o))
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
      objectStorage.Add(hash, created);
      return created;
    }

    internal static void AwakeObject(object obj)
    {
      if (obj is IAwake awakeObj) awakeObj.OnAwake();
      if (obj is IKernel kernelObj)
      {
        ProcessorUpdate.AddKernel(obj);
      }
      else
        ProcessorUpdate.Add(obj);
    }

    internal static void Remove(Dictionary<int, object> objectStorage, object obj)
    {
      objectStorage.Remove(obj.GetType().GetHashCode());
    }

    public static T Add<T>(Type type = null) where T : new() => Add<T>(objectStorage, type);

    public static void Remove(object obj) => Remove(objectStorage, obj);

    internal static void ClearSessionData()
    {
      if (applicationIsQuitting) return;
      var toWipe = new List<int>();
      foreach (var pair in objectStorage)
      {
        if (!(pair.Value is IKernel))
          toWipe.Add(pair.Key);
        if (!(pair.Value is IDisposable needToBeCleaned)) continue;
        needToBeCleaned.Dispose();
      }

      Instance.StopAllCoroutines();
      ProcessorTimer.Default.Dispose();

      Box.Default.Dispose();
      Pool.Dispose();
      Storage.DisposeSelf();
      Cleanup();
      ProcessorScene.Default.Dispose();
      ProcessorUpdate.Default.Dispose();

      foreach (var t in toWipe)
      {
        objectStorage.Remove(t);
      }
    }

    public static class Processors
    {
      internal static Processor[] storage = new Processor[64];
      internal static int length;
    }

    public static void Cleanup()
    {
      groups.All.Dispose();

      for (int i = 0; i < groups.globals.Length; i++)
      {
        groups.globals[i] = null;
      }
    }

    public static class Debugger
    {
      public static void Log(int logID, params object[] contenxt)
      {
        switch (logID)
        {
          case LogType.NOT_ACTIVE:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> is not active. You should not add components to an inactive entity. <b> {contenxt[1]}</b> ");
            break;
          case LogType.ALREADY_HAVE:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> already have this component: <b>{contenxt[1]}</b> ");
            break;
          case LogType.REMOVE_NON_EXISTANT:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> is deleted. You can't remove a component from a deleted entity. <b>{contenxt[1]}</b> ");
            break;
          case LogType.NULL_ENTITY:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> is null. Use <color=#ff0000ff>Entity.Create</color> to register a new entity first. <b>{contenxt[1]}</b> ");
            break;
          case LogType.TAGS_LIMIT_REACHED:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> has reached tag capacity. Go to Tools->Actors->Tags->Size to increase cap. Current cap: <b>{contenxt[1]}</b> ");
            break;
          case LogType.DESTROYED:
            Debug.LogError($"You are trying to release already destroyed entity with ID <b>{contenxt[0]}</b>, <b>{contenxt[1]}</b>");
            break;
        }
      }
    }

    public static SettingsEngine Settings = new SettingsEngine();

    public static int GetTicksCount() => ProcessorUpdate.Default.GetTicksCount();
  }

  public class groups
  {
    public GroupCore this[int index] => globals[index];

    public static bool has(int index)
    {
      return globals.Length > index && globals[index] != null;
    }

    public static GroupCore[] globals = new GroupCore[32];
    internal static CacheGroup All = new CacheGroup();
    internal static FamilyGroupTags ByTag = new FamilyGroupTags();
    internal static FamilyGroupTags ByType = new FamilyGroupTags();
  }

  struct LogType
  {
    public const int NOT_ACTIVE = 0;
    public const int ALREADY_HAVE = 1;
    public const int REMOVE_NON_EXISTANT = 2;
    public const int NULL_ENTITY = 3;
    public const int TAGS_LIMIT_REACHED = 4;
    public const int DESTROYED = 5;
  }
}