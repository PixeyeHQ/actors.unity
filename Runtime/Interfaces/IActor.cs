//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
	public interface IActor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		ref ent GetEntity();
	}
}