//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	[System.Serializable]
	public class SceneReference
	{

		[SerializeField]
		private Object sceneAsset;
		[SerializeField]
		private string sceneName = "";

		public string Path => sceneName;

		// makes it work with the existing Unity methods (LoadLevel/LoadScene)
		public static implicit operator string(SceneReference sceneReference)
		{
			return sceneReference.Path;
		}

	}
}
 