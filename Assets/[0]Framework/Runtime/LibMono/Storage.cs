/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Homebrew
{
    public abstract class Storage
    {
        public static List<Storage> all = new List<Storage>(40);
        public abstract bool HasComponent(int entity);
        public abstract void Remove(int entity);
        internal abstract void RemoveNoCheck(int entity);
        public abstract void Deploy(int entity);
    }

    public class Storage<T> : Storage where T : new()
    {
        public static readonly Storage<T> Instance = new Storage<T>();
        public T[] components = new T[EngineSettings.MinComponents];

        public int[] tags;

        public bool[] entityHasComponent = new bool[EngineSettings.MinComponents];

        public List<GroupBase> groups = new List<GroupBase>(3);

        public Storage()
        {
            all.Add(this);
            var type = typeof(T);
            var atr  = type.GetCustomAttribute<RequireTagsAttribute>();
            if (atr == null) return;
            tags = atr.tags;
        }

        internal T AddWithNoCheck(T component, int entityID)
        {
            if (entityID >= components.Length)
            {
                var l = entityID << 1;

                Array.Resize(ref components, l);
                Array.Resize(ref entityHasComponent, l);
            }

            if (tags != null)
            {
                entityID.AddTagsRaw(tags);
            }

            components[entityID] = component;
            entityHasComponent[entityID] = true;

            return component;
        }

        public T Add(T component, int entity)
        {
            if (entity >= components.Length)
            {
                var l = entity << 1;

                Array.Resize(ref components, l);
                Array.Resize(ref entityHasComponent, l);
            }


            components[entity] = component;
            entityHasComponent[entity] = true;

            if (tags != null)
            {
                entity.Add(tags);
            }

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                if (gr.CheckTags(entity))
                {
                    gr.TryAdd(entity);
                }
            }


            return component;
        }

        public T Add(int entity)
        {
            if (entity >= components.Length)
            {
                var l = entity << 1;

                Array.Resize(ref components, l);
                Array.Resize(ref entityHasComponent, l);
            }

            if (entityHasComponent[entity]) return components[entity];

            if (components[entity] == null)
                components[entity] = new T();

            if (tags != null)
            {
                entity.Add(tags);
            }

            entityHasComponent[entity] = true;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                if (gr.CheckTags(entity))
                {
                    gr.TryAdd(entity);
                }
            }


            return components[entity];
        }

        private T Create(int entity)
        {
            components[entity] = new T();
            entityHasComponent[entity] = true;

            if (tags != null)
            {
                entity.AddTagsRaw(tags);
            }

            return components[entity];
        }

        private T CreateAndResize(int entity)
        {
            var l = entity << 1;
            Array.Resize(ref components, l);
            Array.Resize(ref entityHasComponent, l);

            components[entity] = new T();
            entityHasComponent[entity] = true;

            if (tags != null)
            {
                entity.AddTagsRaw(tags);
            }

            return components[entity];
        }


        public override void Remove(int entity)
        {
            if (Toolbox.applicationIsQuitting) return;
            if (entity >= entityHasComponent.Length) return;
            if (!entityHasComponent[entity]) return;


            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].Remove(entity);
            }

            if (tags != null)
            {
                entity.Remove(tags);
            }


            entityHasComponent[entity] = false;
        }

        internal override void RemoveNoCheck(int entity)
        {
            if (Toolbox.applicationIsQuitting) return;
            if (entity >= entityHasComponent.Length) return;
            if (!entityHasComponent[entity]) return;
 
            entityHasComponent[entity] = false;
 
            if (tags != null)
                entity.RemoveTagsRaw(tags);
        }


        public override void Deploy(int entity)
        {
            int len = groups.Count;

            if (tags != null)
            {
                foreach (var tag in tags)
                {
                    Tags.HandleChange(entity, tag);
                }
            }

            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                int index = gr.GetIndex(entity);
                if (index == -1)
                {
                    if (gr.CheckTags(entity))
                    {
                        gr.TryAdd(entity);
                    }
                }
            }
        }

        public override bool HasComponent(int entity)
        {
            return entity >= components.Length ? false : entityHasComponent[entity];
        }

        public T TryGet(int entity)
        {
            return entity >= components.Length || !entityHasComponent[entity] ? default(T) : components[entity];
        }

        public T GetOrCreate(int entity)
        {
            if (entity >= components.Length)
                return CreateAndResize(entity);
            if (components[entity] == null)
                return Create(entity);
            entityHasComponent[entity] = true;

            if (tags != null)
            {
                entity.AddTagsRaw(tags);
            }

            return components[entity];
        }
    }
}