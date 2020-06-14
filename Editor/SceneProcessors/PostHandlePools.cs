//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;


namespace Pixeye.Actors
{
  using UnityEditor;
  using UnityEngine;

  class PostHandlePools : AssetPostprocessor, IPreprocessBuildWithReport
  {
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
      PostProcessorCheckPools.CheckScene();
    }
  }

  [InitializeOnLoad]
  public static class PostProcessorCheckPools
  {
    static PostProcessorCheckPools()
    {
      EditorApplication.update += Step;
      var layer = Object.FindObjectOfType<Layer>();
      if (layer == null) return;
      layer.ClearNodes();
    }

    static void Step()
    {
      if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
      {
        CheckScene();
      }
    }

    public static void CheckScene()
    {
      var layer = Object.FindObjectOfType<Layer>();
      if (layer == null) return;
      layer.ClearNodes();
      var actors = Object.FindObjectsOfType<Actor>();

      for (int i = 0; i < actors.Length; i++)
      {
        var a = actors[i];
        if (!a.isPooled) continue;
        CheckPoolCache(a.gameObject, Pool.Entities, layer);
      }
    }

    public static void CheckPoolCache(GameObject gameObject, int pool, Layer layer)
    {
      GameObject prefab;
#if UNITY_2018_3_OR_NEWER
      prefab = PrefabUtility.GetCorrespondingObjectFromSource(gameObject);
#else
      prefab = (GameObject) PrefabUtility.GetPrefabObject(gameObject);
#endif
      if (prefab == null) return;
      layer.AddToNode(prefab, gameObject, pool);
    }
  }
}

#endif