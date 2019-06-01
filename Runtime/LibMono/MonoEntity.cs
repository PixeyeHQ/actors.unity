//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	sealed public class MonoEntity : MonoBehaviour, IActor
	{

		#if UNITY_EDITOR

		[SerializeField]
		int _entity;

		ent entityCached;

		public ent entity
		{
			get
			{
				return entityCached;
			}
			set
			{
				entityCached = value;
				_entity = entityCached.id;
			}
		}
		public ref ent GetEntity()
		{
			return ref entityCached;
		}
		#else
			public ent entity;

			public ref ent GetEntity()
		{
			return ref entity;
		}
		#endif

	}
}
