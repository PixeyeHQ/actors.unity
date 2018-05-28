/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/21/2018 9:08 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
	public class BehaviorInput : Behavior, ITick
	{
		[Bind] private DataMove dataMove;

		public override void OnTick()
		{
			dataMove.x = Input.GetAxis("Horizontal");
			dataMove.y = Input.GetAxis("Vertical");
		}
	}
}