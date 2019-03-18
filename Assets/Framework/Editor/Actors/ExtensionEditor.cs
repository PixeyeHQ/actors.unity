//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using UnityEditor;
using UnityEngine;

namespace Pixeye
{
	public static class ExtensionEditor
	{
		public static readonly RectOffset DefaultPadding = new RectOffset(10, 0, 10, 0);

		public readonly static GUIStyle StyleBox = new GUIStyle(GUI.skin.box) {padding = DefaultPadding};
		public readonly static GUIStyle StyleBoxChild = new GUIStyle(GUI.skin.box) {padding = new RectOffset(5, 0, 5, 5)};

		public static GUIStyleState state;

//		style = new GUIStyle(EditorStyles.foldout);
//
//		style.overflow = new RectOffset(-10, 0, 3, 0);
//		style.padding = new RectOffset(25, 0, -3, 0);
//
//		style.active.textColor = c_on;
//		style.active.background = uiTex_in;
//		style.onActive.textColor = c_on;
//		style.onActive.background = uiTex_in_on;
//
//		style.focused.textColor = c_on;
//		style.focused.background = uiTex_in;
//		style.onFocused.textColor = c_on;
//		style.onFocused.background = uiTex_in_on;

		public static void UseVerticalBoxLayout(this Editor e, Action action, GUIStyle style)
		{
			//	DefaultBoxStyle.
			EditorGUILayout.BeginVertical(style);
			action();
			EditorGUILayout.EndVertical();
		}
	}

	public static class EditorUIStyles
	{
		public static GUIStyle box;
		public static GUIStyle boxChild;


		static EditorUIStyles()
		{
			box = new GUIStyle(GUI.skin.box);
			box.padding = new RectOffset(10, 0, 10, 0);
			boxChild = new GUIStyle(GUI.skin.box);
		}
	}
}