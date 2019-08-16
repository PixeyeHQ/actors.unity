//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	public static class Obj
	{
		public static void Release(this GameObject o, int poolID = 0)
		{
			if (poolID <= 0)
				GameObject.Destroy(o);
			else Pool.Despawn(poolID, o);
		}

		//===============================//
		// By GameObject ID
		//===============================//

		// Default
		public static Transform Spawn(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(prefab).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(prefab, parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
		}

		public static T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefab, startPosition, startRotation).GetComponentInChildren<T>();
		}
		
		//Pooled
		public static Transform Spawn(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(prefab, parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
		}

		public static T Spawn<T>(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID , prefab, startPosition, startRotation).GetComponentInChildren<T>();
		}
		
		public static Transform Spawn(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(prefab).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		//===============================//
		// By String ID
		//===============================//

		// Default
		public static Transform Spawn(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(Box.Get<GameObject>(prefabID)).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(Box.Get<GameObject>(prefabID), parent).transform;
		 	tr.localPosition = startPosition;
	  	tr.localRotation = startRotation;
			return tr;
		}
		public static T Spawn<T>(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
		}
		public static T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(prefabID, startPosition, startRotation).GetComponentInChildren<T>();
		}
		
		
		// Pooled
		public static Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID)).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static Transform Spawn(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			return tr;
		}

		public static T Spawn<T>(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
		}

		public static T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
		}
	}
}