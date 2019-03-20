//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.IO;
using System.Linq;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Pixeye
{
	public class StarterTest : Starter
	{

		public GameObject go;
		public int amount = 50;
		public static GameObject gogo;

		protected override void Setup()
		{
			gogo = go;
			Add<ProcTest>();

			var path = Application.dataPath;
			var from = path.LastIndexOf("/");

			path = path.Remove(from);
			path += "/Test";

			for ( int i = 0; i < amount; i++ )
			{
				Instantiate(go);
			}
		}

	}
}