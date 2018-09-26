/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:32 AM
================================================================*/


using System;
using System.Collections.Generic;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Homebrew
{
    public class Actor : MonoCached, IPoolable
    {
        public static Actor[] entites = new Actor[EngineSettings.MinEntities];
        public static Stack<int> prevID = new Stack<int>(100);
        public static int lastID;

        [InfoBox("An actor is a body for an entity. The entity itself is just an incremental number." +
                 "Use actors when you want to compose your entities from the inspector.", InfoMessageType.Info)]

        #region FIELDS

        [FoldoutGroup("Actor")]
        public int id;


        // private Dictionary<int, int> tags = new Dictionary<int, int>(new FastComparable());

        private Dictionary<int, Transform> cachedTransforms;

        #endregion

        #region MONO

        protected override void Awake()
        {
            ProcessingEntities.Add(this);

            #if ACTORS_DEBUG
            var name = gameObject.name.Split('(')[0];
            gameObject.name = name + "_" + id;

            #endif

            base.Awake();
        }


        public override void OnEnable()
        {
            if (state.enabled || state.requireStarter ||
                state.requireActorParent) return;

            if (state.initialized)
            {
                ProcessingEntities.Default.CheckGroups(id, true);
            }

            HandleEnable();
            state.released = false;
            state.enabled = true;

            if (conditionSignals)
                ProcessingSignals.Default.Add(this);

            ProcessingUpdate.Default.Add(this);
        }
//TODO: refactor

        public override void OnDisable()
        {
            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);

            if (Toolbox.isQuittingOrChangingScene() || state.released ||
                !state.enabled) return;

            state.enabled = false;
            state.released = true;
            ProcessingEntities.Default.CheckGroups(id, false);
            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        protected override void HandleReturnToPool()
        {
            int len = Storage.all.Count;
            for (int j = 0; j < len; j++)
            {
                Storage.all[j].Remove(id);
            }

            if (cachedTransforms != null)
                cachedTransforms.Clear();

            Tags.Clear(id);

            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);

            ProcessingUpdate.Default.Remove(this);

            base.HandleReturnToPool();
        }

        protected virtual void OnDestroy()
        {
            if (Toolbox.applicationIsQuitting) return;

            int len = Storage.all.Count;
            for (int j = 0; j < len; j++)
            {
                Storage.all[j].Remove(id);
            }

            Tags.Clear(id);
            prevID.Push(id);

            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);

            if (Toolbox.changingScene) return;
 
            ProcessingUpdate.Default.Remove(this);
        }

        #endregion

        #region ADD/REMOVE

        public void AddCache(int key, string path)
        {
            if (cachedTransforms == null) cachedTransforms = new Dictionary<int, Transform>(2, new FastComparable());
            cachedTransforms.Add(key, Get<Transform>(path));
        }

        public void AddTags(params int[] tags)
        {
            Tags.AddTags(id, tags);
        }

       

        public void Add<T>(T component) where T : IData, new()
        {
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            Storage<T>.Instance.Add(component, id);
        }

        public T Add<T>() where T : IData, new()
        {
            var component = Storage<T>.Instance.Add(id);
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            return component;
        }


        public void Remove<T>() where T : new()
        {
            Storage<T>.Instance.Remove(id);
        }

        #endregion

        #region  GET

        public T Get<T>() where T : IData, new()
        {
            return Storage<T>.Instance.TryGet(id);
        }

        public T Get<T>(int hash)
        {
            return cachedTransforms[hash].GetComponent<T>();
        }

        public T Get<T>(string path)
        {
            var o = selfTransform.Find(path);
            return o.GetComponent<T>();
        }

        #endregion

        #region METHODS

        public override void SetupAfterStarter()
        {
            base.SetupAfterStarter();

            var childs = GetComponentsInChildren<MonoCached>();

            for (int i = 1; i < childs.Length; i++)
            {
                childs[i].actorParent = this;
                childs[i].SetupAfterActor();
            }
        }

        void HandleTagsChanged()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;
            if (state.initialized && !state.enabled) return;


            var groups = ProcessingEntities.Default.GroupsBase;
            int len = ProcessingEntities.Default.groupLength;

            for (int i = 0; i < len; i++)
            {
                groups[i].TagsChanged(id);
            }

            groups = ProcessingEntities.Default.GroupsActors;
            len = ProcessingEntities.Default.groupLengthActors;
            for (int i = 0; i < len; i++)
            {
                groups[i].TagsChanged(id);
            }
        }

        #endregion

        #region TAGS

//        public void AddTags(params int[] tags)
//        {
//            if (state.released) return;
//            Tags.Add(id, tags);
//        }
//
//        public void AddTags(int tag)
//        {
//            if (state.released) return;
//            Tags.Add(id, tag);
//        }
//
//        public void RemoveTags(params int[] tags)
//        {
//            Tags.Remove(id, tags);
//        }
//
//        public void RemoveTags(bool all = false, params int[] tags)
//        {
//            Tags.Remove(id, all, tags);
//        }
//
//        public void RemoveTags(int tag, bool all = false)
//        {
//            Tags.Remove(id, tag, all);
//        }

        #endregion

        #region POOL

        public void Spawn(bool condition_spawned)
        {
            if (condition_spawned)
            {
                state.released = false;
                Setup();
                OnEnable();
                OnSpawned();

                Timer.Add(Time.DeltaTimeFixed, () =>
                {
                    PostSetup();

                    state.initialized = true;
                });
            }
        }

        protected virtual void OnSpawned()
        {
        }

        #endregion
    }
}