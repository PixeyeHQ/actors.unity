//  Project : Battlecruiser
// Contacts : Pix - info@pixeye.games
//     Date : 3/8/2019 

using UnityEngine;

namespace Pixeye.Framework
{
	public static class Log
	{

		public static void print(this object o, object content)
		{
			Debug.Log(content);
		}

	}
}