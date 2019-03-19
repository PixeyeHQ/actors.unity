using System;

namespace Pixeye
{
   [Serializable]
   public class ComponentMola : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentMola ComponentMola(this in ent entity)
        {
            return Storage<ComponentMola>.Instance.components[entity];
        }
    }
 
}