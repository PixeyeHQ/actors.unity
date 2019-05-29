//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Pixeye.Framework
{

	public abstract class DBCore : ScriptableObject
	{

		public object[] components = new object[1];

		protected T Add<T>() where T : class, new()
		{
			var source = StorageData<T>.create();
			var id = StorageData<T>.id;
			if (components.Length <= id)
			{
				Array.Resize(ref components, id << 1);
			}

			components[id] = source;
			return source;
		}

		void OnEnable()
		{
			#if UNITY_EDITOR
			if (!EditorApplication.isPlayingOrWillChangePlaymode) return;
			#endif

			var t = GetType();
			var n = name.Substring(2).Replace(" ", string.Empty);

			MethodInfo method = t.GetMethod(n, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
			method.Invoke(this, null);
		}

	}
}