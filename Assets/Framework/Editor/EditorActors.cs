//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Pixeye
{
	public class EditorActors : EditorWindow
	{
		[MenuItem("Tools/Actors/Preferences", priority = -10)]
		public static void ShowWindow()
		{
			GetWindow<EditorActors>(false, "Actors preferences");
		}

		void OnGUI()
		{
			//DataFramework.pathPrefabsEditor = EditorGUILayout.TextField("Prefabs Resource folder: ", DataFramework.pathPrefabsEditor);
			DataFramework.pathTagsEditor = EditorGUILayout.TextField("Tags path: ", DataFramework.pathTagsEditor);
		}
	}

	[InitializeOnLoad]
	public class EditorActorsFramework
	{
		static bool validate = false;

		static EditorActorsFramework()
		{
			EditorApplication.update += Updating;
		}


		static void Updating()
		{
			var state = EditorApplication.isCompiling;

			if (state) validate = false;

			if (!state && !validate)
			{
				validate = true;
			}
		}

 
	 
	}
}