/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       4/29/2018  4:53 PM
================================================================*/

using System;
using System.Collections.Generic;
 
namespace Homebrew
{
    public class ProcessingSignals : IComponent, IDisposable, IKernel
    {
        public static ProcessingSignals Default;
        public readonly Dictionary<int, List<IRecieve>> signals = new Dictionary<int, List<IRecieve>>(new FastComparable());

        #region LOGIC

        public static void Send<T>(T val = default(T))
        {
            Default.Dispatch(val);
        }

        public void Dispatch<T>(T val = default(T))
        {
            List<IRecieve> cachedSignals;
 
            if (!signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals)) return;

            var len = cachedSignals.Count;

            for (var i = 0; i < len; i++)
            {
                (cachedSignals[i] as IReceive<T>).HandleSignal(val);
            }
        }


        void Add(IRecieve recieve, Type type)
        {
            List<IRecieve> cachedSignals;
            var key = type.GetHashCode();
        
            if (signals.TryGetValue(key, out cachedSignals))
            {
         
                cachedSignals.Add(recieve);
                return;
            }
 
            signals.Add(key, new List<IRecieve> {recieve});
            
        }

        void Remove(IRecieve recieve, Type type)
        {
            List<IRecieve> cachedSignals;
            Timer.Add(Time.DeltaTime, () =>
            {
                if (signals.TryGetValue(type.GetHashCode(), out cachedSignals))
                {
                    cachedSignals.Remove(recieve);
                }
            });
        }


        public static IRecieve Check(object obj)
        {
            var reciever = obj as IRecieve;
            return reciever;
        }


        public void Add(object obj)
        {
            var all = obj.GetType().GetInterfaces();
            var reciever = obj as IRecieve;
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
            var all = obj.GetType().GetInterfaces();
            var reciever = obj as IRecieve;
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