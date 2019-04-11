using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks, false)]
	public class PoolContainer
	{

		public bool globalPool = false;
		private List<GameObject> activeObjs = new List<GameObject>(600);

		//	private Transform parent;
		private Dictionary<int, Stack<GameObject>> cachedObjects = new Dictionary<int, Stack<GameObject>>(600, new FastComparable());

		//	private Dictionary<int, IPoolable> cachedPoolables = new Dictionary<int, IPoolable>(600, new FastComparable());
		private Dictionary<int, int> cachedIds = new Dictionary<int, int>(600, new FastComparable());

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void RegisterObject(GameObject prefab)
		{
			var key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var hasValue = cachedObjects.TryGetValue(key, out stack);
			if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
		}
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void Prepopulate(GameObject prefab, GameObject obj)
		{
			var key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var hasValue = cachedObjects.TryGetValue(key, out stack);
			if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
			else
			{
				cachedIds.Add(obj.GetInstanceID(), key);
			}
		}
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void AddToPool(GameObject go, GameObject prefab)
		{
			cachedIds.Add(go.GetInstanceID(), prefab.GetInstanceID());
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public PoolContainer PopulateWith(GameObject prefab, int amount, int amountPerTick = 10, int timeRate = 1)
		{
			var key = prefab.GetInstanceID();
			Stack<GameObject> stack;
			var hasValue = cachedObjects.TryGetValue(key, out stack);
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

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public GameObject Spawn(GameObject prefab, Transform parent = null)
		{
//			if (parent == null)
//			{
//				parent = this.parent;
//			}

			var key = prefab.GetInstanceID();

			Stack<GameObject> objs;
			var stacked = cachedObjects.TryGetValue(key, out objs);

			if (stacked && objs.Count > 0)
			{
				var obj = objs.Pop();
				var transform = obj.transform;
				if (transform.parent != parent)
					transform.SetParent(parent);

				IPoolable poolable = transform.GetComponent<IPoolable>();
				if (poolable != null)
				{
					poolable.Spawn();
				}

				transform.gameObject.SetActive(true);

				return obj;
			}

			if (!stacked)
			{
				cachedObjects.Add(key, new Stack<GameObject>(600));
			}

			var createdPrefab = Object.Instantiate(prefab, parent);

			var k = createdPrefab.GetInstanceID();

//			var p = createdPrefab.GetComponent<IPoolable>();
//			if (p != null)
//			{
//				if (!cachedPoolables.ContainsKey(k))
//				{
//					cachedPoolables.Add(k, p);
//				}
//			}

			cachedIds.Add(k, key);
			return createdPrefab;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
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
			cachedObjects.Clear();
			cachedIds.Clear();
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		private void Populate(GameObject prefab, int key)
		{
			var go = Object.Instantiate(prefab);
			go.SetActive(false);
			cachedIds.Add(go.GetInstanceID(), key);
			cachedObjects[key].Push(go);
		}

	}
}