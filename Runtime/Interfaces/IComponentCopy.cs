//  Project : ecs
// Contacts : Pix - ask@pixeye.games



namespace Pixeye.Framework
{
   public interface IComponentCopy
    {
	    void Copy(int entityID);
    }
   
   ///   public void Copy(int entityID)
   ///   {
   ///      var component = Storage<${NAME}>.Instance.GetFromStorage(entityID);
   ///   }
    
   
}