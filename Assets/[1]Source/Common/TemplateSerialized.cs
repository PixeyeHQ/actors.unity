//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/18/2019 

#if ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace Homebrew
{
	public abstract class TemplateSerialized : SerializedScriptableObject, IComponent
	{
		Dictionary<int, object> storage = new Dictionary<int, object>();

		protected virtual void OnEnable() { storage.Clear(); }

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

			val = default(T);
			return false;
		}

		public void Add<T>(T obj) { storage.Add(typeof(T).GetHashCode(), obj); }
		public void Add(Type t, object obj) { storage.Add(t.GetHashCode(), obj); }
	}
}
#endif