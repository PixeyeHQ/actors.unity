/*===============================================================
Product:    UndercityRts
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/19/2018 6:23 PM
================================================================*/


using System;
using UnityEngine;

namespace Homebrew
{
	[Serializable]
	public class DataGameObject : IData
	{
		public GameObject go;
		public Transform selfTransform;

		public void Dispose()
		{
			go = null;
			selfTransform = null;
		}
	}
}