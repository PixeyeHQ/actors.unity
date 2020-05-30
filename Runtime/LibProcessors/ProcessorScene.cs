//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public sealed class ProcessorScene : IKernel
  {
    public static ProcessorScene Default = new ProcessorScene();

    public Action OnSceneLoad = delegate { };
    public Action<float> OnSceneLoading = delegate { };
    public Action OnSceneClose = delegate { };

    readonly Dictionary<string, Transform> sceneObjs = new Dictionary<string, Transform>();

    readonly List<string> scenesToKeep = new List<string>();
    readonly List<string> sceneDependsOn = new List<string>();
    readonly Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();

    internal string next_main_scene;

    public void Dispose()
    {
      sceneObjs.Clear();
    }

    public static Transform Get(string id)
    {
      var haveFound = Default.sceneObjs.TryGetValue(id, out var obj);
      if (!haveFound)
      {
        var o = GameObject.Find(id);
        if (o)
          obj = o.transform;
        if (obj) Default.sceneObjs.Add(id, obj);
      }

      return obj;
    }

    public static Transform Get(ref string id)
    {
      var haveFound = Default.sceneObjs.TryGetValue(id, out var obj);
      if (!haveFound)
      {
        var o = GameObject.Find(id);
        if (o)
          obj = o.transform;
        if (obj) Default.sceneObjs.Add(id, obj);
      }

      return obj;
    }

    public void Setup(List<SceneReference> scenesToKeep, List<SceneReference> sceneDependsOn, StarterCore starter)
    {
      this.scenesToKeep.Clear();
      this.sceneDependsOn.Clear();


      for (var i = 0; i < scenesToKeep.Count; i++)
      {
        this.scenesToKeep.Add(scenesToKeep[i].Path);
      }

      for (var i = 0; i < sceneDependsOn.Count; i++)
      {
        this.sceneDependsOn.Add(sceneDependsOn[i].Path);
      }

      Kernel.Instance.StartCoroutine(coSetup(starter));
    }


    internal IEnumerator coSetup(StarterCore starter)
    {
      for (var i = 0; i < SceneManager.sceneCount; i++)
      {
        var scene = SceneManager.GetSceneAt(i);

        if (!scenes.ContainsKey(scene.name))
          scenes.Add(scene.name, scene);
      }

      for (var i = 0; i < sceneDependsOn.Count; i++)
      {
        var name = sceneDependsOn[i];
        if (scenes.ContainsKey(name))
        {
          yield return new WaitForSeconds(0.1f);
          continue;
        }

        var load = SceneManager.LoadSceneAsync(sceneDependsOn[i], LoadSceneMode.Additive);
        while (!load.isDone)
        {
          yield return 0;
        }

        if (!scenes.ContainsKey(name))
          scenes.Add(name, SceneManager.GetSceneByName(name));
      }

      if (sceneDependsOn.Count == 0)
      {
        yield return 0;
      }

      OnSceneLoad();
      starter.BindScene();
    }

    // IEnumerator _Load(int id)
    // {
    //   string pathToScene = SceneUtility.GetScenePathByBuildIndex(id);
    //   string sceneName = System.IO.Path.GetFileNameWithoutExtension(pathToScene);
    //
    //   var load = _Load(sceneName);
    //
    //   while (load.MoveNext())
    //   {
    //     yield return 0;
    //   }
    // }

    IEnumerator CoLoadImpl(string name)
    {
      // void CalculateProgress(AsyncOperation curJob, int _totalStages, ref float _prevProgress, ref float _curProgress)
      // {
      //   _curProgress += curJob.progress / _totalStages - _prevProgress;
      //   _prevProgress = curJob.progress / _totalStages;
      //
      //   _curProgress = Mathf.Clamp(_curProgress, 0f, 1f);
      //   OnSceneLoading(_curProgress);
      // }


      routines.Local.StopAll();
      ProcessorEntities.Clean();
      Kernel.ChangingScene = true;
      Kernel.ClearSessionData();

      StarterCore.ActiveStarter.ReleaseScene();
      //  StarterCore.CleanScene();

      //Plus two for unload assets and load target scene
      var totalStagesNeed = 0;
      float curProgress = 0f, prevProgress = 0f;

      AsyncOperation job = null;


      // routines.app.run(CoAddScene(name));

      //job_load = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);


      var scene_buffer = SceneManager.CreateScene("Actors Buffer Scene");


      SceneManager.SetActiveScene(scene_buffer);
      job = SceneManager.UnloadSceneAsync(StarterCore.ActiveScene);


      while (!job.isDone)
      {
        //CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
        yield return 0;
      }
      job = Resources.UnloadUnusedAssets();

      while (!job.isDone)
      {
        //CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
        yield return 0;
      }

      next_main_scene = name;
      job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);

      job.allowSceneActivation = true;

      while (!job.isDone)
      {
        yield return 0;
      }
      //   SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
      SceneManager.UnloadSceneAsync(scene_buffer);
      Kernel.ChangingScene = false;
      //var scenesToUnload = new List<string>();

      // //Add main scene
      // scenesToUnload.Add(SceneManager.GetActiveScene().name);
      // //Add additive scenes
      // scenesToUnload.AddRange(sceneDependsOn);
      // //Exclude scenes to keep
      // scenesToUnload.RemoveAll((scene) => scenesToKeep.Contains(scene));
      //
      // totalStagesNeed = scenesToUnload.Count + 2;

      // //Do all work
      // for (var i = 0; i < totalStagesNeed; i++)
      // {
      //   //Unload scenes
      //   if (i < scenesToUnload.Count)
      //   {
      //     var key = scenesToUnload[i];
      //     job = SceneManager.UnloadSceneAsync(scenes[key]);
      //
      //   }
      //   //Cleaning
      //   else if (i < totalStagesNeed - 1)
      //   {
      //     job = Resources.UnloadUnusedAssets();
      //   }
      //   //Load target scene
      //   else if (i < totalStagesNeed)
      //   {
      //     scenes.Clear();
      //     job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
      //   }
      //
      //   //Calculate progress
      //   while (!job.isDone)
      //   {
      //     CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
      //     yield return 0;
      //   }
      //
      //   CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
      //   prevProgress = 0f;
      // }

      //SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
      //job.allowSceneActivation = true;
      //Toolbox.changingScene = false;
    }

    AsyncOperation job_load;

    IEnumerator CoAddScene(string name)
    {
      job_load = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
      job_load.allowSceneActivation = false;
      while (!job_load.isDone)
      {
        // CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
        yield return 0;
      }
    }

    // IEnumerator _Load(string name)
    // {
    //   void CalculateProgress(AsyncOperation curJob, int _totalStages, ref float _prevProgress, ref float _curProgress)
    //   {
    //     _curProgress += curJob.progress / _totalStages - _prevProgress;
    //     _prevProgress = curJob.progress / _totalStages;
    //
    //     _curProgress = Mathf.Clamp(_curProgress, 0f, 1f);
    //     OnSceneLoading(_curProgress);
    //   }
    //
    //   for (var i = 0; i < ProcessorCoroutines.coroutine_handlers.Count; i++)
    //   {
    //     ProcessorCoroutines.coroutine_handlers[i].StopAll();
    //   }
    //
    //   if (ProcessorCoroutines.coroutine_handlers.Count > 1)
    //   {
    //     ProcessorCoroutines.coroutine_handlers.RemoveRange(1, ProcessorCoroutines.coroutine_handlers.Count - 1);
    //   }
    //
    //   OnSceneClose();
    //   ProcessorEntities.Clean();
    //   Toolbox.changingScene = true;
    //   Toolbox.Instance.ClearSessionData();
    //
    //   //Plus two for unload assets and load target scene
    //   var totalStagesNeed = 0;
    //   float curProgress = 0f, prevProgress = 0f;
    //
    //   AsyncOperation job = null;
    //   var scenesToUnload = new List<string>();
    //
    //   //Add main scene
    //   scenesToUnload.Add(SceneManager.GetActiveScene().name);
    //   //Add additive scenes
    //   scenesToUnload.AddRange(sceneDependsOn);
    //   //Exclude scenes to keep
    //   scenesToUnload.RemoveAll((scene) => scenesToKeep.Contains(scene));
    //
    //   totalStagesNeed = scenesToUnload.Count + 2;
    //
    //   //Do all work
    //   for (var i = 0; i < totalStagesNeed; i++)
    //   {
    //     //Unload scenes
    //     if (i < scenesToUnload.Count)
    //     {
    //       var key = scenesToUnload[i];
    //       job = SceneManager.UnloadSceneAsync(scenes[key]);
    //
    //       //SceneManager.LoadScene("Scene Level 2", LoadSceneMode.Single);
    //     }
    //     //Cleaning
    //     else if (i < totalStagesNeed - 1)
    //     {
    //       job = Resources.UnloadUnusedAssets();
    //     }
    //     //Load target scene
    //     else if (i < totalStagesNeed)
    //     {
    //       scenes.Clear();
    //       job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
    //     }
    //
    //     //Calculate progress
    //     while (!job.isDone)
    //     {
    //       CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
    //       yield return 0;
    //     }
    //
    //     CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
    //     prevProgress = 0f;
    //   }
    //
    //   SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
    //   job.allowSceneActivation = true;
    //   Toolbox.changingScene = false;
    // }

    public static void Add(int id)
    {
      routines.app.run(_Add(id));
    }

    public static void Add(string id)
    {
      routines.app.run(_Add(id));
    }

    public static void Remove(int index_build) => routines.app.run(CoRemoveSubScene(SceneManager.GetSceneByBuildIndex(index_build)));

    public static void Remove(string scene_name) => routines.app.run(CoRemoveSubScene(SceneManager.GetSceneByName(scene_name)));

    static IEnumerator _Add(int id)
    {
      Kernel.ChangingScene = true;
      SceneManager.sceneLoaded += OnAdditiveLoaded;
      var job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
      while (!job.isDone)
      {
        yield return 0;
      }


      Kernel.ChangingScene = false;
    }

    static IEnumerator _Add(string id)
    {
      Kernel.ChangingScene = true;
      SceneManager.sceneLoaded += OnAdditiveLoaded;
      var job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
      while (!job.isDone)
      {
        yield return 0;
      }


      Kernel.ChangingScene = false;
    }

    static void OnAdditiveLoaded(Scene arg0, LoadSceneMode arg1)
    {
      if (arg1 != LoadSceneMode.Additive) return;


      var objs = arg0.GetRootGameObjects();


      foreach (var obj in objs)
      {
        var transforms = obj.GetComponentsInChildren<Transform>();

        foreach (var tr in transforms)
        {
          var oo = tr.GetComponents<MonoBehaviour>();
          if (!tr.gameObject.activeInHierarchy) continue;
          foreach (var o in oo)
          {
            if (o is IRequireStarter req && o.enabled)
              req.Launch();
          }
        }
      }


      SceneManager.sceneLoaded -= OnAdditiveLoaded;
    }

    static IEnumerator CoRemoveSubScene(Scene scene)
    {
      Kernel.ChangingScene = true;
      var starter = StarterCore.Starters[scene.buildIndex];
      starter.ReleaseScene();
      KillActors(scene);
      StarterCore. Starters.Remove(scene.buildIndex);
      var job = SceneManager.UnloadSceneAsync(scene.buildIndex);
      while (!job.isDone)
      {
        yield return 0;
      }

      Kernel.ChangingScene = false;
    }


    static void KillActors(Scene s)
    {
      var root = s.GetRootGameObjects();

      foreach (var go in root)
      {
        var actors = go.GetComponentsInChildren<Actor>();

        for (int i = 0; i < actors.Length; i++)
        {
          actors[i].entity.Release();
        }
      }
    }

    public static void To(int id)
    {
      var processing = Default;
      string pathToScene = SceneUtility.GetScenePathByBuildIndex(id);
      string sceneName = System.IO.Path.GetFileNameWithoutExtension(pathToScene);
      routines.app.run(processing.CoLoad(sceneName));
    }

    public static void To(string sceneName)
    {
      var processing = Default;
      routines.app.run(processing.CoLoad(sceneName));
    }


    IEnumerator CoLoad(string sceneName)
    {
      var load = CoLoadImpl(sceneName);
      while (load.MoveNext())
      {
        yield return 0;
      }
    }
  }
}