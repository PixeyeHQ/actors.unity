using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public partial class ImplEntity : IRequireActorsLayer
  {
    internal ProcessorEcs processorEcs;

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
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
      entity.managed.transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(string prefabID, Transform parent, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled, true);
      entity.managed.transform =
        pooled ? Obj.Spawn(Pool.Entities, prefabID, parent, position) : Obj.Spawn(prefabID, parent, position);

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
        pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);

      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled);
      entity.managed.transform =
        pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity, pooled, true);
      entity.managed.transform =
        pooled ? Obj.Spawn(Pool.Entities, prefab, parent, position) : Obj.Spawn(prefab, parent, position);

      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    //===============================//
    // For object
    //===============================//

    public ent CreateFor(GameObject go, ModelComposer model)
    {
      processorEcs.Create(out var entity, false, true);
      entity.managed.transform = go.transform;
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent CreateFor(GameObject go)
    {
      processorEcs.Create(out var entity, false, true);
      entity.managed.transform = go.transform;
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    public ent CreateFor(string name)
    {
      processorEcs.Create(out var entity, false, true);
      entity.managed.transform = GameObject.Find(name).transform;
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }
  }
}