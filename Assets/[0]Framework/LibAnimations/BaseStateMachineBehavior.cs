/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/15/2018  7:57 PM
================================================================*/

using System.Linq;
using UnityEngine;
namespace Homebrew{

public abstract class BaseStateMachineBehavior : StateMachineBehaviour
{
	protected Actor actor;

	public void Setup(Actor actor)
	{

		this.actor = actor;
		OnSetup();
	}

	public virtual void End()
	{
		
	}
	
	protected abstract void OnSetup();


}
	
	
	public static class SMUtilities
	{
		
		public static void End(this Animator animator)
		{
			var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>().ToList();
			for (var i = 0; i < behaviors.Count; i++)
			{
				behaviors[i].End();
			}
		}
		
		public static void Initialize(this Animator animator,  Actor actor)
		{
		 var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>().ToList();
			for (var i = 0; i < behaviors.Count; i++)
			{
				 behaviors[i].Setup(actor);
			}
		}
	}
	
	

}