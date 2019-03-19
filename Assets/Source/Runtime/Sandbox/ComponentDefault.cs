using System;
using Pixeye;
namespace MyNameSpace
{
   [Serializable]
   public class ComponentDefault : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault ComponentDefault(this in ent entity)
        {
            return Storage<ComponentDefault>.Instance.components[entity];
        }
    }
 
}