using System;

namespace EcsRx.Unity.EditorInputs
{
    public abstract class SimpleEditorInput<T> : IEditorInput
    {
        public virtual bool HandlesType(Type type)
        { return type == typeof(T); }

        public T GetValue(object value)
        { return (T)value; }

        public object CreateUI(string label, object value)
        {
            var underlyingValue = GetValue(value);
            return CreateTypeUI(label, underlyingValue);
        }

        protected abstract T CreateTypeUI(string label, T value);
    }
}
