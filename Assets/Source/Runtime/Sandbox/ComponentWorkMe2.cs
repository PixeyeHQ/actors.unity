//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
namespace Pixeye
{
   [Serializable]
   public class ComponentWorkMe2 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentWorkMe2 ComponentWorkMe2(this in ent entity)
        {
            return Storage<ComponentWorkMe2>.Instance.components[entity];
        }
    }
 
}