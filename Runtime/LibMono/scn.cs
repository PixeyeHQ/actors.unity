using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public readonly struct scn
  {
    internal int id { get; }
    internal int sceneId { get; }

    internal Scene scene => SceneManager.GetSceneByBuildIndex(sceneId);

    public scn(int buildId)
    {
      sceneId = buildId;
      id = sceneId + 1;
    }

    public scn(string sceneName)
    {
      sceneId = SceneManager.GetSceneByName(sceneName).buildIndex;
      id = sceneId + 1;
    }
  }
}