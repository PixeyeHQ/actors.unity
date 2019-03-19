using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentDefault2 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault2 ComponentDefault2(this in ent entity)
        {
            return Storage<ComponentDefault2>.Instance.components[entity];
        }
    }
 
}
