using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;


namespace Pixeye.Actors
{
  public class ImplObj : IRequireActorsLayer
  {
    Layer layer;

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      this.layer = layer;
    }

    #region Init Childs

    /// Initialize every actor or monocache on childs of the selected gameobject
    public void InitChilds(GameObject obj, InitMode mode = InitMode.All)
    {
      var transforms = obj.GetComponentsInChildren<Transform>(mode == InitMode.All);
      for (var i = 1; i < transforms.Length; i++)
      {
        var tr = transforms[i];
        tr.gameObject.SetActive(true);
        var oo = tr.GetComponents<MonoBehaviour>();

        foreach (var o in oo)
        {
          if (o is IRequireActorsLayer req)
          {
            req.Bootstrap(layer);
            o.enabled = true;
          }
        }
      }
    }

    /// Initialize every actor or monocache on the selected gameobject
    public void Init(GameObject obj)
    {
      DebugInit(obj);

      obj.SetActive(true);
      var oo = obj.GetComponents<MonoBehaviour>();
      foreach (var o in oo)
      {
        if (o is IRequireActorsLayer req)
        {
          req.Bootstrap(layer);
          o.enabled = true;
        }
      }
    }

    [Conditional("ACTORS_DEBUG")]
    void DebugInit(GameObject obj)
    {
      var parent = obj.transform.parent;
      if (!obj.activeInHierarchy && parent != null && parent.gameObject.activeSelf == false)
      {
        Debug.LogError("You are trying to init an object that is not active in hierarchy");
        throw new Exception();
      }
    }

    #endregion

    #region Create

    //===============================//
    // By GameObject ID
    //===============================//

    // Default
    public Transform Spawn(GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = GameObject.Instantiate(prefab, startPosition, startRotation).transform;
      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      // tr.SetAsLastSibling();
      return tr;
    }

    public Transform Spawn(GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return GameObject
        .Instantiate(prefab, parent.TransformPoint(startPosition), startRotation * parent.rotation, parent)
        .transform;
    }

    public T Spawn<T>(GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var o = Spawn(prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    public T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var o = Spawn(prefab, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    //Pooled
    public Transform Spawn(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      //SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();

      return layer.pool.pools[poolID].Spawn(prefab, startPosition, startRotation, parent).transform;
    }

    public T Spawn<T>(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public T Spawn<T>(int poolID, GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefab, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public Transform Spawn(int poolID, GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = layer.pool.pools[poolID].Spawn(prefab, startPosition, startRotation).transform;

      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();

      return tr;
    }

    //===============================//
    // By String ID
    //===============================//

    // Default
    public Transform Spawn(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var tr = GameObject.Instantiate(Box.Get<GameObject>(prefabID), startPosition, startRotation).transform;


      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();

      return tr;
    }

    public Transform Spawn(string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return GameObject.Instantiate(Box.Get<GameObject>(prefabID), parent.TransformPoint(startPosition),
        startRotation * parent.rotation, parent).transform;
    }

    public T Spawn<T>(string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      return Spawn(prefabID, startPosition, startRotation).GetComponentInChildren<T>();
    }

    // Pooled
    public Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = layer.pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation).transform;
      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      return tr;
    }

    public Transform Spawn(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return layer.pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation, parent)
        .transform;
    }

    public T Spawn<T>(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
    }

    #endregion
  }
}