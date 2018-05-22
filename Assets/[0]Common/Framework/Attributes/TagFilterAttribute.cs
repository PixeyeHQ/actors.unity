/*===============================================================
Product:    BattlecruiserPrototype
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/28/2018 5:42 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class TagFilterAttribute : PropertyAttribute
	{
		private System.Type tagType;

		public System.Type Type => tagType;

		public TagFilterAttribute(System.Type type)
		{
			tagType = type;
		}
	}
}