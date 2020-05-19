//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Pixeye.Actors;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Actors
{
	public static class StyleFramework
	{

		public static GUIStyle box;
		public static GUIStyle boxChild;
		public static GUIStyle foldout;
		public static GUIStyle button;
		public static GUIStyle text;
		public static GUILayoutOption boxChildOption;

		static StyleFramework()
		{
			var pro = EditorGUIUtility.isProSkin;

			var uiTex_in    = Resources.Load<Texture2D>("IN foldout focus-6510");
			var uiTex_in_on = Resources.Load<Texture2D>("IN foldout focus on-5718");

			var c_on = pro ? Color.white : new Color(51 / 255f, 102 / 255f, 204 / 255f, 1);

			button = new GUIStyle(EditorStyles.miniButton);
			button.font = Font.CreateDynamicFontFromOSFont(new[] {"Terminus (TTF) for Windows", "Calibri"}, 17);

			text = new GUIStyle(EditorStyles.label);
			text.richText = true;
			text.contentOffset = new Vector2(0, 5);
			text.font = Font.CreateDynamicFontFromOSFont(new[] {"Terminus (TTF) for Windows", "Calibri"}, 14);

			foldout = new GUIStyle(EditorStyles.foldout);

			foldout.overflow = new RectOffset(0, 0, 3, 0);
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
			box.padding = new RectOffset(20, 0, 3, 0);

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

			var a = s.ToCharArray();
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

public static class EditorTypes
{

	public static Dictionary<int, List<FieldInfo>> fields = new Dictionary<int, List<FieldInfo>>(new FastComparable());

	public static int Get(Object target, out List<FieldInfo> objectFields)
	{
		var t    = target.GetType();
		var hash = t.GetHashCode();

		if (!fields.TryGetValue(hash, out objectFields))
		{
			var typeTree = t.GetTypeTree();
			objectFields = target.GetType()
					.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.NonPublic)
					.OrderByDescending(x => typeTree.IndexOf(x.DeclaringType))
					.ToList();
			fields.Add(hash, objectFields);
		}

		return objectFields.Count;
	}

}