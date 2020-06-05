/*MIT License

Copyright(c) 2017 Jeiel Aranal

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace Pixeye.Actors
{
  internal static class HelperSerializedProps
  {
    #region Simple string path based extensions

    /// <summary>
    /// Returns the path to the parent of a SerializedProperty
    /// </summary>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static string ParentPath(this SerializedProperty prop)
    {
      int lastDot = prop.propertyPath.LastIndexOf('.');
      if (lastDot == -1) // No parent property
        return "";

      return prop.propertyPath.Substring(0, lastDot);
    }

    /// <summary>
    /// Returns the parent of a SerializedProperty, as another SerializedProperty
    /// </summary>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static SerializedProperty GetParentProp(this SerializedProperty prop)
    {
      string parentPath = prop.ParentPath();
      return prop.serializedObject.FindProperty(parentPath);
    }

    #endregion

    /// <summary>
    /// Set isExpanded of the SerializedProperty and propogate the change up the hierarchy
    /// </summary>
    /// <param name="prop"></param>
    /// <param name="expand">isExpanded value</param>
    public static void ExpandHierarchy(this SerializedProperty prop, bool expand = true)
    {
      prop.isExpanded = expand;
      SerializedProperty parent = GetParentProp(prop);
      if (parent != null)
        ExpandHierarchy(parent);
    }

    /*public static void CopyValues(this SerializedProperty destination, SerializedProperty source)
		{
			// Iterate through source property paths, 
			SerializedProperty iterSource = source.Copy();
			if (iterSource.NextVisible(true))
			{
				string sourceParentPath = source.ParentPath();
				int startDepth = iterSource.depth;
				do
				{
					if (iterSource.depth < startDepth)
						break;

					// Find the relative path from iteration
					string currPath = iterSource.propertyPath;
					if (currPath.StartsWith(sourceParentPath) == false)
						continue;

					string relPath = currPath.Substring(sourceParentPath.Length, currPath.Length - sourceParentPath.Length);
					SerializedProperty targetProp = destination.FindPropertyRelative(relPath);

					TransferValue(iterSource, targetProp);

				} while (iterSource.NextVisible(true));
			}
		}

		public static bool TransferValue(SerializedProperty source, SerializedProperty dest)
		{
			if (source.propertyType != dest.propertyType)
			{
				return false;
			}

			switch (source.propertyType)
			{
				case SerializedPropertyType.Enum:
					dest.enumValueIndex = source.enumValueIndex;
					return true;
				case SerializedPropertyType.String:
					dest.stringValue = source.stringValue;
					return true;
				case SerializedPropertyType.Float:
					dest.floatValue = source.floatValue;
					return true;
				case SerializedPropertyType.Integer:
					dest.intValue = source.intValue;
					return true;
				case SerializedPropertyType.ObjectReference:
					dest.objectReferenceValue = source.objectReferenceValue;
					return true;
			}

			return false;
		}*/

    #region Reflection based extensions

    // http://answers.unity3d.com/questions/425012/get-the-instance-the-serializedproperty-belongs-to.html

    /// <summary>
    /// Use reflection to get the actual data instance of a SerializedProperty
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static object GetValue<T>(this SerializedProperty prop)
    {
      var path = prop.propertyPath.Replace(".Array.data[", "[");
      object obj = prop.serializedObject.targetObject;
      var elements = path.Split('.');
      foreach (var element in elements)
      {
        if (element.Contains("["))
        {
          var elementName = element.Substring(0, element.IndexOf("["));
          var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
          obj = GetValue(obj, elementName, index);
        }
        else
        {
          obj = GetValue(obj, element);
        }
      }
      if (obj is T)
        return (T) obj;
      return null;
    }

    public static Type GetTypeReflection(this SerializedProperty prop)
    {
      object obj = GetParent<object>(prop);
      if (obj == null)
        return null;

      Type objType = obj.GetType();
      const BindingFlags bindingFlags = System.Reflection.BindingFlags.GetField
                                        | System.Reflection.BindingFlags.GetProperty
                                        | System.Reflection.BindingFlags.Instance
                                        | System.Reflection.BindingFlags.NonPublic
                                        | System.Reflection.BindingFlags.Public;
      FieldInfo field = objType.GetField(prop.name, bindingFlags);
      if (field == null)
        return null;
      return field.FieldType;
    }

    /// <summary>
    /// Uses reflection to get the actual data instance of the parent of a SerializedProperty
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static T GetParent<T>(this SerializedProperty prop)
    {
      var path = prop.propertyPath.Replace(".Array.data[", "[");
      object obj = prop.serializedObject.targetObject;
      var elements = path.Split('.');
      foreach (var element in elements.Take(elements.Length - 1))
      {
        if (element.Contains("["))
        {
          var elementName = element.Substring(0, element.IndexOf("["));
          var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
          obj = GetValue(obj, elementName, index);
        }
        else
        {
          obj = GetValue(obj, element);
        }
      }
      return (T) obj;
    }

    private static object GetValue(object source, string name)
    {
      if (source == null)
        return null;
      Type type = source.GetType();
      FieldInfo f = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
      if (f == null)
      {
        PropertyInfo p = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
        if (p == null)
          return null;
        return p.GetValue(source, null);
      }
      return f.GetValue(source);
    }

    private static object GetValue(object source, string name, int index)
    {
      var enumerable = GetValue(source, name) as IEnumerable;
      if (enumerable == null)
        return null;
      var enm = enumerable.GetEnumerator();
      while (index-- >= 0)
        enm.MoveNext();
      return enm.Current;
    }

    /// <summary>
    /// Use reflection to check if SerializedProperty has a given attribute
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static bool HasAttribute<T>(this SerializedProperty prop)
    {
      object[] attributes = GetAttributes<T>(prop);
      if (attributes != null)
      {
        return attributes.Length > 0;
      }
      return false;
    }

    /// <summary>
    /// Use reflection to get the attributes of the SerializedProperty
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="prop"></param>
    /// <returns></returns>
    public static object[] GetAttributes<T>(this SerializedProperty prop)
    {
      object obj = GetParent<object>(prop);
      if (obj == null)
        return new object[0];

      Type attrType = typeof(T);
      Type objType = obj.GetType();
      const BindingFlags bindingFlags = System.Reflection.BindingFlags.GetField
                                        | System.Reflection.BindingFlags.GetProperty
                                        | System.Reflection.BindingFlags.Instance
                                        | System.Reflection.BindingFlags.NonPublic
                                        | System.Reflection.BindingFlags.Public;
      FieldInfo field = objType.GetField(prop.name, bindingFlags);
      if (field != null)
        return field.GetCustomAttributes(attrType, true);
      return new object[0];
    }

    /// <summary>
    /// Find properties in the serialized object of the given type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <param name="enterChildren"></param>
    /// <returns></returns>
    public static SerializedProperty[] FindPropsOfType<T>(this SerializedObject obj, bool enterChildren = false)
    {
      List<SerializedProperty> foundProps = new List<SerializedProperty>();
      Type propType = typeof(T);

      var iterProp = obj.GetIterator();
      iterProp.Next(true);

      if (iterProp.NextVisible(enterChildren))
      {
        do
        {
          var propValue = iterProp.GetValue<T>();
          if (propValue == null)
          {
            if (iterProp.propertyType == SerializedPropertyType.ObjectReference)
            {
              if (iterProp.objectReferenceValue != null && iterProp.objectReferenceValue.GetType() == propType)
                foundProps.Add(iterProp.Copy());
            }
          }
          else
          {
            foundProps.Add(iterProp.Copy());
          }
        } while (iterProp.NextVisible(enterChildren));
      }
      return foundProps.ToArray();
    }

    #endregion
  }
}