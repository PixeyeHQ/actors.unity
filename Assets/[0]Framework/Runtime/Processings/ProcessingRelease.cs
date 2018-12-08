//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 11/1/2018

namespace Homebrew
{
    public class ProcessingRelease : ProcessingBase
    {
        public Group<ComponentRelease> groupRelease;


        public ProcessingRelease()
        {
            groupRelease.Add += entity =>
            {
                var cRelease = entity.ComponentRelease();
                ComponentObject cObject;
                cRelease.isActor = false;
                if (entity.TryGetComponentObject(out cObject))
                {
                    cRelease.isActor = cObject.obj.GetComponent<Actor>();
                 
                }
                entity.ReleaseFinal(cRelease.isActor);
            };
        }

 
    }
}