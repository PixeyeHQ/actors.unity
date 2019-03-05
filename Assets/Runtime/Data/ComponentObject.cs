//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye
{
	public class ComponentObject : IComponent, IDisposable
	{
		public Transform transform;
		/// <summary>
		/// <para>The ID of pool storage. NOTE: If you add MonoEntity to the object this variable will be ignored.</para>
		/// </summary>
		public int poolType = -1;

		public void Dispose() { transform = null; }
	}

	public static class ExtensionComponentObject
	{
		public static ComponentObject ComponentObject(this int entity) { return Storage<ComponentObject>.Instance.components[entity]; }

		public static bool HasComponentObject(this int entity) { return Storage<ComponentObject>.Instance.HasComponent(entity); }
	}
}