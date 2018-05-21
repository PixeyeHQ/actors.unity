/*===============================================================
Product:    BattlecruiserPrototype
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/28/2018 5:23 PM
================================================================*/


using System;

namespace Homebrew
{
	[AttributeUsage(AttributeTargets.Field)]
	public class TagFieldAttribute : Attribute
	{
		public string categoryName;
	}
}