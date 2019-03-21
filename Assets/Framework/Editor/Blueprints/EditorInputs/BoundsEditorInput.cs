using UnityEditor;
using UnityEngine;

namespace EcsRx.Unity.EditorInputs
{
    public class BoundsEditorInput : SimpleEditorInput<Bounds>
    {
        protected override Bounds CreateTypeUI(string label, Bounds value)
        { return EditorGUILayout.BoundsField(label, value); }
    }
}