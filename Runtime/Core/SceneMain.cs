using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class SceneMain
  {
    internal static string NextActiveSceneName;

    public static Action Closed = delegate { };

    public static void ChangeTo(int buildIndex)
    {
      NextActiveSceneName = SceneManager.GetSceneByBuildIndex(buildIndex).name;
      ChangeOp(buildIndex);
    }

    public static void ChangeTo(string sceneName)
    {
      NextActiveSceneName = sceneName;
      ChangeOp(LayerKernel.SceneIndexFromName(sceneName));
    }

    static void ChangeOp(int buildIndex)
    {
      var nextIndex = buildIndex;

      LayerKernel.Initialized[buildIndex] = false;
      Closed();
      Layer.ActiveLayer.Release();
      LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(Layer.ActiveLayer.Scene));
      LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
      Layer.ActiveLayer = null;
      LayerKernel.RunUnscaled(CoChangeOP());
      
      IEnumerator CoChangeOP()
      {
        while (LayerKernel.LoadJobs.Count > 0)
          yield return 0;
        NextActiveSceneName = SceneManager.GetSceneByBuildIndex(nextIndex).name;
      }
    }
  }
}