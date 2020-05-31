using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  public abstract class StarterCore : MonoBehaviour
  {
    internal static StarterCore ActiveLayer; // current main scene;
    internal Scene Scene => gameObject.scene;

    internal ProcessorUpdate processorUpdate;
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

    protected U Add<U>() where U : new()
    {
      var obj = new U();
      processorUpdate.Add(obj);
      objects.Add(typeof(U).GetHashCode(), obj);
      return obj;
    }

    public U Get<U>() where U : class
    {
      return objects[typeof(U).GetHashCode()] as U;
    }

    void Update()
    {
      var delta = time.delta;
      processorUpdate.Update(delta);
    }

    //   var delta = time.delta;
    //
    //   routines.Global.Tick(time.deltaUnscaled);
    //
    // if (Kernel.ChangingScene)
    // {
    //   updatesKernel.Update(delta);
    //   return;
    // }
    //
    // for (var i = 0; i < timesLen; i++)
    //   {
    //     times[i].Tick();
    //   }
    //
    //
    //   updatesKernel.Update(delta);
    //
    // for (int i = 0; i < updates.Count; i++)
    //   {
    //     updates[i].Update(delta);
    //   }
    //
    //
    // for (var i = 0; i < ProcessorCoroutines.coroutine_handlers.Count; i++)
    //   {
    //     ProcessorCoroutines.coroutine_handlers[i].Tick(delta);
    //   }

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