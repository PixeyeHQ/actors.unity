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
    public class Blueprint : ScriptableObject, IComponent
    {
        protected Dictionary<int, object> components = new Dictionary<int, object>(2, new FastDict());

        public void Add<T>(T component)
        {
            var awakeComponent = component as IAwake;
            if (awakeComponent != null)
                awakeComponent.OnAwake();

            components.Add(component.GetType().GetHashCode(), component);
        }

        public object Get(Type t)
        {
            return components[t.GetHashCode()];
        }

        public T Get<T>()
        {
            return (T) components[typeof(T).GetHashCode()];
        }

        public virtual void Setup()
        {
        }
    }
}