//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using UnityEngine;

namespace Pixeye.Framework
{
	public abstract class Processor : IDisposable
	{

		protected Processor()
		{
			ProcessorGroups.Setup(this);
			ProcessorSignals.Default.Add(this);
			Toolbox.disposables.Add(this);
		}

		public void Dispose()
		{
			ProcessorSignals.Default.Remove(this);
			ProcessorUpdate.Remove(this);

			OnDispose();
		}


		
		protected virtual void OnDispose()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void Initialize()
		{
			SettingsEngine.SizeEntities = 200000;
		}
		
	}
}