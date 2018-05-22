/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       4/30/2018  9:50 PM
================================================================*/


using System;
 
namespace Homebrew
{
	[Serializable]
	public class DataBlueprint : IData
	{
		public Blueprint blueprint;
 
		public void Dispose()
		{
 
			blueprint = null;
		}

		public T Get<T>() where T : class
		{
			return blueprint.Get<T>();
		}
	  
	}
}