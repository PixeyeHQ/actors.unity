/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:32 PM
================================================================*/

using System;
using UnityEngine;


namespace Homebrew
{
    public abstract class GroupBase : IDisposable
    {
        public int length;

        public int[] entities = new int[EngineSettings.MinEntities];
        public Composition composition;


        public Action<int> OnAdded;
        public Action<int> OnRemoved;
        public Action<int, int> OnTagsChanged;

        protected int indexLast;

        public T Get<T>(int index) where T : new()
        {
            return Storage<T>.Instance.TryGet(entities[index]);
        }

        public void TagsChanged(int entityID)
        {
            int index = GetIndex(entityID);
            var actor = Actor.entites[entityID];

            if (index == -1)
            {
                if (composition.include.Length > 0 && !actor.TagsHave(composition.include)) return;
                if (actor.TagsHaveAny(composition.exclude)) return;

                TryAdd(entityID);
            }
            else
            {
                if (OnTagsChanged != null)
                    OnTagsChanged(index, entityID);

                if (composition.include.Length > 0 && !actor.TagsHave(composition.include) ||
                    actor.TagsHaveAny(composition.exclude))
                {
                    RemoveAt(index);
                }
            }
        }

        public int GetIndex(int id)
        {
            for (int i = 0; i < length; i++)
            {
                if (entities[i] != id) continue;
                return i;
            }

            return -1;
        }


        public int GetID(int id)
        {
            return entities[id];
        }

        public Actor GetActor(int id)
        {
            return Actor.entites[entities[id]];
        }

        public bool CheckTags(int entityID)
        {
            var entity = Actor.entites[entityID];

            if (composition.include.Length > 0 && !entity.TagsHave(composition.include))
                return false;

            return composition.exclude.Length <= 0 || !entity.TagsHaveAny(composition.exclude);
        }

        public abstract void AddVirtually(int entityID);

        public abstract void TryAdd(int entityID);

        //TODO : check remove by component mask
        public void Remove(int entityID)
        {
            int i = GetIndex(entityID);
            if (i == -1) return;
            RemoveAt(i);
        }


        public abstract void Populate();
        protected abstract void RemoveAt(int i);


        public void Dispose()
        {
            OnAdded = null;
            OnRemoved = null;
            length = 0;
            entities = new int[EngineSettings.MinEntities];

            OnDispose();
        }

        protected abstract void OnDispose();
    }

    public class Group : GroupBase
    {
        public override void AddVirtually(int entityID)
        {
        }

        public override void TryAdd(int entityID)
        {
            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
            }

            indexLast = length++;


            entities[indexLast] = entityID;

            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;

                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);


