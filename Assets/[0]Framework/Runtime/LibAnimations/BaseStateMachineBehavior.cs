/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/15/2018  7:57 PM
================================================================*/


using UnityEngine;

namespace Homebrew
{
    public abstract class BaseStateMachineBehavior : StateMachineBehaviour
    {
        protected Actor actor;

        public void Setup(Actor actor)
        {
            this.actor = actor;
            OnSetup();
        }

        public abstract void End();
        protected abstract void OnSetup();
    }


    public static class SMUtilities
    {
        public static void End(this Animator animator)
        {
            var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>();
            foreach (var behavior in behaviors)
            {
                behavior.End();
            }
        }

        public static void Initialize(this Animator animator, Actor a)
        {
            var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>();
            foreach (var behavior in behaviors)
            {
                behavior.Setup(a);
            }
        }
    }
}