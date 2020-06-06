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
    public static Time Time => LayerCore.ActiveLayer.Time;
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
  }
}