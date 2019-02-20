/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  6:29 AM
================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Homebrew
{
	public class ProcessingSceneLoad : IKernel
	{
		public static ProcessingSceneLoad Default;

		private List<string> scenesToKeep = new List<string>();
		private List<string> sceneDependsOn = new List<string>();
		private Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();


		public Action sceneLoaded = delegate { };
		public Action sceneClosing = delegate { };


		public void Setup(List<SceneField> scenesToKeep, List<SceneField> sceneDependsOn, Starter starter)
		{
			this.scenesToKeep.Clear();
			this.sceneDependsOn.Clear();

			for (var i = 0; i < scenesToKeep.Count; i++)
			{
				this.scenesToKeep.Add(scenesToKeep[i].SceneName);
			}

			for (var i = 0; i < sceneDependsOn.Count; i++)
			{
				this.sceneDependsOn.Add(sceneDependsOn[i].SceneName);
			}

			Toolbox.Instance.StartCoroutine(_Setup(starter));
		}

		IEnumerator _Setup(Starter starter)
		{
			for (var i = 0; i < SceneManager.sceneCount; i++)
			{
				var scene = SceneManager.GetSceneAt(i);

				scenes.Add(scene.name, scene);
			}

			for (var i = 0; i < sceneDependsOn.Count; i++)
			{
				var name = sceneDependsOn[i];
				if (scenes.ContainsKey(name))
				{
					yield return new WaitForSeconds(0.1f);
					continue;
				}

				var load = SceneManager.LoadSceneAsync(sceneDependsOn[i], LoadSceneMode.Additive);
				while (!load.isDone)
				{
					yield return 0;
				}

				scenes.Add(name, SceneManager.GetSceneByName(name));
			}

			sceneLoaded();

			starter.BindScene();
		}

		IEnumerator _Load(string name)
		{
			sceneClosing();
			Toolbox.changingScene = true;
			Toolbox.Instance.ClearSessionData();


			var s     = SceneManager.GetActiveScene();
			var sName = s.name;

			var job = SceneManager.UnloadSceneAsync(s);

			while (!job.isDone)
			{
				yield return 0;
			}


			scenes.Remove(sName);
			foreach (var key in scenes.Keys)
			{
				if (scenesToKeep.Contains(key)) continue;

				job = SceneManager.UnloadSceneAsync(scenes[key]);

				while (!job.isDone)
				{
					yield return 0;
				}
			}

			job = Resources.UnloadUnusedAssets();
			while (!job.isDone)
			{
				yield return 0;
			}

			scenes.Clear();

			job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}

			SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
			job.allowSceneActivation = true;
			Toolbox.changingScene = false;
		}

		IEnumerator _Load(int id)
		{
			sceneClosing();
			Toolbox.changingScene = true;
			Toolbox.Instance.ClearSessionData();


			var s     = SceneManager.GetActiveScene();
			var sName = s.name;

			var job = SceneManager.UnloadSceneAsync(s);

			while (!job.isDone)
			{
				yield return 0;
			}


			scenes.Remove(sName);
			foreach (var key in scenes.Keys)
			{
				if (scenesToKeep.Contains(key)) continue;

				job = SceneManager.UnloadSceneAsync(scenes[key]);

				while (!job.isDone)
				{
					yield return 0;
				}
			}

			job = Resources.UnloadUnusedAssets();
			while (!job.isDone)
			{
				yield return 0;
			}

			scenes.Clear();

			job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}

			SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(id));
			job.allowSceneActivation = true;
			Toolbox.changingScene = false;
		}

		public static void Add(int id) { Toolbox.Instance.StartCoroutine(_Add(id)); }

		public static void Remove(int id) { Toolbox.Instance.StartCoroutine(_Remove(id)); }

		static IEnumerator _Add(int id)
		{
			Toolbox.changingScene = true;
			SceneManager.sceneLoaded += OnAdditiveLoaded;
			var job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}

			Toolbox.changingScene = false;
		}

		private static void OnAdditiveLoaded(Scene arg0, LoadSceneMode arg1)
		{
			if (arg1 != LoadSceneMode.Additive) return;

			SceneManager.sceneLoaded -= OnAdditiveLoaded;
	//		Toolbox.Instance.StartCoroutine(_OnAdditiveLoaded(arg0));
		}

		static IEnumerator _OnAdditiveLoaded(Scene arg)
		{
//			var roots = arg.GetRootGameObjects();
//			var list  = new List<Actor>(10);
//
//
//			foreach (var o in roots)
//				list.AddRange(o.transform.GetAll<Actor>());


//			var len = list.Count;
//			if (len == 0) yield break;


//			while (true)
//			{
//				for (int i = 0; i < len; i++)
//				{
//					while (true)
//					{
//						if (list[i].state.initialized)
//							break;
//						yield return 0;
//					}
//				}
//
//				break;
//			}

//			for (int i = 0; i < len; i++)
//			{
//				ProcessingEntities.Default.CheckGroups(list[i].entity, true);
//			}
			yield break;
		}


		static IEnumerator _Remove(int id)
		{
			Toolbox.changingScene = true;
			var job = SceneManager.UnloadSceneAsync(id);
			while (!job.isDone)
			{
				yield return 0;
			}

			Toolbox.changingScene = false;
		}


		public static void To(int id)
		{
			var processing = Default;

			Toolbox.Instance.StartCoroutine(processing._Load(id));
		}

		public static void To(string name)
		{
			var processing = Default;
			Toolbox.Instance.StartCoroutine(processing._Load(name));
		}
	}
}