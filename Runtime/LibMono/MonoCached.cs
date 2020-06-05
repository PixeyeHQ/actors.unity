#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Pixeye.Actors
{
  public abstract class MonoCached : MonoBehaviour, IRequireActorsLayer
  {
    [HideInInspector] public LayerCore Layer;

    public ProcessorUpdate Updates => Layer.Updates;
    public ImplObserver Observer => Layer.Observer;
    public ImplActor Actor => Layer.Actor;
    public ImplEntity Entity => Layer.Entity;
    public ImplEcs Ecs => Layer.Ecs;
    public ImplTime Time => Layer.Time;
    public ImplObj Obj => Layer.Obj;

    void Awake()
    {
      if (!Kernel.Instance) return;
      if (Kernel.ChangingScene[gameObject.scene.buildIndex]) return;
      Setup();
    }

    void OnEnable()
    {
      if (!Kernel.Instance) return;
      if (Kernel.ChangingScene[gameObject.scene.buildIndex]) return;
      HandleEnable();
    }

    void OnDisable()
    {
      if (Kernel.ApplicationIsQuitting) return;
      HandleDisable();
    }

    public virtual void Bootstrap(LayerCore layer)
    {
      this.Layer = layer;
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