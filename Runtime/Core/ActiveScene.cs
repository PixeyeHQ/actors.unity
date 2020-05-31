using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public static class ActiveScene
  {
    public static void ChangeTo(int buildIndex)
    {
      routines.app.run(CoChangeActiveScene(SceneManager.GetSceneByBuildIndex(buildIndex)));
    }

    public static void ChangeTo(string name)
    {
      routines.app.run(CoChangeActiveScene(SceneManager.GetSceneByName(name)));
    }

    static IEnumerator CoChangeActiveScene(Scene to)
    {
      StarterCore.ActiveLayer.Release();
      var job = SceneManager.UnloadSceneAsync(StarterCore.ActiveLayer.Scene);
      while (!job.isDone)
      {
        yield return 0;
      }
      job = Resources.UnloadUnusedAssets();
      while (!job.isDone)
      {
        yield return 0;
      }
      job = SceneManager.LoadSceneAsync(to.buildIndex, LoadSceneMode.Additive);

      while (!job.isDone)
      {
        yield return 0;
      }

      yield return 0;
    }
  }
}