//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Pixeye.Framework
{
	/// <summary>
	/// <para>Links a game object with specific entity.</para>
	/// </summary>
	public class MonoEntity : MonoBehaviour, IEntity, IPoolable
	{

		#if UNITY_EDITOR
		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		public int _entity = -1;
		#endif

		[HideInInspector]
		public ent entity = -1;

		internal bool conditionInitialized;

		public virtual void OnEnable()
		{
			if (!conditionInitialized)
			{
				conditionInitialized = true;
				return;
			}

			EntityCore.isAlive[entity.id] = true;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
		}

		public virtual void OnDisable()
		{
			if (!EntityCore.isAlive[entity.id]) return;

			EntityCore.isAlive[entity.id] = false;
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Deactivate);
		}

		public void Release()
		{
			entity.Release();
		}

		public ref readonly ent GetEntity()
		{
			return ref entity;
		}

		public void Spawn()
		{
			conditionInitialized = false;
		}

	}
}