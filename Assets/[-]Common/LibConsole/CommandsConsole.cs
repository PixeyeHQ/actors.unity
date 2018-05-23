/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew
Date:       1/27/2018 2:29 PM
================================================================*/

using UnityEngine;
namespace Homebrew{
public abstract class CommandsConsole : ScriptableObject {


    [Bind]
	public string Help()
    {
	   return Toolbox.Get<ProcessingConsole>().Help();
    }
	
	

}
}