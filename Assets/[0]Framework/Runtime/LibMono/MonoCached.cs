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
        [FoldoutGroup("Mono")] public int entityParent;
        [FoldoutGroup("Mono")] public EntityState state;

        [HideInInspector] public Transform selfTransform;

        internal bool conditionSignals;

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
                entityParent = GetComponentInParent<Actor>().entity;
            }


            Setup();
            state.initialized = true;
        }

        public virtual void OnEnable()
        {
            if (state.requireStarter ||
                state.requireActorParent) return;

            state.released = false;
            state.enabled = true;

            HandleEnable();

            if (conditionSignals)
                ProcessingSignals.Default.Add(this);

            ProcessingUpdate.Default.Add(this);
        }


        public virtual void OnDisable()
        {
            state.enabled = false;

            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);
            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        #endregion

        #region SETUPS

        internal virtual void SetupAfterStarter()
        {
            state.requireStarter = false;
            if (state.requireActorParent) return;
            Setup();
            OnEnable();
            state.initialized = true;
         
        }

        internal void SetupAfterActor()
        {
            if (!state.requireActorParent) return;
            state.requireActorParent = false;
            Setup();
            OnEnable();
            state.initialized = true;
            // Timer.Add(Time.DeltaTimeFixed, () => { state.initialized = true; });
        }

        #endregion

        #region METHODS

        protected virtual void Setup()
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

        public void Release()
        {
            if (state.released) return;
            state.released = true;

            OnHandleRelease();

            if (pool == Pool.None)
            {
                Destroy(gameObject, timeDestroyDelay + 0.03f);
                return;
            }

            HandleReturnToPool();
        }

        protected virtual void OnHandleRelease()
        {
        }

        internal void HandleReturnToPool()
        {
            if (timeDestroyDelay > 0)
                Timer.Add(timeDestroyDelay, () => gameObject.Release(pool));
            else gameObject.Release(pool);
        }

        #endregion
    }
}