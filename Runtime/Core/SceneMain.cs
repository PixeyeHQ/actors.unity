using System;
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
      LayerKernel.ChangingScene[buildIndex] = true;
      Closed();
      LayerCore.ActiveLayer.Release();
      LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
      LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
    }
  }
}