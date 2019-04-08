//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public class DataGame : ScriptableObject, IDisposable
	{

		public virtual void Dispose()
		{
		}

		Dictionary<int, object> storage = new Dictionary<int, object>();

		protected void OnEnable()
		{
			storage.Clear();
			Setup();
		}

		protected virtual void Setup()
		{
		}

		public T Get<T>()
		{
			object ob;
			storage.TryGetValue(typeof(T).GetHashCode(), out ob);
			return (T) ob;
		}

		public bool TryGet<T>(out T val)
		{
			object v;
			if (storage.TryGetValue(typeof(T).GetHashCode(), out v))
			{
				val = (T) v;
				return true;
			}

			val = default;
			return false;
		}

		public void Add<T>(T obj)
		{
			storage.Add(typeof(T).GetHashCode(), obj);
		}

	}
}