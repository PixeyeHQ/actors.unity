//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
 
using UnityEngine;

namespace Pixeye
{
	[CreateAssetMenu(fileName = "Blueprint", menuName = "Actors/Blueprint")]
	public class Blueprint : ScriptableObject
	{

		public IComponent component;
		
		[Reorderable]
		public List<IComponent> components = new List<IComponent>();

  

	}
}