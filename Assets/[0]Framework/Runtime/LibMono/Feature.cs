//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Homebrew
{
	public abstract class Feature : IAwake
	{
		public void Add<T>() where T : new() { Toolbox.Add<T>(); }

		public abstract void OnAwake();
	}
}