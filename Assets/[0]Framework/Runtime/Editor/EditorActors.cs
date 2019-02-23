//  Project : Actors-Unity3d-Framework
// Contacts : Pixeye - ask@pixeye.games
//     Date : 2/23/2019 

using System.IO;
using UnityEditor;
using UnityEngine;

namespace Homebrew
{
	public class EditorActors : EditorWindow
	{
		[MenuItem("Tools/Actors/Preferences", priority = -10)]
		public static void ShowWindow() { GetWindow<EditorActors>(false, "Actors preferences", true); }

		void OnGUI() { Data.pathTagsEditor = EditorGUILayout.TextField("Tags path: ", Data.pathTagsEditor); }


		public static class Data
		{
			internal static readonly string pathTagsMeta = @"\MetaTags.txt";

			public static string pathTagsEditor
			{
				get { return EditorPrefs.GetString("hba.path.tags", @"\Assets\[1]Source\Runtime\Tags"); }
				set { EditorPrefs.SetString("hba.path.tags", value); }
			}

			public static string pathTags => Directory.GetCurrentDirectory() + EditorPrefs.GetString("hba.path.tags", @"\Assets\[1]Source\Runtime\Tags");
		}
	}
}