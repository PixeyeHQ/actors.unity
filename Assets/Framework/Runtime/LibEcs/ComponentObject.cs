//  Project : ecs
// Contacts : Pix - ask@pixeye.games
//     Date : 3/10/2019 

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Serializable]
	public class ComponentObject : IComponent
	{

		 

		public void Copy(int entityID)
		{
		}
		public void Dispose()
		{
		}

	}

	public static partial class HelperComponents
	{

		[RuntimeInitializeOnLoadMethod]
		static void ComponentObjectInit()
		{
			Storage<ComponentObject>.Instance.Creator = () => { return new ComponentObject(); };
    			 
		}

	}
	
}