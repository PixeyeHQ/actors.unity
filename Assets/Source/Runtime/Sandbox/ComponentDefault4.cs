using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentDefault4 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault4 ComponentDefault4(this in ent entity)
        {
            return Storage<ComponentDefault4>.Instance.components[entity];
        }
    }
 
}
