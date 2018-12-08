/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       12/09/2017 16:10
================================================================*/


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

		[FoldoutGroup("SetupData")] public List<FactoryBase> factories;
		[FoldoutGroup("SetupData")] public List<SceneField> ScenesToKeep;
		[FoldoutGroup("SetupData")] public List<SceneField> SceneDependsOn;


		void Awake()
		{
			ProcessingScene.Dynamic = GameObject.Find("Dynamic").transform;

			if (ProcessingUpdate.Default == null)
			{
				ProcessingUpdate.Create();
			}

			if (ProcessingSceneLoad.Default == null)
				ProcessingSceneLoad.Default = Toolbox.Create<ProcessingSceneLoad>();

			ProcessingSceneLoad.Default.Setup(ScenesToKeep, SceneDependsOn, this);
		}


		public void BindScene()
		{
	 
			var poolReg = GetComponent<PoolRegister>();
			if (poolReg) poolReg.Reigster();

			Setup();

			initialized = true;

			var objs = FindObjectsOfType<MonoCached>();

			for (var i = 0; i < objs.Length; i++)
			{
				if (objs[i].state.requireStarter)
					objs[i].SetupAfterStarter();
			}


			Timer.Add(Time.deltaFixed * 2, () =>
			{
				PostSetup();
				Add<ProcessingRelease>();
			});
		}

		protected static T Add<T>() where T : new() { return Toolbox.Add<T>(); }

		protected virtual void Setup() { }

		protected virtual void PostSetup() { }

		protected virtual void OnDestroy() { initialized = false; }
	}
}