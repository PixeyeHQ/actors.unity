#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Pixeye.Actors
{
  public abstract class MonoCached : MonoBehaviour, IRequireActorsLayer
  {
    [HideInInspector] public LayerCore Layer;

    public ProcessorUpdate Engine => Layer.Engine;
    public ImplObserver Observer => Layer.Observer;
    public ImplActor Actor => Layer.Actor;
    public ImplEntity Entity => Layer.Entity;
    public ImplEcs Ecs => Layer.Ecs;
    public Time Time => Layer.Time;
    public ImplObj Obj => Layer.Obj;

    protected virtual void Start()
    {
      if (!LayerKernel.Instance || !LayerKernel.Initialized[gameObject.scene.buildIndex]) return;
      Layer = LayerKernel.Layers[gameObject.scene.buildIndex];
      Setup();
    }

    void OnEnable()
    {
      if (!LayerKernel.Instance || !LayerKernel.Initialized[gameObject.scene.buildIndex]) return;
      HandleEnable();
    }

    void OnDisable()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      HandleDisable();
    }

    public virtual void Bootstrap(LayerCore layer)
    {
      Layer = layer;
      Setup();
      HandleEnable();
    }

    protected virtual void HandleEnable()
    {
    }

    protected virtual void HandleDisable()
    {
    }

    /// Initialize here.
    protected virtual void Setup()
    {
    }
  }
}