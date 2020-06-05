using System;
using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
  public unsafe struct PoolMem
  {
    public int ElementSize;
    public int Length;
    public void* Memory;

    public void Alloc(int length, int elementSize)
    {
      Length      = length;
      ElementSize = elementSize;
      Memory      = (void*) UnmanagedMemory.Alloc(Length * elementSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T* Get<T>(int index) where T : unmanaged
    {
      return (T*) ((byte*) Memory + index * ElementSize);
    }

    public void Realloc(int length)
    {
      Memory = (void*) UnmanagedMemory.ReAlloc(Memory, length * ElementSize);
      Length = length;
    }

    public void Destroy()
    {
      UnmanagedMemory.Free((IntPtr) Memory);
      Memory = null;
      Length = 0;
    }
  }
}