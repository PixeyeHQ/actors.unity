//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
public interface IObject
{

	void Tick(float delta);
	void OnAdd(in ent entity);
	void OnRemove(in ent entity);
	void Dispose();

}
}