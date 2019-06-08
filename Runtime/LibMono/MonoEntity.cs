//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
namespace Pixeye.Framework
{
	sealed public class MonoEntity : MonoBehaviour, IActor
	{
		#if UNITY_EDITOR

		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		int _entity = -1;

		ent entityCached;

		public ent entity
		{
			get { return entityCached; }
			set
			{
				entityCached = value;
				_entity      = entityCached.id;
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