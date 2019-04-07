//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public delegate void CallBackEntity(in ent entity);
	public delegate void CallBackEntityTick(in ent entity, float delta);
}