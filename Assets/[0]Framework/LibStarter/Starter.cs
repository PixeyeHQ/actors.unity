/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif


namespace Homebrew
{
// Start any game    
	public class Starter : MonoBehaviour
	{
		public static bool initialized;
		public static List<MonoCached> objs = new List<MonoCached>();

		[FoldoutGroup("Setup")] public List<Factory> factories;
		[FoldoutGroup("Setup")] public List<DataScene> ScenesToKeep = new List<DataScene>();
		[FoldoutGroup("Setup")] public List<DataScene> SceneDependsOn = new List<DataScene>();

		void Awake()
		{
			for (var i = 0; i < factories.Count; i++)
			{
				Toolbox.Add(factories[i]);
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
}