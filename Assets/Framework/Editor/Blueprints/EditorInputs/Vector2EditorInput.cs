using UnityEditor;
using UnityEngine;

namespace EcsRx.Unity.EditorInputs
{
    public class Vector2EditorInput : SimpleEditorInput<Vector2>
    {
        protected override Vector2 CreateTypeUI(string label, Vector2 value)
        { return EditorGUILayout.Vector2Field(label, value); }
    }
}