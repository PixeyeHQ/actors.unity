using System;
using Pixeye;
namespace Home
{
   [Serializable]
   public class ComponentDefault7 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault7 ComponentDefault7(this in ent entity)
        {
            return Storage<ComponentDefault7>.Instance.components[entity];
        }
    }
 
}
