//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/17/2019 

namespace Homebrew
{
	public interface IPopulate
	{
		void AsClone(ref EntityComposer c);
		void AsRef(ref EntityComposer c);
	}
}