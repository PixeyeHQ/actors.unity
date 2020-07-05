using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public sealed class Layer
  {
    internal static int NEXT_FREE_ID;
    internal static Dictionary<string, int> USED_IDS = new Dictionary<string, int>(StringComparer.Ordinal);
    internal static Layer ActiveLayer; // current main scene;


    internal ProcessorCoroutine processorCoroutine;
    internal ProcessorCoroutine processorCoroutineUnscaled;

    internal ProcessorSignals processorSignals;
    internal ProcessorEcs processorEcs;

    public Action Closed = delegate { };

    public Scene Scene => gameObject.scene;
    public ProcessorUpdate Engine;
    public ImplObj Obj;
    public Time Time;
    public ImplActor Actor;
    public ImplEntity Entity;
    public ImplEcs Ecs;
    public ImplObserver Observer;

    public int ID => id;

    internal GameObject gameObject;
    public Pool Pool;

    internal int id;
    internal bool isReleasing = true;

    internal Action OnLayerDestroy;
    internal Dictionary<int, object> objects = new Dictionary<int, object>();
    internal Dictionary<int, Transform> cachemap = new Dictionary<int, Transform>();
    internal Dictionary<int, Transform> cachemapTag = new Dictionary<int, Transform>();

    /// performs a search of the gameobject by name on all scenes, cache it and
    /// returns it transform.
    public Transform GetObj(string goName)
    {
      var hash      = goName.GetHashCode();
      var haveFound = cachemap.TryGetValue(hash, out var transform);
      if (!haveFound)
      {
        var gameobject            = GameObject.Find(goName);
        if (gameobject) transform = gameobject.transform;
        if (transform) cachemap.Add(hash, transform);
      }

      return transform;
    }

    /// performs a search of the gameobject by tag on all scenes, cache it and
    /// returns it transform.
    public Transform GetObjByTag(string tagName)
    {
      var hash      = tagName.GetHashCode();
      var haveFound = cachemapTag.TryGetValue(hash, out var transform);
      if (!haveFound)
      {
        var gameobject            = GameObject.FindWithTag(tagName);
        if (gameobject) transform = gameobject.transform;
        if (transform) cachemapTag.Add(hash, transform);
      }

      return transform;
    }

    /// performs a search of the gameobject by type on all scenes, cache it and
    /// returns T.
    public T GetObj<T>() where T : MonoBehaviour
    {
      var hash      = typeof(T).GetHashCode();
      var haveFound = objects.TryGetValue(hash, out var o);
      if (!haveFound)
      {
        o = GameObject.FindObjectOfType<T>();
        if (o != null) objects.Add(hash, o);
      }

      return o as T;
    }

    internal Layer(GameObject gameObject, Action OnLayerDestroy)
    {
      this.OnLayerDestroy = OnLayerDestroy;
      this.gameObject     = gameObject;
      if (!USED_IDS.TryGetValue(gameObject.scene.name, out id))
      {
        id = NEXT_FREE_ID++;
        USED_IDS.Add(gameObject.scene.name, id);
      }

      Time = new Time();
      LayerKernel.LayersInUse.Add(this);
    }

    public Y Get<Y>()
    {
      return (Y) objects[typeof(Y).GetHashCode()];
    }

    public Buffer<Y> GetBuffer<Y>() where Y : struct
    {
      return Buffer<Y>.layers[id];
    }

    public Y Add<Y>() where Y : new()
    {
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Bootstrap(this);
      objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    #region SIGNALS

    public void Send<T>(in T signal)
    {
      processorSignals.Dispatch(signal);
    }

    public void AddSignal(object signal)
    {
      processorSignals.Add(signal);
    }

    public void RemoveSignal(object signal)
    {
      processorSignals.Remove(signal);
    }

    #endregion

    #region COROUTINES

    /// Run coroutine on the top of this layer.
    public RoutineCall Run(IEnumerator routine)
    {
      return processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public RoutineCall Run(float delay, IEnumerator routine)
    {
      return processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public RoutineCall RunUnscaled(IEnumerator routine)
    {
      return processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public bool Stop(IEnumerator routine)
    {
      return processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public bool StopUnscaled(IEnumerator routine)
    {
      return processorCoroutineUnscaled.Stop(routine);
    }


    public IEnumerator WaitFrame => null;

    public IEnumerator Wait(float t)
    {
      processorCoroutine.delays[processorCoroutine.currentIndex] = t;
      return null;
    }

    public IEnumerator WaitUnscaled(float t)
    {
      processorCoroutineUnscaled.delays[processorCoroutineUnscaled.currentIndex] = t;
      return null;
    }

    public RoutineCall WaitFor(float t, Action action)
    {
      var routine = Run(CoDelay());

      IEnumerator CoDelay()
      {
        yield return Wait(t);
        action();
      }

      return routine;
    }

    public RoutineCall WaitForUnscaled(float t, Action action)
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


    internal void Release()
    {
      isReleasing = true;
      Closed();
      Engine.Dispose();
      processorCoroutine.Dispose();
      processorCoroutineUnscaled.Dispose();
      LayerKernel.LayersInUse.Remove(this);
      OnLayerDestroy();


      foreach (var obj in objects)
      {
        if (obj.Value is IDisposable wiped)
        {
          wiped.Dispose();
        }
      }

      cachemap.Clear();
      cachemapTag.Clear();
      objects.Clear();
    }
  }

  public enum InitMode
  {
    All,
    ActiveOnly
  }
}