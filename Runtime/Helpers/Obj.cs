//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class Obj
  {
    /// <summary>
    /// Initialize every actor or monocache on childs of the selected gameobject
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void InitEveryChild(GameObject obj)
    {
      var transforms = obj.GetComponentsInChildren<Transform>(true);
      for (var i = 1; i < transforms.Length; i++)
      {
        var tr = transforms[i];
        tr.gameObject.SetActive(true);
        var oo = tr.GetComponents<MonoBehaviour>();

        foreach (var o in oo)
        {
          if (o is IRequireStarter req)
          {
            req.Launch();
            o.enabled = true;
          }
        }
      }
    }

    /// <summary>
    /// Initialize every actor or monocache on the selected gameobject
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Init(GameObject obj)
    {
#if ACTORS_DEBUG

      var parent = obj.transform.parent;
      if (!obj.activeInHierarchy && parent!=null && parent.gameObject.activeSelf == false)
      {
        Debug.LogError("You are trying to init an object that is not active in hierarchy");
        return;
      }

#endif
      obj.SetActive(true);
      var oo = obj.GetComponents<MonoBehaviour>();
      foreach (var o in oo)
      {
        if (o is IRequireStarter req)
        {
          req.Launch();
          o.enabled = true;
        }
      }
    }

    //===============================//
    // By GameObject ID
    //===============================//

    // Default
    public static Transform Spawn(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = Object.Instantiate(prefab).transform;
      tr.position      = startPosition;
      tr.localRotation = startRotation;
#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static Transform Spawn(GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = Object.Instantiate(prefab, parent).transform;
      tr.localPosition = startPosition;
      tr.localRotation = startRotation;
#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static T Spawn<T>(GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
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
    public static Transform Spawn(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = Pool.pools[poolID].Spawn(prefab, parent).transform;
      tr.localPosition = startPosition;
      tr.localRotation = startRotation;
#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static T Spawn<T>(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
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
      tr.position      = startPosition;
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
      tr.position      = startPosition;
      tr.localRotation = startRotation;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif


      return tr;
    }

    public static Transform Spawn(string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = Object.Instantiate(Box.Get<GameObject>(prefabID), parent).transform;
      tr.localPosition = startPosition;
      tr.localRotation = startRotation;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static T Spawn<T>(string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
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
      tr.position      = startPosition;
      tr.localRotation = startRotation;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static Transform Spawn(int poolID, string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = Pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), parent).transform;
      tr.localPosition = startPosition;
      tr.localRotation = startRotation;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static T Spawn<T>(int poolID, string prefabID, Transform parent, Vector3 startPosition = default, Quaternion startRotation = default)
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

  public static partial class HelperFramework
  {
    public static void Release(this GameObject o, int poolID = 0)
    {
      if (poolID <= 0)
        GameObject.Destroy(o);
      else Pool.Despawn(poolID, o);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this GameObject obj, string path)
    {
      return obj.transform.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Transform tr, string path)
    {
      return tr.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Behaviour obj, string path)
    {
      return obj.transform.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Behaviour obj)
    {
      return obj.GetComponent<T>();
    }
  }
}