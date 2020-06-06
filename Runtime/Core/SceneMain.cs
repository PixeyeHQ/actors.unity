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
      LayerKernel.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        Closed();
        LayerKernel.ChangingScene[buildIndex] = true;
        LayerCore.ActiveLayer.Release();
        yield return LayerKernel.WaitFrame;
        LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
        NextActiveSceneName = SceneManager.GetSceneByBuildIndex(buildIndex).name;
      }
    }

    public static void ChangeTo(string sceneName)
    {
      var buildIndex = LayerKernel.SceneIndexFromName(sceneName);
      LayerKernel.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        LayerKernel.ChangingScene[buildIndex] = true;
        LayerCore.ActiveLayer.isDirty    = true;
        yield return LayerKernel.WaitFrame;
        LayerCore.ActiveLayer.Release();
        LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
        NextActiveSceneName = sceneName;
      }
    }
  }
}