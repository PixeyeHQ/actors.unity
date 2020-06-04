using System;
using System.Collections;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class LayerMain
  {
    public static ProcessorUpdate Updates => LayerCore.ActiveLayer.Updates;
    public static ImplEntity Entity => LayerCore.ActiveLayer.Entity;
    public static ImplEcs Ecs => LayerCore.ActiveLayer.Ecs;
    public static ImplObserver Observer => LayerCore.ActiveLayer.Observer;
    public static ImplActor Actor => LayerCore.ActiveLayer.Actor;
    public static ImplTime Time => LayerCore.ActiveLayer.Time;
    public static ImplObj Obj => LayerCore.ActiveLayer.Obj;
    

    public static void Send<Y>(in Y signal) => LayerCore.ActiveLayer.processorSignals.Dispatch(signal);
    public static void AddSignal(object signal) => LayerCore.ActiveLayer.processorSignals.Add(signal);
    public static void RemoveSignal(object signal) => LayerCore.ActiveLayer.processorSignals.Remove(signal);


    /// Initialize every actor or monocache on childs of the selected gameobject
    public static void InitChilds(GameObject obj, InitMode mode = InitMode.All)
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
            req.Bootstrap(LayerCore.ActiveLayer);
            o.enabled = true;
          }
        }
      }
    }

    /// Initialize every actor or monocache on the selected gameobject
    public static void Init(GameObject obj)
    {
#if ACTORS_DEBUG

      var parent = obj.transform.parent;
      if (!obj.activeInHierarchy && parent != null && parent.gameObject.activeSelf == false)
      {
        Debug.LogError("You are trying to init an object that is not active in hierarchy");
        return;
      }

#endif
      obj.SetActive(true);
      var oo = obj.GetComponents<MonoBehaviour>();
      foreach (var o in oo)
      {
        if (o is IRequireActorsLayer req)
        {
          req.Bootstrap(LayerCore.ActiveLayer);
          o.enabled = true;
        }
      }
    }


    #region Coroutines

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(float delay, IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool Stop(IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool StopUnscaled(IEnumerator routine)
    {
      return LayerCore.ActiveLayer.processorCoroutineUnscaled.Stop(routine);
    }


    public static IEnumerator WaitFrame => null;

    public static IEnumerator Wait(float t)
    {
      LayerCore.ActiveLayer.processorCoroutine.delays[LayerCore.ActiveLayer.processorCoroutine.currentIndex] = t;
      return null;
    }

    public static IEnumerator WaitUnscaled(float t)
    {
      LayerCore.ActiveLayer.processorCoroutineUnscaled.delays[
        LayerCore.ActiveLayer.processorCoroutineUnscaled.currentIndex] = t;
      return null;
    }

    public static RoutineCall WaitFor(float t, Action action)
    {
      var routine = Run(CoDelay());

      IEnumerator CoDelay()
      {
        yield return Wait(t);
        action();
      }

      return routine;
    }

    public static RoutineCall WaitForUnscaled(float t, Action action)
    {
      var routine = RunUnscaled(CoDelay());

      IEnumerator CoDelay()
      {
        yield return WaitUnscaled(t);
        action();
      }

      return routine;
    }

    #endregion

    #region Create

    //===============================//
    // By GameObject ID
    //===============================//

    // Default
    public static Transform Spawn(GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = GameObject.Instantiate(prefab, startPosition, startRotation).transform;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static Transform Spawn(GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = GameObject
        .Instantiate(prefab, parent.TransformPoint(startPosition), startRotation * parent.rotation, parent)
        .transform;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static T Spawn<T>(GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
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
    public static Transform Spawn(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      //var layer = Kernel.Layers[o.gameObject.scene.buildIndex];
      var tr = LayerCore.ActiveLayer.pool.pools[poolID].Spawn(prefab, startPosition, startRotation, parent).transform;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static T Spawn<T>(int poolID, GameObject prefab, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefab, parent, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public static T Spawn<T>(int poolID, GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      return Spawn(poolID, prefab, startPosition, startRotation).GetComponentInChildren<T>();
    }

    public static Transform Spawn(int poolID, GameObject prefab, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = LayerCore.ActiveLayer.pool.pools[poolID].Spawn(prefab, startPosition, startRotation).transform;


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
      var tr = GameObject.Instantiate(Box.Get<GameObject>(prefabID), startPosition, startRotation).transform;


#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif
      return tr;
    }

    public static Transform Spawn(string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = GameObject.Instantiate(Box.Get<GameObject>(prefabID), parent.TransformPoint(startPosition),
        startRotation * parent.rotation, parent).transform;


#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static T Spawn<T>(string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
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
    public static Transform Spawn(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = LayerCore.ActiveLayer.pool.pools[poolID]
        .Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation).transform;

#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static Transform Spawn(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
      var tr = LayerCore.ActiveLayer.pool.pools[poolID]
        .Spawn(Box.Get<GameObject>(prefabID), startPosition, startRotation, parent).transform;


#if UNITY_EDITOR
      tr.SetAsLastSibling();
#endif

      return tr;
    }

    public static T Spawn<T>(int poolID, string prefabID, Transform parent, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
#if UNITY_EDITOR
      var o = Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
      (o as Component).transform.SetAsLastSibling();
      return o;
#else
      return Spawn(poolID, prefabID, parent, startPosition, startRotation).GetComponentInChildren<T>();
#endif
    }

    public static T Spawn<T>(int poolID, string prefabID, Vector3 startPosition = default,
      Quaternion startRotation = default)
    {
#if UNITY_EDITOR
      var o = Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
      (o as Component).transform.SetAsLastSibling();
      return o;
#else
     return Spawn(poolID, prefabID, startPosition, startRotation).GetComponentInChildren<T>();
#endif
    }

    #endregion
  }
}