using UnityEngine;
using UnityEditor;

namespace Pixeye.Actors
{
	[CustomPropertyDrawer(typeof(EnumFlagAttribute))]
	public class DrawerEnumFlags : PropertyDrawer
	{
		public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
		{
			_property.intValue = EditorGUI.MaskField(_position, _label, _property.intValue, _property.enumNames);
		}
	}
}
 