/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/23/2018 1:39 PM
================================================================*/


#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Homebrew
{
	[CreateAssetMenu(menuName = "Plugables/Console", fileName = "Console")]
	public class PluggableConsole : Pluggable
	{
		[FoldoutGroup("Setup")] public CommandsConsole commandsDebug;
		public override void Plug()
		{
			Toolbox.Add<ProcessingConsole>().Setup(commandsDebug);	 
		}
	}
}