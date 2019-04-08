//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye.Framework
{
	public interface IReceive<T> : IReceive
	{
		void HandleSignal(in T arg);
	}

	public interface IReceive { }
}