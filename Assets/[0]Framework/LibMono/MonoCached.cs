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
        #region FIELDS

        [InfoBox("Monocached is a base monobehavior class of the ACTORS framework. It is used to initialize an object, handle object pooling/destroying.", InfoMessageType.Info)]
        [FoldoutGroup("Mono"), TagFilter(typeof(Pool))]
        public int pool;

        [FoldoutGroup("Mono")] public float timeDestroyDelay;
        [FoldoutGroup("Mono")] public float timeScale = 1;
        [FoldoutGroup("Mono")] public Actor actorParent;
        [FoldoutGroup("Mono")] public EntityState state;

        [HideInInspector] public Transform selfTransform;

        protected bool conditionSignals;

        #endregion

        #region MONO

        protected virtual void Awake()
        {
            selfTransform = transform;

            state.enabled = false;
            state.initialized = false;

            conditionSignals = ProcessingSignals.Check(this);

            if (Starter.initialized == false)
            {
                state.requireStarter = true;

                return;
            }


            if (state.requireActorParent)
            {
                actorParent = GetComponentInParent<Actor>();
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

            if (conditionSignals)
                ProcessingSignals.Default.Add(this);

            ProcessingUpdate.Default.Add(this);

            HandleEnable();
        }


        public virtual void OnDisable()
        {
            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);

            if (Toolbox.isQuittingOrChangingScene() || !state.enabled) return;

            state.enabled = false;


            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        #endregion

        #region SETUPS

        public virtual void SetupAfterStarter()
        {
            if (state.requireActorParent) return; 
            state.requireStarter = false;
            Setup();
            OnEnable();

            Timer.Add(Time.DeltaTimeFixed, () =>
            {
                PostSetup();
                state.initialized = true;
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
                PostSetup();
                state.initialized = true;
            });
        }

        #endregion

        #region METHODS

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

        protected virtual void OnHandleDestroy()
        {
        }

        public void HandleDestroy()
        {
            if (state.released) return;
            state.released = true;


            if (pool == Pool.None)
            {
                OnHandleDestroy();
                Destroy(gameObject, timeDestroyDelay + 0.03f);
                return;
            }

            HandleReturnToPool();
        }

        protected virtual void HandleReturnToPool()
        {
            var processingPool = ProcessingGoPool.Default;
            Timer.Add(timeDestroyDelay + 0.03f, () => processingPool.Despawn(pool, gameObject));
        }

        #endregion
    }
}