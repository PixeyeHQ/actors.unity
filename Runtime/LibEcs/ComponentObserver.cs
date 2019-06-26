//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace Pixeye.Framework
{
	[Serializable]
	public sealed class ComponentObserver
	{
		public IWrap[] wrappers = new IWrap[1];
		public int length;
	}

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
		public static void DisposeComponentObserver(in ent entity)
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
		public static ref ComponentObserver ComponentObserver(in this ent entity)
		{
			return ref Storage<ComponentObserver>.Instance.components[entity.id];
		}
	}

	#endregion
}