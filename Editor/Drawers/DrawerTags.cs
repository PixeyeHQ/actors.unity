//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace Pixeye.Actors
{
  [CustomPropertyDrawer(typeof(TagFilterAttribute))]
  public class DrawerTags : PropertyDrawer
  {
    static SerializedProperty prop;
    static FieldInfo[] objectFields;

    public int currentIndex;
    public FastString fs = new FastString(128);
    public List<FieldInfo> fields = new List<FieldInfo>();

    int val = -1;

    object array_obj;
    int array_index;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
      if (property.serializedObject.isEditingMultipleObjects)
        return;


      label.text = "";
      EditorGUI.BeginProperty(position, label, property);
      position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);


      var tagFilter = attribute as TagFilterAttribute;
      var tagType   = tagFilter.Type;

#if ODIN_INSPECTOR
			var a = property.serializedObject.targetObject.GetType().Assembly;
			if (a.FullName == "Sirenix.OdinInspector.EmittedUnityProperties") return;
#endif

      if (prop != property)
      {
        objectFields = ReturnConst(tagType);
        prop         = property;
      }

      var listNames = new List<string>();
      fields.Clear();

      var vv = property.intValue;

      foreach (var t in objectFields)
      {
        var myFieldInfo = t;

        var tagField = Attribute.GetCustomAttribute(t, typeof(TagFieldAttribute)) as TagFieldAttribute;
        if (tagField == null) continue;


        var nameF = myFieldInfo.Name;

        var className = tagField.className != null ? $"{tagField.className}/" : "";
        var catName   = tagField.categoryName != null ? $"{tagField.categoryName}/" : "";

        fs.Append(className + catName + nameF);
        listNames.Add(fs.ToString());
        fs.Clear();
        fields.Add(myFieldInfo);

        if (vv == (int) myFieldInfo.GetValue(this))
        {
          currentIndex = fields.Count - 1;
        }
      }


      if (listNames.Count == 0)
      {
        EditorGUI.EndProperty();
        return;
      }

      var raw  = listNames[currentIndex].Split('/');
      var name = raw[raw.Length - 1];

      var l = label;

      l.text = $"{name} [ {property.intValue} ]";

      if (EditorGUI.DropdownButton(position, l, FocusType.Keyboard))
      {
        var menu = new GenericMenu();

        for (var i = 0; i < listNames.Count; i++)
        {
          AddMenuItemForTags(menu, listNames[i], i);
        }

        array_obj = fieldInfo.GetValue(property.serializedObject.targetObject);
        if (array_obj.GetType().IsArray)
          array_index = Convert.ToInt32(new string(property.propertyPath.Where(char.IsDigit).ToArray()));

        menu.DropDown(position);
      }

      if (val > -1)
      {
        if (array_obj.GetType().IsArray)
        {
          var arr = array_obj as int[];
          arr[array_index] = (int) fields[val].GetValue(this);
          fieldInfo.SetValue(property.serializedObject.targetObject, arr);
        }
        else
        {
          property.intValue = (int) fields[val].GetValue(this);
        }

        val = -1;
      }

      EditorGUI.EndProperty();
    }

    void AddMenuItemForTags(GenericMenu menu, string menuPath, int index)
    {
      var content = new GUIContent(menuPath);
      content.text = $"{menuPath} [ {(int) fields[index].GetValue(this)} ]";
      menu.AddItem(content, currentIndex.Equals(index), () => val = index);
    }

    static FieldInfo[] ReturnConst(Type[] t)
    {
      var constants  = new ArrayList();
      var fieldInfos = new List<FieldInfo[]>();

      foreach (var t1 in t)
      {
        var type  = t1;
        var iType = type.IsInterface;

        if (iType)
        {
          foreach (var tp in PostHandleTags.tagTypes)
          {
            fieldInfos.Add(tp.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy));
          }

          continue;
        }

        fieldInfos.Add(t1.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy));
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