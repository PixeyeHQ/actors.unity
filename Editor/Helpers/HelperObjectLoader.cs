/// Add somewhere in Editor folder
/// Select prefab and press Command/control + W to get it in the scene

using UnityEditor;
using UnityEngine;

namespace Pixeye.Actors
{
  public class HelperObjectLoader
  {
    [MenuItem("Assets/Populate On Scene %W")]
    static void PopulateOnScene()
    {
      var selected = Selection.activeObject;

      var prefab = selected as GameObject;
      if (prefab == null) return;
      var obj = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
      if (!obj) return;

      var sandbox = GameObject.Find("[SANDBOX]");
      if (sandbox == null)
      {
        sandbox = new GameObject("[SANDBOX]");
        sandbox.transform.position = new Vector3(9999, 0, 0);
      }

      Debug.Log("<b>Sandbox:</b>  " + obj.name + " added to scene");

      obj.transform.parent = sandbox.transform;
      obj.transform.localPosition = new Vector3(0, 0, 0);

      Selection.activeGameObject = obj;

      if (SceneView.lastActiveSceneView == null) return;

      SceneView.lastActiveSceneView.pivot = obj.transform.position;
      SceneView.lastActiveSceneView.size = 1;

      SceneView.lastActiveSceneView.Repaint();
    }
  }
}