using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class SceneSub
  {
    public static void Add(int buildIndex)
    {
      Kernel.ChangingScene[buildIndex] = true;
      LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
    }

    public static void Remove(int buildIndex)
    {
      if (Kernel.Layers[buildIndex] == null) return;

      LayerApp.Run(CoRemove());

      IEnumerator CoRemove()
      {
        Kernel.Layers[buildIndex].Release();
        yield return LayerApp.WaitFrame;
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
      }
    }

    public static void Add(string sceneName)
    {
      Kernel.ChangingScene[SceneManager.GetSceneByName(sceneName).buildIndex] = true;
      LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
    }

    public static void Remove(string sceneName)
    {
      var buildIndex = SceneManager.GetSceneByName(sceneName).buildIndex;
      if (Kernel.Layers[buildIndex] == null) return;

      LayerApp.Run(CoRemove());

      IEnumerator CoRemove()
      {
        Kernel.Layers[buildIndex].Release();
        yield return LayerApp.WaitFrame;
        LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
        LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
      }
    }
  }
}