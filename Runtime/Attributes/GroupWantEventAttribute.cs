//  Project : Actors
// Contacts : Pix - ask@pixeye.games


using System;

namespace Pixeye.Framework
{
	public sealed class GroupWantEventAttribute : Attribute
	{
		public Op ev;
		public GroupWantEventAttribute(Op ev)
		{
			this.ev = ev;
		}
	}
}