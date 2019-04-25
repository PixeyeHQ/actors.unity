//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

/// TODO: refactor this shit.
namespace Pixeye.Framework
{
	[CustomPropertyDrawer(typeof(TagFilterAttribute))]
	public class DrawerTags : PropertyDrawer
	{

		private static SerializedProperty prop;
		static FieldInfo[] objectFields;

		public int currentIndex;
		public FastString fs = new FastString(128);
		public List<FieldInfo> fields = new List<FieldInfo>();

		int val = -1;

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (property.serializedObject.isEditingMultipleObjects)
				return;

			EditorGUI.BeginProperty(position, label, property);
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			var tagFilter = attribute as TagFilterAttribute;
			var tagType = tagFilter.Type;

			#if ODIN_INSPECTOR
			var a = property.serializedObject.targetObject.GetType().Assembly;
			if (a.FullName == "Sirenix.OdinInspector.EmittedUnityProperties") return;
			#endif
			
			if (prop != property)
			{
				objectFields = ReturnConst(tagType);
				prop = property;
			}

			var listNames = new List<string>();
			fields.Clear();

			var vv = property.intValue;

			for (var i = 0; i < objectFields.Length; i++)
			{
				var myFieldInfo = objectFields[i];

				var tagField = Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;
				if (tagField == null) continue;

				var nameF = myFieldInfo.Name;

				var className = tagField.className != null ? string.Format("{0}/", tagField.className) : "";
				var catName = tagField.categoryName != null ? string.Format("{0}/", tagField.categoryName) : "";
				fs.Append(className + catName + nameF);
				listNames.Add(fs.ToString());
				fs.Clear();
				fields.Add(myFieldInfo);

				if (vv == (int) myFieldInfo.GetValue(this))
					currentIndex = fields.Count - 1;
			}

			if (listNames.Count == 0)
			{
				EditorGUI.EndProperty();
				return;
			}

			var raw = listNames[currentIndex].Split('/');
			var name = raw[raw.Length - 1];

			var l = new GUIContent(label);
			l.text = string.Format("{0} [ {1} ]", name, property.intValue);

			if (EditorGUI.DropdownButton(position, l, FocusType.Passive))
			{
				GenericMenu menu = new GenericMenu();
				for (var i = 0; i < listNames.Count; i++)
				{
					AddMenuItemForTags(menu, listNames[i], i);
				}

				menu.ShowAsContext();
			}

			if (val > -1)
			{
				property.intValue = (int) fields[val].GetValue(this);
				val = -1;
			}

			EditorGUI.EndProperty();
		}

		void AddMenuItemForTags(GenericMenu menu, string menuPath, int index)
		{
			var content = new GUIContent(menuPath);
			content.text = string.Format("{0} [ {1} ]", menuPath, (int) fields[index].GetValue(this));

			menu.AddItem(content, currentIndex.Equals(index), () => val = index);
		}

