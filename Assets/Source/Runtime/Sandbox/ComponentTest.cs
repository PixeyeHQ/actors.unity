//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using UnityEngine;

namespace Pixeye
{
	[Serializable]
	public class ComponentTest : IComponent
	{
		public GameObject go;
	}

	public static class ExtensionComponentTest
	{
		public static ComponentTest ComponentTest(this in ent entity)
		{
			return Storage<ComponentTest>.Instance.components[entity];
		}
	}
}