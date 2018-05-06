/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 1:53 PM
================================================================*/


using System;

namespace Homebrew
{
	[Flags]
	public enum EntityState
	{
		None = 0,
		Visible = 1 << 0,
		Active = 1 << 1,
		Enabled = 1 << 2,
		Released = 1 << 3,
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