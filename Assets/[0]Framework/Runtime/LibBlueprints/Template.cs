//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/23/2018


using System.Collections.Generic;
using Homebrew;
using UnityEngine;

public abstract class Template : ScriptableObject, IComponent
{
	Dictionary<int, object> storage = new Dictionary<int, object>();

	protected void OnEnable()
	{
		storage.Clear();
		Setup();
	}

	protected virtual void Setup() { }

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
}