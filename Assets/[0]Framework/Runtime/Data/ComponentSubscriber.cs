/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/2/2018  7:54 AM
================================================================*/

 
namespace Homebrew{
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