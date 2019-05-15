//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using UnityEngine;

namespace Pixeye.Framework
{
	[Serializable]
	public class BufferStruct<T> where T : struct
	{

		public static BufferStruct<T> Instance = new BufferStruct<T>();

		public T[] source = new T[12];
		public int length;

		public ref T this[int index] => ref source[index];

		public void Add(T obj)
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = obj;
		}

		public void RemoveAt(int index)
		{
			--length;
			for (int i = index; i < length; ++i)
				SetElement(i, ref source[i + 1]);
		}

		public void SetElement(int index, ref T arg)
		{
			source[index] = arg;
		}

		public ref T Add()
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			return ref source[length++];
		}

	}
}