using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeye.Actors
{
  public class Kernel : MonoBehaviour
  {
    public static bool ChangingScene;
    public static bool ApplicationIsQuitting;
    public static bool IsQuittingOrChangingScene() => ApplicationIsQuitting || ChangingScene;
    public static SettingsActors Settings = new SettingsActors();
    public static int GetTicksCount => 0;

    internal static Kernel Instance;
    internal const string KernelSceneName = "Actors Framework";
    internal static LayerCore[] Layers = new LayerCore[48];
    internal static readonly List<LayerCore> LayersInUse = new List<LayerCore>();

#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
#else
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
#endif
    static void Bootstrap()
    {
      HandleSettings();
      Random.Bootstrap();
      ProcessorEcs.Bootstrap();
      HandleScenes();

      void HandleSettings()
      {
        var t = Resources.Load<TextAsset>("SettingsFramework");
        if (t != null)
          JsonUtility.FromJsonOverwrite(t.text, Settings);

        Settings.SizeGenerations = Settings.SizeComponents / 32;
      }

      void HandleScenes()
      {
        var scene     = SceneManager.CreateScene(KernelSceneName, new CreateSceneParameters(LocalPhysicsMode.None));
        var objKernel = new GameObject("Actors Setup");
        SceneManager.MoveGameObjectToScene(objKernel, scene);
        ActiveScene.NextActiveSceneName = SceneManager.GetActiveScene().name;
        var kernel = objKernel.AddComponent<Kernel>();
        var layer  = objKernel.AddComponent<LayerApp>();
        Instance = kernel;
      }
    }

    void Awake()
    {
      UpdateTypes();
    }

    void UpdateTypes()
    {
      var types    = AppDomain.CurrentDomain.GetAssemblies().SelectMany(t => t.GetTypes());
      var storages = types.Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);
      foreach (var item in storages)
      {
        Activator.CreateInstance(item);
      }

      // this is for people who prefere to make components without any helpers.
      foreach (var type in types.Where(t => t.IsDefined(typeof(ActorsComponent), false)))
      {
        var genericStorage     = typeof(Storage<>);
        var constructedStorage = genericStorage.MakeGenericType(type);
        Activator.CreateInstance(constructedStorage);
      }
    }


    // public static void Cleanup()
    // {
    //   groups.All.Dispose();
    //
    //   for (int i = 0; i < groups.globals.Length; i++)
    //   {
    //     groups.globals[i] = null;
    //   }
    // }

    public static class Debugger
    {
      public static void Log(int logID, params object[] contenxt)
      {
        switch (logID)
        {
          case LogType.NOT_ACTIVE:
            Debug.LogError(
              $"Entity <b>{contenxt[0]}</b> is not active. You should not add components to an inactive entity. <b> {contenxt[1]}</b> ");
            break;
          case LogType.ALREADY_HAVE:
            Debug.LogError($"Entity <b>{contenxt[0]}</b> already have this component: <b>{contenxt[1]}</b> ");
            break;
          case LogType.REMOVE_NON_EXISTANT:
            Debug.LogError(
              $"Entity <b>{contenxt[0]}</b> is deleted. You can't remove a component from a deleted entity. <b>{contenxt[1]}</b> ");
            break;
          case LogType.NULL_ENTITY:
            Debug.LogError(
              $"Entity <b>{contenxt[0]}</b> is null. Use <color=#ff0000ff>Entity.Create</color> to register a new entity first. <b>{contenxt[1]}</b> ");
            break;
          case LogType.TAGS_LIMIT_REACHED:
            Debug.LogError(
              $"Entity <b>{contenxt[0]}</b> has reached tag capacity. Go to Tools->Actors->Tags->Size to increase cap. Current cap: <b>{contenxt[1]}</b> ");
            break;
          case LogType.DESTROYED:
            Debug.LogError(
              $"You are trying to release already destroyed entity with ID <b>{contenxt[0]}</b>, <b>{contenxt[1]}</b>");
            break;
        }
      }
    }

    internal float timescale_cache = 1;

    IEnumerator OnApplicationFocus(bool hasFocus)
    {
      yield return new WaitForSeconds(0.01f);
      if (Settings.PauseOnFocusLost == false) yield break;
      if (!hasFocus)
      {
        timescale_cache        = time.Default.timeScale;
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
      EntityImplOld.Dispose();
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