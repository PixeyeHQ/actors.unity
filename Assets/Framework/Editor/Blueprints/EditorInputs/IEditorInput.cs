using System;

namespace EcsRx.Unity.EditorInputs
{
    public interface IEditorInput
    {
        bool HandlesType(Type type);
        object CreateUI(string label, object value);
    }
}