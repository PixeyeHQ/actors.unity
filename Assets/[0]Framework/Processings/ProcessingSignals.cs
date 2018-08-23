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
    public class ProcessingSignals : IComponent, IDisposable
    {
        public static ProcessingSignals Default;
        public readonly Dictionary<int, List<IRecieve>> signals = new Dictionary<int, List<IRecieve>>();

        #region LOGIC

        public void SendLocal<T>(T val = default(T))
        {
            List<IRecieve> cachedSignals;

            if (!signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals)) return;

            var len = cachedSignals.Count;
          
            for (var i = 0; i < len; i++)
            {
                (cachedSignals[i] as IReceiveLocal<T>).HandleSignal(val);
            }
        }

        public static void Send<T>(T val = default(T))
        {
            List<IRecieve> cachedSignals;

            if (!Default.signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals)) return;

            var len = cachedSignals.Count;

            for (var i = 0; i < len; i++)
            {
                (cachedSignals[i] as IReceive<T>).HandleSignal(val);
            }
        }


        public void Add<T>(IRecieve recieve)
        {
            List<IRecieve> cachedSignals;
            if (signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals))
            {
                cachedSignals.Add(recieve);
                return;
            }

            signals.Add(typeof(T).GetHashCode(), new List<IRecieve> {recieve});
        }

        public void Remove<T>(IRecieve recieve)
        {
            List<IRecieve> cachedSignals;
            Timer.Add(Time.DeltaTime, () =>
            {
                if (signals.TryGetValue(typeof(T).GetHashCode(), out cachedSignals))
                {
                    cachedSignals.Remove(recieve);
                }
            });
        }


        public void Add(IRecieve recieve, Type type)
        {
            List<IRecieve> cachedSignals;
            if (signals.TryGetValue(type.GetHashCode(), out cachedSignals))
            {
                cachedSignals.Add(recieve);
                return;
            }

            signals.Add(type.GetHashCode(), new List<IRecieve> {recieve});
        }

        public void Remove(IRecieve recieve, Type type)
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


        public static bool TryAddToGlobal(object obj)
        { 
            var reciever = obj as IRecieve;
            if (reciever == null) return false;
            var all = obj.GetType().GetInterfaces();
            var hasLocals = false;
            foreach (var intType in all)
            {
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
                {
                    Default.Add(reciever, intType.GetGenericArguments()[0]);
                }


                if (!hasLocals && intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
                    hasLocals = true;
            }

            return hasLocals;
        }


        public static bool TryRemoveGlobal(object obj)
        {
            var reciever = obj as IRecieve;
            if (reciever == null) return false;
            var hasLocals = false;
            var all = obj.GetType().GetInterfaces();

            foreach (var intType in all)
            {
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
                {
                    Default.Remove(reciever, intType.GetGenericArguments()[0]);
                }
                else if (!hasLocals && intType.IsGenericType &&
                         intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
                {
                    hasLocals = true;
                }
            }

            return hasLocals;
        }


        public void Add(object obj)
        {
            var all = obj.GetType().GetInterfaces();
            var reciever = obj as IRecieve;
            foreach (var intType in all)
            {
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
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
                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
                {
                    Remove(reciever, intType.GetGenericArguments()[0]);
                }
            }
        }
//        public void Add(object obj)
//        {
//            var reciever = obj as IRecieve;
//            if (reciever == null) return;
//
//            var all = obj.GetType().GetInterfaces();
//
//            foreach (var intType in all)
//            {
//                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
//                {
//                    Default.Add(reciever, intType.GetGenericArguments()[0]);
//                }
//                else if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
//                {
//                    Add(reciever, intType.GetGenericArguments()[0]);
//                }
//            }
//        }
//        public void Remove(object obj)
//        {
//            var reciever = obj as IRecieve;
//            if (reciever == null) return;
//            var all = obj.GetType().GetInterfaces();
//
//            foreach (var intType in all)
//            {
//                if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceive<>))
//                {
//                    Default.Remove(reciever, intType.GetGenericArguments()[0]);
//                }
//                else if (intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IReceiveLocal<>))
//                {
//                    Remove(reciever, intType.GetGenericArguments()[0]);
//                }
//            }
     //   }

        public void Dispose()
        {
            signals.Clear();
        }

        #endregion
    }
}