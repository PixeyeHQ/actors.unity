//  Project : Actors
// Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using System.IO;
using UnityEditor;

namespace Pixeye.Framework
{
	internal static class DataFramework
	{

		public static int sizeTags
		{
			get { return EditorPrefs.GetInt("hba.data.tags", 24); }
			set { EditorPrefs.SetInt("hba.data.tags", value); }
		}

		public static string nameSpace
		{
			get { return EditorPrefs.GetString("hba.data.namespace", "Pixeye"); }
			set { EditorPrefs.SetString("hba.data.namespace", value); }
		}

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