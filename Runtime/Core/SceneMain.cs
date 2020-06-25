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
      ChangeOp(NextActiveSceneName);
    }

    public static void ChangeTo(string sceneName)
    {
      NextActiveSceneName = sceneName;
      ChangeOp(sceneName);
    }

    static void ChangeOp(string sceneName)
    {
      var nextScene = sceneName;

      LayerKernel.Initialized[SceneSub.GetLayerIndex(sceneName)] = false;
      Closed();
      Layer.ActiveLayer.Release();
      LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(Layer.ActiveLayer.Scene));
      LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
      Layer.ActiveLayer = null;
      LayerKernel.RunUnscaled(CoChangeOP());
      
      IEnumerator CoChangeOP()
      {
        while (LayerKernel.LoadJobs.Count > 0)
          yield return 0;
        NextActiveSceneName = nextScene;
      }
    }
  }
}
