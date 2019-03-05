//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye
{
    public class ProcessingSignals : IComponent, IDisposable, IKernel
    {
        public static ProcessingSignals Default = new ProcessingSignals();
        public readonly Dictionary<int, List<IReceive>> signals = new Dictionary<int, List<IReceive>>(new FastComparable());

        #region LOGIC

        public static void Send<T>(ref T val)
        {
            Default.Dispatch(ref val);
        }

        public void Dispatch<T>(ref T val)
        {
            List<IReceive> cachedSignals;

            if (!signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals)) return;

            var len = cachedSignals.Count;

            for (var i = 0; i < len; i++)
            {
                (cachedSignals[i] as IReceive<T>).HandleSignal(ref val);
            }
        }


        void Add(IReceive receive, Type type)
        {
            List<IReceive> cachedSignals;
            var            key = type.GetHashCode();

            if (signals.TryGetValue(key, out cachedSignals))
            {
                cachedSignals.Add(receive);
                return;
            }

            signals.Add(key, new List<IReceive> {receive});
        }

        void Remove(IReceive receive, Type type)
        {
            List<IReceive> cachedSignals;
            if (signals.TryGetValue(type.GetHashCode(), out cachedSignals))
            {
                cachedSignals.Remove(receive);
            }
        }


        public static bool Check(object obj)
        {
            var reciever = obj as IReceive;
            return reciever != null;
        }


        public void Add(object obj)
        {
            var all      = obj.GetType().GetInterfaces();
            var reciever = obj as IReceive;
            foreach (var intType in all)
            {
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
                {
                    Add(reciever, intType.GetGenericArguments()[0]);
                }
            }
        }

        public void Remove(object obj)
        {
            var all      = obj.GetType().GetInterfaces();
            var reciever = obj as IReceive;
            foreach (var intType in all)
            {
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
                {
                    Remove(reciever, intType.GetGenericArguments()[0]);
                }
            }
        }


        public void Dispose()
        {
            signals.Clear();
        }

        #endregion
    }
}