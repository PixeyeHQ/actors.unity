using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public abstract class LayerCore : MonoBehaviour
  {
    internal static LayerCore ActiveLayer; // current main scene;
    internal Scene Scene => gameObject.scene;

    internal ProcessorUpdate processorUpdate;
    internal ProcessorCoroutine processorCoroutine;
    internal ProcessorSignals processorSignals;
    internal ProcessorEcs processorEcs;

    internal EntityImpl entityImpl;

    internal Dictionary<int, object> objects = new Dictionary<int, object>();


    internal void Release()
    {
      OnLayerDestroy();

      processorUpdate.Dispose();

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
      var delta = time.delta;
      processorUpdate.Update(delta);
    }


    void FixedUpdate()
    {
      var delta = time.deltaFixed;
      processorUpdate.FixedUpdate(delta);
    }

    void LateUpdate()
    {
      var delta = time.delta;
      processorUpdate.LateUpdate(delta);
    }
  }
}