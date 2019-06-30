//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public class StarterKernel : MonoBehaviour
	{
		[FoldoutGroup("SetupData")]
		public List<Pluggable> pluggables = new List<Pluggable>();


		void Awake()
		{
			if (ProcessorUpdate.Default == null)
				ProcessorUpdate.Create();


			for (var i = 0; i < pluggables.Count; i++)
				pluggables[i].Plug();
		}

		IEnumerator OnApplicationFocus(bool hasFocus)
		{
			if (Application.runInBackground) yield break;
			yield return new WaitForSeconds(0.01f);
			if (!hasFocus)
			{
				Time.Default.timeScaleCached = Time.Default.timeScale;
				Time.Default.timeScale       = 0;
			}
			else
			{
				Time.Default.timeScale = Time.Default.timeScaleCached;
			}
		}
	}
}