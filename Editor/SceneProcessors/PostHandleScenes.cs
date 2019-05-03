using System.IO;
using Pixeye.Framework;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
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

	[MenuItem("Assets/Create/Actors/Add/Scene", false, MENU_ITEM_PRIORITY)]
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
		NewSceneSetup setup = NewSceneSetup.EmptyScene;
		var           scene = EditorSceneManager.NewScene(setup);

		EditorSceneManager.SaveScene(scene, pathName);
	}

}

[InitializeOnLoad]
public static class ProcEditorSceneObserve
{

	static ProcEditorSceneObserve()
	{
		EditorSceneManager.newSceneCreated += SceneCreating;
	}

	public static void SceneCreating(Scene scene, NewSceneSetup setup, NewSceneMode mode)
	{
		if (Camera.main != null)
		{
			var camGO = Camera.main.gameObject;
			GameObject.DestroyImmediate(camGO.gameObject);
		}

		var light = GameObject.Find("Directional Light");
		if (light != null)
		{
			GameObject.DestroyImmediate(light.gameObject);
		}

		new GameObject("[SETUP]");
		new GameObject("[SCENE]");

		Debug.Log("New scene created!");
	}

}