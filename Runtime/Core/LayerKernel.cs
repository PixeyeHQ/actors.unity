using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: Preserve]

namespace Pixeye.Actors
{
  public class LayerKernel : Layer<LayerKernel>, ITick
  {
    internal const int LAYERS_AMOUNT_TOTAL = 128;

     
    public static bool[] Initialized = new bool[LAYERS_AMOUNT_TOTAL];
    public static bool ApplicationIsQuitting;
    public static bool IsQuittingOrChangingScene() => ApplicationIsQuitting;

    public static List<AsyncOperation> LoadJobs = new List<AsyncOperation>();
    public static Action<float> OnSceneLoading = delegate { };

    public static int GetTicksCount
    {
      get
      {
        var amount = 0;
        foreach (var layer in LayersInUse)
        {
          amount += layer.Engine.GetTicksCount;
        }

        return amount;
      }
    }

    public static SettingsActors Settings = new SettingsActors();

    internal static Layer LayerCurrentInit; // only for setup stuff to provide layer to the processors constructors.
 
    internal const string KernelSceneName = "Actors Framework";
    internal static Layer[] Layers = new Layer[128];
    internal static readonly List<Layer> LayersInUse = new List<Layer>();

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Bootstrap()
    {
      HandleSettings();
      UpdateTypes();
      Random.Bootstrap();
      Comparers.Bootstrap();
      ProcessorEcs.Bootstrap();
      HandleScenes();

      void HandleSettings()
      {
        var t = Resources.Load<TextAsset>("SettingsFramework");
        if (t != null)
          JsonUtility.FromJsonOverwrite(t.text, Settings);

        Settings.SizeGenerations = Settings.SizeComponents / 32;

        Application.targetFrameRate = Settings.Fps;
        QualitySettings.vSyncCount  = Settings.Vsync;

        if (Settings.Fps == -1)
        {
          Time.Fps      = 60;
          Time.FpsLimit = false;
        }
        else
        {
          Time.Fps      = Settings.Fps;
          Time.FpsLimit = true;
        }

        Time.FpsPhysics = Settings.FpsPhysics;
      }

      void HandleScenes()
      {
        var scene     = SceneManager.CreateScene(KernelSceneName, new CreateSceneParameters(LocalPhysicsMode.None));
        var objKernel = new GameObject("Actors Setup");
        SceneManager.MoveGameObjectToScene(objKernel, scene);
        SceneMain.NextActiveSceneName = SceneManager.GetActiveScene().name;
        var kernel = objKernel.AddComponent<LayerKernel>();

        InstanceInternal = kernel;

        foreach (var plugPath in Settings.Plugins)
        {
          var pl = Resources.Load<Pluggable>(plugPath);
          pl.Plug();
        }
      }
    }


    static void UpdateTypes()
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


    public static class Debugger
    {
      public static void Log(int logID, params object[] contenxt)
      {
        switch (logID)
        {
          case LogType.NO_COMPONENT:
            Debug.LogError(
              $"Entity <b>{contenxt[0]}</b> doesn't have a component <b> {contenxt[1]}</b>");
            break;
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

    IEnumerator OnApplicationFocus(bool hasFocus)
    {
      yield return new WaitForSeconds(0.01f);
      if (Settings.PauseOnFocusLost == false) yield break;
      if (!hasFocus)
      {
        foreach (var core in LayersInUse)
        {
          core.Time.timescaleCacheOnFocus = core.Time.scale;
          core.Time.scale                 = 0;
        }
      }
      else
      {
        foreach (var core in LayersInUse)
        {
          core.Time.scale = core.Time.timescaleCacheOnFocus;
        }
      }
    }

    protected override void Setup()
    {
    }


    void OnApplicationQuit()
    {
      ApplicationIsQuitting = true;
#if UNITY_EDITOR
      Dispose();
#endif
    }

    internal static unsafe void Dispose()
    {
      for (int i = 0; i < ProcessorEcs.Entities.Length; i++)
      {
        var meta = ProcessorEcs.Entities.Get<EntityMeta>(i);
        Marshal.FreeHGlobal((IntPtr) meta->components);
        Marshal.FreeHGlobal((IntPtr) meta->groups);
      }

      UnmanagedMemory.Cleanup();
    }

        public void Tick(float dt)
    {
      HandleLoadingProgress();
    }

    static void HandleLoadingProgress()
    {
      if (LoadJobs.Count <= 0) return;

      var progress = 0f;
      for (var i = 0; i < LoadJobs.Count; i++)
      {
        progress += LoadJobs[i].progress;
      }

      var ratio = progress / LoadJobs.Count;
      OnSceneLoading(ratio);
      if (ratio == 1)
      {
        LoadJobs.Clear();
      }
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
    public const int NO_COMPONENT = 6;
  }
}