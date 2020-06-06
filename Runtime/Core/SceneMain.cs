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
      LayerKernel.Run(CoChangeTo(buildIndex));
    }

    public static void ChangeTo(string sceneName)
    {
      var buildIndex = LayerKernel.SceneIndexFromName(sceneName);
      NextActiveSceneName = sceneName;
      LayerKernel.Run(CoChangeTo(buildIndex));
    }

    static IEnumerator CoChangeTo(int buildIndex)
    {
      LayerKernel.ChangingScene[buildIndex] = true;
      LayerCore.ActiveLayer.isDirty         = true;
      yield return LayerKernel.WaitFrame;
      LayerCore.ActiveLayer.Release();
      LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
      LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
    }
  }
}