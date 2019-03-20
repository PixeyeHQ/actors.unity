using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentDefault9 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault9 ComponentDefault9(this in ent entity)
        {
            return Storage<ComponentDefault9>.Instance.components[entity];
        }
    }
 
}
