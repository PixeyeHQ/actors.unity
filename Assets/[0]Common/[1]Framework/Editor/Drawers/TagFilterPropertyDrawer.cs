/*===============================================================
Product:    BattlecruiserPrototype
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       4/28/2018 5:50 PM
================================================================*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Homebrew
{
	[CustomPropertyDrawer(typeof(TagFilterAttribute))]
	public class TagFilterPropertyDrawer : PropertyDrawer
	{
		public int currentIndex;
		public FastString fs = new FastString(128);
		public List<FieldInfo> fields = new List<FieldInfo>();

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginProperty(position, label, property);
			EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

			var tagFilter = attribute as TagFilterAttribute;
			var tagType = tagFilter.Type;

			var objectFields = ReturnConst(tagType);

			var listNames = new List<string>();
			fields.Clear();

			var vv = property.intValue;

			for (var i = 0; i < objectFields.Length; i++)
			{
				var myFieldInfo = objectFields[i];
				var tagField = Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;

				if (tagField == null) continue;
				fs.Append(tagField.categoryName).Append("/").Append(myFieldInfo.Name);
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

			currentIndex = EditorGUI.Popup(position, property.displayName, currentIndex, listNames.ToArray());


			var raw = listNames[currentIndex].Split('/');
			var name = raw[raw.Length - 1];

			var field = fields.Find(f => f.Name == name);
			property.intValue = (int) field.GetValue(this);

			EditorGUI.EndProperty();
		}


		FieldInfo[] ReturnConst(Type t)
		{
			ArrayList constants = new ArrayList();

			FieldInfo[] fieldInfos = t.GetFields(
				BindingFlags.Public | BindingFlags.Static |
				BindingFlags.FlattenHierarchy);


			foreach (FieldInfo fi in fieldInfos)

				if (fi.IsLiteral && !fi.IsInitOnly)
					constants.Add(fi);


			return (FieldInfo[]) constants.ToArray(typeof(FieldInfo));
		}
	}
}