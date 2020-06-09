
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class ImplEntity : IRequireActorsLayer
  {
    internal ProcessorEcs processorEcs;
    internal LayerCore layer;

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      this.layer   = layer;
      processorEcs = layer.processorEcs;
    }
    
    public ent Create()
    {
      processorEcs.Create(out var entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    //===============================//
    // From string
    //===============================//

    public ent Create(string prefabID, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform = pooled ? layer.Obj.Spawn(Pool.Entities, prefabID, position) : layer.Obj.Spawn(prefabID, position);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(ModelComposer model)
    {
      processorEcs.Create(out var entity);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }
    
    public ent Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform = pooled ? layer.Obj.Spawn(Pool.Entities, prefabID, position) : layer.Obj.Spawn(prefabID, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(string prefabID, Transform parent, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefabID, parent, position) : layer.Obj.Spawn(prefabID, parent, position);

      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(string prefabID, Transform parent, ModelComposer model, Vector3 position = default,
      bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefabID, parent, position) : layer.Obj.Spawn(prefabID, parent, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    //===============================//
    // From prefab
    //===============================//

    public ent Create(GameObject prefab, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefab, position) : layer.Obj.Spawn(prefab, position);

      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefab, position) : layer.Obj.Spawn(prefab, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefab, parent, position) : layer.Obj.Spawn(prefab, parent, position);

      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(GameObject prefab, Transform parent, ModelComposer model, Vector3 position = default,
      bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? layer.Obj.Spawn(Pool.Entities, prefab, parent, position) : layer.Obj.Spawn(prefab, parent, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    //===============================//
    // For object
    //===============================//

    internal ent CreateForActor(Actor actor, ScriptableBuild buildFrom, bool pooled)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform = actor.transform;
      if (buildFrom != null)
        buildFrom.ExecuteOnStart(entity, actor);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    internal ent CreateForActor(Actor actor, ModelComposer model, bool pooled)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform = actor.transform;
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }
 
    public ent CreateFor(GameObject go, ModelComposer model)
    {
      processorEcs.Create(out var entity, false);
      entity.managed.transform = go.transform;
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent CreateFor(GameObject go)
    {
      processorEcs.Create(out var entity, false);
      entity.managed.transform = go.transform;
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent CreateFor(string name)
    {
      processorEcs.Create(out var entity, false);
      entity.managed.transform = GameObject.Find(name).transform;
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }
  }
}