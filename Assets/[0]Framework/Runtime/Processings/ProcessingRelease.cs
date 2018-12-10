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
                if (entity.Get(out cObject))
                {
                    cRelease.isActor = cObject.obj.GetComponent<Actor>();
                    if (!cRelease.isActor && cObject.poolType != -1)
                    {
                        cObject.obj.Release(cObject.poolType);
                    }
                 
                }
                entity.ReleaseFinal(cRelease.isActor);
            };
        }

 
    }
}