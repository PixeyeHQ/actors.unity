//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Pixeye.Actors
{
  /// A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene. 
  public abstract class Layer<T> : LayerCore
  {
    public static new ProcessorUpdate Updates => LayerTyped.core.Updates;
    public static new ImplEntity Entity => LayerTyped.core.Entity;
    public static new ImplEcs Ecs => LayerTyped.core.Ecs;
    public static new ImplObserver Observer => LayerTyped.core.Observer;
    public static new ImplActor Actor => LayerTyped.core.Actor;
    public static new Time Time => LayerTyped.core.Time;
    public static new ImplObj Obj => LayerTyped.core.Obj;

    internal static Layer<T> LayerTyped;
    internal LayerCore core;

    protected sealed override void Awake()
    {
      core = this;
      base.Awake();
      Bootstrap(); // Setup actors logic for a scene.
      Setup();     // Entry point for developers.
      if (gameObject.scene.buildIndex >= 0)
        LayerKernel.ChangingScene[gameObject.scene.buildIndex] = false;
    }

    void Start()
    {
      isDirty = false;
    }

    void Bootstrap()
    {
      #region Update Layers

      var buildIndex = gameObject.scene.buildIndex;
      if (buildIndex != -1)
      {
        LayerKernel.Layers[buildIndex] = this;
      }

      LayerTyped = this;

      #endregion

      #region Update Services

      Processor.NextID = 0; // drop so the processors of the new layer can grab fresh ID.

      core.Updates = new ProcessorUpdate();
      Updates.Add(this);

      // cant add two same classes in toolbox :( temporary solution.
      processorCoroutineUnscaled            = new ProcessorCoroutine();
      processorCoroutineUnscaled.timescaled = false;
      processorCoroutineUnscaled.Bootstrap(this);

      processorCoroutine = new ProcessorCoroutine();
      processorCoroutine.Bootstrap(this);

      pool     = Add<Pool>();
      core.Obj = Add<ImplObj>();

      processorSignals = Add<ProcessorSignals>();
      processorEcs     = Add<ProcessorEcs>();
      core.Actor       = Add<ImplActor>();
      core.Entity      = Add<ImplEntity>();
      core.Ecs         = Add<ImplEcs>();
      core.Observer    = Add<ImplObserver>();

      Add<ProcessorObserver>();

      Updates.layer = LayerTyped;

      #endregion

      #region Update Active Layer

      if (gameObject.scene.name != LayerKernel.KernelSceneName)
        if (SceneMain.NextActiveSceneName != null && SceneMain.NextActiveSceneName == gameObject.scene.name)
        {
          SceneMain.NextActiveSceneName = default;
          ActiveLayer                   = this;
          Run(CoWaitForSceneLoad());

          IEnumerator CoWaitForSceneLoad()
          {
            while (!gameObject.scene.isLoaded)
              yield return 0;

            SceneManager.SetActiveScene(gameObject.scene);
          }
        }

      #endregion

      #region Pools & Activations

      for (var i = 0; i < nodes.Count; i++)
        nodes[i].Populate(this);


      var objs = gameObject.scene.GetRootGameObjects();
      foreach (var obj in objs)
      {
        var transforms = obj.GetComponentsInChildren<Transform>();

        foreach (var tr in transforms)
        {
          if (!tr.gameObject.activeInHierarchy) continue;
          var oo = tr.GetComponents<MonoBehaviour>();
          foreach (var o in oo)
          {
            if (o is IRequireActorsLayer req && o.enabled)
            {
              req.Bootstrap(this);
            }
          }
        }
      }

      #endregion
    }

    #region Services

    public static Y Add<Y>() where Y : new()
    {
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Bootstrap(LayerTyped);
      LayerTyped.objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    public static Y Get<Y>() where Y : class
    {
      return LayerTyped.objects[typeof(Y).GetHashCode()] as Y;
    }

    #endregion

    #region Coroutines

    /// Run coroutine on the top of this layer.
    public new static RoutineCall Run(IEnumerator routine)
    {
      return LayerTyped.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public new static RoutineCall Run(float delay, IEnumerator routine)
    {
      return LayerTyped.processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public new static RoutineCall RunUnscaled(IEnumerator routine)
    {
      return LayerTyped.processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public new static RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return LayerTyped.processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public new static bool Stop(IEnumerator routine)
    {
      return LayerTyped.processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public new static bool StopUnscaled(IEnumerator routine)
    {
      return LayerTyped.processorCoroutineUnscaled.Stop(routine);
    }


    public new static IEnumerator WaitFrame => null;

    public new static IEnumerator Wait(float t)
    {
      LayerTyped.processorCoroutine.delays[LayerTyped.processorCoroutine.currentIndex] = t;
      return null;
    }

    public new static IEnumerator WaitUnscaled(float t)
    {
      LayerTyped.processorCoroutineUnscaled.delays[LayerTyped.processorCoroutineUnscaled.currentIndex] = t;
      return null;
    }

    public new static RoutineCall WaitFor(float t, Action action)
    {
      var routine = Run(CoDelay());

      IEnumerator CoDelay()
      {
        yield return Wait(t);
        action();
      }

      return routine;
    }

    public new static RoutineCall WaitForUnscaled(float t, Action action)
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

    #region Signals

    public new static void Send<Y>(in Y signal) => LayerTyped.processorSignals.Dispatch(signal);
    public new static void AddSignal(object signal) => LayerTyped.processorSignals.Add(signal);
    public new static void RemoveSignal(object signal) => LayerTyped.processorSignals.Remove(signal);

    #endregion
  }
}