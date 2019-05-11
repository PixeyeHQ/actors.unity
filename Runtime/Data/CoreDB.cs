//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	public abstract class CoreDB : ScriptableObject, IDB
	{

		[HideInInspector]
		public Dictionary<int, IData> storage = new Dictionary<int, IData>(FastComparable.Default);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get<T>(int hash) where T : class
		{
			return storage[hash] as T;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get<T>() where T : class
		{
			return storage[typeof(T).GetHashCode()] as T;
		}

		public void Add(IData obj)
		{
			storage.Add(obj.GetType().GetHashCode(), obj);
		}

		public abstract void Setup();

	}
}