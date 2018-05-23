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
		int Priority { get; }
		bool Finish { get; set; }
		bool IsActing { get; set; }
		void Handle();
		void HandleInterrupt();
	 
	}
}