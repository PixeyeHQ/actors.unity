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
    public class Actor : MonoCached
    {
        public static Actor[] entites = new Actor[EngineSettings.MinEntities];
        public static Stack<int> prevID = new Stack<int>(100);
        public static int lastID;

        #region FIELDS

        [FoldoutGroup("Actor")] public int id;


        private List<Composition> compositions;
        private List<int> compositionNoTags = new List<int>();

        private Dictionary<int, int> tags = new Dictionary<int, int>(new FastComparable());
        private Dictionary<int, IData> cachedData;

        private Dictionary<int, Transform> cachedTransforms;
        private Action OnTagsChanged;

        #endregion

        #region MONO

        protected override void Awake()
        {
            OnTagsChanged = HandleTagsChanged;
            ProcessingEntities.Add(this);
            base.Awake();
        }


        public override void OnEnable()
        {
            if (state.enabled || state.requireStarter ||
                state.requireActorParent) return;


            if (state.disabled)
                ProcessingEntities.Default.CheckGroups(id, true);


            HandleEnable();
            state.released = false;
            state.disabled = false;
            state.enabled = true;

            if (ProcessingSignals.TryAddToGlobal(this))
            {
                if (signals == null)
                {
                    signals = new ProcessingSignals();
                }

                signals.Add(this);
            }


            int len = compositionNoTags.Count;
            int i;

            for (i = 0; i < len; i++)
            {
                Behavior.behaviors[compositionNoTags[i]].AddElement(id);
            }


            len = compositions != null ? compositions.Count : -1;

            for (i = 0; i < len; i++)
            {
                var composition = compositions[i];

                if (composition.changed || !composition.Contain(tags)) continue;
                composition.changed = true;
                int l = composition.ids.Count;

                for (int j = 0; j < l; j++)
                {
                    Behavior.behaviors[composition.ids[j]].AddElement(id);
                }

                l = composition.delegates.Count;
                for (int j = 0; j < l; j++)
                {
                    composition.delegates[j](true);
                }
            }


            ProcessingUpdate.Default.Add(this);
        }
//TODO: refactor

        public override void OnDisable()
        {
            if (Toolbox.isQuittingOrChangingScene() || state.released ||
                !state.enabled) return;

            state.enabled = false;
            state.disabled = true;

            ProcessingEntities.Default.CheckGroups(id, false);

            int len = compositionNoTags.Count;
            int i;

            for (i = 0; i < len; i++)
            {
                Behavior.behaviors[compositionNoTags[i]].RemoveElement(id);
            }


            len = compositions != null ? compositions.Count : -1;

            for (i = 0; i < len; i++)
            {
                var composition = compositions[i];
                if (composition.changed || !composition.Contain(tags)) continue;
                composition.changed = true;
                int l = composition.ids.Count;
                for (int j = 0; j < l; j++)
                {
                    Behavior.behaviors[composition.ids[j]].RemoveElement(id);
                }

                l = composition.delegates.Count;
                for (int j = 0; j < l; j++)
                {
                    composition.delegates[j](false);
                }
            }


            if (ProcessingSignals.TryRemoveGlobal(this))
            {
                signals?.Remove(this);
            }


            ProcessingUpdate.Default.Remove(this);

            HandleDisable();
        }

        protected override void HandleReturnToPool()
        {
            TagsClearAll();

            ProcessingEntities.Default.CheckGroups(id, false);

            int len = compositionNoTags.Count;
            int i;

            for (i = 0; i < len; i++)
            {
                Behavior.behaviors[compositionNoTags[i]].RemoveElement(id);
            }


            len = compositions != null ? compositions.Count : -1;

            for (i = 0; i < len; i++)
            {
                var composition = compositions[i];

                composition.changed = false;
                int l = composition.ids.Count;
                for (int j = 0; j < l; j++)
                {
                    Behavior.behaviors[composition.ids[j]].RemoveElement(id);
                }

                l = composition.delegates.Count;
                for (int j = 0; j < l; j++)
                {
                    composition.delegates[j](false);
                }
            }


            if (ProcessingSignals.TryRemoveGlobal(this))
            {
                signals?.Remove(this);
            }


            ProcessingUpdate.Default.Remove(this);


            base.HandleReturnToPool();
        }

        protected void OnDestroy()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;
            prevID.Push(id);


            ProcessingEntities.Default.CheckGroups(id, false);

            int len = compositionNoTags.Count;
            int i;

            for (i = 0; i < len; i++)
            {
                Behavior.behaviors[compositionNoTags[i]].RemoveElement(id);
            }


            len = compositions != null ? compositions.Count : -1;

            for (i = 0; i < len; i++)
            {
                var composition = compositions[i];

                int l = composition.ids.Count;
                for (int j = 0; j < l; j++)
                {
                    Behavior.behaviors[composition.ids[j]].RemoveElement(id);
                }

                composition.delegates.Clear();
            }


            if (ProcessingSignals.TryRemoveGlobal(this))
            {
                signals?.Remove(this);
            }


            ProcessingUpdate.Default.Remove(this);


            compositionNoTags?.Clear();
            compositions?.Clear();
            tags?.Clear();
            signals?.Dispose();
            signals = null;

            if (cachedData == null) return;

            foreach (var valuePair in cachedData)
            {
                var data = valuePair.Value as IDisposable;
                if (data != null) data.Dispose();
            }

            cachedData.Clear();
        }

        #endregion

        #region ADD/REMOVE

        public void AddCache(int key, string path)
        {
            if (cachedTransforms == null) cachedTransforms = new Dictionary<int, Transform>(2, new FastComparable());
            cachedTransforms.Add(key, Get<Transform>(path));
        }

        public Composition BindComposiiton()
        {
            var compo = new Composition();
            if (compositions == null)
            {
                compositions = new List<Composition>();
                OnTagsChanged = HandleTagsChangedComposition;
            }

            compositions.Add(compo);
            return compo;
        }


        public void Add<T>(T component, StorageType storageType = StorageType.Global) where T : IData, new()
        {
            if (storageType == StorageType.Global)
                Storage<T>.Instance.Add(component, id);
            else
            {
                if (cachedData == null)
                {
                    cachedData = new Dictionary<int, IData>(3, new FastComparable());
                    cachedData.Add(typeof(T).GetHashCode(), component);
                }
                else
                {
                    cachedData.Add(typeof(T).GetHashCode(), component);
                }
            }

            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }
        }

        public T Add<T>(StorageType storageType = StorageType.Global) where T : class, new()
        {
            if (typeof(T).IsSubclassOf(typeof(Behavior)))
            {
                int key = typeof(T).GetHashCode();
                Behavior behavior;
                if (!Behavior.behaviors.TryGetValue(key, out behavior))
                {
                    behavior = new T() as Behavior;
                    Behavior.behaviors.Add(key, behavior);
                }

                compositionNoTags.Add(key);
                return behavior as T;
            }

            T component;
            if (storageType == StorageType.Global)
                component = Storage<T>.Instance.Add(id);
            else
            {
                component = new T();
                if (cachedData == null)
                {
                    cachedData = new Dictionary<int, IData>(3, new FastComparable());
                    cachedData.Add(typeof(T).GetHashCode(), component as IData);
                }
                else
                {
                    cachedData.Add(typeof(T).GetHashCode(), component as IData);
                }
            }

            var setupable = component as ISetup;
            if (setupable != null)
            {
                setupable.Setup(this);
            }

            return component;
        }


        public void Bind<T>() where T : new()
        {
            Storage<T>.Instance.Add(id);
        }

        public void Unbind<T>() where T : new()
        {
            Storage<T>.Instance.Remove(id);
        }


        public void Remove<T>() where T : new()
        {
            int key = typeof(T).GetHashCode();
            if (typeof(T).IsSubclassOf(typeof(Behavior)))
            {
                Behavior behavior;

                if (!Behavior.behaviors.TryGetValue(key, out behavior)) return;
                behavior.RemoveElement(id);
                compositionNoTags.Remove(key);
                return;
            }


            IData data;
            if (!cachedData.TryGetValue(key, out data)) return;
            var disposable = data as IDisposable;
            if (disposable != null) disposable.Dispose();
            cachedData.Remove(key);
        }

        #endregion

        #region  GET

        public T Get<T>(StorageType stype = StorageType.Global) where T : new()
        {
            var obj = stype == StorageType.Global
                ? Storage<T>.Instance.TryGet(id)
                : (T) cachedData[typeof(T).GetHashCode()];

            return obj != null
                ? obj
                : typeof(T).IsSubclassOf(typeof(UnityEngine.Object))
                    ? GetComponentInChildren<T>()
                    : default(T);
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

        void HandleTagsChangedComposition()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;
            if (state.disabled) return;


            int len = compositions.Count;

            for (int i = 0; i < len; i++)
            {
                var composition = compositions[i];

                if (composition.Contain(tags))
                {
                    if (composition.changed) continue;

                    int count = composition.ids.Count;
                    composition.changed = true;
                    for (int j = 0; j < count; j++)
                    {
                        Behavior.behaviors[composition.ids[j]].AddElement(id);
                    }

                    int l = composition.delegates.Count;
                    for (int j = 0; j < l; j++)
                    {
                        composition.delegates[j](true);
                    }
                }
                else
                {
                    if (!composition.changed) continue;
                    composition.changed = false;
                    int count = composition.ids.Count;
                    for (int j = 0; j < count; j++)
                    {
                        Behavior.behaviors[composition.ids[j]].RemoveElement(id);
                    }

                    int l = composition.delegates.Count;
                    for (int j = 0; j < l; j++)
                    {
                        composition.delegates[j](false);
                    }
                }
            }

            var groups = ProcessingEntities.Default.GroupsBase;
            len = ProcessingEntities.Default.groupLength;

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

        void HandleTagsChanged()
        {
            if (Toolbox.isQuittingOrChangingScene()) return;
            if (state.disabled) return;


            
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
    
        public bool TagsHaveAny(params int[] filter)
        {
            for (int i = 0; i < filter.Length; i++)
            {
                return tags.ContainsKey(filter[i]);
            }

            return false;
        }

        public bool TagsHave(params int[] filter)
        {
            for (int i = 0; i < filter.Length; i++)
            {
                if (!tags.ContainsKey(filter[i])) return false;
            }

            return true;
        }

        public bool TagsHave(int val)
        {
            return tags.ContainsKey(val);
        }


        public void TagsRemove(params int[] ids)
        {
            bool tagsChanged = false;
            foreach (int index in ids)
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
            OnTagsChanged();
        }

        public void TagsClearAll()
        {
            tags.Clear();
        }

        public void TagsRemove(int id, bool all = false)
        {
            int val;
            if (!tags.TryGetValue(id, out val)) return;
            val = all ? 0 : Mathf.Max(0, val - 1);

            if (val == 0)
            {
                tags.Remove(id);
                OnTagsChanged();
            }
            else tags[id] = val;
        }

    

        public void TagsAdd(params int[] ids)
        {
            bool c = false;
            foreach (int index in ids)
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

            OnTagsChanged();
        }

        public void TagsAdd(int id)
        {
            if (tags.ContainsKey(id))
            {
                tags[id] += 1;

                return;
            }

            tags.Add(id, 1);

            OnTagsChanged();
        }

        #endregion
    }
}