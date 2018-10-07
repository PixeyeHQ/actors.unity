/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/27/2018  10:12 PM
================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    [Serializable]
    public class Blueprint : ScriptableObject, IComponent, IStorage
    {
        protected Dictionary<int, object> components = new Dictionary<int, object>(2, new FastComparable());

        public void Add<T>(T component)
        {
            var awakeComponent = component as IAwake;
            if (awakeComponent != null)
                awakeComponent.OnAwake();

            components.Add(typeof(T).GetHashCode(), component);
        }

        public object Get(Type t)
        {
            return components[t.GetHashCode()];
        }

        public T Get<T>() where T : class
        {
            return components[typeof(T).GetHashCode()] as T;
        }
        
        public T Get<T>(int key) where T : class
        {
            return components[key] as T;
        }

        public virtual void Setup()
        {
        }
    }
}