//   Project : Cryoshock
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 11/1/2018


namespace Homebrew
{
	[System.Serializable]
	public class ComponentRelease : IComponent
	{
	}

	public static partial class ExtensionComponentRelease
	{
		public static ComponentRelease ComponentRelease(this int entity) { return Storage<ComponentRelease>.Instance.components[entity]; }
	}
}