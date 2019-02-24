//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games
namespace Pixeye
{
 

	public interface IReceive<T> : IReceive
	{
		void HandleSignal(ref T arg);
	}

	public interface IReceive
	{
	}
}