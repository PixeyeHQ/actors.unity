/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       24/06/2017 20:56
================================================================*/


#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Pixeye.Framework
{
	public abstract class MonoCached : MonoBehaviour, IRequireStarter
	{
		 

		void Awake()
		{
			if (Starter.initialized == false) return;
			Setup();
		}


		void OnEnable()
		{
			if (Starter.initialized == false) return;
			HandleEnable();
		}

		void OnDisable()
		{
			HandleDisable();
		}


		public void Launch()
		{
			Setup();
			OnEnable();
		}


		protected virtual void HandleEnable()
		{
		}

		protected virtual void HandleDisable()
		{
		}

		protected virtual void Setup()
		{
		}
	}
}