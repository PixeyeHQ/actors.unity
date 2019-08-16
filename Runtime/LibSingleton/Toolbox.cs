//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using Pixeye.Source;
using UnityEngine;

namespace Pixeye.Framework
{
	/// <summary>
	/// <para>Service locator</para>
	/// </summary>
	public class Toolbox : Singleton<Toolbox>
	{
		[SerializeField]
		Dictionary<int, object> data = new Dictionary<int, object>(5, new FastComparable());

		public static bool Contains<T>()
		{
			return Instance.data.ContainsKey(typeof(T).GetHashCode());
		}

		public static List<IDisposable> disposables = new List<IDisposable>(64);

		public static Action OnDestroyAction = delegate { };

		/// <summary>
		/// <para>Creates an object to the toolbox by type.</para> 
		/// </summary>
		public static T Add<T>(Type type = null) where T : new()
		{
			object o;
			var    hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
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

		/// <summary>
		/// <para>Adds an object to the toolbox</para>
		/// </summary>
		public static void Add(object obj)
		{
			object possibleObj;
			if (Instance.data.TryGetValue(obj.GetType().GetHashCode(), out possibleObj))
			{
				InitializeObject(possibleObj);
			}

			var add             = obj;
			var scriptable      = obj as ScriptableObject;
			if (scriptable) add = Instantiate(scriptable);
			InitializeObject(obj);

			Instance.data.Add(obj.GetType().GetHashCode(), add);
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
			ProcessorUpdate.Add(obj);
		}

		/// <summary>
		/// <para>Gets an object from the toolbox by type</para>
		/// </summary>
		public static T Get<T>()
		{
			object resolve;
			var    hasValue = Instance.data.TryGetValue(typeof(T).GetHashCode(), out resolve);
			return hasValue ? (T) resolve : default(T); 
		}

		internal void ClearSessionData()
		{
			if (applicationIsQuitting) return;

			var toWipe = new List<int>();

			foreach (var pair in data)
			{
				if (!(pair.Value is IKernel))
					toWipe.Add(pair.Key);

				if (!(pair.Value is IDisposable needToBeCleaned)) continue;

				needToBeCleaned.Dispose();
			}

			Pool.Dispose();
			Storage.Dispose();
			ProcessorGroups.Dispose();
			ProcessorTimer.Default.Dispose();
			ProcessorScene.Default.Dispose();
			ProcessorUpdate.Default.Dispose();
			Box.Default.Dispose();

			for (var i = 0; i < toWipe.Count; i++)
			{
				data.Remove(toWipe[i]);
			}
		}

		public static void DisposeObject(object obj)
		{
			if (isQuittingOrChangingScene()) return;

			var disposable = obj as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		void OnDestroy()
		{
			for (int i = 0; i < disposables.Count; i++)
			{
				disposables[i].Dispose();
			}
		}

		protected override void OnApplicationQuit()
		{
			base.OnApplicationQuit();
			OnDestroyAction();
		}
	}
}