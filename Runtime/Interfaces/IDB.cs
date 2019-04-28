//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Runtime.CompilerServices;

namespace Pixeye
{
	public interface IDB
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		T Get<T>(int hash) where T : class;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		T Get<T>() where T : class;
	}
}