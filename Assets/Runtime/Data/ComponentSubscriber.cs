//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games
 
namespace Pixeye{
[System.Serializable]
public class ComponentSubscriber : IComponent
{
	public Actor Actor;
  

	public void Dispose()
	{
		Actor = null;
	}
}

}