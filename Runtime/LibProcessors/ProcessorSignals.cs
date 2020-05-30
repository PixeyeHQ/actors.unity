//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye.Actors
{
  public sealed class ProcessorSignals : IDisposable, IKernel
  {
    public static ProcessorSignals Default = new ProcessorSignals();
    internal List<SignalHandler> handlers = new List<SignalHandler>();

    public static void Send<T>(in T val)
    {
      for (int i = 0; i < Default.handlers.Count; i++)
      {
        Default.handlers[i].Dispatch(val);
      }
    }

    public static void Send<T>(in T val, int index)
    {
      Default.handlers[index].Dispatch(val);
    }

    public static void Add(object obj, int index = 0)
    {
      var processor = Default;
      processor.handlers[index].Add(obj);
    }

    public static void Remove(object obj, int index = 0)
    {
      var processor = Default;
      processor.handlers[index].Remove(obj);
    }
 
    public void Dispose()
    {
      var processor = Default;
      for (int i = 0; i < processor.handlers.Count; i++)
        processor.handlers[i].signals.Clear();
    }
  }

  internal class SignalHandler
  {
    internal readonly Dictionary<int, List<IReceive>> signals = new Dictionary<int, List<IReceive>>(new FastComparable());

    internal void Dispatch<T>(in T val)
    {
      if (!signals.TryGetValue(typeof(T).GetHashCode(), out var receiveList))
        return;
      int count = receiveList.Count;
      for (int index = 0; index < count; ++index)
        (receiveList[index] as IReceive<T>).HandleSignal(in val);
    }

    internal void Add(IReceive receive, Type type)
    {
      int hashCode = type.GetHashCode();
      if (signals.TryGetValue(hashCode, out var receiveList))
        receiveList.Add(receive);
      else
        signals.Add(hashCode, new List<IReceive>()
        {
          receive
        });
    }

    internal void Remove(IReceive receive, Type type)
    {
      if (!signals.TryGetValue(type.GetHashCode(), out var receiveList))
        return;
      receiveList.Remove(receive);
    }

    internal void Add(object obj)
    {
      var interfaces = obj.GetType().GetInterfaces();
      var receive = obj as IReceive;
      foreach (var type in interfaces)
      {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
          Add(receive, type.GetGenericArguments()[0]);
      }
    }

    internal void Remove(object obj)
    {
      var interfaces = obj.GetType().GetInterfaces();
      var receive = obj as IReceive;
      foreach (var type in interfaces)
      {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
          Remove(receive, type.GetGenericArguments()[0]);
      }
    }

    internal void Dispose()
    {
      signals.Clear();
    }
  }
}