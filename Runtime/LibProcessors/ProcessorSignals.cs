//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye.Framework
{
	public sealed class ProcessorSignals : IDisposable, IKernel
	{
		public static ProcessorSignals Default = new ProcessorSignals();
		private readonly Dictionary<int, List<IReceive>> signals = new Dictionary<int, List<IReceive>>((IEqualityComparer<int>) new FastComparable());

		public static void Send<T>(in T val)
		{
			Default.Dispatch(in val);
		}

		private void Dispatch<T>(in T val)
		{
			List<IReceive> receiveList;
			if (!signals.TryGetValue(typeof(T).GetHashCode(), out receiveList))
				return;
			int count = receiveList.Count;
			for (int index = 0; index < count; ++index)
				(receiveList[index] as IReceive<T>).HandleSignal(in val);
		}

		private void Add(IReceive receive, Type type)
		{
			int            hashCode = type.GetHashCode();
			List<IReceive> receiveList;
			if (signals.TryGetValue(hashCode, out receiveList))
				receiveList.Add(receive);
			else
				signals.Add(hashCode, new List<IReceive>()
				{
						receive
				});
		}

		private void Remove(IReceive receive, Type type)
		{
			List<IReceive> receiveList;
			if (!signals.TryGetValue(type.GetHashCode(), out receiveList))
				return;
			receiveList.Remove(receive);
		}

		public static bool Check(object obj)
		{
			return obj is IReceive;
		}

		public static void Add(object obj)
		{
			var      processor  = Default;
			var      interfaces = obj.GetType().GetInterfaces();
			IReceive receive    = obj as IReceive;
			foreach (Type type in interfaces)
			{
				if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
					processor.Add(receive, type.GetGenericArguments()[0]);
			}
		}

		public static void Remove(object obj)
		{
			var      processor  = Default;
			var      interfaces = obj.GetType().GetInterfaces();
			IReceive receive    = obj as IReceive;
			foreach (Type type in interfaces)
			{
				if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IReceive<>))
					processor.Remove(receive, type.GetGenericArguments()[0]);
			}
		}

		public void Dispose()
		{
			signals.Clear();
		}
	}
}