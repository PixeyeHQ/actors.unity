/*===============================================================
Product:    Unity3dTools
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       5/6/2018 2:04 PM
================================================================*/


namespace Homebrew
{
	public interface ITickLate : IUpdatable
	{
		void TickLate();
	}
}