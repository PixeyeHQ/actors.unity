//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using Unity.IL2CPP.CompilerServices;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public partial class Actor : MonoBehaviour, IRequireStarter, IActor
	{
		public ent entity;

		#if UNITY_EDITOR

		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		internal int _entity = -1;


		#endif

		[FoldoutGroup("Main")]
		public bool isPooled;

		[FoldoutGroup("Main")]
		public ScriptableBuild buildFrom;


		//===============================//
		// Methods
		//===============================//

		#if UNITY_EDITOR

		protected bool manualRemoved;

		void Awake() => manualRemoved = !enabled;

		protected virtual void OnEnable()
		{
			unsafe
			{
				if (!manualRemoved) return;
				manualRemoved                   = false;
				Entity.cache[entity.id].isAlive = true;
				EntityOperations.Set(entity, 0, EntityOperations.Action.Activate);
			}
		}

		protected virtual void OnDisable()
		{
			unsafe
			{
				if (Toolbox.applicationIsQuitting || !Entity.cache[entity.id].isAlive) return;
				manualRemoved                   = true;
				Entity.cache[entity.id].isAlive = false;
				EntityOperations.Set(entity, 0, EntityOperations.Action.Deactivate);
			}
		}

		#else
				protected virtual void OnEnable(){}
				protected virtual void OnDisable(){}
		#endif
	}
}