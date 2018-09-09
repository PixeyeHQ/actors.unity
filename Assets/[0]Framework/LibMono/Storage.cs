/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
 

namespace Homebrew
{
    public enum StorageType
    {
        Local = 0,
        Global = 1,
    }

    public class Storage<T> where T : new()
    {
        public static readonly Storage<T> Instance = new Storage<T>();
        public T[] components = new T[EngineSettings.MinComponents];
        public bool[] entityHasComponent = new bool[EngineSettings.MinComponents];
        public int length = EngineSettings.MinComponents;


        public List<GroupBase> groups = new List<GroupBase>();


        public T AddVirtual(T component, int entityID)
        {
            if (entityID >= length)
            {
                length = entityID << 1;

                Array.Resize(ref components, length);
                Array.Resize(ref entityHasComponent, length);
            }

            components[entityID] = component;
            entityHasComponent[entityID] = true;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].AddVirtually(entityID);
            }


            return component;
        }

        public T AddVirtual(int entityID)
        {
            
            if (entityHasComponent[entityID]) return components[entityID];

            if (entityID >= length)
            {
                length = entityID << 1;

                Array.Resize(ref components, length);
                Array.Resize(ref entityHasComponent, length);
            }

            if (components[entityID] == null)
                components[entityID] = new T();

            entityHasComponent[entityID] = true;
            

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].AddVirtually(entityID);
            }


            return components[entityID];
        }
        
        
        
        public T Add(T component, int entityID)
        {
            if (entityID >= length)
            {
                length = entityID << 1;

                Array.Resize(ref components, length);
                Array.Resize(ref entityHasComponent, length);
            }


            components[entityID] = component;
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


            return component;
        }

        public T Add(int entityID)
        {
            if (entityHasComponent[entityID]) return components[entityID];

            if (entityID >= length)
            {
                length = entityID << 1;

                Array.Resize(ref components, length);
                Array.Resize(ref entityHasComponent, length);
            }

            if (components[entityID] == null)
                components[entityID] = new T();

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

        public void Remove(int entityID)
        {
            if (!entityHasComponent[entityID]) return;

            entityHasComponent[entityID] = false;

            int len = groups.Count;
            for (int i = 0; i < len; i++)
            {
                groups[i].Remove(entityID);
            }
        }

        public bool HasComponent(int entityID)
        {
            return entityID >= length ? false : entityHasComponent[entityID];
        }


        public T Get(int entityID)
        {
            return components[entityID];
        }

        public T TryGet(int entityID)
        {
            return entityID >= length ? default(T) : components[entityID];
        }


        public bool TryGet(int entityID, out T val)
        {
            if (entityID >= length)
            {
                val = default(T);
                return false;
            }

            val = components[entityID];
            return true;
        }
    }
}