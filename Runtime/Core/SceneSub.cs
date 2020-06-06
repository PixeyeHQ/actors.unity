using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class SceneSub
  {
    public static void Add(int buildIndex)
    {
      LayerKernel.ChangingScene[buildIndex] = true;
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
    }

    public static void Remove(int buildIndex)
    {
      if (LayerKernel.Layers[buildIndex] == null) return;

      LayerKernel.Run(CoRemove());

      IEnumerator CoRemove()
      {
        LayerKernel.Layers[buildIndex].Release();
        yield return LayerKernel.WaitFrame;
        LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
        LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      }
    }

    public static void Add(string sceneName)
    {
      var buildIndex = LayerKernel.SceneIndexFromName(sceneName);
      LayerKernel.ChangingScene[buildIndex] = true;
      LayerKernel.LoadJobs.Add(SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive));
    }

    public static void Remove(string sceneName)
    {
      var buildIndex = SceneManager.GetSceneByName(sceneName).buildIndex;
      if (LayerKernel.Layers[buildIndex] == null) return;

      LayerKernel.Run(CoRemove());

      IEnumerator CoRemove()
      {
        LayerKernel.Layers[buildIndex].Release();
        yield return LayerKernel.WaitFrame;
        LayerKernel.LoadJobs.Add(SceneManager.UnloadSceneAsync(buildIndex));
        LayerKernel.LoadJobs.Add(Resources.UnloadUnusedAssets());
      }
    }
  }
}