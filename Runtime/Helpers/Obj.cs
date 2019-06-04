//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	public static class Obj
	{

		public static T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab).transform;
			go.localPosition = startPosition;
			go.localRotation = startRotation;
			return go.GetComponentInChildren<T>();
		}

		public static Transform Spawn(string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var prefab = Box.Get<GameObject>(prefabID);
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static Transform Spawn(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}
		
		public static Transform Spawn(GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static T Spawn<T>(GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(prefab, parent).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go.GetComponent<T>();
		}

	 
		
		public static Transform Spawn(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = Object.Instantiate(Box.Get<GameObject>(prefabID)).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

		public static Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var go = HandlePool.pools[poolID].Spawn(prefabID).transform;
			go.position = startPosition;
			go.localRotation = startRotation;
			go.localScale = Vector3.one;
			return go;
		}

	}
}