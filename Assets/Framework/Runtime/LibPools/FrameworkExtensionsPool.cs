/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/23/2018 12:33 PM
================================================================*/


 
using UnityEngine;


namespace Pixeye
{
	public static partial class FrameworkExtensions
	{
		public static void Release(this GameObject o, int poolID = -1)
		{
			if (poolID == -1)
			{
				UnityEngine.GameObject.Destroy(o);
			}
			else ProcessingPool.Despawn(poolID, o);
		}

		 #region NO POOLS

		public static Transform Populate(this object o, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, string prefabID, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, string prefabID, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

 
		public static Transform Populate(this object o, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		
		public static Transform Populate(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Populate<T>(this object o, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Populate<T>(this object o, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go     = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}
		
		#endregion


		#region POOLS

		public static Transform Populate(this object o, int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, int poolID, string prefabID, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, string prefabID, Transform parent, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		
		public static Transform Populate(this object o, int poolID, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, GameObject prefab, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, int poolID, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, string prefabID, string parentID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var parent = ProcessingScene.Get(parentID);
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponentInChildren<T>();
		}

		
		public static Transform Populate(this object o, int poolID, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var go = ProcessingPool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, GameObject prefab, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
		 
			var go = ProcessingPool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Populate(this object o, int poolID, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go;
		}

		public static T Populate<T>(this object o, int poolID, string prefabID, Vector3 startPosition = default(Vector3), Quaternion startRotation = default(Quaternion))
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = ProcessingPool.pools[poolID].Spawn(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}
		
		#endregion
	 
	}
}