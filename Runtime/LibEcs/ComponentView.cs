//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

using System;
 
using UnityEngine;

namespace Pixeye.Framework
{
	[Serializable]
	public class ComponentView : IComponent
	{

		[HideInInspector]
		public IView source;

		public void Copy(int entityID)
		{
			var component = Storage<ComponentView>.Instance.GetFromStorage(entityID);
		}

		public void Dispose()
		{
			source = null;
		}

	}

	public static partial class HelperComponents
	{

		[RuntimeInitializeOnLoadMethod]
		static void ComponentViewInit()
		{
			Storage<ComponentView>.Instance.Creator = () => { return new ComponentView(); };
		}

		public static ComponentView ComponentView(this in ent entity)
		{
			return Storage<ComponentView>.Instance.components[entity.id];
		}

	}
}