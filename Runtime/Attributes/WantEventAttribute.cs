//  Project : Actors
// Contacts : Pix - ask@pixeye.games


using System;

namespace Pixeye.Framework
{
	public sealed class WantEventAttribute : Attribute
	{
		public Op ev;
		public WantEventAttribute(Op ev)
		{
			this.ev = ev;
		}
	}
}