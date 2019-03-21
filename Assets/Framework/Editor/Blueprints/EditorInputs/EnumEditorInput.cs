using System;
using UnityEditor;

namespace EcsRx.Unity.EditorInputs
{
    public class EnumEditorInput : SimpleEditorInput<Enum>
    {
        public override bool HandlesType(Type type)
        {
            return type.IsEnum;
        }
        
        protected override Enum CreateTypeUI(string label, Enum value)
        { return EditorGUILayout.EnumPopup(label, value); }
    }
}
