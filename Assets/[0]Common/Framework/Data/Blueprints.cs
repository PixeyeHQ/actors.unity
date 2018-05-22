/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/14/2018  12:07 PM
================================================================*/


using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	[CreateAssetMenu(fileName = "Blueprints", menuName = "Data/Blueprints")]
	[System.Serializable]
	public class Blueprints : ScriptableObject, IAwake
	{
		public List<Blueprint> blueprints = new List<Blueprint>();


		public void OnAwake()
		{
			for (var i = 0; i < blueprints.Count; i++)
			{
				blueprints[i].Setup();
			}
		}
	}
}