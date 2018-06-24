/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/5/2018  8:49 AM
================================================================*/

namespace Homebrew
{
	public interface IAction
	{
		int priority { get; }
		bool finish { get; set; }
		bool isActing { get; set; }
		void Handle();
		void HandleInterrupt();
	 
	}
}