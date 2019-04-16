//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;

namespace Pixeye.Framework
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
			//started = false;
			var starter = Object.FindObjectOfType<Starter>();
			if (starter == null) return;
			starter.ClearNodes();
		}

	//	private static bool started = false;

		static void Step()
		{
			if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
			{
			//	started = true;
				CheckScene();
			}
		}

		public static void CheckScene()
		{
			var starter = Object.FindObjectOfType<Starter>();
	//		started = false;
			if (starter == null) return;
			starter.ClearNodes();
			var actors = Object.FindObjectsOfType<Actor>();

			for (int i = 0; i < actors.Length; i++)
			{
				var a = actors[i];

				if (!a.isPooled) continue;
				CheckPoolCache(a.gameObject, Pool.Entities, starter);
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