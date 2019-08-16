//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

#if UNITY_EDITOR
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
		bool isAlive;
		public void Setup(ent entity, bool isAlive)
		{
			this.entity  = entity;
			this.isAlive = isAlive;
		}


		#if ODIN_INSPECTOR
 	  [Sirenix.OdinInspector.Button]
		#else
		[Button]
		#endif
		void Activate()
		{
			if (isAlive) return;

			isAlive = true;
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			gameObject.SetActive(true);
		}

		#if ODIN_INSPECTOR
 	  [Sirenix.OdinInspector.Button]
		#else
		[Button]
		#endif
		void Deactivate()
		{
			if (!isAlive) return;

			isAlive = false;
			EntityOperations.Set(entity, 0, EntityOperations.Action.Deactivate);
			gameObject.SetActive(false);
		}


		void OnDestroy()
		{
			if (entity.Exist) entity.Release();
		}
	}
}
#endif