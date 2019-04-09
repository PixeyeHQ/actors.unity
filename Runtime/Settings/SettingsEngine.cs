//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

 
using UnityEngine;

namespace Pixeye.Framework
{
	public static class SettingsEngine
	{

		public const int SizeEntities = 1024;
		public const int SizeComponents = 1024;
		public const int SizeBlueprinths = 24;
		public const int SizeGenerations = 4;

		public static int sizeOfEnt;

		[RuntimeInitializeOnLoadMethod]
		static void Setup()
		{
			sizeOfEnt = System.Runtime.InteropServices.Marshal.SizeOf<ent>();
		}

	}
}