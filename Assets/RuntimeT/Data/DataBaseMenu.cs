//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;

namespace Pixeye
{
	[System.Serializable]
	public class ComponentBaseMenu : IComponent
	{
		public GameObject defaultSelected;

		public void Dispose()
		{
		}
	}
}