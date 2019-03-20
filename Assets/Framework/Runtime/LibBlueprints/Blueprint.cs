//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye
{
	[CreateAssetMenu(fileName = "Blueprint", menuName = "Actors/Blueprint")]
	public class Blueprint : ScriptableObject
	{

		[Button]
		public void Test() { }

	}
}