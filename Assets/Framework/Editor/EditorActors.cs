//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.IO;
using UnityEditor;
using UnityEngine;

namespace Pixeye
{
	public class EditorActors : EditorWindow
	{
		[MenuItem("Tools/Actors/Preferences", priority = -10)]
		public static void ShowWindow() { GetWindow<EditorActors>(false, "Actors preferences"); }

		void OnGUI()
		{
			//DataFramework.pathPrefabsEditor = EditorGUILayout.TextField("Prefabs Resource folder: ", DataFramework.pathPrefabsEditor);
			DataFramework.pathTagsEditor = EditorGUILayout.TextField("Tags path: ", DataFramework.pathTagsEditor);
		}


		 
	}
}