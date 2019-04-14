//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public interface IScriptableObject
	{

		void Tick(in ent entity, float delta);
		void OnAdd(in ent entity);
		void OnRemove(in ent entity);
		void Dispose();

	}
}