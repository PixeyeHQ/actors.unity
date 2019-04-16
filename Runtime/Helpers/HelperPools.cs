/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/23/2018 12:33 PM
================================================================*/

using UnityEngine;

namespace Pixeye.Framework
{
	public static partial class HelperFramework
	{

		public static void Release(this GameObject o, int poolID = 0)
		{
			if (poolID <= 0)
			{
				GameObject.Destroy(o);
			}
			else HandlePool.Despawn(poolID, o);
		}

//		internal static void ReleaseEntity(this GameObject o, bool isEntity = false)
//		{
//			if (!isEntity)
//			{
//				GameObject.Destroy(o);
//			}
//			else HandlePool.Despawn(Pool.Entities, o);
//		}

		#region NO POOLS

		public static Transform Spawn(this object o, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, string prefabID, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessorScene.Get(parentID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessorScene.Get(parentID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessorScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessorScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Spawn<T>(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Spawn<T>(this object o, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		#endregion

		#region POOLS

		public static Transform Spawn(this object o, int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, int poolID, string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, int poolID, string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, int poolID, GameObject prefab, string parentID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var parent = ProcessorScene.Get(parentID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, int poolID, GameObject prefab, string parentID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var parent = ProcessorScene.Get(parentID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, int poolID, string prefabID, string parentID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var parent = ProcessorScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(this object o, int poolID, string prefabID, string parentID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var parent = ProcessorScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = HandlePool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = HandlePool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Spawn<T>(this object o, int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = HandlePool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(this object o, int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			GameObject go;

			if (HandlePool.pools[poolID].Spawn(prefab, out go))
			{
				return go.transform;
			}
			var tr = go.transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static T Spawn<T>(this object o, int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = HandlePool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		internal static Transform SpawnInternal(GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		internal static Transform SpawnInternal(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static Transform SpawnInternal(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		internal static Transform SpawnInternal(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{


			var tr = HandlePool.pools[poolID].Spawn(prefab).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;

			return tr;
		}

		internal static Transform SpawnInternal(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var tr = HandlePool.pools[poolID].Spawn(prefab).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;

			return tr;
		}

		#endregion

	}
}