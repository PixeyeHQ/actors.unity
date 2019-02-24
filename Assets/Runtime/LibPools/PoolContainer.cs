using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye
{
	public class PoolContainer
	{
		public bool globalPool = false;
		public List<GameObject> activeObjs = new List<GameObject>(600);

		protected Transform parent;

		protected Dictionary<int, Stack<GameObject>> cachedObjects = new Dictionary<int, Stack<GameObject>>(600, new FastComparable());

		protected Dictionary<int, IPoolable> cachedPoolables = new Dictionary<int, IPoolable>(600, new FastComparable());
		protected Dictionary<int, int> cachedIds = new Dictionary<int, int>(600, new FastComparable());


		public void RegisterObject(GameObject prefab)
		{
			var               key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var               hasValue = cachedObjects.TryGetValue(key, out stack);
			if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
		}

		public void Prepopulate(GameObject prefab, GameObject obj)
		{
			var               key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var               hasValue = cachedObjects.TryGetValue(key, out stack);
			if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
			else
			{
				cachedIds.Add(obj.GetInstanceID(), key);
			}
		}


		public void AddToPool(GameObject go, GameObject prefab) { cachedIds.Add(go.GetInstanceID(), prefab.GetInstanceID()); }

		public PoolContainer PopulateWith(GameObject prefab, int amount, int amountPerTick = 10, int timeRate = 1)
		{
			var               key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var               hasValue = cachedObjects.TryGetValue(key, out stack);
			if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>(amount));


			Timer.Add(Time.delta * timeRate, () =>
			{
				for (var i = 0; i < amountPerTick; i++)
				{
					if (amount == 0) break;
					Populate(prefab, key);
					amount--;
				}

				if (amount > 0)
				{
					Timer.Add(Time.delta * timeRate, () => PopulateWith(prefab, amount, amountPerTick, timeRate));
				}
			});


			return this;
		}

		public GameObject Spawn(GameObject prefab, Transform parent = null)
		{
		 
			if (parent == null)
			{
				parent = this.parent;
			}

			var key = prefab.GetInstanceID();

			Stack<GameObject> objs;
			var               stacked = cachedObjects.TryGetValue(key, out objs);

			if (stacked && objs.Count > 0)
			{
				
				var obj       = objs.Pop();
				var transform = obj.transform;
				if (transform.parent != parent)
					transform.SetParent(parent);
				transform.gameObject.SetActive(true);
				IPoolable poolable;

				if (cachedPoolables.TryGetValue(obj.GetInstanceID(), out poolable))
					poolable.Spawn();

				return obj;
			}


			if (!stacked)
			{
				cachedObjects.Add(key, new Stack<GameObject>(600));
			}

			var createdPrefab = Object.Instantiate(prefab, parent);

			var k = createdPrefab.GetInstanceID();

			var p = createdPrefab.GetComponent<IPoolable>();
			if (p != null)
			{
				if (!cachedPoolables.ContainsKey(k))
				{
					cachedPoolables.Add(k, p);
				}
			}

			cachedIds.Add(k, key);
			return createdPrefab;
		}

		public void Despawn(GameObject go)
		{
			go.SetActive(false);

			cachedObjects[cachedIds[go.GetInstanceID()]].Push(go);
		}

		public void DespawnAll()
		{
			for (var i = 0; i < activeObjs.Count; i++)
			{
				Despawn(activeObjs[i]);
			}

			activeObjs.Clear();
		}

		public void Dispose()
		{
			//	cachedPoolables.Clear();
			cachedObjects.Clear();
			cachedIds.Clear();
		}

		private void Populate(GameObject prefab, int key)
		{
			var go = Object.Instantiate(prefab);
			go.SetActive(false);
			cachedIds.Add(go.GetInstanceID(), key);
			cachedObjects[key].Push(go);
		}
	}
}