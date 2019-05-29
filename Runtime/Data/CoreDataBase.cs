//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Reflection;
using UnityEngine;

namespace Pixeye.Framework
{

	public abstract class CoreDataBase : ScriptableObject
	{

		public object[] components = new object[1];

		protected T Add<T>() where T : class, new()
		{
			var source = StorageData<T>.create();
			var id = StorageData<T>.Instance.id;
			if (components.Length <= id)
				Array.Resize(ref components, id << 1);

			components[id] = source;
			return source;
		}

		internal void Setup()
		{
			var t = GetType();
			var n = name.Substring(2).Replace(" ", string.Empty);

			MethodInfo method = t.GetMethod(n, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
			method.Invoke(this, null);
		}

	}
}