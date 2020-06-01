using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public partial class EntityImpl : IRequireActorsLayer
  {
    public LayerCore layer;

    public void Launch(LayerCore layer)
    {
      this.layer = layer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create()
    {
      ProcessorEcs.Create(out var entity, layer);

      //EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
      return entity;
    }
  }
}