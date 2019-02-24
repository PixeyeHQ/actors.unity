//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye
{
	public interface IPopulate
	{
		void AsClone(ref EntityComposer c);
		void AsRef(ref EntityComposer c);
	}
}