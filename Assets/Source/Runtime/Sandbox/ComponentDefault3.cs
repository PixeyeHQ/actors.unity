using System;
 namespace Pixeye
{
   [Serializable]
   public class ComponentDefault3 : IComponent
    {
          
    }
    
  public static partial class ExtensionComponents
    {
        public static ComponentDefault3 ComponentDefault3(this in ent entity)
        {
            return Storage<ComponentDefault3>.Instance.components[entity];
        }
    }
 
}
