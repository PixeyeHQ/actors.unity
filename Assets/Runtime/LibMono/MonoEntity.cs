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
		 
		[FoldoutGroup("Main"), TagFilter(typeof(Pool))]
		public int pool = -1;
		[FoldoutGroup("Main"),ReadOnly]
		public int entity = -1;
		[FoldoutGroup("Main"),ReadOnly]
		public bool conditionEnabled;

		bool conditionInitialized = false;
		
 		public virtual void OnEnable()
    	{
	        if (!conditionInitialized)
	        {
		        conditionInitialized = true;
		        return;
	        }
 		conditionEnabled = true;
 		ProcessingEntities.Default.CheckGroups(entity, true);
 		}
 
		public virtual void OnDisable()
		{
			conditionEnabled = false;
			ProcessingEntities.Default.CheckGroups(entity, false);
		}
		
		protected void OnDestroy()
		{
			int len = Storage.all.Count;

			for (int j = 0; j < len; j++)
				Storage.all[j].RemoveNoCheck(entity);

			Tags.Clear(entity);
			ProcessingEntities.prevID.Push(entity);
		}
		
		/// <summary>
		/// <para>Destroys the object. If the poolID is defined, deactivates the object instead.</para>
		/// </summary>
		public void Release()
		{
	 
			if (pool == Pool.None)
			{
				Destroy(gameObject, 0.03f);
				return;
			}

			gameObject.Release(pool);
		}
	}
}