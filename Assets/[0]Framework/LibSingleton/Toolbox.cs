/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       14/09/2017 03:45
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

		public static void Remove(object obj)
		{
			if (applicationIsQuitting) return;
			Instance.data.Remove(obj.GetType().GetHashCode());
		}

		public static void InitializeObject(object obj)
		{
			var awakeble = obj as IAwake;
			if (awakeble != null) awakeble.OnAwake();

			var tickable = obj as ITick;
			if (tickable != null) ProcessingUpdate.Default.Add(tickable);
		}


		public static T Get<T>()
		{
			object resolve;

			var hasValue = Instance.data.TryGetValue(typeof(T).GetHashCode(), out resolve);

			if (!hasValue)
				Instance.data.TryGetValue(typeof(T).GetHashCode(), out resolve);
			return (T) resolve;
		}

		public void ClearSessionData()
		{
			if (applicationIsQuitting) return;

 ;
			var toWipe = new List<int>();

			foreach (var pair in data)
			{
				var needToBeWiped = pair.Value as IMustBeWipedOut;
				if (needToBeWiped != null) toWipe.Add(pair.Key);

				var needToBeCleaned = pair.Value as IDisposable;
				if (needToBeCleaned == null) continue;

				needToBeCleaned.Dispose();
			}

			for (var i = 0; i < toWipe.Count; i++)
			{
				data.Remove(toWipe[i]);
			}
		}
	}
}