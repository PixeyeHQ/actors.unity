using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentDefault1 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault1 ComponentDefault1(this in ent entity)
        {
            return Storage<ComponentDefault1>.Instance.components[entity];
        }
    }
 
}