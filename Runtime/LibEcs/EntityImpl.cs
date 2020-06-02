using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public partial class EntityImpl : IRequireActorsLayer
  {

    internal ProcessorEcs processorEcs;

    public void Launch(LayerCore layer)
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
  }
}