using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class ActiveScene
  {
    internal static string NextActiveSceneName;

    public static void ChangeTo(int buildIndex)
    {
      LayerApp.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        LayerCore.ActiveLayer.Release();
        yield return LayerApp.WaitFrame;
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
        NextActiveSceneName = SceneManager.GetSceneByBuildIndex(buildIndex).name;
      }
    }

    public static void ChangeTo(string name)
    {
      LayerApp.Run(CoChangeTo());

      IEnumerator CoChangeTo()
      {
        LayerCore.ActiveLayer.isDirty = true;
        yield return LayerApp.WaitFrame;
        LayerCore.ActiveLayer.Release();
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(LayerCore.ActiveLayer.Scene));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
        LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive));
        NextActiveSceneName = name;
      }
    }
  }
}