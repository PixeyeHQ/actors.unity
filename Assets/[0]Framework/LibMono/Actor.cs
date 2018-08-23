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
        public static int prevID = -1;
        public static int lastID;

        #region FIELDS

        [FoldoutGroup("Actor")] public int id;
        [FoldoutGroup("Actor")] public Blueprint blueprint;

        public Dictionary<int, int> tags;

        protected List<Composition> compositions;
        protected List<int> compositionNoTags = new List<int>();

        #endregion

        #region MONO

        protected override void Awake()
        {
            var len = entites.Length;
            if (lastID == len)
            {
                Array.Resize(ref entites, Mathf.Clamp(lastID << 1, 0, 1000000));
            }

            if (prevID != -1)
            {
                id = prevID;
                prevID = -1;
                entites[id] = this;
            }
            else
            {
                id = lastID;
                entites[lastID++] = this;
            }


            base.Awake();
        }

        public override void OnEnable()
        {
            if (state.Contain(EntityState.Enabled) || state.Contain(EntityState.RequireStarter) ||
                state.Contain(EntityState.RequireActorParent)) return;


            if (state.Contain(EntityState.Disabled))
                ProcessingEntities.Default.CheckGroups(id, true);
            state &= ~EntityState.Disabled;
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


            if (compositions != null)
                foreach (var composition in compositions)
                {
                    if (composition.changed || !composition.Equals(this)) continue;
                    composition.changed = true;
                    foreach (var i in composition.ids)
                    {
                        AddToBehavior(i);
                    }
                }


            foreach (var i in compositionNoTags)
            {
                AddToBehavior(i);
            }

            ProcessingUpdate.Default.Add(this);

            HandleEnable();

            //     
        }

        public override void OnDisable()
        {
            if (Toolbox.isQuittingOrChangingScene() || !state.Contain(EntityState.Enabled)) return;


            state &= ~EntityState.Enabled;
            state |= EntityState.Disabled;
            ProcessingEntities.Default.CheckGroups(id, false);


            if (compositions != null)
                foreach (var composition in compositions)
                {
                    if (!composition.changed) continue;
                    composition.changed = false;
                    foreach (var i in composition.ids)
                    {
                        RemoveFromBehavior(i);
                    }
                }

            foreach (var i in compositionNoTags)
            {
                RemoveFromBehavior(i);
            }

            if (ProcessingSignals.TryRemoveGlobal(this))
            {
                signals?.Remove(this);
            }


            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        protected virtual void OnDestroy()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;

            ProcessingEntities.Default.CheckGroups(id, false);

            ProcessingUpdate.Default.Remove(this);
            signals?.Remove(this);

            prevID = id;
            state |= EntityState.Released;

            foreach (var i in compositionNoTags)
            {
                RemoveFromBehavior(i);
            }

            if (compositions != null)
                foreach (var composition in compositions)
                {
                    foreach (var i in composition.ids)
                    {
                        RemoveFromBehavior(i);
                    }
                }


            tags?.Clear();
            signals?.Dispose();
            signals = null;
        }

        #endregion

        #region ADD/REMOVE

        public Composition BindComposiiton()
        {
            var compo = new Composition();
            if (compositions == null) compositions = new List<Composition>();
            compositions.Add(compo);
            return compo;
        }


        public T Add<T>(T component) where T : new()
        {
            component = Storage<T>.Instance.Add(component, id);
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            return component;
        }


        private void AddToBehavior(int key)
        {
            Behavior.behaviors[key].AddElement(id);
        }

        private void RemoveFromBehavior(int key)
        {
            Behavior.behaviors[key].RemoveElement(id);
        }

        public T Add<T>() where T : new()
        {
            if (typeof(T).IsSubclassOf(typeof(Behavior)))
            {
                var key = typeof(T).GetHashCode();
                Behavior behavior;
                if (Behavior.behaviors.TryGetValue(key, out behavior))
                {
                    behavior.AddElement(id);
                }
                else
                {
                    compositionNoTags.Add(key);
                    behavior = new T() as Behavior;
                    Behavior.behaviors.Add(key, behavior);
                }

                return default(T);
            }

            var component = Storage<T>.Instance.TryAdd(id);
            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            return component;
        }

        public void Remove<T>() where T : new()
        {
            if (typeof(T).IsSubclassOf(typeof(Behavior)))
            {
                Behavior behavior;
                var key = typeof(T).GetHashCode();
                if (Behavior.behaviors.TryGetValue(key, out behavior))
                {
                    behavior.RemoveElement(id);
                    compositionNoTags.Remove(key);
                }

                return;
            }

            Storage<T>.Instance.Remove(id);
        }

        #endregion

        #region  GET

        public T Get<T>() where T : new()
        {
            var obj = Storage<T>.Instance.TryGet(id);
            return obj != null
                ? obj
                : typeof(T).IsSubclassOf(typeof(UnityEngine.Object))
                    ? GetComponentInChildren<T>()
                    : default(T);
        }

        public T Get<T>(string path)
        {
            if (path == string.Empty) return GetComponentInChildren<T>();
            var o = selfTransform.Find(path);
            return o == null ? default(T) : o.GetComponent<T>();
        }

        public object Get(Type t)
        {
            object obj;

            if (t == typeof(Component))
                return selfTransform.GetComponentInChildren(t);

            var len = ProcessingEntities.storageTypes.Count;
            for (var i = 0; i < len; i++)
            {
                obj = ProcessingEntities.storageTypes[i].TryGet(t, id);
                if (obj != null)
                    return obj;
            }


            return null;
        }

        #endregion


        #region METHODS

        public void BindTags()
        {
            tags = new Dictionary<int, int>(new FastDict());
        }

        public override void SetupAfterStarter()
        {
            base.SetupAfterStarter();

            var childs = GetComponentsInChildren<MonoCached>();

            for (var i = 1; i < childs.Length; i++)
            {
                childs[i].actorParent = this;
                childs[i].SetupAfterActor();
            }
        }

        void HandleTagsChanged()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;


            var len = compositions != null ? compositions.Count : 0;

            for (var i = 0; i < len; i++)
            {
                var composition = compositions[i];

                if (composition.Equals(this))
                {
                    if (composition.changed) continue;

                    var count = composition.ids.Count;
                    composition.changed = true;
                    for (var j = 0; j < count; j++)
                    {
                        AddToBehavior(composition.ids[j]);
                    }
                }
                else
                {
                    if (!composition.changed) continue;
                    composition.changed = false;
                    var count = composition.ids.Count;
                    for (var j = 0; j < count; j++)
                    {
                        RemoveFromBehavior(composition.ids[j]);
                    }
                }
            }

            var groups = ProcessingEntities.Default.GroupsBase;
            len = ProcessingEntities.Default.groupCount;


            for (var i = 0; i < len; i++)
            {
                groups[i].ChangeTags(id);
            }

            groups = ProcessingEntities.Default.GroupsActors;
            len = ProcessingEntities.Default.groupCountActors;
            for (var i = 0; i < len; i++)
            {
                groups[i].ChangeTags(id);
            }
        }

        public virtual void Spawn(bool arg)
        {
        }

        #endregion


        #region TAGS

        public bool HasTagAny(params int[] filter)
        {
            for (var i = 0; i < filter.Length; i++)
            {
                if (tags.ContainsKey(filter[i])) return true;
            }

            return false;
        }

        public bool HasTags(params int[] filter)
        {
            for (var i = 0; i < filter.Length; i++)
            {
                if (!tags.ContainsKey(filter[i])) return false;
            }

            return true;
        }

        public bool HasTag(int val)
        {
            return tags.ContainsKey(val);
        }


        public void RemoveTags(params int[] ids)
        {
            var tagsChanged = false;
            foreach (var index in ids)
            {
                int val;
                if (!tags.TryGetValue(index, out val)) continue;
                val = Mathf.Max(0, val - 1);

                if (val == 0)
                {
                    tags.Remove(index);
                    tagsChanged = true;
                }
                else tags[index] = val;
            }

            if (tagsChanged == false) return;
            HandleTagsChanged();
        }

        public void RemoveTags(int id, bool all = false)
        {
            int val;
            if (!tags.TryGetValue(id, out val)) return;
            val = all ? 0 : Mathf.Max(0, val - 1);

            if (val == 0)
            {
                tags.Remove(id);
                HandleTagsChanged();
            }
            else tags[id] = val;
        }


        public void AddTags(params int[] ids)
        {
            var c = false;
            foreach (var index in ids)
            {
                if (tags.ContainsKey(index))
                {
                    tags[index] += 1;
                    continue;
                }


                tags.Add(index, 1);
                c = true;
            }

            if (!c) return;

            HandleTagsChanged();
        }

        public void AddTag(int id)
        {
            if (tags.ContainsKey(id))
            {
                tags[id] += 1;

                return;
            }

            tags.Add(id, 1);

            HandleTagsChanged();
        }

        #endregion
    }
}