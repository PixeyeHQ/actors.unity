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
            state.enabled = false;
            state.initialized = false;

            if (state.requireActorParent)
                return;


            if (Starter.initialized == false)
            {
                state.requireStarter = true;

                return;
            }


            Setup();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state.initialized = true;

                PostSetup();
            });
        }

        public virtual void OnEnable()
        {
            if (state.enabled || state.requireStarter ||
                state.requireActorParent) return;
           
            state.released = false;
            state.enabled = true;


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
            if (Toolbox.isQuittingOrChangingScene() || !state.enabled) return;

            state.enabled = false;


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
            state.requireStarter = false;
            Setup();
            OnEnable();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state.initialized = true;
                PostSetup();
            });
        }

        public void SetupAfterActor()
        {
            if (!state.requireActorParent) return;
            state.requireActorParent = false;
            Setup();
            OnEnable();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                state.initialized = true;
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
       
            if (state.released) return;
            state.released = true;
            state.enabled = false;
            if (pool == Pool.None)
            {
              
                Destroy(gameObject, timeDestroyDelay);
                return;
            }

            HandleReturnToPool();
        }

        protected virtual void HandleReturnToPool()
        {
            var processingPool = Toolbox.Get<ProcessingGoPool>();
            if (timeDestroyDelay > 0)
                Timer.Add(timeDestroyDelay, () => processingPool.Despawn(pool, gameObject));
            else processingPool.Despawn(pool, gameObject);
        }

        #endregion
    }
}