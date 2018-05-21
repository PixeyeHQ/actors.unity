/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/21/2018 9:08 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class BehaviorTest : Behavior, ITick
	{
		[Bind] private DataTest test;

		public override void OnTick()
		{
			Debug.Log(test.Test);
		}
	}
}