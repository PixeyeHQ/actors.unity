/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/23/2018 1:07 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public abstract class Plugable : ScriptableObject
	{
		public abstract void Plug();
	}
}