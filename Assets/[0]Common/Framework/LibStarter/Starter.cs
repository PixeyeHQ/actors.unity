/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;


namespace Homebrew
{
// Start any game    
	public class Starter : MonoBehaviour
	{
		public static bool initialized;
		public static List<MonoCached> objs = new List<MonoCached>();

		[Foldout("Setup")] public List<Factory> Factories;
		[Foldout("Setup")] public List<string> ScenesToKeep = new List<string>();
		[Foldout("Setup")] public List<string> SceneDependsOn = new List<string>();


		void Awake()
		{
			for (var i = 0; i < Factories.Count; i++)
			{
				Toolbox.Add(Factories[i]);
			}


			Toolbox.Add<ProcessingSceneLoad>().Setup(ScenesToKeep, SceneDependsOn, this);
		}


		public void BindScene()
		{
			var poolReg = GetComponent<PoolRegister>();
			if (poolReg) poolReg.Reigster();
			Setup();

			initialized = true;
			for (int i = 0; i < objs.Count; i++)
			{
				objs[i].state &= ~EntityState.OnHold;
				objs[i].Initialize();
			}


			objs.Clear();
		}

		protected virtual void Setup()
		{
		}

		private void OnDestroy()
		{
			initialized = false;
		}
	}

	[Serializable]
	public class CacheObj
	{
		public string valueKey;
		public Transform valueObject;
	}
}