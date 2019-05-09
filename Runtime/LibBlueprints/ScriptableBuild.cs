//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Reflection;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Pixeye.Framework
{
	#if ODIN_INSPECTOR
	using Sirenix.OdinInspector;

	public abstract class ScriptableBuild : SerializedScriptableObject
	{

		protected Dictionary<int, Action<EntityComposer>> helpers = new Dictionary<int, Action<EntityComposer>>();

		
		protected virtual void OnEnable()
		{
			#if UNITY_EDITOR
			if (!EditorApplication.isPlayingOrWillChangePlaymode) return;
			#endif

			Type t = GetType();
			var n = name.Split(' ');
			helpers.Add(GetInstanceID(), (Action<EntityComposer>) Delegate.CreateDelegate(typeof(Action<EntityComposer>), null, t.GetMethod(n[1], BindingFlags.Public | BindingFlags.Static)));
		}

		protected virtual void OnDisable()
		{
			helpers.Clear();
		}
		
		
		internal virtual void Execute(in ent entity)
		{
			EntityComposer.Default.entity = entity;
			helpers[GetInstanceID()](EntityComposer.Default);
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

	}

	#else
	using UnityEngine;
	public class ScriptableBuild : ScriptableObject
	{
    protected Dictionary<int,Action<EntityComposer>> helpers = new Dictionary<int, Action<EntityComposer>>();
	
		internal virtual void Execute(in ent entity)
		{
			EntityComposer.Default.entity = entity;
			helpers[GetInstanceID()](EntityComposer.Default);
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

	  protected virtual void OnEnable()
		{
			#if UNITY_EDITOR
			if (!EditorApplication.isPlayingOrWillChangePlaymode) return;
			#endif

			Type t = GetType();
			var n = name.Split(' ');
			helpers.Add(GetInstanceID(), (Action<EntityComposer>) Delegate.CreateDelegate(typeof(Action<EntityComposer>), null, t.GetMethod(n[1], BindingFlags.Public | BindingFlags.Static)));
		}

		protected virtual void OnDisable()
		{
			helpers.Clear();
		}

	}

	#endif
}