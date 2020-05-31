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
    internal static readonly string KernelSceneName = "Actors Framework";
    internal static List<StarterCore> Layers = new List<StarterCore>();

#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
#else
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
#endif
    static void Bootstrap()
    {
      var scene = SceneManager.CreateScene(KernelSceneName, new CreateSceneParameters(LocalPhysicsMode.None));
      var objKernel = new GameObject("Actors Setup");
      SceneManager.MoveGameObjectToScene(objKernel, scene);
      MainScene.NextActiveSceneName = SceneManager.GetActiveScene().name;
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