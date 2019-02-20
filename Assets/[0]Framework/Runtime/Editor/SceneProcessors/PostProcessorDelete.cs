//  Project : Battlecruiser
// Contacts : Pixeye - info@pixeye.games
//     Date : 2/19/2019 

namespace Homebrew
{
	using UnityEngine;
	using UnityEditor;

	class PostProcessorDelete : AssetPostprocessor
	{
		static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
		{
			var starter = GameObject.FindObjectOfType<Starter>();
			if (starter != null)
				starter.CheckNodes();
 
		}
	}
}