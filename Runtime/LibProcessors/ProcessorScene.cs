//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Framework
{
	public sealed class ProcessorScene : IKernel
	{
		public static ProcessorScene Default = new ProcessorScene();

		public Action sceneLoaded = delegate { };
		public Action sceneClosing = delegate { };

		readonly Dictionary<string, Transform> sceneObjs = new Dictionary<string, Transform>();

		List<string> scenesToKeep = new List<string>();
		List<string> sceneDependsOn = new List<string>();
		Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();

		public void Dispose()
		{
			sceneObjs.Clear();
		}

		public static Transform Get(string id)
		{
			Transform obj;
			var       haveFound = Default.sceneObjs.TryGetValue(id, out obj);
			if (!haveFound)
			{
				var o = GameObject.Find(id);
				if (o)
					obj = o.transform;
				if (obj) Default.sceneObjs.Add(id, obj);
			}

			return obj;
		}

		public static Transform Get(ref string id)
		{
			Transform obj;
			var       haveFound = Default.sceneObjs.TryGetValue(id, out obj);
			if (!haveFound)
			{
				var o = GameObject.Find(id);
				if (o)
					obj = o.transform;
				if (obj) Default.sceneObjs.Add(id, obj);
			}

			return obj;
		}

		public void Setup(List<SceneReference> scenesToKeep, List<SceneReference> sceneDependsOn, Starter starter)
		{
			this.scenesToKeep.Clear();
			this.sceneDependsOn.Clear();


			for (var i = 0; i < scenesToKeep.Count; i++)
			{
				this.scenesToKeep.Add(scenesToKeep[i].Path);
			}

			for (var i = 0; i < sceneDependsOn.Count; i++)
			{
				this.sceneDependsOn.Add(sceneDependsOn[i].Path);
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

			if (sceneDependsOn.Count == 0)
			{
				yield return 0;
			}

			sceneLoaded();

			starter.BindScene();
		}

		IEnumerator _Load(string name)
		{
			sceneClosing();
			Toolbox.changingScene = true;
			Toolbox.Instance.ClearSessionData();

			if (scenes.Keys.Count == 1)
			{
				scenes.Clear();
				SceneManager.LoadScene(name);
				SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
				Toolbox.changingScene = false;
				yield break;
			}

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
			Toolbox.changingScene    = false;
		}

		IEnumerator _Load(int id)
		{
			sceneClosing();
			Toolbox.changingScene = true;
			Toolbox.Instance.ClearSessionData();

			if (scenes.Keys.Count == 1)
			{
				scenes.Clear();
				SceneManager.LoadScene(id);
				SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(id));
				Toolbox.changingScene = false;
				yield break;
			}

			var s     = SceneManager.GetActiveScene();
			var sName = s.name;

			var job = SceneManager.UnloadSceneAsync(s);

			while (!job.isDone)
			{
				yield return 0;
			}

			scenes.Remove(sName);

			if (scenes.Keys.Count != 1)
			{
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
			}


			scenes.Clear();

			job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}

			SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(id));
			job.allowSceneActivation = true;
			Toolbox.changingScene    = false;
		}

		public static void Add(int id)
		{
			Toolbox.Instance.StartCoroutine(_Add(id));
		}
		public static void Add(string id)
		{
			Toolbox.Instance.StartCoroutine(_Add(id));
		}
		
		public static void Remove(int id)
		{
			Toolbox.Instance.StartCoroutine(_Remove(id));
		}
		public static void Remove(string id)
		{
			Toolbox.Instance.StartCoroutine(_Remove(id));
		}
		static IEnumerator _Add(int id)
		{
			Toolbox.changingScene    =  true;
			SceneManager.sceneLoaded += OnAdditiveLoaded;
			var job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}


			Toolbox.changingScene = false;
		}

		static IEnumerator _Add(string id)
		{
			Toolbox.changingScene    =  true;
			SceneManager.sceneLoaded += OnAdditiveLoaded;
			var job = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);
			while (!job.isDone)
			{
				yield return 0;
			}


			Toolbox.changingScene = false;
		}

		static void OnAdditiveLoaded(Scene arg0, LoadSceneMode arg1)
		{
			if (arg1 != LoadSceneMode.Additive) return;


			var objs = arg0.GetRootGameObjects();


			foreach (var obj in objs)
			{
				var transforms = obj.GetComponentsInChildren<Transform>();

				foreach (var tr in transforms)
				{
					var o = tr.GetComponent("MonoBehaviour");

					if (o != null)
					{
						var req = o as IRequireStarter;
						if (req != null)
							req.Launch();
					}
				}
			}


			SceneManager.sceneLoaded -= OnAdditiveLoaded;
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

		static IEnumerator _Remove(string id)
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