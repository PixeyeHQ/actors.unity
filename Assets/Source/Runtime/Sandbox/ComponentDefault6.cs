using System;
using Pixeye;
namespace Home
{
   [Serializable]
   public class ComponentDefault6 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault6 ComponentDefault6(this in ent entity)
        {
            return Storage<ComponentDefault6>.Instance.components[entity];
        }
    }
 
}
