/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  6:01 AM
================================================================*/
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections;
using System.Collections.Generic;
 
using UnityEngine;

namespace Homebrew
{
	public class StarterKernel : MonoBehaviour
	{
		[FoldoutGroup("Setup")] public Blueprints blueprints;
		[FoldoutGroup("Setup")] public DataGame dataGameSettings;
		[FoldoutGroup("Setup")] public DataGame dataGameSession;

		[FoldoutGroup("Setup")] public List<Pluggable> pluggables = new List<Pluggable>();
 

		private void Awake()
		{
		  	Toolbox.Add(blueprints);
			ProcessingUpdate.Default = Toolbox.Add<ProcessingUpdate>();

			Time.Default = Toolbox.Add<Time>();


			ProcessingTimer.Default = Toolbox.Add<ProcessingTimer>();
			ProcessingPools.Default = Toolbox.Add<ProcessingPools>();
			ProcessingSignals.Default = Toolbox.Add<ProcessingSignals>();
			ProcessingGoPool.Default = Toolbox.Add<ProcessingGoPool>();
			ProcessingResources.Default = Toolbox.Add<ProcessingResources>();
			ProcessingEntities.Default = Toolbox.Add<ProcessingEntities>();
			ProcessingAttributes.Default = Toolbox.Add<ProcessingAttributes>();
			ProcessingBehaviorAttributes.Default = Toolbox.Add<ProcessingBehaviorAttributes>();
			ProcessingScene.Default = Toolbox.Add<ProcessingScene>();


			for (var i = 0; i < pluggables.Count; i++)
			{
				pluggables[i].Plug();
			}

 

			Toolbox.Add(dataGameSession);
			Toolbox.Add(dataGameSettings);

			Application.runInBackground = false;
 

			ProcessingPools.Default.Populate<Timer>(30);
		}


		private IEnumerator OnApplicationFocus(bool hasFocus)
		{
			if (hasFocus) Time.Default.OnFocus();
			yield return new WaitForSeconds(0.01f);
			Time.Default.isActive = hasFocus ? 1f : 0f;
		}

 
	}
}