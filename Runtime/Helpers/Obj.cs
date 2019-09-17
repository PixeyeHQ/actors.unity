//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Runtime.CompilerServices;
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


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(this Transform tr, string path)
		{
			return tr.Find(path).GetComponent<T>();
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
			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			return tr;
		}

		public static Transform Spawn(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(prefab, parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			return tr;
		}
		public static T Spawn<T>(GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
		  
			#if UNITY_EDITOR
      var o = Spawn(prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
	  	(o as Component).transform.SetAsLastSibling();
			return o;
			#else
			return Spawn(prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
		}

		public static T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
		 
			#if UNITY_EDITOR
      var o = Spawn(prefab, startPosition, startRotation).GetComponentInChildren<T>();
			(o as Component).transform.SetAsLastSibling();
	return o;
			#else
			return Spawn(prefab, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
		}
		
		//Pooled
		public static Transform Spawn(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(prefab, parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;
			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			return tr;
		}
		public static T Spawn<T>(int poolID, GameObject prefab, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
	 
			return Spawn(poolID, prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
	
		}

		public static T Spawn<T>(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			return Spawn(poolID, prefab, startPosition, startRotation).GetComponentInChildren<T>();
		}
		
		public static Transform Spawn(int poolID, GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(prefab).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;

			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			
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

      #if UNITY_EDITOR
			tr.SetAsLastSibling();
      #endif
			
			
			return tr;
		}

		public static Transform Spawn(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Object.Instantiate(Box.Get<GameObject>(prefabID), parent).transform;
		 	tr.localPosition = startPosition;
	  	tr.localRotation = startRotation;

	    #if UNITY_EDITOR
			tr.SetAsLastSibling();
	    #endif
	    
			return tr;
		}
		public static T Spawn<T>(string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			 
			#if UNITY_EDITOR
      var o = Spawn(prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
	  	(o as Component).transform.SetAsLastSibling();
		return o;
			#else
			return Spawn(prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
		}
		public static T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			#if UNITY_EDITOR
      var o = Spawn(prefabID, startPosition, startRotation).GetComponentInChildren<T>();
			(o as Component).transform.SetAsLastSibling();
		return o;
			#else
			return Spawn(prefabID, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
		}
		
		
		// Pooled
		public static Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID)).transform;
			tr.position = startPosition;
			tr.localRotation = startRotation;

			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			
			return tr;
		}

		public static Transform Spawn(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			var tr = Pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), parent).transform;
			tr.localPosition = startPosition;
			tr.localRotation = startRotation;

			#if UNITY_EDITOR
			tr.SetAsLastSibling();
			#endif
			
			return tr;
		}

		public static T Spawn<T>(int poolID, string prefabID, Transform parent , Vector3 startPosition = default, Quaternion startRotation = default)
		{
			#if UNITY_EDITOR
      var o = Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
			(o as Component).transform.SetAsLastSibling();
		return o;
			#else
			return Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
		 
		}

		public static T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
		{
			#if UNITY_EDITOR
      var o = Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
			(o as Component).transform.SetAsLastSibling();
      return o;
			#else
			return Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
			#endif
			 
		}
	}
}