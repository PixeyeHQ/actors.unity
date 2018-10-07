/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       3/21/2018  10:34 AM
================================================================*/

using UnityEngine;

namespace Homebrew
{
	[System.Serializable]
	public class DataBaseMenu : IData
	{
		public GameObject defaultSelected;

		public void Dispose()
		{
		}
	}
}