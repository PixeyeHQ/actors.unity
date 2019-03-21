//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye
{
	public static class ExtensionEditor
	{

		public static readonly RectOffset DefaultPadding = new RectOffset(10, 0, 10, 0);

		public readonly static GUIStyle StyleBox = new GUIStyle(GUI.skin.box) {padding = DefaultPadding};
		public readonly static GUIStyle StyleBoxChild = new GUIStyle(GUI.skin.box) {padding = new RectOffset(5, 0, 5, 5)};

		public static bool UseUIButton(this Editor e, string icon, GUIStyle style, int fontSize = 12, float width = 28, float height = 28)
		{
			style.fontSize = fontSize;
			var val = GUILayout.Button(icon, style, GUILayout.Width(width), GUILayout.Height(height));

			return val;
		}
		public static bool UseUIButtonExtended(this Editor e, string icon, GUIStyle style, int fontSize = 12)
		{
			GUIContent btnTxt = new GUIContent(icon);
			style.fontSize = fontSize;
			var rt = GUILayoutUtility.GetRect(btnTxt, style, GUILayout.ExpandWidth(false));
			rt.y = rt.y + 10;
			rt.size = rt.size + new Vector2(10, 10);
			rt.center = new Vector2(EditorGUIUtility.currentViewWidth / 2, rt.center.y);
			return GUI.Button(rt, btnTxt, style);
		}

		public static bool UseButton(this Editor e, in string label, GUIStyle style = null)
		{
			return GUILayout.Button(label, style, GUILayout.ExpandWidth(false));
		}

		public static bool UseButton(this Editor e, in string label, GUIStyle style, float height)
		{
			var arg = GUILayout.Button(label, style, GUILayout.Height(height));
			return arg;
		}

		#region Labels

		public static void UseLabelLayout(this GUIStyle style, in string label)
		{
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.LabelField(label, style);
			EditorGUILayout.EndHorizontal();
		}

		public static void UseProperty(this GUIStyle style,  SerializedProperty property, bool includeChildren)
		{
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.PropertyField(property, includeChildren);
			EditorGUILayout.EndHorizontal();
			//EditorGUILayout.LabelField(label, style);
		}
		
		public static void UseLabel(this GUIStyle style, in string label)
		{
			EditorGUILayout.LabelField(label, style);
		}
		
		public static void UseLabel(this GUIStyle style, in string label, float width)
		{
			EditorGUILayout.LabelField(label, style, GUILayout.ExpandWidth(false), GUILayout.Width(width));
		}
		
	 
		

		public static string UseTextInput(this GUIStyle style, in string label, in string input)
		{
			return EditorGUILayout.TextField(label, input, style);
		}

		public static void UseLabel(this Editor e, in string label, GUIStyle style)
		{
			EditorGUILayout.BeginHorizontal(style);
			EditorGUILayout.LabelField(label, style);
			EditorGUILayout.EndHorizontal();
		}

		#endregion

		public static void UseHorizontalLayout(this Editor e, Action action, GUIStyle style)
		{
			EditorGUILayout.BeginHorizontal(style);
			action();
			EditorGUILayout.EndHorizontal();
		}

		public static void UseHorizontalLayout(this GUIStyle style, Action action)
		{
			EditorGUILayout.BeginHorizontal(style);
			action();
			EditorGUILayout.EndHorizontal();
		}

		public static void UseVerticalLayout(this Editor e, Action action, GUIStyle style)
		{
			EditorGUILayout.BeginVertical(style);
			action();
			EditorGUILayout.EndVertical();
		}

		public static void UseVerticalLayout(this GUIStyle style, Action action)
		{
			EditorGUILayout.BeginVertical(style);
			action();
			EditorGUILayout.EndVertical();
		}

		public static void UseButton(this Editor e, MethodInfo m)
		{
			if (GUILayout.Button(m.Name))
			{
				m.Invoke(e.target, null);
			}
		}

	}
}

public static class EditorUIStyles
{

	public static GUIStyle box;
	public static GUIStyle boxChild;
	public static GUIStyle foldout;
	public static GUIStyle button;
	public static GUIStyle text;
	public static GUILayoutOption boxChildOption;

	static EditorUIStyles()
	{
		bool pro = EditorGUIUtility.isProSkin;

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

public static class EditorTypes
{

	public static Dictionary<int, List<FieldInfo>> fields = new Dictionary<int, List<FieldInfo>>(new FastComparable());

	static EditorTypes()
	{
	}

	public static int Get(Object target, out List<FieldInfo> objectFields)
	{
		var t    = target.GetType();
		var hash = t.GetHashCode();

		if (!fields.TryGetValue(hash, out objectFields))
		{
			var typeTree = t.GetTypeTree();
			objectFields = target.GetType()
					.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
					.OrderByDescending(x => typeTree.IndexOf(x.DeclaringType))
					.ToList();
			fields.Add(hash, objectFields);
		}

		return objectFields.Count;
	}

}