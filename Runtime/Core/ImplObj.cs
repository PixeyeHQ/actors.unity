using UnityEngine;
using UnityEngine.SceneManagement;


namespace Pixeye.Actors
{
  public class ImplObj : IRequireActorsLayer
  {
    LayerCore layer;

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      this.layer = layer;
    }

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
      var tr = GameObject
        .Instantiate(prefab, parent.TransformPoint(startPosition), startRotation * parent.rotation, parent)
        .transform;

      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();
      return tr;
    }

    public T Spawn<T>(GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var o = Spawn(prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    public T Spawn<T>(GameObject prefab, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var o   = Spawn(prefab, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    //Pooled
    public Transform Spawn(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = layer.pool.pools[poolID].Spawn(prefab, startPosition, startRotation, parent).transform;

      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();

      return tr;
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
      var tr = GameObject.Instantiate(Box.Get<GameObject>(prefabID), parent.TransformPoint(startPosition),
        startRotation * parent.rotation, parent).transform;


      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();

      return tr;
    }

    public T Spawn<T>(string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var o = Spawn(prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    public T Spawn<T>(string prefabID, Vector3 startPosition = default, Quaternion startRotation = default)
    {
      var o = Spawn(prefabID, startPosition, startRotation).GetComponentInChildren<T>();

      return o;
    }

    // Pooled
    public Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = layer.pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation).transform;
      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);

      //tr.SetAsLastSibling();

      return tr;
    }

    public Transform Spawn(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = layer.pool.pools[poolID].Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation, parent)
        .transform;
      SceneManager.MoveGameObjectToScene(tr.gameObject, layer.Scene);
      //tr.SetAsLastSibling();
      return tr;
    }

    public T Spawn<T>(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var o = Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    public T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var o = Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
      return o;
    }

    #endregion
  }
}