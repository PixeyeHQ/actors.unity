/*===============================================================
Product:    Unity-Framework
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       6/24/2018 2:58 PM
================================================================*/


using System;
using UnityEngine;

namespace Homebrew
{
	[Serializable]
	[CreateAssetMenu(fileName = "DataScene", menuName = "Data/Scenes")]
	public class DataScene : ScriptableObject
	{
		public string sceneName;
	}
}