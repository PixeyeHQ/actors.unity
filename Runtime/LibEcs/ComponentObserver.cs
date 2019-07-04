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
		static void ComponentObserverInit()
		{
			Storage<ComponentObserver>.Instance.Creator       = () => new ComponentObserver();
			Storage<ComponentObserver>.Instance.DisposeAction = DisposeComponentObserver;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DisposeComponentObserver(in ent entity)
		{
			ref var component = ref Storage<ComponentObserver>.Instance.components[entity.id];


			for (int i = 0; i < component.length; i++)
			{
				component.wrappers[i].Dispose();
				component.wrappers[i] = null;
			}

			component.length = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref ComponentObserver ComponentObserver(in this ent entity)
		{
			return ref Storage<ComponentObserver>.Instance.components[entity.id];
		}
	}

	#endregion
}