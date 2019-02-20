//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/18/2019 

namespace Homebrew
{
	public abstract class Feature : IAwake
	{
		public void Add<T>() where T : new() { Toolbox.Add<T>(); }

		public abstract void OnAwake();
	}
}