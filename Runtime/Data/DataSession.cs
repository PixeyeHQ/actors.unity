//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public abstract class DataSession : ScriptableObject, IDisposable
	{

		internal static Dictionary<int, object> binds = new Dictionary<int, object>();

		public virtual void Dispose()
		{
		}

		public void Add<T>(T obj) where T : new()
		{
			binds.Add(typeof(T).GetHashCode(), obj);
		}

		public T Add<T>() where T : new()
		{
			var o = new T();
			binds.Add(typeof(T).GetHashCode(), o);
			return o;
		}

	}
}