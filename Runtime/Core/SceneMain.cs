using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class SceneMain
  {
    internal static string NextActiveSceneName;

    public static void ChangeTo(int buildIndex)
    {
      LayerApp.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        Kernel.ChangingScene[buildIndex] = true;
        LayerCore.ActiveLayer.Release();
        yield return LayerApp.WaitFrame;
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
        NextActiveSceneName = SceneManager.GetSceneByBuildIndex(buildIndex).name;
      }
    }

    public static void ChangeTo(string sceneName)
    {
      var buildIndex = Kernel.SceneIndexFromName(sceneName);
      LayerApp.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        Kernel.ChangingScene[buildIndex] = true;
        LayerCore.ActiveLayer.isDirty    = true;
        yield return LayerApp.WaitFrame;
        LayerCore.ActiveLayer.Release();
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
        NextActiveSceneName = sceneName;
      }
    }
  }
}