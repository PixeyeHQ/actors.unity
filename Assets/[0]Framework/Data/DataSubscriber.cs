/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/2/2018  7:54 AM
================================================================*/

 
namespace Homebrew{
[System.Serializable]
public class DataSubscriber : IData
{
	public Actor actor;
  

	public void Dispose()
	{
		actor = null;
	}
}

}