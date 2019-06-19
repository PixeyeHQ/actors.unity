//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;


namespace Pixeye.Framework
{
	[Serializable]
	public class BufferStruct<T> where T : struct
	{
		public static BufferStruct<T> Default = new BufferStruct<T>(500);

		public T[] source;
		public int length;

		public ref T this[int index] => ref source[index];


		public BufferStruct(int size)
		{
			source = new T[size];
		}
		
		
		public void Add(in T obj)
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
	}
}