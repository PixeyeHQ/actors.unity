//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	public sealed class BufferObj<T> where T : class
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

			public T Add()
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);
 
			return source[length++] = Creator();
		}


		public void Add(in T obj)
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = obj;
		}

		public void RemoveAt(int index)
		{
				Array.Copy(source, index + 1, source, index, length-- - index);
		}
	}
}