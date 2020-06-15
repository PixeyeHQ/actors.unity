//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using System.Linq;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;


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
    public static IPooledLayer Find(int index)
    {
      GameObject[] rootGameObjects = SceneManager.GetSceneAt(index).GetRootGameObjects();
      foreach (var rootGameObject in rootGameObjects)
      {
        IPooledLayer[] childrenInterfaces = rootGameObject.GetComponentsInChildren<IPooledLayer>();
        foreach (var childInterface in childrenInterfaces)
        {
          return childInterface;
        }
      }

      return null;
    }

    static PostProcessorCheckPools()
    {
      EditorApplication.update += Step;

      for (int i = 0; i < SceneManager.sceneCount; i++)
      {
        GameObject[] rootGameObjects = SceneManager.GetSceneAt(i).GetRootGameObjects();
        foreach (var rootGameObject in rootGameObjects)
        {
          IPooledLayer[] childrenInterfaces = rootGameObject.GetComponentsInChildren<IPooledLayer>();
          foreach (var ilayer in childrenInterfaces)
          {
            ilayer.ClearNodes();
          }
        }
      }
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
      for (int i = 0; i < SceneManager.sceneCount; i++)
      {
        GameObject[] rootGameObjects = SceneManager.GetSceneAt(i).GetRootGameObjects();
        foreach (var rootGameObject in rootGameObjects)
        {
          IPooledLayer[] childrenInterfaces = rootGameObject.GetComponentsInChildren<IPooledLayer>();
          foreach (var ilayer in childrenInterfaces)
          {
            ilayer.ClearNodes();
       
            foreach (var obj in rootGameObjects)
            {
              var actors = obj.GetComponentsInChildren<Actor>();
 
              foreach (var a in actors)
              {
               
                if (!a.isPooled) continue;
                CheckPoolCache(a.gameObject, Pool.Entities, ilayer);
              }
            }
          }
        }
      }
    }

    public static void CheckPoolCache(GameObject gameObject, int pool, IPooledLayer layer)
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