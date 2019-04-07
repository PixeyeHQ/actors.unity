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
		#region FIELDS

		[HideInInspector] public Transform selfTransform;
		bool conditionSignals;

		#endregion


		void Awake()
		{
			selfTransform = transform;
			conditionSignals = ProcessorSignals.Check(this);
			if (Starter.initialized == false) return;
			Setup();
			
		}


		void OnEnable()
		{
			if (Starter.initialized == false) return;


			HandleEnable();

			if (conditionSignals)
				ProcessorSignals.Default.Add(this);

			ProcessorUpdate.Default.Add(this);
		}

		void OnDisable()
		{
			if (conditionSignals)
				ProcessorSignals.Default.Remove(this);
			ProcessorUpdate.Default.Remove(this);

			HandleDisable();
		}


		public virtual void AwakeAfterStarter()
		{
			Setup();
			OnEnable();
		}


		protected virtual void HandleEnable() { }

		protected virtual void HandleDisable() { }

		protected virtual void Setup() { }
	}
}
