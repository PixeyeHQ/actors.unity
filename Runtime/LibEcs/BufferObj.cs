//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	sealed class BufferObj<T> where T : class
	{
		public static BufferObj<T> Default = null;
		public static Func<T> Creator;
		public T[] source;
		public int length;

		public ref T this[int index] => ref source[index];


		public BufferObj(int size, Func<T> Creator)
		{
			source               = new T[size];
			BufferObj<T>.Creator = Creator;
		}

		public T Get()
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			ref var next = ref source[length++];
			if (next == null)
				next = Creator();

			return next;
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
				source[i] = source[i + 1];
		}
	}
}