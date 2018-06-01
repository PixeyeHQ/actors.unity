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
	public abstract class Blueprint : ScriptableObject, IComponent
	{
		protected Dictionary<int, object> components = new Dictionary<int, object>();
		//public bool initialized;


		public void Add<T>(T component)
		{
			var awakeComponent = component as IAwake;
			if (awakeComponent != null)
				awakeComponent.OnAwake();
			
			components.Add(component.GetType().GetHashCode(), component);
		}


		public object Get(Type t)
		{
			object obj;
			components.TryGetValue(t.GetHashCode(), out obj);

			return obj;
		}

		public T Get<T>() where T : class
		{
			object obj;
			if (components.TryGetValue(typeof(T).GetHashCode(), out obj))
			{
				return (T) obj;
			}

			return null;
		}

		public virtual void Setup()
		{
		}


		public void Dispose()
		{
			//	initialized = false;
			components.Clear();
		}
	}
}