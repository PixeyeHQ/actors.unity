//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

 
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Homebrew
{
	/// <summary>
	/// <para>Links a game object with specific entity.</para>
	/// </summary>
	public class MonoEntity : MonoBehaviour
	{
		[FoldoutGroup("Main"),ReadOnly]
		public int entity = -1;
		[FoldoutGroup("Main"),ReadOnly]
		public bool conditionEnabled;
		public virtual void Release() { }
	}
}