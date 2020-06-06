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
  public abstract class LayerCore : MonoBehaviour
  {
    internal static int LayerNextID;
    internal static LayerCore ActiveLayer; // current main scene;
    internal Scene Scene => gameObject.scene;
    
    internal ProcessorCoroutine processorCoroutine;
    internal ProcessorCoroutine processorCoroutineUnscaled;

    internal ProcessorSignals processorSignals;
    internal ProcessorEcs processorEcs;

    public Action Closed = delegate { };

    public ProcessorUpdate Updates;
    public ImplObj Obj;
    public Time Time;
    public ImplActor Actor;
    public ImplEntity Entity;
    public ImplEcs Ecs;
    public ImplObserver Observer;


    internal Pool pool;

    internal int id = LayerNextID++;
    internal bool isDirty = true;

    internal Dictionary<int, object> objects = new Dictionary<int, object>();


    protected virtual void Awake()
    {
      Time = new Time();
      LayerKernel.LayersInUse.Add(this);
    }

    #region Signals

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

    #region POOLING

    internal List<PoolNode> nodes = new List<PoolNode>();
#if UNITY_EDITOR
    public void ClearNodes()
    {
      for (int i = 0; i < nodes.Count; i++)
      {
        var n = nodes[i];
        n.createdObjs.Clear();
        n.prefab = null;
      }

      nodes.Clear();
    }

    public void AddToNode(GameObject prefab, GameObject instance, int pool)
    {
      var id                  = prefab.GetInstanceID();
      var nodesValid          = nodes.FindValidNodes(id);
      var conditionNodeCreate = true;
      var nodesToKill         = new List<int>();

      for (var i = 0; i < nodesValid.Count; i++)
      {
        var node = nodes[nodesValid[i]];

        var index = node.createdObjs.FindInstanceID(instance);
        if (index != -1 && pool != node.pool)
        {
          node.createdObjs.RemoveAt(index);
        }
        else if (index == -1 && pool == node.pool)
        {
          conditionNodeCreate = false;
          node.createdObjs.Add(instance);
        }

        if (index != -1 && pool == node.pool)
        {
          conditionNodeCreate = false;
        }

        if (node.createdObjs.Count == 0)
        {
          node.prefab = null;
          nodesToKill.Add(nodesValid[i]);
        }
      }

      for (var i = 0; i < nodesToKill.Count; i++)
      {
        nodes.RemoveAt(nodesToKill[i]);
      }

      if (conditionNodeCreate)
      {
        var node = new PoolNode();
        node.id          = id;
        node.prefab      = prefab;
        node.pool        = pool;
        node.createdObjs = new List<GameObject>();
        node.createdObjs.Add(instance);
        nodes.Add(node);
      }
    }
#endif

    #endregion

    internal void Release()
    {
      Closed();
      isDirty = true;
      processorCoroutine.Dispose();
      processorCoroutineUnscaled.Dispose();
      LayerKernel.LayersInUse.Remove(this);
      Updates.Dispose();
      OnLayerDestroy();

      foreach (var obj in objects)
      {
        if (obj.Value is IDisposable wiped)
        {
          wiped.Dispose();
        }
      }
    }


    /// Scene entry point, load your custom stuff from here.
    protected abstract void Setup();

    /// Clean *your* custom scene stuff from here.
    protected abstract void OnLayerDestroy();


    void Update()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (isDirty) return;
      Time.Tick();
      var delta = Time.deltaTime;
      Updates.Update(delta);
    }

    void FixedUpdate()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (isDirty) return;

      var delta = Time.deltaTimeFixed;
      Updates.FixedUpdate(delta);
    }

    void LateUpdate()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      if (isDirty) return;

      var delta = Time.deltaTime;
      Updates.LateUpdate(delta);
    }


    void OnApplicationQuit()
    {
      isDirty = true;
    }
  }

  public enum InitMode
  {
    All,
    ActiveOnly
  }
}