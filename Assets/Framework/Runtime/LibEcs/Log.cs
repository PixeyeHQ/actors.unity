//  Project : Battlecruiser
// Contacts : Pix - info@pixeye.games
//     Date : 3/8/2019 

using UnityEngine;

namespace Pixeye
{
	public static class Log
	{
		public static void Show(string context, params object[] args)
		{
			var final = string.Format(context, args);
			Debug.Log(final);
		}

		public static void Show(string context, Object o, params object[] args)
		{
			var final = string.Format(context, args);
			Debug.Log(final, o);
		}
	}
}