                entities.InsertCheck(e.id, ref length, ref indexLast);
                Array.Copy(entities, indexLast, entities, indexLast + 1, length - indexLast - 1);
                entities[indexLast] = e.id;
            }
        }

        protected override void RemoveAt(int i)
        {
            int l = length--;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, i + 1, entities, i, l - i);
        }

        protected override void OnDispose()
        {
        }
    }

    public class Group<T> : GroupBase where T : IComponent, new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        private Storage<T> storage = Storage<T>.Instance;

        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID)) return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
            }

            indexLast = length++;


            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID)) return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
            }


            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);


            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;


                if (!storage.HasComponent(e.id)) continue;


                if (length == entities.Length)
                {
                    int len = (length << 1) + 1;
                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                }

                int entityID = e.id;
                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];


                if (OnAdded != null)
                    OnAdded(indexLast);
            }
        }

        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;

            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }

    public class Group<T, Y> : GroupBase where T : IComponent, new() where Y : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;


        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID))
                return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID) || !storage2.HasComponent(entityID)) return;
            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);


            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e == null || !e.state.enabled) continue;
                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;


                if (!storage.HasComponent(e.id) || !storage2.HasComponent(e.id)) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                }

                int entityID = e.id;
                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
            }
        }

        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }

    public class Group<T, Y, U> : GroupBase where T : IComponent, new() where Y : new() where U : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;

        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
        }

        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID)
            ) return;


            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID)
            ) return;


            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len + 1);
                Array.Resize(ref component, len + 1);
                Array.Resize(ref component2, len + 1);
                Array.Resize(ref component3, len + 1);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);


            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;

                int entityID = e.id;

                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID)
                ) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                }

                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
            }
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }

    public class Group<T, Y, U, I> : GroupBase where T : IComponent, new()
        where Y : new()
        where U : new()
        where I : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];

        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;

        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
        }

        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID)
            ) return;


            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID)
            ) return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];

            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);

            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e == null || !e.state.enabled) continue;


                int entityID = e.id;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID)
                ) continue;


                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                    Array.Resize(ref component4, len);
                }

                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
            }
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }

    public class Group<T, Y, U, I, O> : GroupBase where T : IComponent, new()
        where Y : new()
        where U : new()
        where I : new()
        where O : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];
        public O[] component5 = new O[EngineSettings.MinComponents];

        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;
        Storage<O> storage5 = Storage<O>.Instance;


        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID) ||
                !storage5.HasComponent(entityID)
            ) return;


            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];
            component5[indexLast] = storage5.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID) ||
                !storage5.HasComponent(entityID)
            ) return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];
            component5[indexLast] = storage5.components[entityID];


            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);


            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;
                int entityID = e.id;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID) ||
                    !storage5.HasComponent(entityID)
                ) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                    Array.Resize(ref component4, len);
                    Array.Resize(ref component5, len);
                }


                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
                component5[indexLast] = storage5.components[entityID];
            }
        }


        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
            Array.Copy(component5, next, component5, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }


    public class Group<T, Y, U, I, O, P> : GroupBase where T : IComponent, new()
        where Y : new()
        where U : new()
        where I : new()
        where O : new()
        where P : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];
        public O[] component5 = new O[EngineSettings.MinComponents];
        public P[] component6 = new P[EngineSettings.MinComponents];

        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;
        Storage<O> storage5 = Storage<O>.Instance;
        Storage<P> storage6 = Storage<P>.Instance;

        public override void AddVirtually(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID) ||
                !storage5.HasComponent(entityID) ||
                !storage6.HasComponent(entityID)
            ) return;


            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
                Array.Resize(ref component6, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];
            component5[indexLast] = storage5.components[entityID];
            component6[indexLast] = storage6.components[entityID];

            if (OnAdded != null)
                OnAdded(indexLast);
        }

        public override void TryAdd(int entityID)
        {
            if (!storage.HasComponent(entityID) ||
                !storage2.HasComponent(entityID) ||
                !storage3.HasComponent(entityID) ||
                !storage4.HasComponent(entityID) ||
                !storage5.HasComponent(entityID) ||
                !storage6.HasComponent(entityID)
            ) return;

            if (entities.Length <= length)
            {
                int len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
                Array.Resize(ref component6, len);
            }

            indexLast = length++;

            entities[indexLast] = entityID;
            component[indexLast] = storage.components[entityID];
            component2[indexLast] = storage2.components[entityID];
            component3[indexLast] = storage3.components[entityID];
            component4[indexLast] = storage4.components[entityID];
            component5[indexLast] = storage5.components[entityID];
            component6[indexLast] = storage6.components[entityID];

            if (OnAdded != null)
                OnAdded(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);
            storage6.groups.Add(this);

            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.TagsHave(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.TagsHaveAny(composition.exclude))
                        continue;
                int entityID = e.id;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID) ||
                    !storage5.HasComponent(entityID) ||
                    !storage6.HasComponent(entityID)
                ) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                    Array.Resize(ref component4, len);
                    Array.Resize(ref component5, len);
                    Array.Resize(ref component6, len);
                }


                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
                component5[indexLast] = storage5.components[entityID];
                component6[indexLast] = storage6.components[entityID];
            }
        }


        protected override void RemoveAt(int i)
        {
            int l = length--;
            int next = i + 1;
            int size = l - i;
            OnRemoved?.Invoke(i);
            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
            Array.Copy(component5, next, component5, i, size);
            Array.Copy(component6, next, component6, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }
}