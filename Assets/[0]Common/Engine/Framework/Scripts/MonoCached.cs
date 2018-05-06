/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:06 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class MonoCached : MonoBehaviour
	{
		[Header("==Mono==")] public float destroyDelayTime;

		[HideInInspector, EnumFlag] public EntityState state;
		[HideInInspector] public Transform selfTransform;

		private void Awake()
		{
			selfTransform = transform;
			state = default(EntityState);
			state |= EntityState.Active;

			OnAwake();
		}

		protected virtual void OnAwake()
		{
		}

		protected virtual void OnEnable()
		{
			state &= ~EntityState.Released;
			ProcessingUpdate.HandleAdd(this);
		}

		protected virtual void OnDisable()
		{
			ProcessingUpdate.HandleRemove(this);
		}

		public virtual void Tick()
		{
		}

		public virtual void TickFixed()
		{
		}

		public virtual void TickLate()
		{
		}


		public void HandleDestroyGO()
		{
			if (state.HasState(EntityState.Released)) return;
			state |= EntityState.Released;
			HandleReleaseGO();
		}

		public void HandleReleaseGO()
		{
			OnDestroyGO();
			Destroy(gameObject, destroyDelayTime == 0 ? Time.deltaTime : destroyDelayTime);
		}

		protected virtual void OnDestroyGO()
		{
		}

		protected virtual void OnDispose()
		{
		}

		private void OnDestroy()
		{
			OnDispose();
		}
	}
}