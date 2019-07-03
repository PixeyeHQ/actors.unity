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
		public ent entity = -1;

		#if UNITY_EDITOR
		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		internal int _entity = -1;
		#endif

		[FoldoutGroup("Main")]
		public bool isPooled;

		[FoldoutGroup("Main")]
		public ScriptableBuild buildFrom;

	 
	}
}