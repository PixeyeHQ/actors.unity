//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using System.Runtime.CompilerServices;

namespace Pixeye.Framework
{
	public interface IActor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		ref ent GetEntity();
	}
}