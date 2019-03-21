using System;
using System.Collections.Generic;
using EcsRx.Unity.EditorInputs;

namespace Pixeye
{
    public static class DefaultEditorInputRegistry
    {
        private static readonly EditorInputRegistry _editorInputRegistry;

        static DefaultEditorInputRegistry()
        {
            _editorInputRegistry = new EditorInputRegistry(new List<IEditorInput>
            {
                new IntEditorInput(),
                new FloatEditorInput(),
                new StringEditorInput(),
                new BoolEditorInput(),
                new Vector2EditorInput(),
                new Vector3EditorInput(),
                new ColorEditorInput(),
                new BoundsEditorInput(),
                new RectEditorInput(),
                new EnumEditorInput(),
                new GameObjectEditorInput()
            });
        }

        public static IEditorInput GetHandlerFor(Type type)
        { return _editorInputRegistry.GetHandlerFor(type); }
    }
}