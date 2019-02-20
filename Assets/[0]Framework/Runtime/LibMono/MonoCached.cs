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


namespace Homebrew
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
			conditionSignals = ProcessingSignals.Check(this);
		}


		void OnEnable()
		{
			if (Starter.initialized == false) return;


			HandleEnable();

			if (conditionSignals)
				ProcessingSignals.Default.Add(this);

			ProcessingUpdate.Default.Add(this);
		}

		void OnDisable()
		{
			if (conditionSignals)
				ProcessingSignals.Default.Remove(this);
			ProcessingUpdate.Default.Remove(this);

			HandleDisable();
		}


		public virtual void SetupAfterStarter()
		{
			Setup();
			OnEnable();
		}


		protected virtual void HandleEnable() { }

		protected virtual void HandleDisable() { }

		protected abstract void Setup();
	}
}