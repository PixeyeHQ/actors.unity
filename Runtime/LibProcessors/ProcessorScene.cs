//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
	public sealed class ProcessorScene : IKernel
	{
		public static ProcessorScene Default = new ProcessorScene();
        
		public Action OnSceneLoad = delegate { };
        public Action<float> OnSceneLoading = delegate { };
		public Action OnSceneClose = delegate { };

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

			Toolbox.SceneCoroutine.StartCoroutine(_Setup(starter));
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

			OnSceneLoad();

			starter.BindScene();
		}

        IEnumerator _Load(int id)
        {
	        string pathToScene = SceneUtility.GetScenePathByBuildIndex(id);
	        string sceneName   = System.IO.Path.GetFileNameWithoutExtension(pathToScene);
	        
          IEnumerator load = _Load(sceneName);

            while (load.MoveNext())
                yield return 0;
        }
        IEnumerator _Load(string name)
        {
            void CalculateProgress(AsyncOperation curJob, int _totalStages, ref float _prevProgress, ref float _curProgress)
            {
                _curProgress += curJob.progress / _totalStages - _prevProgress;
                _prevProgress = curJob.progress / _totalStages;

                _curProgress = Mathf.Clamp(_curProgress, 0f, 1f);
                OnSceneLoading(_curProgress);
            }

            routines.Default.StopAll();
            ProcessorEntities.Clean();
            OnSceneClose();
            Toolbox.changingScene = true;
            Toolbox.Instance.ClearSessionData();

            //Plus two for unload assets and load target scene
            int totalStagesNeed = 0;
            float curProgress = 0f, prevProgress = 0f;

            AsyncOperation job = null;
            List<string> scenesToUnload = new List<string>();

            //Add main scene
            scenesToUnload.Add(SceneManager.GetActiveScene().name);
            //Add additive scenes
            scenesToUnload.AddRange(sceneDependsOn);
            //Exclude scenes to keep
            scenesToUnload.RemoveAll((scene) => scenesToKeep.Contains(scene));

            totalStagesNeed = scenesToUnload.Count + 2;

            //Do all work
            for (int i = 0; i < totalStagesNeed; i++)
            {
                //Unload scenes
                if (i < scenesToUnload.Count)
                {
                    string key = scenesToUnload[i];

                    job = SceneManager.UnloadSceneAsync(scenes[key]);
                }
                //Cleaning
                else if (i < totalStagesNeed - 1)
                {
                    job = Resources.UnloadUnusedAssets();
                }
                //Load target scene
                else if (i < totalStagesNeed)
                {
                    scenes.Clear();
                    job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
                }
                //Calculate progress
                while (!job.isDone)
                {
                    CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
                    yield return 0;
                }
                CalculateProgress(job, totalStagesNeed, ref prevProgress, ref curProgress);
                prevProgress = 0f;
            }

            SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
            job.allowSceneActivation = true;
            Toolbox.changingScene = false;
        }

        public static void Add(int id)
		{
			Toolbox.SceneCoroutine.StartCoroutine(_Add(id));
		}
		public static void Add(string id)
		{
			Toolbox.SceneCoroutine.StartCoroutine(_Add(id));
		}

		public static void Remove(int id)
		{
			Toolbox.SceneCoroutine.StartCoroutine(_Remove(id));
		}
		public static void Remove(string id)
		{
			Toolbox.SceneCoroutine.StartCoroutine(_Remove(id));
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
					var oo = tr.GetComponents<IRequireStarter>();
					foreach (var o in oo)
					{
						o.Launch();
					}
				}
			}


			SceneManager.sceneLoaded -= OnAdditiveLoaded;
		}

		static IEnumerator _Remove(int id)
		{
			Toolbox.changingScene = true;
			KillActors(SceneManager.GetSceneByBuildIndex(id));
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
			KillActors(SceneManager.GetSceneByName(id));
			var job = SceneManager.UnloadSceneAsync(id);
			while (!job.isDone)
			{
				yield return 0;
			}

			Toolbox.changingScene = false;
		}

		static void KillActors(Scene s)
		{
			var root = s.GetRootGameObjects();

			foreach (var go in root)
			{
				var actors = go.GetComponentsInChildren<Actor>();

				for (int i = 0; i < actors.Length; i++)
				{
					actors[i].entity.Release();
				}
			}
		}

		public static void To(int id)
		{
			var processing = Default;
			//	Processor.processorsLen = 0;
			Toolbox.SceneCoroutine.StartCoroutine(processing._Load(id));
		}

		public static void To(string name)
		{
			var processing = Default;
			Toolbox.SceneCoroutine.StartCoroutine(processing._Load(name));
		}
	}
}