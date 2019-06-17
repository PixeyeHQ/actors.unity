//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public delegate bool EntityCallback(in ent entity);

	public delegate bool EntityCallbackUpdated(in ent entity, float delta);

	public delegate void EntityAction(in ent entity);

	public delegate void EntityActionUpdated(in ent entity, float delta);

	public delegate void ModelComposer(in ent entity);
}