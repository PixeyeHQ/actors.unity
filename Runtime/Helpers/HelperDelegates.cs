//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Actors
{
  public delegate bool EntityFunction(ent entity);

  public delegate bool EntityFunctionUpdated(ent entity, float delta);

  public delegate void EntityAction(ent entity);

  public delegate void EntityActionUpdated(ent entity, float delta);

  public delegate void ModelComposer(ent entity);

  public delegate void GroupEvent(ent[] entities, int length);
}