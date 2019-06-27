//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using Pixeye.Framework;
using UnityEngine;

namespace Pixeye.Source
{
	/// <summary>
	/// Activates/Deactives object with entity. This script won't be added to final build.
	/// </summary>
	sealed class ActorUtil : MonoBehaviour
	{
		ent entity;
		public void Setup(ent entity)
		{
			this.entity = entity;
		}

		#if ODIN_INSPECTOR
 	  [Sirenix.OdinInspector.Button]
		#else
		[Button]
		#endif
		void Activate()
		{
			unsafe
			{
				if (Entity.cache[entity.id].isAlive) return;

				Entity.cache[entity.id].isAlive = true;
				EntityOperations.Set(entity, 0, EntityOperations.Action.Activate);
				gameObject.SetActive(true);
			}
		}

		#if ODIN_INSPECTOR
 	  [Sirenix.OdinInspector.Button]
		#else
		[Button]
		#endif
		void Deactivate()
		{
			unsafe
			{
				if (!Entity.cache[entity.id].isAlive) return;

				Entity.cache[entity.id].isAlive = false;
				EntityOperations.Set(entity, 0, EntityOperations.Action.Deactivate);
				gameObject.SetActive(false);
			}
		}
		
	}
}