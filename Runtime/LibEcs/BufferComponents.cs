//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using System.Runtime.InteropServices;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BufferComponents
	{
		public ushort* ids;
		public byte length;
		public byte amount;


		public int Get(int id)
		{
			return ids[id];
		}

		public BufferComponents(int size)
		{
			ids    = (ushort*) Marshal.AllocHGlobal(size * sizeof(ushort)); //UnmanagedMemory.Alloc(size * sizeof(ushort));
			length = (byte) size;
			amount = 0;
		}

		public void Clear()
		{
			amount = 0;
		}

		public void Add(int type)
		{
			if (length == amount)
			{
				length = (byte) (amount << 1); // not safe
				ids = (ushort*) Marshal.ReAllocHGlobal((IntPtr) ids, (IntPtr)(length * sizeof(ushort)));
				//UnmanagedMemory.ReAlloc(ids, length * sizeof(ushort));
			}

			ids[amount++] = (ushort) type;
		}

		public void Remove(int type)
		{
			var typeConverted = (ushort) type;

			for (int i = 0; i < amount; i++)
			{
				if (ids[i] == typeConverted)
				{
					RemoveAt(i);
					break;
				}
			}
		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < amount - 1; ++i)
				ids[i] = ids[i + 1];

			amount--;
		}
	}
}