//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye.Framework
{
	public interface IComponent
	{
		void Copy(int entityID);
		void Dispose();
	}
}