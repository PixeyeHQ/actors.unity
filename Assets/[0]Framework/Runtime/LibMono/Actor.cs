/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:32 AM
================================================================*/

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
        public int entity;


        private Dictionary<int, Transform> cachedTransforms;

        #endregion

        #region METHODS

        protected override void Awake()
        {
            ProcessingEntities.Create(this);
            #if ACTORS_DEBUG
            var name = gameObject.name.Split('(')[0];
            gameObject.name = name + "_" + id;
            #endif
            base.Awake();
            AddGo();
        }

        internal override void SetupAfterStarter()
        {
            base.SetupAfterStarter();

            var childs = GetComponentsInChildren<MonoCached>();

            for (int i = 1; i < childs.Length; i++)
            {
                childs[i].actorParent = this;
                childs[i].SetupAfterActor();
            }
        }

        public override void OnEnable()
        {
            if (state.requireStarter || state.requireActorParent) return;


            state.released = false;
            state.enabled = true;

            HandleEnable();
            ProcessingEntities.Default.CheckGroups(entity, true);
        }

        public override void OnDisable()
        {
            state.enabled = false;
            state.released = true;


            ProcessingEntities.Default.CheckGroups(entity, false);

            HandleDisable();
        }

        protected void OnDestroy()
        {
            int len = Storage.all.Count;
            for (int j = 0; j < len; j++)
            {
                Storage.all[j].RemoveNoCheck(entity);
            }

            Tags.Clear(entity);
            prevID.Push(entity);
        }

        #endregion

        #region ADD/REMOVE

        public void Add(int key, string path)
        {
            if (cachedTransforms == null) cachedTransforms = new Dictionary<int, Transform>(2, new FastComparable());
            cachedTransforms.Add(key, Get<Transform>(path));
        }

        protected void Add(int tags)
        {
            Tags.AddTagsRaw(entity, tags);
        }

        protected void Add(params int[] tags)
        {
            Tags.AddTagsRaw(entity, tags);
        }

        protected void Add<T>(T component) where T : IComponent, new()
        {
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            Storage<T>.Instance.AddWithNoCheck(component, entity);
        }

        protected void Add<T>() where T : IComponent, new()
        {
            var component = Storage<T>.Instance.GetOrCreate(entity);
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }
        }

        protected void Remove<T>() where T : new()
        {
            Storage<T>.Instance.Remove(entity);
        }

        void AddGo()
        {
            var component = Storage<ComponentObject>.Instance.GetOrCreate(entity);
            component.transform = selfTransform;
            component.obj = gameObject;
            component.entityID = entity;
            Storage<ComponentObject>.Instance.AddWithNoCheck(component, entity);
        }

        #endregion

        #region  GET

        public T Get<T>() where T : IComponent, new()
        {
            return Storage<T>.Instance.TryGet(entity);
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

        #region POOL

        public void Spawn()
        {
            AddGo();
            OnEnable();
            OnSpawned();
        }


        protected virtual void OnSpawned()
        {
        }

        #endregion
    }
}