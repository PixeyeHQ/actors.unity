//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using UnityEngine;
using System.Runtime.CompilerServices;

namespace Pixeye.Framework
{
	#if ACTORS_COMPONENTS_STRUCTS
	struct ComponentObserver
	{
		public IWrap[] wrappers;
		public int length;
	}
	#else
	sealed class ComponentObserver
	{
		public IWrap[] wrappers = new IWrap[1];
		public int length;
	}
	#endif


	#region HELPERS

	public static partial class Components
	{
		public const string Observer = "Pixeye.Source.ComponentObserver";


		[RuntimeInitializeOnLoadMethod]
		static void ComponentObserverInit()=> new SComponentObserver();
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref ComponentObserver ComponentObserver(in this ent entity) =>
			ref Storage<ComponentObserver>.components[entity.id];


		internal class SComponentObserver : Storage<ComponentObserver>.Setup
		{
			public override ComponentObserver Create() => new ComponentObserver();

			public override void Dispose(int[] id, int len)
			{
				for (int i = 0; i < len; i++)
				{
					ref var component = ref components[id[i]];
					
					for (int ii = 0; ii < component.length; ii++)
					{
						component.wrappers[ii].Dispose();
						component.wrappers[ii] = null;
					}

					component.length = 0;
				}
			}
		}
	}

	#endregion
}