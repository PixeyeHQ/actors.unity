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
        public Composition Composition;


        public Action<int> OnAdded;
        public Action<int> OnRemoved;


        public void ChangeTags(int entityID)
        {
            var inGroup = false;


            for (var i = 0; i < length; i++)
            {
                if (entities[i] != entityID) continue;

                inGroup = true;
                break;
            }


            var actor = Actor.entites[entityID];


            if (!inGroup)
            {
                if (actor.HasTags(Composition.include) && !actor.HasTagAny(Composition.exclude))
                {
                    TryAddEntity(entityID, true);
                }
            }
            else
            {
                if (!actor.HasTags(Composition.include) || actor.HasTagAny(Composition.exclude))
                {
                    TryRemoveEntity(entityID);
                }
            }
        }

        public int FromVirtual(int id)
        {
            return entities[id];
        }


        public Actor From(int id)
        {
            return Actor.entites[entities[id]];
        }

        public abstract void TryAddVirtually(int entityID);
        public abstract void TryAddEntity(int entityID, bool tagsChecked = false);
        public abstract void TryRemoveEntity(int entityID);


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
        public override void TryAddVirtually(int entityID)
        {
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var entity = Actor.entites[entityID];
            if (entity.isActiveAndEnabled == false) return;

            if (!tagsChecked)
            {
                if (!entity.HasTags(Composition.include))
                    return;


                if (entity.HasTagAny(Composition.exclude))
                    return;
            }

            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
            }

            entities[length++] = entityID;
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] == entityID)
                {
                    length--;
                    Array.Copy(entities, i + 1, entities, i, length - i);
                    OnRemoved?.Invoke(i);
                    break;
                }
            }
        }


        public override void Populate()
        {
            for (var i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
 
                if (e==null||e.isActiveAndEnabled == false) continue;
                if (e.tags == null) continue;
                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);


                entities[length++] = e.id;
            }
        }

        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            length--;
        }

        protected override void OnDispose()
        {
        }
    }

    public class Group<T> : GroupBase where T : IComponent, new()
    {
        public T[] component = new T[EngineSettings.MinComponents];


        public override void TryAddVirtually(int entityID)
        {
            var storage = Storage<T>.Instance;
            if (storage.HasComponent(entityID) == false) return;
            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
            }


            entities[length] = entityID;
            component[length++] = storage.components[entityID];

            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var storage = Storage<T>.Instance;


            if (storage.HasComponent(entityID) == false) return;
            var entity = Actor.entites[entityID];
            if (entity.isActiveAndEnabled == false) return;

            if (!tagsChecked)
            {
                if (Composition.include.Length > 0)
                    if (!entity.HasTags(Composition.include))
                        return;


                if (Composition.exclude.Length > 0)
                    if (entity.HasTagAny(Composition.exclude))
                        return;
            }

            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
            }


            entities[length] = entityID;
            component[length++] = storage.components[entityID];

            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] != entityID) continue;


                length--;

                Array.Copy(entities, i + 1, entities, i, length - i);
                Array.Copy(component, i + 1, component, i, length - i);
                OnRemoved?.Invoke(i);

                break;
            }
        }


        public override void Populate()
        {
            var storage = Storage<T>.Instance;


            storage.groups.Add(this);


            for (var i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e!=null&&e.isActiveAndEnabled == false) continue;

                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;


                if (storage.HasComponent(e.id) == false) continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);

                if (length == component.Length)
                {
                    var len = length << 1;
                    Array.Resize(ref component, len);
                }

                entities[length] = e.id;

                component[length++] = storage.components[e.id];
            }
        }

        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            Array.Copy(component, i + 1, component, i, length - i);
            length--;
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


        public override void TryAddVirtually(int entityID)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;

            if (storage.HasComponent(entityID) == false) return;
            if (storage2.HasComponent(entityID) == false) return;
            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
            }


            entities[length] = entityID;
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;


            if (storage.HasComponent(entityID) == false) return;
            if (storage2.HasComponent(entityID) == false) return;
            var entity = Actor.entites[entityID];
            if (entity!=null&&entity.isActiveAndEnabled == false) return;
            if (!tagsChecked)
            {
                if (Composition.include.Length > 0)
                    if (!entity.HasTags(Composition.include))
                        return;

                if (Composition.exclude.Length > 0)
                    if (entity.HasTagAny(Composition.exclude))
                        return;
            }


            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
            }


            entities[length] = entityID;
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] == entityID)
                {
                    OnRemoved?.Invoke(i);
                    length--;
                    Array.Copy(entities, i + 1, entities, i, length - i);
                    Array.Copy(component, i + 1, component, i, length - i);
                    Array.Copy(component2, i + 1, component2, i, length - i);


                    break;
                }
            }
        }


        public override void Populate()
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;


            storage.groups.Add(this);
            storage2.groups.Add(this);


            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e.isActiveAndEnabled == false) continue;
                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;


                if (storage.HasComponent(e.id) == false) continue;
                if (storage2.HasComponent(e.id) == false) continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);

                if (length == component.Length)
                {
                    var len = length << 1;
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                }


                entities[length] = e.id;

                component2[length] = storage2.components[e.id];
                component[length++] = storage.components[e.id];
            }
        }

        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            Array.Copy(component, i + 1, component, i, length - i);
            Array.Copy(component2, i + 1, component2, i, length - i);
            length--;
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

        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            Array.Copy(component, i + 1, component, i, length - i);
            Array.Copy(component2, i + 1, component2, i, length - i);
            Array.Copy(component3, i + 1, component3, i, length - i);
            length--;
        }

        public override void TryAddVirtually(int entityID)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;


            if (storage.HasComponent(entityID) == false) return;
            if (storage2.HasComponent(entityID) == false) return;
            if (storage3.HasComponent(entityID) == false) return;


            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
            }

            entities[length] = entityID;
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;


            if (storage.HasComponent(entityID) == false) return;

            if (storage2.HasComponent(entityID) == false) return;

            if (storage3.HasComponent(entityID) == false) return;
            var entity = Actor.entites[entityID];
            if (entity.isActiveAndEnabled == false) return;

            if (!tagsChecked)
            {
                if (Composition.include.Length > 0)
                    if (!entity.HasTags(Composition.include))
                        return;

                if (Composition.exclude.Length > 0)
                    if (entity.HasTagAny(Composition.exclude))
                        return;
            }


            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
            }

            entities[length] = entityID;
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] != entityID) continue;
                OnRemoved?.Invoke(i);
                length--;
                Array.Copy(entities, i + 1, entities, i, length - i);
                Array.Copy(component, i + 1, component, i, length - i);
                Array.Copy(component2, i + 1, component2, i, length - i);
                Array.Copy(component3, i + 1, component3, i, length - i);

                break;
            }
        }


        public override void Populate()
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;


            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);


            for (var i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e!=null&&e.isActiveAndEnabled == false) continue;
                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;


                if (storage.HasComponent(e.id) == false) continue;
                if (storage2.HasComponent(e.id) == false) continue;
                if (storage3.HasComponent(e.id) == false) continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);

                if (length == component.Length)
                {
                    var len = length << 1;
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                }

                entities[length] = e.id;


                component3[length] = storage3.components[e.id];
                component2[length] = storage2.components[e.id];
                component[length++] = storage.components[e.id];
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

        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            Array.Copy(component, i + 1, component, i, length - i);
            Array.Copy(component2, i + 1, component2, i, length - i);
            Array.Copy(component3, i + 1, component3, i, length - i);
            Array.Copy(component4, i + 1, component4, i, length - i);
            length--;
        }

        public override void TryAddVirtually(int entityID)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;


            if (storage.HasComponent(entityID) == false) return;
            if (storage2.HasComponent(entityID) == false) return;
            if (storage3.HasComponent(entityID) == false) return;
            if (storage4.HasComponent(entityID) == false) return;

            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
            }

            entities[length] = entityID;
            component4[length] = storage4.components[entityID];
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;


            if (storage.HasComponent(entityID) == false) return;

            if (storage2.HasComponent(entityID) == false) return;

            if (storage3.HasComponent(entityID) == false) return;

            if (storage4.HasComponent(entityID) == false) return;
            var entity = Actor.entites[entityID];
            if (entity.isActiveAndEnabled == false) return;
            if (!tagsChecked)
            {
                if (Composition.include.Length > 0)
                    if (!entity.HasTags(Composition.include))
                        return;

                if (Composition.exclude.Length > 0)
                    if (entity.HasTagAny(Composition.exclude))
                        return;
            }


            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
            }

            entities[length] = entityID;
            component4[length] = storage4.components[entityID];
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];
            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] != entityID) continue;
                OnRemoved?.Invoke(i);
                length--;
                Array.Copy(entities, i + 1, entities, i, length - i);
                Array.Copy(component, i + 1, component, i, length - i);
                Array.Copy(component2, i + 1, component2, i, length - i);
                Array.Copy(component3, i + 1, component3, i, length - i);
                Array.Copy(component4, i + 1, component4, i, length - i);

                break;
            }
        }

        public override void Populate()
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;

            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);

            for (var i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e!=null&&e.isActiveAndEnabled == false) continue;
                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;

                if (storage.HasComponent(e.id) == false) continue;
                if (storage2.HasComponent(e.id) == false) continue;
                if (storage3.HasComponent(e.id) == false) continue;
                if (storage4.HasComponent(e.id) == false) continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);

                if (length == component.Length)
                {
                    var len = length << 1;
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                    Array.Resize(ref component4, len);
                }

                entities[length] = e.id;

                component4[length] = storage4.components[e.id];
                component3[length] = storage3.components[e.id];
                component2[length] = storage2.components[e.id];
                component[length++] = storage.components[e.id];
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


        public override void TryAddVirtually(int entityID)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;
            var storage5 = Storage<O>.Instance;


            if (storage.HasComponent(entityID) == false) return;
            if (storage2.HasComponent(entityID) == false) return;
            if (storage3.HasComponent(entityID) == false) return;
            if (storage4.HasComponent(entityID) == false) return;
            if (storage5.HasComponent(entityID) == false) return;


            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
            }

            entities[length] = entityID;
            component5[length] = storage5.components[entityID];
            component4[length] = storage4.components[entityID];
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];

            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryAddEntity(int entityID, bool tagsChecked = false)
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;
            var storage5 = Storage<O>.Instance;


            if (storage.HasComponent(entityID) == false) return;

            if (storage2.HasComponent(entityID) == false) return;

            if (storage3.HasComponent(entityID) == false) return;

            if (storage4.HasComponent(entityID) == false) return;

            if (storage5.HasComponent(entityID) == false) return;
            var entity = Actor.entites[entityID];
            if (entity.isActiveAndEnabled == false) return;
            if (!tagsChecked)
            {
                if (Composition.include.Length > 0)
                    if (!entity.HasTags(Composition.include))
                        return;

                if (Composition.exclude.Length > 0)
                    if (entity.HasTagAny(Composition.exclude))
                        return;
            }

            if (entities.Length <= length)
            {
                var len = entityID == 0 ? EngineSettings.MinComponents : entityID << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
            }

            entities[length] = entityID;
            component5[length] = storage5.components[entityID];
            component4[length] = storage4.components[entityID];
            component3[length] = storage3.components[entityID];
            component2[length] = storage2.components[entityID];
            component[length++] = storage.components[entityID];

            if (OnAdded != null)
                OnAdded(length-1);
        }

        public override void TryRemoveEntity(int entityID)
        {
            for (var i = 0; i < length; i++)
            {
                if (entities[i] != entityID) continue;
                OnRemoved?.Invoke(i);
                length--;
                Array.Copy(entities, i + 1, entities, i, length - i);
                Array.Copy(component, i + 1, component, i, length - i);
                Array.Copy(component2, i + 1, component2, i, length - i);
                Array.Copy(component3, i + 1, component3, i, length - i);
                Array.Copy(component4, i + 1, component4, i, length - i);
                Array.Copy(component5, i + 1, component5, i, length - i);

                break;
            }
        }

        public override void Populate()
        {
            var storage = Storage<T>.Instance;
            var storage2 = Storage<Y>.Instance;
            var storage3 = Storage<U>.Instance;
            var storage4 = Storage<I>.Instance;
            var storage5 = Storage<O>.Instance;

            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);


            for (var i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e!=null&&e.isActiveAndEnabled == false) continue;
                if (Composition.include.Length > 0)
                    if (!e.HasTags(Composition.include))
                        continue;

                if (Composition.exclude.Length > 0)
                    if (e.HasTagAny(Composition.exclude))
                        continue;

                if (storage.HasComponent(e.id) == false) continue;
                if (storage2.HasComponent(e.id) == false) continue;
                if (storage3.HasComponent(e.id) == false) continue;
                if (storage4.HasComponent(e.id) == false) continue;
                if (storage5.HasComponent(e.id) == false) continue;


                if (length == entities.Length)
                    Array.Resize(ref entities, length << 1);

                if (length == component.Length)
                {
                    var len = length << 1;
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                    Array.Resize(ref component3, len);
                    Array.Resize(ref component4, len);
                    Array.Resize(ref component5, len);
                }

                entities[length] = e.id;
                component5[length] = storage5.components[e.id];
                component4[length] = storage4.components[e.id];
                component3[length] = storage3.components[e.id];
                component2[length] = storage2.components[e.id];
                component[length++] = storage.components[e.id];
            }
        }


        protected override void RemoveAt(int i)
        {
            Array.Copy(entities, i + 1, entities, i, length - i);
            Array.Copy(component, i + 1, component, i, length - i);
            Array.Copy(component2, i + 1, component2, i, length - i);
            Array.Copy(component3, i + 1, component3, i, length - i);
            Array.Copy(component4, i + 1, component4, i, length - i);
            Array.Copy(component5, i + 1, component5, i, length - i);
            length--;
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }
}