/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/13/2018  11:02 PM
================================================================*/

using System;

namespace Homebrew
{
	[Flags]
	public enum EntityState
	{
		Visible = 1 << 0,
		Active = 1 << 1,
		Enabled = 1 << 2,
		Released = 1 << 3,
		OnHold = 1 << 4,
		ActiveAndEnabled = Active | Enabled
	}

	public static partial class FrameworkExtensions
	{
		public static bool HasState(this EntityState state, EntityState possibleState)
		{
			return (state & possibleState) == possibleState;
		}
		
		
	}
}