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
    public static new ProcessorUpdate Engine => InternalInstance.core.Engine;
    public static new ImplEntity Entity => InternalInstance.core.Entity;
    public static new ImplEcs Ecs => InternalInstance.core.Ecs;
    public static new ImplObserver Observer => InternalInstance.core.Observer;
    public static new ImplActor Actor => InternalInstance.core.Actor;
    public static new Time Time => InternalInstance.core.Time;
    public static new ImplObj Obj => InternalInstance.core.Obj;
    public static new int ID => InternalInstance.id;
    
    internal static Layer<T> InternalInstance;
    internal LayerCore core;

  

    protected sealed override void Awake()
    {
      core = this;
      base.Awake();
      Bootstrap(); // Setup actors logic for a scene.
      Setup();     // Entry point for developers.
    }

    void Start()
    {
      isReleasing = false;
    }

    void Bootstrap()
    {
      #region Update Layers

      var buildIndex = gameObject.scene.buildIndex;
      if (buildIndex != -1)
      {
        LayerKernel.Layers[buildIndex] = this;
      }

      InternalInstance = this;

      #endregion

      #region Update Services

      Processor.NEXT_FREE_ID = 0; // drop so the processors of the new layer can grab fresh ID.

      core.Engine = new ProcessorUpdate();
      Engine.Add(this);

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

      Engine.layer = InternalInstance;

      #endregion

      #region Update Layer

      if (gameObject.scene.name != LayerKernel.KernelSceneName)
        if (SceneMain.NextActiveSceneName != null && SceneMain.NextActiveSceneName == gameObject.scene.name)
        {
          SceneMain.NextActiveSceneName = default;
          ActiveLayer                   = this;
        }

      Run(CoWaitForSceneLoad());

      IEnumerator CoWaitForSceneLoad()
      {
        while (!gameObject.scene.isLoaded)
          yield return 0;

        if (ActiveLayer == this)
        {
          SceneManager.SetActiveScene(gameObject.scene);
        }


        if (gameObject.scene.buildIndex >= 0)
          LayerKernel.Initialized[gameObject.scene.buildIndex] = true;
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
      LayerKernel.LayerCurrentInit = InternalInstance;
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Bootstrap(InternalInstance);
      InternalInstance.objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    public static void Remove<Y>()
    {
      var key = typeof(Y).GetHashCode();
      if (InternalInstance.objects.TryGetValue(key, out var obj))
      {
        if (obj is IDisposable member)
          member.Dispose();
        InternalInstance.objects.Remove(key);
      }
    }

    public static void Remove<Y>(Y obj)
    {
      if (obj is IDisposable member)
        member.Dispose();

      InternalInstance.objects.Remove(typeof(Y).GetHashCode());
    }


    public static Y Get<Y>() where Y : class
    {
      return InternalInstance.objects[typeof(Y).GetHashCode()] as Y;
    }

    #endregion

    #region Coroutines

    /// Run coroutine on the top of this layer.
    public new static RoutineCall Run(IEnumerator routine)
    {
      return InternalInstance.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public new static RoutineCall Run(float delay, IEnumerator routine)
    {
      return InternalInstance.processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public new static RoutineCall RunUnscaled(IEnumerator routine)
    {
      return InternalInstance.processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public new static RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return InternalInstance.processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public new static bool Stop(IEnumerator routine)
    {
      return InternalInstance.processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public new static bool StopUnscaled(IEnumerator routine)
    {
      return InternalInstance.processorCoroutineUnscaled.Stop(routine);
    }


    public new static IEnumerator WaitFrame => null;

    public new static IEnumerator Wait(float t)
    {
      InternalInstance.processorCoroutine.delays[InternalInstance.processorCoroutine.currentIndex] = t;
      return null;
    }

    public new static IEnumerator WaitUnscaled(float t)
    {
      InternalInstance.processorCoroutineUnscaled.delays[InternalInstance.processorCoroutineUnscaled.currentIndex] = t;
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

    public new static void Send<Y>(in Y signal) => InternalInstance.processorSignals.Dispatch(signal);
    public new static void AddSignal(object signal) => InternalInstance.processorSignals.Add(signal);
    public new static void RemoveSignal(object signal) => InternalInstance.processorSignals.Remove(signal);

    #endregion
  }
}