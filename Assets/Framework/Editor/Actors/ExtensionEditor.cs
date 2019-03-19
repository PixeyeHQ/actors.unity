//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Pixeye
{
	public static class ExtensionEditor
	{
		public static readonly RectOffset DefaultPadding = new RectOffset(10, 0, 10, 0);

		public readonly static GUIStyle StyleBox = new GUIStyle(GUI.skin.box) {padding = DefaultPadding};
		public readonly static GUIStyle StyleBoxChild = new GUIStyle(GUI.skin.box) {padding = new RectOffset(5, 0, 5, 5)};


		public static void UseVerticalBoxLayout(this Editor e, Action action, GUIStyle style)
		{
			EditorGUILayout.BeginVertical(style);
			action();
			EditorGUILayout.EndVertical();
		}
	}

	public static class EditorUIStyles
	{
		public static GUIStyle box;
		public static GUIStyle boxChild;
		public static GUIStyle foldout;

		public static GUILayoutOption boxChildOption;

		static EditorUIStyles()
		{
			bool pro = EditorGUIUtility.isProSkin;

			var uiTex_in    = Resources.Load<Texture2D>("IN foldout focus-6510");
			var uiTex_in_on = Resources.Load<Texture2D>("IN foldout focus on-5718");

			var c_on = pro ? Color.white : new Color(51 / 255f, 102 / 255f, 204 / 255f, 1);

			foldout = new GUIStyle(EditorStyles.foldout);

			foldout.overflow = new RectOffset(-10, 0, 3, 0);
			foldout.padding = new RectOffset(25, 0, -3, 0);

			foldout.active.textColor = c_on;
			foldout.active.background = uiTex_in;
			foldout.onActive.textColor = c_on;
			foldout.onActive.background = uiTex_in_on;

			foldout.focused.textColor = c_on;
			foldout.focused.background = uiTex_in;
			foldout.onFocused.textColor = c_on;
			foldout.onFocused.background = uiTex_in_on;

			foldout.hover.textColor = c_on;
			foldout.hover.background = uiTex_in;

			foldout.onHover.textColor = c_on;
			foldout.onHover.background = uiTex_in_on;


			box = new GUIStyle(GUI.skin.box);
			box.padding = new RectOffset(10, 0, 10, 0);

			boxChild = new GUIStyle(GUI.skin.box);
			boxChild.active.textColor = c_on;
			boxChild.active.background = uiTex_in;
			boxChild.onActive.textColor = c_on;
			boxChild.onActive.background = uiTex_in_on;

			boxChild.focused.textColor = c_on;
			boxChild.focused.background = uiTex_in;
			boxChild.onFocused.textColor = c_on;
			boxChild.onFocused.background = uiTex_in_on;


			EditorStyles.foldout.active.textColor = c_on;
			EditorStyles.foldout.active.background = uiTex_in;
			EditorStyles.foldout.onActive.textColor = c_on;
			EditorStyles.foldout.onActive.background = uiTex_in_on;

			EditorStyles.foldout.focused.textColor = c_on;
			EditorStyles.foldout.focused.background = uiTex_in;
		 	EditorStyles.foldout.onFocused.textColor = c_on;
		 	EditorStyles.foldout.onFocused.background = uiTex_in_on;

			EditorStyles.foldout.hover.textColor = c_on;
			EditorStyles.foldout.hover.background = uiTex_in;

			EditorStyles.foldout.onHover.textColor = c_on;
			EditorStyles.foldout.onHover.background = uiTex_in_on;
		}


		public static string FirstLetterToUpperCase(this string s)
		{
			if (string.IsNullOrEmpty(s))
				return string.Empty;

			char[] a = s.ToCharArray();
			a[0] = char.ToUpper(a[0]);
			return new string(a);
		}

		public static IList<Type> GetTypeTree(this Type t)
		{
			var types = new List<Type>();
			while (t.BaseType != null)
			{
				types.Add(t);
				t = t.BaseType;
			}

			return types;
		}
	}
}