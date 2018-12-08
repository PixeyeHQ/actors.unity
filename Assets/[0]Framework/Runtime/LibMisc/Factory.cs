/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       16/09/2017 02:45
================================================================*/


 
namespace Homebrew
{
	public abstract class Factory<T> : FactoryBase where T : class
	{
		protected static T Default;
		void OnEnable() { Default = this as T; }
	}
}