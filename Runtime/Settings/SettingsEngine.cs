//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	[Serializable]
	public class SettingsEngine
	{
		public int SizeEntities = 1024;
		public int SizeComponents = 256;
		public int SizeGenerations = 4;
		public int SizeProcessors = 256;
	}
}