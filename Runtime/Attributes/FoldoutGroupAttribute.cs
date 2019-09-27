/*===============================================================
Product:    ActorBasedBehaviors
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/17/2018 6:31 AM
================================================================*/

#if!ODIN_INSPECTOR

 
using UnityEngine;

namespace Pixeye.Actors
{
	public class FoldoutGroupAttribute : PropertyAttribute
	{
		public string name;
		public bool foldEverything;
 
		/// <summary>Adds the property to the specified foldout group.</summary>
		/// <param name="name">Name of the foldout group.</param>
		/// <param name="foldEverything">Toggle to put all properties to the specified group</param>
	
		public FoldoutGroupAttribute(string name, bool foldEverything = false)
		{
			this.foldEverything = foldEverything;
			this.name = name;
		}
		
		
		
	}
}
#endif