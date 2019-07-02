//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif

namespace Pixeye.Framework
{
	public class ScriptableBuild : ScriptableObject

	{
		public Dictionary<int, ModelComposer> helpers = new Dictionary<int, ModelComposer>();

		internal virtual void Execute(in ent entity, Actor a = null)
		{
			helpers[GetInstanceID()](entity);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
		}

		internal virtual void ExecuteOnStart(in ent entity, Actor a)
		{
			helpers[GetInstanceID()](entity);
			if (!a.isActiveAndEnabled) return;
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
		}

		protected virtual void OnEnable()
		{
			#if UNITY_EDITOR
			if (!EditorApplication.isPlayingOrWillChangePlaymode) return;
			#endif

			Type t = GetType();
			var  n = name.Substring(5).Replace(" ", string.Empty);
			helpers.Add(GetInstanceID(), (ModelComposer) Delegate.CreateDelegate(typeof(ModelComposer), null, t.GetMethod(n, BindingFlags.Public | BindingFlags.Static | BindingFlags.Default)));
		}

		protected virtual void OnDisable()
		{
			helpers.Clear();
		}
	}
}