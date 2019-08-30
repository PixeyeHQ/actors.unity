//  Project : Actors
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;

namespace Pixeye.Framework
{
	[Flags]
	public enum Op
	{
		Add = 0x0,
		Remove = 0x1,
		All = Add | Remove
	}

	public abstract class GroupEvents
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnRemove(ent[] entities, int length)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnAdd(ent[] entities, int length)
		{
		}

		internal virtual void AddProcessor(Processor proc)
		{
		}
	}

	public abstract class GroupEvents<T> : GroupEvents where T : class
	{
		public T proc;

		internal override void AddProcessor(Processor proc)
		{
			this.proc = proc as T;
		}
	}
}