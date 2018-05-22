/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  6:01 AM
================================================================*/

using System.Collections;
using UnityEngine;

namespace Homebrew
{
	public class StarterKernel : MonoBehaviour
	{
		[Foldout("Setup")] public DataGame DataGameSettings;
		[Foldout("Setup")] public DataGame DataGameSession;
		[Foldout("Setup")] public CommandsConsole CommandsDebug;
		[Foldout("Setup")] public Blueprints Blueprints;

		private void Awake()
		{
			Toolbox.Add(Blueprints);
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
			
			Toolbox.Add<ProcessingConsole>()
				.Setup(CommandsDebug);


			Toolbox.Add(DataGameSession);
			Toolbox.Add(DataGameSettings);

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