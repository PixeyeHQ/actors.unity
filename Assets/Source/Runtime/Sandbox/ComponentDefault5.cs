using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentDefault5 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault5 ComponentDefault5(this in ent entity)
        {
            return Storage<ComponentDefault5>.Instance.components[entity];
        }
    }
 
}
