/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Homebrew
{
    public abstract class Storage
    {
        public static List<Storage> all = new List<Storage>(40);
        public abstract void Remove(int entityID);
        internal abstract void RemoveNoCheck(int entityID);
        public abstract void Deploy(int entityID);
    }

    public class Storage<T> : Storage where T : new()
    {
        public static readonly Storage<T> Instance = new Storage<T>();
        public T[] components = new T[EngineSettings.MinComponents];

        public int[] tags = null;

        public bool[] entityHasComponent = new bool[EngineSettings.MinComponents];

        public List<GroupBase> groups = new List<GroupBase>();

        public Storage()
        {
            all.Add(this);
            var type = typeof(T);
            var atr  = type.GetCustomAttribute<TagRequireAttribute>();
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

        public T Add(T component, int entityID)
        {
            if (entityID >= components.Length)
            {
                var l = entityID << 1;

                Array.Resize(ref components, l);
                Array.Resize(ref entityHasComponent, l);
            }


            components[entityID] = component;
            entityHasComponent[entityID] = true;

            if (tags != null)
            {
                entityID.Add(tags);
            }

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                if (gr.CheckTags(entityID))
                {
                    gr.TryAdd(entityID);
                }
            }


            return component;
        }

        public T Add(int entityID)
        {
            if (entityID >= components.Length)
            {
                var l = entityID << 1;

                Array.Resize(ref components, l);
                Array.Resize(ref entityHasComponent, l);
            }

            if (entityHasComponent[entityID]) return components[entityID];

            if (components[entityID] == null)
                components[entityID] = new T();

            if (tags != null)
            {
                entityID.Add(tags);
            }

            entityHasComponent[entityID] = true;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                if (gr.CheckTags(entityID))
                {
                    gr.TryAdd(entityID);
                }
            }

            return components[entityID];
        }

        private T Create(int entityID)
        {
            components[entityID] = new T();
            entityHasComponent[entityID] = true;

            if (tags != null)
            {
                entityID.AddTagsRaw(tags);
            }

            return components[entityID];
        }

        private T CreateAndResize(int entityID)
        {
            var l = entityID << 1;
            Array.Resize(ref components, l);
            Array.Resize(ref entityHasComponent, l);

            components[entityID] = new T();
            entityHasComponent[entityID] = true;

            if (tags != null)
            {
                entityID.AddTagsRaw(tags);
            }

            return components[entityID];
        }

        public override void Remove(int entityID)
        {
            if (entityID >= entityHasComponent.Length) return;
            if (!entityHasComponent[entityID]) return;

            entityHasComponent[entityID] = false;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].Remove(entityID);
            }

            if (tags != null)
                entityID.Remove(tags);
        }

        internal override void RemoveNoCheck(int entityID)
        {
            if (entityID >= entityHasComponent.Length) return;
            if (!entityHasComponent[entityID]) return;

            entityHasComponent[entityID] = false;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].Remove(entityID);
            }

            if (tags != null)
                entityID.RemoveTagsRaw(tags);
        }


        public override void Deploy(int entityID)
        {
            int len = groups.Count;

            if (tags != null)
            {
                foreach (var tag in tags)
                {
                    Tags.HandleChange(entityID, tag);
                }
            }

            for (int i = 0; i < len; i++)
            {
                var gr = groups[i];

                int index = gr.GetIndex(entityID);
                if (index == -1)
                {
                    if (gr.CheckTags(entityID))
                    {
                        gr.TryAdd(entityID);
                    }
                }
            }
        }

        public bool HasComponent(int entityID)
        {
            return entityID >= components.Length ? false : entityHasComponent[entityID];
        }

        public T TryGet(int entityID)
        {
            return entityID >= components.Length || !entityHasComponent[entityID] ? default(T) : components[entityID];
        }

        public T GetOrCreate(int entityID)
        {
            if (entityID >= components.Length)
                return CreateAndResize(entityID);
            if (components[entityID] == null)
                return Create(entityID);
            entityHasComponent[entityID] = true;

            if (tags != null)
            {
                entityID.AddTagsRaw(tags);
            }

            return components[entityID];
        }
    }
}