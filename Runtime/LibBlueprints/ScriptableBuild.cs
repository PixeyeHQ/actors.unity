//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye.Framework
{
	#if ODIN_INSPECTOR
	using Sirenix.OdinInspector;

	public abstract class ScriptableBuild : SerializedScriptableObject
	{

		protected Dictionary<int, Action<EntityComposer>> helpers = new Dictionary<int, Action<EntityComposer>>();

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
	}

	#endif
}