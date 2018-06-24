using System.Linq;
using Homebrew;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine;


[InitializeOnLoad]
public class SceneGenerator
{
	static SceneGenerator()
	{
		EditorSceneManager.newSceneCreated += SceneCreating;
		EditorSceneManager.sceneSaved += SceneSaved;
	
	}


	private static void SceneSaved(Scene scene)
	{
		var original = EditorBuildSettings.scenes;

		for (int i = 0; i < original.Length; i++)
		{
			var s = original[i].path;
			if (s != scene.path) continue;

			SaveSceneName.SaveScenesName();
			return;
		}

		var newSettings = new EditorBuildSettingsScene[original.Length + 1];
		System.Array.Copy(original, newSettings, original.Length);
		var sceneToAdd = new EditorBuildSettingsScene(scene.path, true);
		newSettings[newSettings.Length - 1] = sceneToAdd;
		EditorBuildSettings.scenes = newSettings;

		SaveSceneName.SaveScenesName();
	}


	public static void SceneCreating(Scene scene, NewSceneSetup setup, NewSceneMode mode)
	{
		if (Camera.main == null) return;
		var camGO = Camera.main.gameObject;
		var lightGO = GameObject.Find("Directional Light").gameObject;
		GameObject.DestroyImmediate(lightGO);
		GameObject.DestroyImmediate(camGO);
		new GameObject("[SETUP]");
		var s = new GameObject("[SCENE]");
		var d = new GameObject("Dynamic");
		d.transform.parent = s.transform;
		Debug.Log("New scene created!");
	}
}