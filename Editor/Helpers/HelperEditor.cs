//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Actors
{
  public static class HelperEditor
  {
    public static string GetPathLibrary()
    {
      var path = Application.dataPath;
      path = string.Format($"{path.Remove(path.LastIndexOf("/", StringComparison.Ordinal))}/Library/PackageCache");
      var dir = Directory.GetDirectories(path).Where(s => s.Contains("com.pixeye.ecs")).ToArray();

      return dir.Length == 0 ? string.Empty : dir[0];
    }

    public static readonly RectOffset DefaultPadding = new RectOffset(10, 0, 10, 0);

    public static readonly GUIStyle StyleBox;
    public static readonly GUIStyle StyleBoxChild;

    static HelperEditor()
    {
//			StyleBox = new GUIStyle(GUI.skin.box) {padding = DefaultPadding};
      //	StyleBoxChild = new GUIStyle(GUI.skin.box) {padding = new RectOffset(5, 0, 5, 5)};
    }

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

    public static void UseProperty(this GUIStyle style, SerializedProperty property, bool includeChildren)
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

    public static string GetSelectedPathOrFallback()
    {
      string path = "Assets";

      foreach (Object obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
      {
        path = AssetDatabase.GetAssetPath(obj);
        if (!string.IsNullOrEmpty(path) && File.Exists(path))
        {
          path = Path.GetDirectoryName(path);
          break;
        }
      }

      return path;
    }
  }
}