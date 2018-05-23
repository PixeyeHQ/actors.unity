/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  6:29 AM
================================================================*/

using System;
using System.Collections.Generic;
using MEC;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Homebrew
{
	public class ProcessingSceneLoad
	{
		private List<string> scenesToKeep = new List<string>();
		private List<string> sceneDependsOn = new List<string>();
		private Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();
		private ScenesList _scenesList;


		public Action sceneLoaded = delegate { };
		public Action sceneClosed = delegate { };


		public string GetFromList(int index)
		{
			if (_scenesList == null) _scenesList = Resources.Load<ScenesList>("ScenesList");
			return _scenesList.scenesNames[index];
		}

		public void Setup(List<string> scenesToKeep, List<string> sceneDependsOn, Starter starter)
		{
			this.scenesToKeep = scenesToKeep;
			this.sceneDependsOn = sceneDependsOn;
        
			Timing.RunCoroutine(_Setup(starter));
		}

		IEnumerator<float> _Setup(Starter starter)
		{
 
			for (var i = 0; i < SceneManager.sceneCount; i++)
			{
				var scene = SceneManager.GetSceneAt(i);

				scenes.Add(scene.name, scene);
			}

			sceneClosed();

			for (var i = 0; i < sceneDependsOn.Count; i++)
			{
				var name = sceneDependsOn[i];
				if (scenes.ContainsKey(name))
				{
					yield return Timing.WaitForSeconds(0.1f);
					continue;
				}

				var load = SceneManager.LoadSceneAsync(sceneDependsOn[i], LoadSceneMode.Additive);
				yield return Timing.WaitUntilDone(load);
				scenes.Add(name, SceneManager.GetSceneByName(name));
			}

			sceneLoaded();
	 
			starter.BindScene();
		}

		IEnumerator<float> _Load(string name)
		{
			Toolbox.changingScene = true;

			Toolbox.Instance.ClearSessionData();

			var s = SceneManager.GetActiveScene();
			var sName = s.name;
			var job = SceneManager.UnloadSceneAsync(s);
			yield return Timing.WaitUntilDone(job);
			scenes.Remove(sName);
			foreach (var key in scenes.Keys)
			{
				if (scenesToKeep.Contains(key)) continue;

				job = SceneManager.UnloadSceneAsync(scenes[key]);

				yield return Timing.WaitUntilDone(job);
			}

			job = Resources.UnloadUnusedAssets();
			yield return Timing.WaitUntilDone(job);

			scenes.Clear();

			job = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
			yield return Timing.WaitUntilDone(job);

			SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
			job.allowSceneActivation = true;
			Toolbox.changingScene = false;
		}


		public static void To(int id)
		{
			var processing = Toolbox.Get<ProcessingSceneLoad>();
			var name = processing.GetFromList(id);
			Timing.KillCoroutines();
			Timing.RunCoroutine(processing._Load(name));
		}

		public static void To(string name)
		{
			var processing = Toolbox.Get<ProcessingSceneLoad>();
			Timing.RunCoroutine(processing._Load(name));
		}
	}
}