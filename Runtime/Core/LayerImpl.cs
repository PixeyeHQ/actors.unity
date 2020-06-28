//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Pixeye.Actors
{
  /// A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene. 
  public abstract class Layer<T> : MonoBehaviour
  {
    public static ProcessorUpdate Engine => InstanceInternal.self.Engine;
    public static ImplEntity Entity => InstanceInternal.self.Entity;
    public static ImplEcs Ecs => InstanceInternal.self.Ecs;
    public static ImplObserver Observer => InstanceInternal.self.Observer;
    public static ImplActor Actor => InstanceInternal.self.Actor;
    public static Time Time => InstanceInternal.self.Time;
    public static ImplObj Obj => InstanceInternal.self.Obj;

    public static int ID => InstanceInternal.self.id;

    internal static Layer<T> InstanceInternal;

    [SerializeField, HideInInspector]
    public Layer self;

    void Awake()
    {
      self = new Layer(gameObject, OnLayerDestroy);

      //temporary
      if (gameObject.scene.name == SceneMain.NextActiveSceneName)
        Layer.ActiveLayer = self;

      Bootstrap();      // Setup layer.
      Setup();          // Entry point for developers.
      ActivateActors(); // Setup sctors.
    }

    void Start()
    {
      self.isReleasing = false;
    }

    void ActivateActors()
    {
     
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
              req.Bootstrap(self);
            }
          }
        }
      }
    }

    void Update()
    {
#if UNITY_EDITOR
      if (self == null || self.Engine == null) return;
#endif
      self.Engine.Update();
    }

    void FixedUpdate()
    {
#if UNITY_EDITOR
      if (self == null || self.Engine == null) return;
#endif
      self.Engine.FixedUpdate();
    }

    void LateUpdate()
    {
#if UNITY_EDITOR
      if (self == null || self.Engine == null) return;
#endif
      self.Engine.LateUpdate();
    }

    void OnApplicationQuit()
    {
#if UNITY_EDITOR
      if (self == null) return;
#endif
      self.isReleasing = true;
    }

    /// Scene entry point, load your custom stuff from here.
    protected abstract void Setup();

    /// Clean *your* custom scene stuff from here.
    protected virtual void OnLayerDestroy()
    {
    }

    void Bootstrap()
    {
      #region Update Layers

      var buildIndex = gameObject.scene.buildIndex;
      if (buildIndex != -1)
      {
        LayerKernel.Layers[buildIndex] = self;
      }

      InstanceInternal = this;

      #endregion

      #region Update Services

      Processor.NEXT_FREE_ID = 0; // drop so the processors of the new layer can grab fresh ID.

      self.Engine = new ProcessorUpdate();
      Engine.Add(this);

      // cant add two same classes in toolbox :( temporary solution.
      self.processorCoroutineUnscaled            = new ProcessorCoroutine();
      self.processorCoroutineUnscaled.timescaled = false;
      self.processorCoroutineUnscaled.Bootstrap(self);

      self.processorCoroutine = new ProcessorCoroutine();
      self.processorCoroutine.Bootstrap(self);

      self.Pool = Add<Pool>();
      self.Obj  = Add<ImplObj>();

      self.processorSignals = Add<ProcessorSignals>();
      self.processorEcs     = Add<ProcessorEcs>();
      self.Actor            = Add<ImplActor>();
      self.Entity           = Add<ImplEntity>();
      self.Ecs              = Add<ImplEcs>();
      self.Observer         = Add<ImplObserver>();

      Add<ProcessorObserver>();

      Engine.layer = self;

      #endregion

      #region Update Layer

      Run(CoWaitForSceneLoad());

      IEnumerator CoWaitForSceneLoad()
      {
        while (!gameObject.scene.isLoaded)
          yield return 0;


        if (gameObject.scene.name == SceneMain.NextActiveSceneName)
        {
          Layer.ActiveLayer = self;
          SceneManager.SetActiveScene(gameObject.scene);
        }

        if (gameObject.scene.buildIndex >= 0)
          LayerKernel.Initialized[gameObject.scene.buildIndex] = true;
      }

      #endregion
    }

    #region Services

    public static Y Add<Y>() where Y : new()
    {
      LayerKernel.LayerCurrentInit = InstanceInternal.self;
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Bootstrap(InstanceInternal.self);
      InstanceInternal.self.objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    public static void Remove<Y>()
    {
      var key = typeof(Y).GetHashCode();
      if (InstanceInternal.self.objects.TryGetValue(key, out var obj))
      {
        if (obj is IDisposable member)
          member.Dispose();
        InstanceInternal.self.objects.Remove(key);
      }
    }

    public static void Remove<Y>(Y obj)
    {
      if (obj is IDisposable member)
        member.Dispose();

      InstanceInternal.self.objects.Remove(typeof(Y).GetHashCode());
    }


    public static Y Get<Y>() where Y : class
    {
      return InstanceInternal.self.objects[typeof(Y).GetHashCode()] as Y;
    }

    /// performs a search of the gameobject by name on all scenes, cache it and
    /// returns it transform.
    public static Transform GetObj(string goName)
    {
      return InstanceInternal.self.GetObj(goName);
    }

    /// performs a search of the gameobject by tag on all scenes, cache it and
    /// returns it transform.
    public static Transform GetObjByTag(string tagName)
    {
      return InstanceInternal.self.GetObjByTag(tagName);
    }

    /// performs a search of the gameobject by type on all scenes, cache it and
    /// returns T.
    public static Y GetObj<Y>() where Y : MonoBehaviour
    {
      return InstanceInternal.self.GetObj<Y>();
    }


    public static Buffer<Y> GetBuffer<Y>() where Y : struct
    {
      return InstanceInternal.self.GetBuffer<Y>();
    }

    #endregion

    #region Coroutines

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(float delay, IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutine.Run(delay, routine);
    }


    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutineUnscaled.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall RunUnscaled(float delay, IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutineUnscaled.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool Stop(IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutine.Stop(routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool StopUnscaled(IEnumerator routine)
    {
      return InstanceInternal.self.processorCoroutineUnscaled.Stop(routine);
    }


    public static IEnumerator WaitFrame => null;

    public static IEnumerator Wait(float t)
    {
      InstanceInternal.self.processorCoroutine.delays[InstanceInternal.self.processorCoroutine.currentIndex] = t;
      return null;
    }

    public static IEnumerator WaitUnscaled(float t)
    {
      InstanceInternal.self.processorCoroutineUnscaled.delays[
        InstanceInternal.self.processorCoroutineUnscaled.currentIndex] = t;
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

    #region Signals

    public static void Send<Y>(in Y signal) => InstanceInternal.self.processorSignals.Dispatch(signal);
    public static void AddSignal(object signal) => InstanceInternal.self.processorSignals.Add(signal);
    public static void RemoveSignal(object signal) => InstanceInternal.self.processorSignals.Remove(signal);

    #endregion
 
  }
}