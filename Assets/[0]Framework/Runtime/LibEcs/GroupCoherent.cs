//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/23/2018

using System;

namespace Homebrew
{
    public class GroupCoherent<T> : GroupBase where T : IComponent, new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        private Storage<T> storage = Storage<T>.Instance;


        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity)) return;


            if (entities.Length <= length)
            {
                int len = length << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
            }


            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];


            if (Added != null)
                Added(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);

            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];
                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;


                if (!storage.HasComponent(e.entity)) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;
                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                }

                int entityID = e.entity;
                indexLast = length++;


                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
            }
        }

        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);


            int l = --length;

            int next = i + 1;
            int size = l - i;


            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
        }
    }

    public class GroupCoherent<T, Y> : GroupBase where T : IComponent, new() where Y : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;


        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) || !storage2.HasComponent(entity)) return;
            if (entities.Length <= length)
            {
                int len = length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
            }


            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];


            if (Added != null)
                Added(indexLast);
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
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;


                if (!storage.HasComponent(e.entity) || !storage2.HasComponent(e.entity)) continue;


                if (length == entities.Length)
                {
                    int len = length << 1;

                    Array.Resize(ref entities, len);
                    Array.Resize(ref component, len);
                    Array.Resize(ref component2, len);
                }

                int entityID = e.entity;
                indexLast = length++;


                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
            }
        }

        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;

            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
            component2 = new Y[EngineSettings.MinComponents];
        }
    }

    public class GroupCoherent<T, Y, U> : GroupBase where T : IComponent, new() where Y : new() where U : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;

        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;

            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
        }

        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity)
            ) return;


            if (entities.Length <= length)
            {
                int len = length << 1;
                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
            }


            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];

            if (Added != null)
                Added(indexLast);
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
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;

                int entityID = e.entity;

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
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
        }
    }

    public class GroupCoherent<T, Y, U, I> : GroupBase where T : IComponent, new()
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
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;

            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
        }

        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
            {
                int len = length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
            }

            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];


            if (Added != null)
                Added(indexLast);
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


                int entityID = e.entity;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID)
                ) continue;


                if (composition.include.Length > 0)
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
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
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
        }
    }

    public class GroupCoherent<T, Y, U, I, O> : GroupBase where T : IComponent, new()
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


        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity) ||
                !storage5.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
            {
                int len = entity == 0 ? EngineSettings.MinComponents : length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
            }

            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];
            component5[indexLast] = storage5.components[entity];


            if (Added != null)
                Added(indexLast);
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
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;
                int entityID = e.entity;
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
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;

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
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
            component5 = new O[EngineSettings.MinComponents];
        }
    }


    public class GroupCoherent<T, Y, U, I, O, P> : GroupBase where T : IComponent, new()
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


        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity) ||
                !storage5.HasComponent(entity) ||
                !storage6.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
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

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];
            component5[indexLast] = storage5.components[entity];
            component6[indexLast] = storage6.components[entity];


            if (Added != null)
                Added(indexLast);
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
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;
                int entityID = e.entity;
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
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;


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
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
            component5 = new O[EngineSettings.MinComponents];
            component6 = new P[EngineSettings.MinComponents];
        }
    }


    public class GroupCoherent<T, Y, U, I, O, P, A> : GroupBase where T : IComponent, new()
                                                        where Y : new()
                                                        where U : new()
                                                        where I : new()
                                                        where O : new()
                                                        where P : new()
                                                        where A : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];
        public O[] component5 = new O[EngineSettings.MinComponents];
        public P[] component6 = new P[EngineSettings.MinComponents];
        public A[] component7 = new A[EngineSettings.MinComponents];

        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;
        Storage<O> storage5 = Storage<O>.Instance;
        Storage<P> storage6 = Storage<P>.Instance;
        Storage<A> storage7 = Storage<A>.Instance;

        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity) ||
                !storage5.HasComponent(entity) ||
                !storage6.HasComponent(entity) ||
                !storage7.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
            {
                int len = length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
                Array.Resize(ref component6, len);
                Array.Resize(ref component7, len);
            }

            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];
            component5[indexLast] = storage5.components[entity];
            component6[indexLast] = storage6.components[entity];
            component7[indexLast] = storage7.components[entity];


            if (Added != null)
                Added(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);
            storage6.groups.Add(this);
            storage7.groups.Add(this);

            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;
                int entityID = e.entity;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID) ||
                    !storage5.HasComponent(entityID) ||
                    !storage6.HasComponent(entityID) ||
                    !storage7.HasComponent(entityID)
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
                    Array.Resize(ref component7, len);
                }


                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
                component5[indexLast] = storage5.components[entityID];
                component6[indexLast] = storage6.components[entityID];
                component7[indexLast] = storage7.components[entityID];
            }
        }


        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;


            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
            Array.Copy(component5, next, component5, i, size);
            Array.Copy(component6, next, component6, i, size);
            Array.Copy(component7, next, component7, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
            component5 = new O[EngineSettings.MinComponents];
            component6 = new P[EngineSettings.MinComponents];
            component7 = new A[EngineSettings.MinComponents];
        }
    }


    public class GroupCoherent<T, Y, U, I, O, P, A, S> : GroupBase where T : IComponent, new()
                                                           where Y : new()
                                                           where U : new()
                                                           where I : new()
                                                           where O : new()
                                                           where P : new()
                                                           where A : new()
                                                           where S : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];
        public O[] component5 = new O[EngineSettings.MinComponents];
        public P[] component6 = new P[EngineSettings.MinComponents];
        public A[] component7 = new A[EngineSettings.MinComponents];
        public S[] component8 = new S[EngineSettings.MinComponents];

        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;
        Storage<O> storage5 = Storage<O>.Instance;
        Storage<P> storage6 = Storage<P>.Instance;
        Storage<A> storage7 = Storage<A>.Instance;
        Storage<S> storage8 = Storage<S>.Instance;

        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity) ||
                !storage5.HasComponent(entity) ||
                !storage6.HasComponent(entity) ||
                !storage7.HasComponent(entity) ||
                !storage8.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
            {
                int len = length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
                Array.Resize(ref component6, len);
                Array.Resize(ref component7, len);
                Array.Resize(ref component8, len);
            }

            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];
            component5[indexLast] = storage5.components[entity];
            component6[indexLast] = storage6.components[entity];
            component7[indexLast] = storage7.components[entity];
            component8[indexLast] = storage8.components[entity];


            if (Added != null)
                Added(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);
            storage6.groups.Add(this);
            storage7.groups.Add(this);
            storage8.groups.Add(this);

            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;
                int entityID = e.entity;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID) ||
                    !storage5.HasComponent(entityID) ||
                    !storage6.HasComponent(entityID) ||
                    !storage7.HasComponent(entityID) ||
                    !storage8.HasComponent(entityID)
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
                    Array.Resize(ref component7, len);
                    Array.Resize(ref component8, len);
                }


                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
                component5[indexLast] = storage5.components[entityID];
                component6[indexLast] = storage6.components[entityID];
                component7[indexLast] = storage7.components[entityID];
                component8[indexLast] = storage8.components[entityID];
            }
        }


        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;


            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
            Array.Copy(component5, next, component5, i, size);
            Array.Copy(component6, next, component6, i, size);
            Array.Copy(component7, next, component7, i, size);
            Array.Copy(component8, next, component8, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
            component5 = new O[EngineSettings.MinComponents];
            component6 = new P[EngineSettings.MinComponents];
            component7 = new A[EngineSettings.MinComponents];
            component8 = new S[EngineSettings.MinComponents];
        }
    }


    public class GroupCoherent<T, Y, U, I, O, P, A, S, D> : GroupBase where T : IComponent, new()
                                                              where Y : new()
                                                              where U : new()
                                                              where I : new()
                                                              where O : new()
                                                              where P : new()
                                                              where A : new()
                                                              where S : new()
                                                              where D : new()
    {
        public T[] component = new T[EngineSettings.MinComponents];
        public Y[] component2 = new Y[EngineSettings.MinComponents];
        public U[] component3 = new U[EngineSettings.MinComponents];
        public I[] component4 = new I[EngineSettings.MinComponents];
        public O[] component5 = new O[EngineSettings.MinComponents];
        public P[] component6 = new P[EngineSettings.MinComponents];
        public A[] component7 = new A[EngineSettings.MinComponents];
        public S[] component8 = new S[EngineSettings.MinComponents];
        public D[] component9 = new D[EngineSettings.MinComponents];
        Storage<T> storage = Storage<T>.Instance;
        Storage<Y> storage2 = Storage<Y>.Instance;
        Storage<U> storage3 = Storage<U>.Instance;
        Storage<I> storage4 = Storage<I>.Instance;
        Storage<O> storage5 = Storage<O>.Instance;
        Storage<P> storage6 = Storage<P>.Instance;
        Storage<A> storage7 = Storage<A>.Instance;
        Storage<S> storage8 = Storage<S>.Instance;
        Storage<D> storage9 = Storage<D>.Instance;

        public override void TryAdd(int entity)
        {
            if (!storage.HasComponent(entity) ||
                !storage2.HasComponent(entity) ||
                !storage3.HasComponent(entity) ||
                !storage4.HasComponent(entity) ||
                !storage5.HasComponent(entity) ||
                !storage6.HasComponent(entity) ||
                !storage7.HasComponent(entity) ||
                !storage8.HasComponent(entity) ||
                !storage9.HasComponent(entity)
            ) return;

            if (entities.Length <= length)
            {
                int len = length << 1;

                Array.Resize(ref entities, len);
                Array.Resize(ref component, len);
                Array.Resize(ref component2, len);
                Array.Resize(ref component3, len);
                Array.Resize(ref component4, len);
                Array.Resize(ref component5, len);
                Array.Resize(ref component6, len);
                Array.Resize(ref component7, len);
                Array.Resize(ref component8, len);
                Array.Resize(ref component9, len);
            }

            indexLast = length++;

            entities[indexLast] = entity;
            component[indexLast] = storage.components[entity];
            component2[indexLast] = storage2.components[entity];
            component3[indexLast] = storage3.components[entity];
            component4[indexLast] = storage4.components[entity];
            component5[indexLast] = storage5.components[entity];
            component6[indexLast] = storage6.components[entity];
            component7[indexLast] = storage7.components[entity];
            component8[indexLast] = storage8.components[entity];
            component9[indexLast] = storage9.components[entity];

            if (Added != null)
                Added(indexLast);
        }


        public override void Populate()
        {
            storage.groups.Add(this);
            storage2.groups.Add(this);
            storage3.groups.Add(this);
            storage4.groups.Add(this);
            storage5.groups.Add(this);
            storage6.groups.Add(this);
            storage7.groups.Add(this);
            storage8.groups.Add(this);
            storage9.groups.Add(this);
            for (int i = 0; i < Actor.lastID; i++)
            {
                var e = Actor.entites[i];

                if (e == null || !e.state.enabled) continue;

                if (composition.include.Length > 0)
                    if (!e.entity.Has(composition.include))
                        continue;

                if (composition.exclude.Length > 0)
                    if (e.entity.HasAny(composition.exclude))
                        continue;
                int entityID = e.entity;
                if (!storage.HasComponent(entityID) ||
                    !storage2.HasComponent(entityID) ||
                    !storage3.HasComponent(entityID) ||
                    !storage4.HasComponent(entityID) ||
                    !storage5.HasComponent(entityID) ||
                    !storage6.HasComponent(entityID) ||
                    !storage7.HasComponent(entityID) ||
                    !storage8.HasComponent(entityID) ||
                    !storage9.HasComponent(entityID)
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
                    Array.Resize(ref component7, len);
                    Array.Resize(ref component8, len);
                    Array.Resize(ref component9, len);
                }


                indexLast = length++;

                entities[indexLast] = entityID;
                component[indexLast] = storage.components[entityID];
                component2[indexLast] = storage2.components[entityID];
                component3[indexLast] = storage3.components[entityID];
                component4[indexLast] = storage4.components[entityID];
                component5[indexLast] = storage5.components[entityID];
                component6[indexLast] = storage6.components[entityID];
                component7[indexLast] = storage7.components[entityID];
                component8[indexLast] = storage8.components[entityID];
                component9[indexLast] = storage9.components[entityID];
            }
        }


        protected override void RemoveAt(int i)
        {
            if (Removed != null)
                Removed(i);

            int l    = --length;
            int next = i + 1;
            int size = l - i;


            Array.Copy(entities, next, entities, i, size);
            Array.Copy(component, next, component, i, size);
            Array.Copy(component2, next, component2, i, size);
            Array.Copy(component3, next, component3, i, size);
            Array.Copy(component4, next, component4, i, size);
            Array.Copy(component5, next, component5, i, size);
            Array.Copy(component6, next, component6, i, size);
            Array.Copy(component7, next, component7, i, size);
            Array.Copy(component8, next, component8, i, size);
            Array.Copy(component9, next, component9, i, size);
        }


        protected override void OnDispose()
        {
            component = new T[EngineSettings.MinComponents];
            component2 = new Y[EngineSettings.MinComponents];
            component3 = new U[EngineSettings.MinComponents];
            component4 = new I[EngineSettings.MinComponents];
            component5 = new O[EngineSettings.MinComponents];
            component6 = new P[EngineSettings.MinComponents];
            component7 = new A[EngineSettings.MinComponents];
            component8 = new S[EngineSettings.MinComponents];
            component9 = new D[EngineSettings.MinComponents];
        }
    }
}