//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public sealed class ProcessorSignals : IDisposable
  {
    internal Dictionary<int, List<IReceive>> signals = new Dictionary<int, List<IReceive>>(new FastComparable());

    internal void Dispatch<T>(in T val)
    {
      if (!signals.TryGetValue(typeof(T).GetHashCode(), out var receiveList))
        return;
      int count = receiveList.Count;
      for (int index = 0; index < count; ++index)
        (receiveList[index] as IReceive<T>).HandleSignal(in val);
    }

    internal void Add(object obj)
    {
      var      interfaces = obj.GetType().GetInterfaces();
      IReceive receive    = obj as IReceive;
      foreach (Type type in interfaces)
      {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
        {
          Add(receive, type.GetGenericArguments()[0]);
        }
      }
    }

    internal void Remove(object obj)
    {
      var interfaces = obj.GetType().GetInterfaces();
      var receive    = obj as IReceive;
      foreach (var type in interfaces)
      {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
          Remove(receive, type.GetGenericArguments()[0]);
      }
    }

    void Add(IReceive receive, Type type)
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

    void Remove(IReceive receive, Type type)
    {
      if (!signals.TryGetValue(type.GetHashCode(), out var receiveList))
        return;
      receiveList.Remove(receive);
    }

    public void Dispose()
    {
      signals.Clear();
    }
  }
}