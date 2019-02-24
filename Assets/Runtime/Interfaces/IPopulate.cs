//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/17/2019 

namespace Pixeye
{
	public interface IPopulate
	{
		void AsClone(ref EntityComposer c);
		void AsRef(ref EntityComposer c);
	}
}