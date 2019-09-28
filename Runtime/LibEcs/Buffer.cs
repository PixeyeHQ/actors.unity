using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
	public class Buffer<T> : IEnumerable where T : struct
	{
		public static Buffer<T> Instance = new Buffer<T>(256);
		public int length;

		int[] queue;
		int[] pointers;
		T[] elements;
		int queueIndex;

		public ref T this[int index] => ref elements[pointers[index]];

		public Buffer(int size)
		{
			queue    = new int[size];
			pointers = new int[size];
			elements = new T[size];
		}


		public void Clear()
		{
			length = 0;
			queueIndex = 0;
		}


		public ref T Add(out int pointer)
		{
			if (length == elements.Length)
			{
				Array.Resize(ref elements, length << 1);
				Array.Resize(ref pointers, length << 1);
				Array.Resize(ref queue, length << 1);
			}

			var index = length++;
			if (queueIndex > 0)
			{
				pointer = pointers[index] = queue[--queueIndex];
			}
			else
			{
				pointer = pointers[index] = index;
			}


			return ref elements[pointer];
		}
		public ref T Add()
		{
			if (length == elements.Length)
			{
				Array.Resize(ref elements, length << 1);
				Array.Resize(ref pointers, length << 1);
				Array.Resize(ref queue, length << 1);
			}

			var index = length++;
			if (queueIndex > 0)
			{
				pointers[index] = queue[--queueIndex];
			}
			else
			{
				pointers[index] = index;
			}

			return ref elements[pointers[index]];
		}


		int indexLast;
		int offset;
		//int offsetBase;
		/// <summary>
		/// Can be used to safely remove elements by index. Don't use it inside loops. Use Remove instead.
		/// </summary>
		/// <param name="index"></param>
		public void RemoveAt(int index)
		{
			if (index - indexLast > 0)
			{
				indexLast =  index;
				index     -= ++offset;
			}
			else
			{
				indexLast = index;
				offset    = 0;
			}

			queue[queueIndex++] = pointers[index];

			if (index < --length)
			{
				Array.Copy(pointers, index + 1, pointers, index, length - index);
			}
		}

		public void Remove(int index)
		{
  		queue[queueIndex++] = pointers[index];

			if (index < --length)
			{
				Array.Copy(pointers, index + 1, pointers, index, length - index);
			}
		}

		#region ENUMERATOR

		public Enumerator GetEnumerator()
		{
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public struct Enumerator : IEnumerator
		{
			Buffer<T> buffer;
			int position;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(Buffer<T> buffer)
			{
			 
				position    = -1;
				this.buffer = buffer;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
			 
				return ++position  < buffer.length;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
 
				position = -1;
			}

			object IEnumerator.Current => Current;

			public int Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get { return position; }
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
				buffer = null;
			}
		}

		#endregion
	}
}