/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:49 PM
================================================================*/


using UnityEngine;
namespace Homebrew{
public class StarterKernel : MonoBehaviour {
	private void Awake()
	{
		Toolbox.Add<ProcessingUpdate>();
	}
}
}