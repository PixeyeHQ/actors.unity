//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;


namespace Pixeye
{
	using UnityEditor;
	using UnityEngine;


	class AssetCheckPools : AssetPostprocessor, IPreprocessBuildWithReport
	{
 

		public int callbackOrder => 0;

		public void OnPreprocessBuild(BuildReport report) { PostProcessorCheckPools.CheckScene(); }
	}


	[InitializeOnLoad]
	public static class PostProcessorCheckPools
	{
		//const string define = "ACTORS_POOL";

		static PostProcessorCheckPools()
		{
			EditorApplication.update += Step;

			var starter = Object.FindObjectOfType<Starter>();
			if (starter == null) return;
			starter.ClearNodes();


//			BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
//			string           defines          = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
//
//
//			if (defines.Contains(define))
//			{
//				return;
//			}
//
//			PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, (defines + ";" + define));
		}

		static void Step()
		{
			if (EditorApplication.isPlayingOrWillChangePlaymode && !Application.isPlaying)
			{
				CheckScene();
			}
		}

		public static void CheckScene()
		{
			var starter = Object.FindObjectOfType<Starter>();
			if (starter == null) return;
			starter.ClearNodes();
			var actors = Object.FindObjectsOfType<Actor>();

			for (int i = 0; i < actors.Length; i++)
			{
				var a = actors[i];
				if (a.pool == 0) continue;
				CheckPoolCache(a.gameObject, a.pool, starter);
			}
		}

		public static void CheckPoolCache(GameObject gameObject, int pool, Starter starter)
		{
			GameObject prefab;
			#if UNITY_2018_3_OR_NEWER
			prefab = PrefabUtility.GetCorrespondingObjectFromSource(gameObject);
			 
			#else
			prefab = (GameObject) PrefabUtility.GetPrefabObject(gameObject);
		    #endif
			if (prefab == null) return;
			starter.AddToNode(prefab, gameObject, pool);
		}
	}
}
#endif