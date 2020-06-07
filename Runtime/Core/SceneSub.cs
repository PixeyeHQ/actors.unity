using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  public static class SceneSub
  {
    enum State
    {
      AlreadyAdded,
      InvalidIndex,
      NotAdded
    }

    static State CheckSceneState(int buildIndex)
    {
      if (buildIndex == -1) return State.InvalidIndex;

      for (int i = 0; i < SceneManager.sceneCount; i++)
      {
        var scn = SceneManager.GetSceneAt(i);
        if (scn.buildIndex == buildIndex) return State.AlreadyAdded;
      }

      return State.NotAdded;
    }

    public static AsyncOperation Add(int buildIndex)
    {
      var state = CheckSceneState(buildIndex);
      if (state == State.AlreadyAdded) return null;

      LayerKernel.ChangingScene[buildIndex] = true;
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
      return LayerKernel.LoadJobs[LayerKernel.LoadJobs.Count - 1];
    }

    public static void Add(string sceneName)
    {
      var buildIndex = LayerKernel.SceneIndexFromName(sceneName);
      DebugScene(buildIndex);
      Add(buildIndex);
    }

    public static void Remove(int buildIndex)
    {
      var state = CheckSceneState(buildIndex);
      if (state == State.InvalidIndex || state == State.NotAdded) return;
      LayerKernel.Run(CoRemove(buildIndex));
    }

    public static void Remove(string sceneName)
    {
      var buildIndex = SceneManager.GetSceneByName(sceneName).buildIndex;
      var state      = CheckSceneState(buildIndex);
      if (state == State.InvalidIndex || state == State.NotAdded) return;

      LayerKernel.Run(CoRemove(buildIndex));
    }

    static IEnumerator CoRemove(int buildIndex)
    {
      if (LayerKernel.Layers[buildIndex] != null) // check if this scene is a part of Actors Layers.
        LayerKernel.Layers[buildIndex].Release();
      yield return LayerKernel.WaitFrame;
      LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
      LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
    }

    [Conditional("ACTORS_DEBUG")]
    static void DebugScene(int buildIndex)
    {
      if (buildIndex == -1)
      {
        Debug.Log($"There is no scene with Build Index {buildIndex}.");
        throw new Exception();
      }
    }
  }
}