/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       24/06/2017 20:56
================================================================*/


using System;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Homebrew
{
    public class MonoCached : MonoBehaviour
    {
        #region FIELDS

        [FoldoutGroup("Mono")] public Pool pool;
        [FoldoutGroup("Mono")] public EntityState state;
        [FoldoutGroup("Mono")] public float timeDestroyDelay;
        [FoldoutGroup("Mono")] public float timeScale = 1;
        [FoldoutGroup("Mono")] public Actor actorParent;

        [HideInInspector] public ProcessingSignals signals;
        [HideInInspector] public Transform selfTransform;

        #endregion

        #region MONO

        protected virtual void Awake()
        {
            selfTransform = transform;
            state &= ~EntityState.Enabled;
            state &= ~EntityState.Initialized;

            if (state.Contain(EntityState.RequireActorParent))
                return;


            if (Starter.initialized == false)
            {
                state |= EntityState.RequireStarter;
                return;
            }


            Setup();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state |= EntityState.Initialized;
                PostSetup();
            });
        }

        public virtual void OnEnable()
        {
            if (state.Contain(EntityState.Enabled) || state.Contain(EntityState.RequireStarter) ||
                state.Contain(EntityState.RequireActorParent)) return;

            state &= ~EntityState.Released;
            state |= EntityState.Enabled;


            if (ProcessingSignals.TryAddToGlobal(this))
            {
                if (signals == null)
                {
                    signals = new ProcessingSignals();
                }

                signals.Add(this);
            }


            ProcessingUpdate.Default.Add(this);

            HandleEnable();
        }


        public virtual void OnDisable()
        {
            if (Toolbox.isQuittingOrChangingScene() || !state.Contain(EntityState.Enabled)) return;

            state &= ~EntityState.Enabled;


            if (ProcessingSignals.TryRemoveGlobal(this))
            {
                signals?.Remove(this);
            }


            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        #endregion

        #region SETUPS

        public virtual void SetupAfterStarter()
        {
            state &= ~EntityState.RequireStarter;
            Setup();
            OnEnable();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state |= EntityState.Initialized;
                PostSetup();
            });
        }

        public void SetupAfterActor()
        {
            if (!state.Contain(EntityState.RequireActorParent)) return;
            state &= ~EntityState.RequireActorParent;
            Setup();
            OnEnable();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state |= EntityState.Initialized;
                PostSetup();
            });
        }

        #endregion

        #region METHODS

        protected void BindSignals()
        {
            signals = new ProcessingSignals();
        }

        protected virtual void Setup()
        {
        }

        protected virtual void PostSetup()
        {
        }

        protected virtual void HandleEnable()
        {
        }

        protected virtual void HandleDisable()
        {
        }

        #endregion

        #region DESTROY

        public void HandleDestroy()
        {
            if (state.Contain(EntityState.Released)) return;

            state |= EntityState.Released;
            state &= ~EntityState.Enabled;
            state &= ~EntityState.Initialized;

            if (pool == Pool.None)
            {
                Destroy(gameObject, timeDestroyDelay);
                return;
            }

            HandleReturnToPool();
        }

        private void HandleReturnToPool()
        {
            var processingPool = Toolbox.Get<ProcessingGoPool>();
            if (timeDestroyDelay > 0)
                Timer.Add(timeDestroyDelay, () => processingPool.Despawn(pool, gameObject));
            else processingPool.Despawn(pool, gameObject);
        }

        #endregion
    }
}