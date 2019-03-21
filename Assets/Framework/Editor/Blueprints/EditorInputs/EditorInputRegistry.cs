using System;
using System.Collections.Generic;
using System.Linq;

namespace EcsRx.Unity.EditorInputs
{
    public class EditorInputRegistry
    {
        public IEnumerable<IEditorInput> Handlers { get; private set; }

        public EditorInputRegistry(IEnumerable<IEditorInput> handlers)
        {
            Handlers = handlers;
        }

        public IEditorInput GetHandlerFor(Type type)
        {
            return Handlers.SingleOrDefault(x => x.HandlesType(type));
        }
    }
}