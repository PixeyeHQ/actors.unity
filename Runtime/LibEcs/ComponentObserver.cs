//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
#if ACTORS_COMPONENTS_STRUCTS
  struct ComponentObserver
  {
    public IWrap[] wrappers;
    public int length;
  }

#else
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  sealed class ComponentObserver
  {
    public IWrap[] wrappers = new IWrap[1];
    public int length;
  }

#endif

  #region HELPERS

  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  static class ComponentHelper
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static ref ComponentObserver ComponentObserver(in this ent entity) =>
      ref Storage<ComponentObserver>.components[entity.id];
  }

  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  sealed class StorageComponentObserver : Storage<ComponentObserver>
  {
    public override ComponentObserver Create() => new ComponentObserver();

    public override void Dispose(indexes disposed)
    {
      foreach (var id in disposed)
      {
        ref var component = ref components[id];
        for (int ii = 0; ii < component.length; ii++)
        {
          component.wrappers[ii].Dispose();
          component.wrappers[ii] = null;
        }

        component.length = 0;
      }
    }
  }

  #endregion
}