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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create()
    {
      processorEcs.Create(out var entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create(string prefabID, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity);
      entity.managed.transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity);
      entity.managed.transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      model(entity);
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create(string prefabID, Transform parent, Vector3 position = default, bool pooled = false)
    {
      processorEcs.Create(out var entity);
      entity.managed.transform =
        pooled ? Obj.Spawn(Pool.Entities, prefabID, parent, position) : Obj.Spawn(prefabID, parent, position);
  
      processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
      return entity;
    }


    //model(entity);
  }
}