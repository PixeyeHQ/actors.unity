/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:28 PM
================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public class Toolbox : Singleton<Toolbox>
	{
		[SerializeField] private Dictionary<int, object> data = new Dictionary<int, object>();


		public static bool Contains<T>()
		{
			return Instance.data.ContainsKey(typeof(T).GetHashCode());
		}

		public static T Add<T>(Type type = null) where T : new()
		{
			object o;
			var hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
			if (Instance.data.TryGetValue(hash, out o))
			{
				InitializeObject(o);
				return (T) o;
			}

			var created = new T();

			InitializeObject(created);
			Instance.data.Add(hash, created);

			return created;
		}


		public static object Get(Type t)
		{
			object resolve;
			Instance.data.TryGetValue(t.GetHashCode(), out resolve);
			return resolve;
		}

		public static object Add(object obj)
		{
			object possibleObj;
			if (Instance.data.TryGetValue(obj.GetType().GetHashCode(), out possibleObj))
			{
				InitializeObject(possibleObj);
				return possibleObj;
			}

			var add = obj;
			var scriptable = obj as ScriptableObject;
			if (scriptable) add = Instantiate(scriptable);
			InitializeObject(obj);

			Instance.data.Add(obj.GetType().GetHashCode(), add);
			return add;
		}

		public static void InitializeObject(object obj)
		{
			var awakeble = obj as IAwake;
			if (awakeble != null) awakeble.OnAwake();

			var tickable = obj as ITick;
			if (tickable != null) Get<ProcessingUpdate>().Add(tickable);
		}


		public static T Get<T>()
		{
			object resolve;

			var hasValue = Instance.data.TryGetValue(typeof(T).GetHashCode(), out resolve);

			if (!hasValue)
				Instance.data.TryGetValue(typeof(T).GetHashCode(), out resolve);
			return (T) resolve;
		}
	}
}