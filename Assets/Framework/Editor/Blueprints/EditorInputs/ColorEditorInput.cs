using UnityEditor;
using UnityEngine;

namespace EcsRx.Unity.EditorInputs
{
    public class ColorEditorInput : SimpleEditorInput<Color>
    {
        protected override Color CreateTypeUI(string label, Color value)
        { return EditorGUILayout.ColorField(label, value); }
    }
}