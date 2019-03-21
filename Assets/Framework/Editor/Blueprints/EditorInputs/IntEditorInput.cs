using UnityEditor;

namespace EcsRx.Unity.EditorInputs
{
    public class IntEditorInput : SimpleEditorInput<int>
    {
        protected override int CreateTypeUI(string label, int value)
        { return EditorGUILayout.IntField(label, value); }
    }
}