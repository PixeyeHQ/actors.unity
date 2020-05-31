using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class MainScene
  {
    internal static string NextActiveSceneName;
    
    public static void ChangeTo(int buildIndex)
    {
      StarterCore.ActiveLayer.Release();
      LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(StarterCore.ActiveLayer.Scene));
      LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive));
      NextActiveSceneName = SceneManager.GetSceneByBuildIndex(buildIndex).name;
    }

    public static void ChangeTo(string name)
    {
      StarterCore.ActiveLayer.Release();
      LayerApp.LoadJobs.Add(SceneManager.UnloadSceneAsync(StarterCore.ActiveLayer.Scene));
      LayerApp.LoadJobs.Add(Resources.UnloadUnusedAssets());
      LayerApp.LoadJobs.Add(SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive));
      NextActiveSceneName = name;
    }
  }
}