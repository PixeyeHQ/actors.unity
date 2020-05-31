using Pixeye.Actors;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEditor.SceneManagement;
using UnityEngine;
using Scene = UnityEngine.SceneManagement.Scene;

public class PostHandleScenes : EndNameEditAction
{
  const int MENU_ITEM_PRIORITY = 0;
  static Texture2D scriptIcon;

  public override void OnEnable()
  {
    base.OnEnable();
    scriptIcon = EditorGUIUtility.IconContent("SceneAsset Icon").image as Texture2D;
  }

  [MenuItem("Assets/Create/Actors/Scene", false, MENU_ITEM_PRIORITY)]
  public static void Add()
  {
    CreateFromTemplate("Scene.unity", HelperEditor.GetSelectedPathOrFallback());
  }

  static void CreateFromTemplate(string name, string path)
  {
    ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, CreateInstance<PostHandleScenes>(), name, scriptIcon, path);
  }


  public override void Action(int instanceId, string pathName, string resourceFile)
  {
    ProcEditorSceneObserve.name = pathName;
    NewSceneSetup setup = NewSceneSetup.EmptyScene;
    var scene = EditorSceneManager.NewScene(setup);
    EditorSceneManager.SaveScene(scene, pathName);
  }
}

[InitializeOnLoad]
public static class ProcEditorSceneObserve
{
  internal static string name;

  static ProcEditorSceneObserve()
  {
    EditorSceneManager.newSceneCreated += SceneCreating;
  }

  public static void SceneCreating(Scene scene, NewSceneSetup setup, NewSceneMode mode)
  {
    if (Camera.main != null)
    {
      var camGO = Camera.main.gameObject;
      Object.DestroyImmediate(camGO.gameObject);
    }

    var light = GameObject.Find("Directional Light");
    if (light != null)
    {
      Object.DestroyImmediate(light.gameObject);
    }

    var chunks = name.Split('/');
    var n = chunks[chunks.Length - 1];
    n = n.Split('.')[0];
    n = n.Replace("Scene", "");
 
    var gameObject = new GameObject(n + " Setup");
    var o = new GameObject("---Dynamic-----------------------------------------------------------------------------------------------------");
    o.SetActive(false);

    Debug.Log("New scene created!");
  }
}