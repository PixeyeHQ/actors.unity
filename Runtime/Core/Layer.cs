//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor;
#endif
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  /// A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene. 
  public abstract class Layer<T> : LayerCore
  {
    public static ImplEntity Entity => layer.implEntity;
    public static ImplEcs Ecs => layer.implEcs;
    public static ImplObserver Observer => layer.implObserver;
 
    internal static Layer<T> layer;

    protected sealed override void Awake()
    {
      base.Awake();
      Bootstrap(); // Setup actors logic for a scene.
      Setup();     // Entry point for developers.
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
        Kernel.Layers[buildIndex] = this;
      }

      layer = this;

      #endregion

      #region Update Services

      Processor.NextID = 0; // drop so the processors of the new layer can grab fresh ID.

      processorUpdate = new ProcessorUpdate();
      processorUpdate.Add(this);

      processorCoroutine = Add<ProcessorCoroutine>();
      processorSignals   = Add<ProcessorSignals>();
      processorEcs       = Add<ProcessorEcs>();
      implEntity         = Add<ImplEntity>();
      implEcs            = Add<ImplEcs>();

      Add<ProcessorObserver>();

      processorUpdate.layer = layer;

      #endregion

      #region Update Active Layer

      if (gameObject.scene.name != Kernel.KernelSceneName)
        if (ActiveScene.NextActiveSceneName != null && ActiveScene.NextActiveSceneName == gameObject.scene.name)
        {
          ActiveScene.NextActiveSceneName = default;
          ActiveLayer                     = this;
          Run(CoWaitForSceneLoad());

          IEnumerator CoWaitForSceneLoad()
          {
            while (!gameObject.scene.isLoaded)
              yield return 0;

            SceneManager.SetActiveScene(gameObject.scene);
          }
        }

      #endregion
    }


    #region Services

    public static Y Add<Y>() where Y : new()
    {
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Bootstrap(layer);
      layer.objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    public static Y Get<Y>() where Y : class
    {
      return layer.objects[typeof(Y).GetHashCode()] as Y;
    }

    #endregion

    #region Coroutines

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(IEnumerator routine)
    {
      return layer.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(float delay, IEnumerator routine)
    {
      return layer.processorCoroutine.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool Stop(IEnumerator routine)
    {
      return layer.processorCoroutine.Stop(routine);
    }

    public static IEnumerator WaitFrame => null;

    public static IEnumerator Wait(float t)
    {
      layer.processorCoroutine.delays[layer.processorCoroutine.currentIndex] = t;
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

    #endregion

    #region Signals

    public new static void Send<Y>(in Y signal) => layer.processorSignals.Dispatch(signal);
    public new static void AddSignal(object signal) => layer.processorSignals.Add(signal);
    public new static void RemoveSignal(object signal) => layer.processorSignals.Remove(signal);

    #endregion
  }
}