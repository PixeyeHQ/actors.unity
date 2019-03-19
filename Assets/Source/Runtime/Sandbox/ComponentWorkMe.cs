//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
namespace Pixeye
{
   [Serializable]
   public class ComponentWorkMe : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentWorkMe ComponentWorkMe(this in ent entity)
        {
            return Storage<ComponentWorkMe>.Instance.components[entity];
        }
    }
 
}