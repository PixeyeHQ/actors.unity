//  Project : ecs
// Contacts : Pix - ask@pixeye.games
//     Date : 3/12/2019 

using System;

namespace Pixeye
{
	[Serializable]
	public class ComponentData : IComponent
	{
		[TagFilter(typeof(ITagData))]
		public int source;
	}

	public static class ExtensionComponentData
	{
		public static ComponentData ComponentData(this ent entity)
		{
			return Storage<ComponentData>.Instance.components[entity];
		}
	}
}