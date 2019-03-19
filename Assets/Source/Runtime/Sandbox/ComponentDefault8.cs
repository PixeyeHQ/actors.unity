using System;
using Pixeye;
namespace Home
{
   [Serializable]
   public class ComponentDefault8 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault8 ComponentDefault8(this in ent entity)
        {
            return Storage<ComponentDefault8>.Instance.components[entity];
        }
    }
 
}
