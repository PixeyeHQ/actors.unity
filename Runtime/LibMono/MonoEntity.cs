//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	sealed class MonoEntity : MonoBehaviour, IActor
	{

		public ent entity;

		public ref ent GetEntity
		{
			get => ref entity;
		}

	}
}
