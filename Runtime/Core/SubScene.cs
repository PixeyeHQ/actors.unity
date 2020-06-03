using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class SubScene
  {
    public static void Add(int buildIndex)
    {
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