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
            if (property.serializedObject.isEditingMultipleObjects)
                return;

            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var tagFilter = attribute as TagFilterAttribute;
            var tagType = tagFilter.Type;

            var objectFields = ReturnConst(tagType);

            List<string> listNames = new List<string>();
            fields.Clear();

            var v_tag = property.intValue;

            for (var i = 0; i < objectFields.Length; i++)
            {
                var myFieldInfo = objectFields[i];
                var tagField = Attribute.GetCustomAttribute(objectFields[i], typeof(TagFieldAttribute)) as TagFieldAttribute;

                if (tagField == null) continue;

                var nameF = myFieldInfo.Name;
                var className = tagField.className != null ? tagField.className + "/" : "";
                var catName = tagField.categoryName != null ? tagField.categoryName + "/" : "";
                fs.Append(className + catName + nameF);

                listNames.Add(fs.ToString());
                fs.Clear();
                fields.Add(myFieldInfo);

                if (v_tag == (int)myFieldInfo.GetValue(this)) currentIndex = fields.Count - 1;
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
            property.intValue = (int)field.GetValue(this);
            EditorGUI.EndProperty();
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