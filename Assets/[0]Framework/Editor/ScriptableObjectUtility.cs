/*===============================================================
Product:    Unity-Framework
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       6/24/2018 3:02 PM
================================================================*/


using System;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Homebrew
{
	public static class ScriptableObjectUtility
	{
		/// <summary>
		//	This makes it easy to create, name and place unique new ScriptableObject asset files.
		/// </summary>
		public static T CreateOrGetAsset<T>(string p, string n) where T : ScriptableObject
		{
			T asset = AssetDatabase.LoadAssetAtPath<T>("Assets/" + p + "/" + n + ".asset");

			if (asset == null)
			{
				asset = ScriptableObject.CreateInstance<T>();


				string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath("Assets/" + p + "/" + n + ".asset");
				if (assetPathAndName == String.Empty)
				{
					Directory.CreateDirectory(Application.dataPath + "/" + p);
					assetPathAndName = AssetDatabase.GenerateUniqueAssetPath("Assets/" + p + "/" + n + ".asset");
				}


				AssetDatabase.CreateAsset(asset, assetPathAndName);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
			}

			return asset;
		}
	}
}