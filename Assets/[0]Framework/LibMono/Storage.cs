/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;


namespace Homebrew
{
    public interface IStorageType
    {
        object TryGet(Type t, int id);
    }

    public class Storage<T> : IStorageType where T : new()
    {
        public static readonly Storage<T> Instance = new Storage<T>();
        public T[] components = new T[EngineSettings.MinComponents];
        public bool[] entityHasComponent = new bool[EngineSettings.MinComponents];
        public int length = EngineSettings.MinComponents;


        public List<GroupBase> groups = new List<GroupBase>();

        Storage()
        {
            ProcessingEntities.storageTypes.Add(this);
        }

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

            var len = groups.Count;
            for (var i = 0; i < len; i++)
            {
                groups[i].TryAddVirtually(entityID);
            }


            return component;
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

            var len = groups.Count;
            for (var i = 0; i < len; i++)
            {
                groups[i].TryAddEntity(entityID);
            }


            return component;
        }

        public T TryAdd(int entityID)
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

            var len = groups.Count;
            for (var i = 0; i < len; i++)
            {
                groups[i].TryAddEntity(entityID);
            }

            return components[entityID];
        }

        public void Remove(int entityID)
        {
            if (!entityHasComponent[entityID]) return;
      
            entityHasComponent[entityID] = false;

            var len = groups.Count;
            for (var i = 0; i < len; i++)
            {
                groups[i].TryRemoveEntity(entityID);
            }
        }

        public bool HasComponent(int entityID)
        {
            return entityID >= length ? false : entityHasComponent[entityID];
        }

        public T TryGet(int entityID)
        {
            return entityID >= length ? default(T) : components[entityID];
        }

        public object TryGet(Type t, int id)
        {
            return TryGet(id);
        }
    }

    public class StorageSingle<T> : IStorageType
    {
        public static readonly StorageSingle<T> Instance = new StorageSingle<T>();
        public T component;


        public object TryGet(Type t, int id)
        {
            return component;
        }
    }
}