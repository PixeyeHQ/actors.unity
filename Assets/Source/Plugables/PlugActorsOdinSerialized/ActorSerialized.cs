//   Project : Actors
//  Contacts : Pixeye - ask@pixeye.games 

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


namespace Pixeye
{
	public class ActorSerialized : Actor, IPoolable
	{
		[FoldoutGroup("Setup")]
		public TemplateActor template;
 
		protected override void Setup() { template.Add(this); }

		public void Spawn() {
      transform.CreateReferenceActor(entity, pool);
      template.Setup(this); }
	}
}
#endif