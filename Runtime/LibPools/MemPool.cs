using System;

namespace Pixeye.Framework
{
	public unsafe struct MemPool
	{

		public int ElementSize;
		public int Length;
		public void* Memory;

		public MemPool(int length, int elementSize)
		{
			Memory = (void*) UnmanagedMemory.Alloc(length);
			Length = length;
			ElementSize = elementSize;
		}

		public void* this[int index] => (byte*) Memory + ElementSize * index;

		public void Destroy()
		{
			UnmanagedMemory.Free((IntPtr) Memory);
			Memory = null;
			Length = 0;
		}

	}
}