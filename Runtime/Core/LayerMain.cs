using System;
using System.Collections;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class LayerMain
  {
    public static ProcessorUpdate Engine => Layer.ActiveLayer.Engine;
    public static ImplEntity Entity => Layer.ActiveLayer.Entity;
    public static ImplEcs Ecs => Layer.ActiveLayer.Ecs;
    public static ImplObserver Observer => Layer.ActiveLayer.Observer;
    public static ImplActor Actor => Layer.ActiveLayer.Actor;
    public static Time Time => Layer.ActiveLayer.Time;
    public static ImplObj Obj => Layer.ActiveLayer.Obj;


    public static void Send<Y>(in Y signal) => Layer.ActiveLayer.processorSignals.Dispatch(signal);
    public static void AddSignal(object signal) => Layer.ActiveLayer.processorSignals.Add(signal);
    public static void RemoveSignal(object signal) => Layer.ActiveLayer.processorSignals.Remove(signal);


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
            req.Bootstrap(Layer.ActiveLayer);
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
          req.Bootstrap(Layer.ActiveLayer);
          o.enabled = true;
        }
      }
    }


    #region Coroutines

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(float delay, IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool Stop(IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool StopUnscaled(IEnumerator routine)
    {
      return Layer.ActiveLayer.processorCoroutineUnscaled.Stop(routine);
    }


    public static IEnumerator WaitFrame => null;

    public static IEnumerator Wait(float t)
    {
      Layer.ActiveLayer.processorCoroutine.delays[Layer.ActiveLayer.processorCoroutine.currentIndex] = t;
      return null;
    }

    public static IEnumerator WaitUnscaled(float t)
    {
      Layer.ActiveLayer.processorCoroutineUnscaled.delays[
        Layer.ActiveLayer.processorCoroutineUnscaled.currentIndex] = t;
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