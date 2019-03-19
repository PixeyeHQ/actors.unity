//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEditor.IMGUI.Controls;
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
			DataFramework.nameSpace = EditorGUILayout.TextField("Namespace: ", DataFramework.nameSpace);
			DataFramework.pathTagsEditor = EditorGUILayout.TextField("Tags path: ", DataFramework.pathTagsEditor);
		}
	}


	[InitializeOnLoad]
	public static class EditorActorsFramework
	{
		internal static bool needToRepaint;
		internal static Event currentEvent;
		internal static float t;


		static EditorActorsFramework()
		{
			EditorApplication.update += Updating;
		}

		static void Updating()
		{
			CheckMouse();


			if (needToRepaint)
			{
				t += UnityEngine.Time.deltaTime;

				if (t >= 0.3f)
				{
					t -= 0.3f;
					needToRepaint = false;
				}
			}
		}

		static void CheckMouse()
		{
			var ev = currentEvent;
			if (ev == null) return;

			if (ev.type == EventType.MouseMove)
				needToRepaint = true;
		}
	}
}