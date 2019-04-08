//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

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
					var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p)).ToArray();
					foreach (var tp in types)
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