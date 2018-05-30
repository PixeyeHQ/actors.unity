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
	public class MonoCached : MonoBehaviour
	{
		#region MEMBERS

		[FoldoutGroup("Mono")] public Pool pool;
		[FoldoutGroup("Mono")] public float destroyDelayTime;

		[HideInInspector] public Time time;
		[HideInInspector] public Transform selfTransform;
		[HideInInspector, EnumFlag] public EntityState state;

		#endregion

		#region UPDATES

		public virtual void Tick()
		{
		}

		#endregion

		# region EXTENDED MONOBEHAVIOR

		void Awake()
		{
			selfTransform = transform;
			if (Starter.initialized == false)
			{
				state |= EntityState.OnHold;
				Starter.objs.Add(this);
			}
			else OnAwake();
		}

		protected virtual void OnAwake()
		{
		}


		public void Initialize()
		{
			OnAwake();
			OnEnable();
		}


		public void Spawn(bool arg)
		{
			if (arg) OnSpawn();
			else OnDespawn();
		}

		public void HandleTimeScale(float val)
		{
			time.timeScale = val;
			OnTimeScaleChanged();
		}


		public virtual void OnEnable()
		{
			if (state.HasState(EntityState.OnHold)) return;
			state &= ~EntityState.Released;

			ProcessingUpdate.Default.Add(this);
		}

		public virtual void OnDisable()
		{
			ProcessingUpdate.Default.Remove(this);
		}

		protected virtual void OnSpawn()
		{
		}

		protected virtual void OnDespawn()
		{
		}


		protected virtual void OnTimeScaleChanged()
		{
		}

		#endregion

		#region DESTROY AND POOL

		public void HandleReturnToPool()
		{
			var processingPool = Toolbox.Get<ProcessingGoPool>();
			if (destroyDelayTime > 0)
				Timer.Add(destroyDelayTime, () => processingPool.Despawn(pool, gameObject));
			else processingPool.Despawn(pool, gameObject);
		}

		public void HandleDestroyGO()
		{
			if (state.HasState(EntityState.Released)) return;

			state |= EntityState.Released;

			state &= ~EntityState.Enabled;
			state &= ~EntityState.OnHold;
			
			OnBeforeDestroy();
			
			if (pool == Pool.None)
			{
		 
				Destroy(gameObject, destroyDelayTime == 0 ? Time.DeltaTime : destroyDelayTime);
				return;
			}

			HandleReturnToPool();
		}

		protected virtual void OnBeforeDestroy()
		{
		}

		#endregion
	}
}