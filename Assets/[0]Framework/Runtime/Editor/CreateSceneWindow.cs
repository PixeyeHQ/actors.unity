//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/23/2018


using System.IO;
using Homebrew;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;
 
public class CreateSceneWindow : EditorWindow
{
	[MenuItem("Tools/Actors/Add/Scene", false, 0)]
	public static void ShowWindow() { GetWindow<CreateSceneWindow>(false, "New scene", true); }

	void OnGUI()
	{
		DataSceneWindow.name = EditorGUILayout.TextField("Scene name: ", DataSceneWindow.name);
		DataSceneWindow.path = EditorGUILayout.TextField("Scene path: ", DataSceneWindow.path);

		if (GUILayout.Button("Save scene!"))
		{
			NewSceneSetup setup;
			setup = NewSceneSetup.EmptyScene;

			var newScene = EditorSceneManager.NewScene(setup);
			EditorSceneManager.SaveScene(newScene, DataSceneWindow.path + DataSceneWindow.name + ".unity");
			Saved(newScene);

			// EditorSceneManager.sceneOpened += Saved;
		}
	}

	public static void Saved(Scene scene)
	{
		new GameObject("[SETUP]");
		var s = new GameObject("[SCENE]");
		var d = new GameObject("Dynamic");
		d.transform.parent = s.transform;
		Debug.Log("New scene created!");
	}
}

public static class DataSceneWindow
{
	public static string path
	{
		get
		{
			#if UNITY_EDITOR
			return EditorPrefs.GetString("dsw_path", "Assets/[2]Content/Scenes/");
			#else
            return false;
#endif
		}

		set
		{
			#if UNITY_EDITOR
			EditorPrefs.SetString("dsw_path", value);
			#endif
		}
	}

	public static string name
	{
		get
		{
			#if UNITY_EDITOR
			return EditorPrefs.GetString("dsw_name", "sceneDefault");
			#else
            return false;
         #endif
		}

		set
		{
			#if UNITY_EDITOR
			EditorPrefs.SetString("dsw_name", value);
			#endif
		}
	}
}