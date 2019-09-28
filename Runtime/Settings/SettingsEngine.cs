//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Actors
{
	[Serializable]
	public class SettingsEngine
	{
		public int SizeEntities = 1024;
		public int SizeComponents = 128;
		public int SizeGenerations = 4;
		public int SizeGroups = 256;
		public bool DebugNames = true;
		public string Namespace = "";
	}
}