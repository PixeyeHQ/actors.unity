//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
using UnityEngine;

namespace Pixeye
{
	[CreateAssetMenu(fileName = "Blueprint", menuName = "Actors/Blueprint")]
	public class Blueprint : ScriptableObject
	{

		public List<ComponentRelease> components = new List<ComponentRelease>();

		[Button]
		public void Test()
		{
		}

	}
}