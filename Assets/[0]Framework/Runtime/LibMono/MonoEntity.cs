//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/19/2019 

 
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Homebrew
{
	public class MonoEntity : MonoBehaviour
	{
		[FoldoutGroup("Main"),ReadOnly]
		public int entity = -1;
		[FoldoutGroup("Main"),ReadOnly]
		public bool conditionEnabled;
		public virtual void Release() { }
	}
}