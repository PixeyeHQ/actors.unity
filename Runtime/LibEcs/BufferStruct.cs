//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;

namespace Pixeye.Framework
{
	[Serializable]
	public class BufferStruct<T> where T : struct
	{
		public static BufferStruct<T> Default = new BufferStruct<T>(500);
		
		public int length;

		public T[] source;
		int[] pointers;
		int[] queue;
		int lengthQueue;
		int tail;
		int head;


		public ref T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref source[pointers[index]];
		}


		public BufferStruct(int size)
		{
			source   = new T[size];
			pointers = new int[size];
			queue    = new int[size];
		}


		public ref T Add()
		{
			var index = length++;
			if (lengthQueue> 0)
			{
				pointers[index] = queue[head];
				queue[head]     = 0;
				head            = (head + 1) % queue.Length;
				lengthQueue--;
			}
			else pointers[index] = length;
			return ref source[pointers[index]];
		}

		public int AddIndex()
		{
			var index = length++;
			if (lengthQueue > 0)
			{
				pointers[index] = queue[head];
				queue[head]     = 0;
				head            = (head + 1) % queue.Length;
				lengthQueue--;
			}
			else pointers[index] = length;
 
			return index;
		}


		public void RemoveAt(int index)
		{
			queue[tail] = pointers[index];
			tail        = (tail + 1) % queue.Length;
			lengthQueue++;

			--length;
			for (int i = index; i < length; i++)
			{
				pointers[i] = pointers[i + 1];
			}
		}
	}
}