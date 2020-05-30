//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Actors
{
#if ACTORS_COMPONENTS_STRUCTS
	struct ComponentObserver
	{
		public IWrap[] wrappers;
		public int length;
	}
#else
  sealed class ComponentObserver
  {
    public IWrap[] wrappers = new IWrap[1];
    public int length;
  }
#endif

  #region HELPERS

  static class component
  {
    internal static ref ComponentObserver ComponentObserver(in this ent entity) =>
      ref Storage<ComponentObserver>.components[entity.id];
  }

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