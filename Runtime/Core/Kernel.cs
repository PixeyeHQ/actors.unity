using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeye.Actors
{
  public class Kernel : MonoBehaviour
  {
    internal static Kernel Instance;

#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
#else
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
#endif
    static void SetKernel()
    {
      var scene = SceneManager.CreateScene("Actors Framework", new CreateSceneParameters(LocalPhysicsMode.None));
      var lastActiveScene = SceneManager.GetActiveScene();
      SceneManager.SetActiveScene(scene);
      var objKernel = new GameObject("Actors Kernel");
      var kernel = objKernel.AddComponent<Kernel>();
      var layer = objKernel.AddComponent<LayerApp>();
      Instance = kernel;
    }


    public static bool ChangingScene;
    public static bool ApplicationIsQuitting;
    public static bool IsQuittingOrChangingScene() => ApplicationIsQuitting || ChangingScene;

    /// Always bigger than actual scene index by 1. This is because 0 index is reserved by framework. 
    //public static int ActiveSceneIndex => ActiveStarter.sceneIndex;
      internal static Dictionary<int, object> objectStorage = new Dictionary<int, object>(5, new FastComparable());

    internal static T Add<T>(Dictionary<int, object> objectStorage, int index, Type type = null) where T : new()
    {
      var hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
      if (objectStorage.TryGetValue(hash, out var o))
      {
        ProcessorUpdateOld.Add(o);
        //AwakeObject(o);
        return (T) o;
      }
      var created = new T();
      var proc = typeof(T).IsSubclassOf(typeof(Processor));
      if (!proc)
      {
        ProcessorUpdateOld.Add(created);
        //AwakeObject(created);
      }
      objectStorage.Add(hash, created);
      return created;
    }

    internal static T Add<T>(Dictionary<int, object> objectStorage, Type type = null) where T : new()
    {
      var hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
      if (objectStorage.TryGetValue(hash, out var o))
      {
        ProcessorUpdateOld.Add(o);
        //AwakeObject(o);
        return (T) o;
      }
      var created = new T();
      var proc = typeof(T).IsSubclassOf(typeof(Processor));
      if (!proc)
      {
        ProcessorUpdateOld.Add(created);
        //AwakeObject(created);
      }
      objectStorage.Add(hash, created);
      return created;
    }

    internal static T Get<T>(Dictionary<int, object> objectStorage)
    {
      var hasValue = objectStorage.TryGetValue(typeof(T).GetHashCode(), out var resolve);
      return hasValue ? (T) resolve : default;
    }

    internal static object Get(Dictionary<int, object> objectStorage, Type t)
    {
      objectStorage.TryGetValue(t.GetHashCode(), out var resolve);
      return resolve;
    }

    internal static void Remove(Dictionary<int, object> objectStorage, object obj)
    {
      objectStorage.Remove(obj.GetType().GetHashCode());
    }

    public static T Add<T>(Type type = null) where T : new() => Add<T>(objectStorage, type);

    ///Gets object
    public static object Get(Type t)
    {
      objectStorage.TryGetValue(t.GetHashCode(), out var resolve);
      return resolve;
    }

    ///Gets object
    public static T Get<T>()
    {
      var hasValue = objectStorage.TryGetValue(typeof(T).GetHashCode(), out var resolve);
      return hasValue ? (T) resolve : default(T);
    }

    public static void Remove(object obj) => Remove(objectStorage, obj);

    internal static void ClearSessionData()
    {
      Instance.StopAllCoroutines();
      // if (ApplicationIsQuitting) return;
      // var toWipe = new List<int>();
      // foreach (var pair in objectStorage)
      // {
      //   if (!(pair.Value is IKernel))
      //     toWipe.Add(pair.Key);
      //   if (!(pair.Value is IDisposable needToBeCleaned)) continue;
      //   needToBeCleaned.Dispose();
      // }
      //
      // Instance.StopAllCoroutines();
      ProcessorTimer.Dispose();

      Box.Default.Dispose();
      Pool.Dispose();
      Storage.DisposeSelf();
      Cleanup();
      // ProcessorScene.Default.Dispose();
      //ProcessorUpdate.Default.Dispose();
      //
      // foreach (var t in toWipe)
      // {
      //   objectStorage.Remove(t);
      // }
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

    public static int GetTicksCount() => ProcessorUpdateOld.Default.GetTicksCount();

    internal float timescale_cache = 1;

    IEnumerator OnApplicationFocus(bool hasFocus)
    {
      yield return new WaitForSeconds(0.01f);
      if (Settings.PauseOnFocusLost == false) yield break;
      if (!hasFocus)
      {
        timescale_cache = time.Default.timeScale;
        time.Default.timeScale = 0;
      }
      else
      {
        time.Default.timeScale = timescale_cache;
      }
    }

    void OnApplicationQuit()
    {
#if UNITY_EDITOR
      Entity.Dispose();
#endif
    }
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