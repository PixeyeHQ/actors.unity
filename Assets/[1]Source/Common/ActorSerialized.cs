//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/19/2019 

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


namespace Homebrew
{
	public class ActorSerialized : Actor, IPoolable
	{
		[FoldoutGroup("Setup")]
		public TemplateActor template;

		protected override void Setup() { template.Add(this); }

		public void Spawn() { template.Setup(this); }
	}
}
#endif