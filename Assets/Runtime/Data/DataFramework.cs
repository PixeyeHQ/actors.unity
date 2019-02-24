//  Project : Actors
// Contacts : Pixeye - ask@pixeye.games


#if UNITY_EDITOR
using System.IO;
using UnityEditor;

namespace Pixeye
{
	public static class DataFramework
	{
		//public static readonly string pathTagsMeta = @"\MetaTags.txt";

		public static string pathPrefabsEditor
		{
			get { return EditorPrefs.GetString("hba.path.prefabs", ""); }
			set { EditorPrefs.SetString("hba.path.prefabs", value); }
		}

		public static string pathTagsEditor
		{
			get { return EditorPrefs.GetString("hba.path.tags", @"\Assets\Runtime\Tags"); }
			set { EditorPrefs.SetString("hba.path.tags", value); }
		}

		public static string pathTags => Directory.GetCurrentDirectory() + EditorPrefs.GetString("hba.path.tags", @"\Assets\Runtime\Tags");
	}
}
#endif