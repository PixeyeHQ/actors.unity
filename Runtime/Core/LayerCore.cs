using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public abstract class LayerCore : MonoBehaviour
  {
    internal static int LayerNextID;
    internal static LayerCore ActiveLayer; // current main scene;
    internal Scene Scene => gameObject.scene;

    internal ProcessorUpdate processorUpdate;
    internal ProcessorCoroutine processorCoroutine;
    internal ProcessorSignals processorSignals;
    internal ProcessorEcs processorEcs;
    
    internal ImplEntity implEntity;
    internal ImplEcs implEcs;
    internal ImplObserver implObserver;

    internal int id = LayerNextID++;
    internal bool isDirty = true;

    internal Dictionary<int, object> objects = new Dictionary<int, object>();


    protected virtual void Awake()
    {
      Kernel.LayersInUse.Add(this);
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


    // public void Send<T>(T obj)
    // {
    //   //self.processorSignals.Dispatch(obj);
    // }
    //
    // public void AddSignal(object o)
    // {
    //   //self.processorSignals.Add(o);
    // }
    //
    // public void RemoveSignal(object o)
    // {
    //   //self.processorSignals.Remove(o);
    // }


    internal void Release()
    {
      Kernel.LayersInUse.Remove(this);
      processorUpdate.Dispose();
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
      if (isDirty) return;
      var delta = time.delta;
      processorUpdate.Update(delta);
    }


    void FixedUpdate()
    {
      if (isDirty) return;
      var delta = time.deltaFixed;
      processorUpdate.FixedUpdate(delta);
    }

    void LateUpdate()
    {
      if (isDirty) return;
      var delta = time.delta;
      processorUpdate.LateUpdate(delta);
    }
  }
}