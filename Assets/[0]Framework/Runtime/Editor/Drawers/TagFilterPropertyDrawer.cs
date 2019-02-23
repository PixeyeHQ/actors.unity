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
		 
		int val = -1;

	 

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (property.serializedObject.isEditingMultipleObjects)
				return;
		 
	 
			EditorGUI.BeginProperty(position, label, property);
		 	position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
		 

			var tagFilter = attribute as TagFilterAttribute;
			var tagType   = tagFilter.Type;

			var objectFields = ReturnConst(tagType);

			var listNames = new List<string>();
			fields.Clear();

			var vv = property.intValue;

			for (var i = 0; i < objectFields.Length; i++)
			{
				var myFieldInfo = objectFields[i];
				var tagField    = Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;

				if (tagField == null) continue;
                var nameF = myFieldInfo.Name;
                var className = tagField.className != null ? tagField.className + "/" : "";
                var catName = tagField.categoryName != null ? tagField.categoryName + "/" : "";
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


			var raw  = listNames[currentIndex].Split('/');
			var name = raw[raw.Length - 1];
		 
		 
		 
			var l = new GUIContent(label);
			l.text = name + " [ " + property.intValue + " ]";
			
			if (EditorGUI.DropdownButton(position, l, FocusType.Passive))
			{
				GenericMenu menu = new GenericMenu();
				for (var i = 0; i < listNames.Count; i++)
				{
					AddMenuItemForTags(menu, listNames[i], i);
				}

				menu.ShowAsContext();
			}
		
//			if (GUILayout.Button(name + " [ " + property.intValue + " ]"))
//			{
//				GenericMenu menu = new GenericMenu();
//				for (var i = 0; i < listNames.Count; i++)
//				{
//					AddMenuItemForTags(menu, listNames[i], i);
//				}
//
//				menu.ShowAsContext();
//			}
 
			if (val > -1)
			{
				property.intValue = (int) fields[val].GetValue(this);
				val = -1;
			}

//			currentIndex = EditorGUI.Popup(position, property.displayName, currentIndex, listNames.ToArray());
//            
//
//			var raw  = listNames[currentIndex].Split('/');
//			var name = raw[raw.Length - 1];
//
//			var field = fields.Find(f => f.Name == name);
//			property.intValue = (int) field.GetValue(this);

			EditorGUI.EndProperty();
		 

	 
		}

		void AddMenuItemForTags(GenericMenu menu, string menuPath, int index)
		{
		var content = new GUIContent(menuPath);
			content.text = menuPath + " [ " + (int) fields[index].GetValue(this) + " ]";
			// the menu item is marked as selected if it matches the current value of m_Color
			menu.AddItem(content, currentIndex.Equals(index), () => val = index);
		}
 

        static FieldInfo[] ReturnConst(Type[] t)
        {
            var constants = new ArrayList();
            List<FieldInfo[]> fieldInfos = new List<FieldInfo[]>();
            for (int i = 0; i < t.Length; i++)
            {
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