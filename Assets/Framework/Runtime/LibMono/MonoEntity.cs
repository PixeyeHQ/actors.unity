//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Pixeye
{
	/// <summary>
	/// <para>Links a game object with specific entity.</para>
	/// </summary>
	public class MonoEntity : MonoBehaviour
	{
		#if UNITY_EDITOR
		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		public int _entity = -1;
		#endif

		[HideInInspector]
		public ent entity = -1;

		bool conditionInitialized;

		public virtual void OnEnable()
		{
			if (!conditionInitialized)
			{
				conditionInitialized = true;
				return;
			}

			RefEntity.isAlive[entity] = true; //|= ent.isEnabled | ent.isAlive;
			//EntityReferencesDepr.entityRefs[entity].TurnBitOn(ent.isEnabled|ent.isAlive);

			//conditionEnabled = true;
			ProcEntities.Default.CheckGroups(entity, true);
		}

		public virtual void OnDisable()
		{
			RefEntity.isAlive[entity] = false; //&= ~ent.isEnabled | ent.isAlive;
			//EntityReferencesDepr.entityRefs[entity].TurnBitOff(ent.isEnabled|ent.isAlive);
			//conditionEnabled = false;
			ProcEntities.Default.CheckGroups(entity, false);
		}

		protected void OnDestroy()
		{
			if (Toolbox.applicationIsQuitting) return;

			int len = Storage.all.Count;

			for (int j = 0; j < len; j++)
				Storage.all[j].RemoveNoCheck(entity);

			Tags.Clear(entity);
			ProcEntities.prevID.Push(entity);
		}

		public void CollectAllReferences()
		{
			entity.RefComponentsAll();
		}

		public void Release()
		{
			entity.Release();
		}
	}
}