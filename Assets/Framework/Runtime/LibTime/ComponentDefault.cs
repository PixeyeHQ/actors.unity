using System;
using Pixeye;
using UnityEngine;

namespace Pixeye
{
	[Serializable]
	public class ComponentDefault : IComponent
	{

		public GameObject gameObject;
		public float val;
		public Action ac;

	}

	public static class ExtensionComponents
	{

		public static ComponentDefault ComponentDefault(this in ent entity)
		{
			return Storage<ComponentDefault>.Instance.components[entity];
		}

	}
}