		static FieldInfo[] ReturnConst(Type[] t)
		{
			var constants = new ArrayList();
			List<FieldInfo[]> fieldInfos = new List<FieldInfo[]>();

			for (int i = 0; i < t.Length; i++)
			{
				var type = t[i];
				var iType = type.IsInterface;

				if (iType)
				{
					foreach (var tp in PostHandleTags.tagTypes)
					{
						fieldInfos.Add(tp.GetFields(
						                            BindingFlags.Public | BindingFlags.Static |
						                            BindingFlags.FlattenHierarchy));
					}

					continue;
				}

				fieldInfos.Add(t[i].GetFields(
				                              BindingFlags.Public | BindingFlags.Static |
				                              BindingFlags.FlattenHierarchy));
			}

			foreach (var item in fieldInfos)
			foreach (var fi in item)
			{
				if (fi.IsLiteral && !fi.IsInitOnly)
					constants.Add(fi);
			}

			return constants.ToArray(typeof(FieldInfo)) as FieldInfo[];
		}

	}
}
//#else
//
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using Sirenix.OdinInspector.Editor;
//using Sirenix.Utilities;
//using Sirenix.Utilities.Editor;
//using UnityEditor;
//using UnityEngine;
//
//namespace Pixeye.Framework
//{
//	//[CustomPropertyDrawer(typeof(TagFilterAttribute))]
//	public class DrawerTags : OdinAttributeDrawer<TagFilterAttribute, int>
//	{
//
//		private static SerializedProperty prop;
//		static FieldInfo[] objectFields = new FieldInfo[0];
//		static Type[] possibleTypes = new Type[0];
//
//		public int currentIndex;
//		public FastString fs = new FastString(128);
//		public List<FieldInfo> fields = new List<FieldInfo>();
//		public List<string> listNames = new List<string>();
//
//		public string[] names = new string[0];
//		public int[] values = new int[0];
//		public GUIContent[] guiContentes = new GUIContent[0];
//		int val = -1;
//		GenericMenu menu = new GenericMenu();
//	 
//		public HashSet<string> props = new HashSet<string>();
//
//		protected override void Initialize()
//		{
//			base.Initialize();
//			props.Add(Property.NiceName);
//			menu = new GenericMenu();
//			objectFields = ReturnConst(Attribute.Type);
//			var arg0 = ValueEntry.SmartValue;
//			names = new string[objectFields.Length];
//			values = new int[objectFields.Length];
//			guiContentes = new GUIContent[objectFields.Length];
//
//			for (var i = 0; i < objectFields.Length; i++)
//			{
//				var myFieldInfo = objectFields[i];
//
//				var tagField = System.Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;
//
//				var nameF = myFieldInfo.Name;
//				guiContentes[i] = new GUIContent();
//				guiContentes[i].text = string.Format("{0} [ {1} ]", nameF, myFieldInfo.GetValue(this));
//				var className = tagField.className != null ? string.Format("{0}/", tagField.className) : "";
//				var catName = tagField.categoryName != null ? string.Format("{0}/", tagField.categoryName) : "";
//				fs.Append(className + catName + nameF);
//				names[i] = fs.ToString();
//				values[i] = (int) myFieldInfo.GetValue(this);
//				fs.Clear();
//				fields.Add(myFieldInfo);
//
//				if (arg0 == (int) myFieldInfo.GetValue(this))
//				{
//					currentIndex = i;
//				}
//			}
//
//			for (var i = 0; i < names.Length; i++)
//			{
//				AddMenuItemForTags(menu, names[i], i);
//			}
//		}
//
//		public bool t;
//
//		protected override void DrawPropertyLayout(GUIContent label)
//		{
//			// 	CallNextDrawer(label);
//
//			var c = guiContentes[currentIndex];
//			var rect = EditorGUILayout.GetControlRect();
//
//			if (EditorGUI.DropdownButton(rect, c, FocusType.Passive))
//			{
//				menu.ShowAsContext();
//			}
//
//			if (val > -1)
//			{
//				currentIndex = val;
//				ValueEntry.SmartValue = values[val];
//				val = -1;
//				menu = new GenericMenu();
//				for (var i = 0; i < names.Length; i++)
//				{
//					AddMenuItemForTags(menu, names[i], i);
//				}
//			}
//
//			//			var raw = listNames[currentIndex].Split('/');
////			var name = raw[raw.Length - 1];
////
////			var l = new GUIContent(label);
////			l.text = string.Format("{0} [ {1} ]", name, property.intValue);
////
////			if (EditorGUI.DropdownButton(position, l, FocusType.Passive))
////			{
////				GenericMenu menu = new GenericMenu();
////				for (var i = 0; i < listNames.Count; i++)
////				{
////					AddMenuItemForTags(menu, listNames[i], i);
////				}
////
////				menu.ShowAsContext();
////			}
//
////		Rect rect = EditorGUILayout.GetControlRect();
////		SirenixEditorGUI.DrawBorders(rect, 1);
////		g.text = ValueEntry.SmartValue.ToString();
////		SirenixEditorFields.TextField(g.text);
//			//SirenixEditorGUI.ToolbarTab(true,g.text);
//
//			//SirenixEditorFields.TextField(g.text);
//			//SirenixEditorGUI.MessageBox(g.text);
//
//			// var prev = EditorGUIUtility.labelWidth;
////        EditorGUIUtility.labelWidth = 20;
////
////        var raw = listNames[currentIndex].Split('/');
////        var name = raw[raw.Length - 1];
////        var l = new GUIContent(label);
////        l.text = string.Format("{0} [ {1} ]", name, ValueEntry.SmartValue);
//
//			// EditorGUIUtility.labelWidth = prev;
//
//			//CallNextDrawer(label);
//
////			Rect rect = EditorGUILayout.GetControlRect();
////
////			// Draw the health bar.
////			//float width = Mathf.Clamp01(this.ValueEntry.SmartValue / this.Attribute.MaxHealth);
////			SirenixEditorGUI.DrawSolidRect(rect, new Color(0f, 0f, 0f, 0.3f), false);
////			SirenixEditorGUI.DrawSolidRect(rect.SetWidth(rect.width * 12), Color.red, false);
////			SirenixEditorGUI.DrawBorders(rect, 1);
//		}
////		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
////		{
////			if (property.serializedObject.isEditingMultipleObjects)
////				return;
////
////			EditorGUI.BeginProperty(position, label, property);
////			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
////
////			var tagFilter = attribute as TagFilterAttribute;
////			var tagType = tagFilter.Type;
////
////			var a = property.serializedObject.targetObject.GetType().Assembly;
////			if (a.FullName == "Sirenix.OdinInspector.EmittedUnityProperties") return;
//// 
////			if (prop != property)
////			{
////				objectFields = ReturnConst(tagType);
////				prop = property;
////			}
////
////			var listNames = new List<string>();
////			fields.Clear();
////
////			var vv = property.intValue;
////
////			for (var i = 0; i < objectFields.Length; i++)
////			{
////				var myFieldInfo = objectFields[i];
////
////				var tagField = Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;
////				if (tagField == null) continue;
////
////				var nameF = myFieldInfo.Name;
////
////				var className = tagField.className != null ? string.Format("{0}/", tagField.className) : "";
////				var catName = tagField.categoryName != null ? string.Format("{0}/", tagField.categoryName) : "";
////				fs.Append(className + catName + nameF);
////				listNames.Add(fs.ToString());
////				fs.Clear();
////				fields.Add(myFieldInfo);
////
////				if (vv == (int) myFieldInfo.GetValue(this))
////					currentIndex = fields.Count - 1;
////			}
////
////			if (listNames.Count == 0)
////			{
////				EditorGUI.EndProperty();
////				return;
////			}
////
////			var raw = listNames[currentIndex].Split('/');
////			var name = raw[raw.Length - 1];
////
////			var l = new GUIContent(label);
////			l.text = string.Format("{0} [ {1} ]", name, property.intValue);
////
////			if (EditorGUI.DropdownButton(position, l, FocusType.Passive))
////			{
////				GenericMenu menu = new GenericMenu();
////				for (var i = 0; i < listNames.Count; i++)
////				{
////					AddMenuItemForTags(menu, listNames[i], i);
////				}
////
////				menu.ShowAsContext();
////			}
////
////			if (val > -1)
////			{
////				property.intValue = (int) fields[val].GetValue(this);
////				val = -1;
////			}
////
////			EditorGUI.EndProperty();
////		}
//
//	 
//	//	private static IEnumerable<Type> tagTypes = new Type[0];
//
//		void AddMenuItemForTags(GenericMenu menu, string menuPath, int index)
//		{
//			var content = new GUIContent(menuPath);
//			content.text = string.Format("{0} [ {1} ]", menuPath, (int) fields[index].GetValue(this));
//
//			menu.AddItem(content, currentIndex.Equals(index), () => val = index);
//		}
//
//		//private bool initialized = false;
//
//		static FieldInfo[] ReturnConst(Type[] tagsType)
//		{
//			var constants = new ArrayList();
//			List<FieldInfo[]> fieldInfos = new List<FieldInfo[]>();
//
//			for (int i = 0; i < tagsType.Length; i++)
//			{
//				var type = tagsType[i];
//				var iType = type.IsInterface;
//
//				if (iType)
//				{
//					var len = PostHandleTags.tagTypes.Count;
//					for (int j = 0; j < len; j++)
//					{
//					  	fieldInfos.Add(PostHandleTags.tagTypes[j].GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy));
//
//					}
//					
//				 
//				}
//				else
//					fieldInfos.Add(tagsType[0].GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy));
//			}
//
//			foreach (var item in fieldInfos)
//			foreach (var fi in item)
//			{
//				if (fi.IsLiteral && !fi.IsInitOnly)
//					constants.Add(fi);
//			}
//
//			return constants.ToArray(typeof(FieldInfo)) as FieldInfo[];
//		}
//
//	}
//}
//#endif