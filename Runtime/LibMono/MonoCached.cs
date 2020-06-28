#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Pixeye.Actors
{
  public abstract class MonoCached : MonoBehaviour, IRequireActorsLayer
  {
    [HideInInspector] public Layer Layer;

    public ProcessorUpdate Engine => Layer.Engine;
    public ImplObserver Observer => Layer.Observer;
    public ImplActor Actor => Layer.Actor;
    public ImplEntity Entity => Layer.Entity;
    public ImplEcs Ecs => Layer.Ecs;
    public Time Time => Layer.Time;
    public ImplObj Obj => Layer.Obj;

    protected virtual void Start()
    {
      if (!LayerKernel.InstanceInternal || !LayerKernel.Initialized[SceneSub.GetLayerIndex(gameObject.scene.name)]) return;
      if (Layer != null) return;
      
      Layer = LayerKernel.Layers[SceneSub.GetLayerIndex(gameObject.scene.name)];
      Setup();
    }

    void OnEnable()
    {
      if (!LayerKernel.InstanceInternal || !LayerKernel.Initialized[SceneSub.GetLayerIndex(gameObject.scene.name)]) return;
      HandleEnable();
    }

    void OnDisable()
    {
      if (LayerKernel.ApplicationIsQuitting) return;
      HandleDisable();
    }

    public virtual void Bootstrap(Layer layer)
    {
      // Case: Session Start. 
      // When childs are initialized manually from the parent, layer will treat them as eligable
      // objects to bootstrap. To prevent double bootstrap we check the layer. If it is not null
      // then we know that the monocache was already activated.
      if (Layer != null) return;
      Layer = layer;
      Setup();
      HandleEnable();
    }

    public virtual void HandleEnable()
    {
    }

    public virtual void HandleDisable()
    {
    }

    /// Initialize your logic here. This is a custom Start method.
    protected virtual void Setup()
    {
    }
  }
}
