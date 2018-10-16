//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 10/16/2018

namespace Homebrew
{
    public class MonoActor : Actor
    {
        public override void OnEnable()
        {
            if (state.requireStarter || state.requireActorParent) return;

            state.released = false;
            state.enabled = true;

            HandleEnable();

            ProcessingUpdate.Default.Add(this);

            if (conditionSignals)
                ProcessingSignals.Default.Add(this);


            ProcessingEntities.Default.CheckGroups(entity, true);
        }

        public override void OnDisable()
        {
            state.enabled = false;
            state.released = true;
            if (conditionSignals)
                ProcessingSignals.Default.Remove(this);
            ProcessingUpdate.Default.Remove(this);
            ProcessingEntities.Default.CheckGroups(entity, false);


            HandleDisable();
        }
    }
}