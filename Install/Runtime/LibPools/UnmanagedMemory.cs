using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pixeye.Actors
{
  public sealed unsafe class UnmanagedMemory
  {
#if UNITY_EDITOR
    static readonly HashSet<IntPtr> allocations = new HashSet<IntPtr>();
#endif

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntPtr Alloc(int size)
    {
      var ptr = Marshal.AllocHGlobal(size);
#if UNITY_EDITOR
      allocations.Add(ptr);
#endif
      return ptr;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntPtr ReAlloc(void* mem, int size)
    {
      var pointer = Marshal.ReAllocHGlobal((IntPtr) mem, (IntPtr) size);

#if UNITY_EDITOR
      allocations.Remove((IntPtr) mem);
      allocations.Add(pointer);
#endif
      return pointer;
    }

    public static void Free(IntPtr ptr)
    {
      Marshal.FreeHGlobal(ptr);
#if UNITY_EDITOR
      allocations.Remove(ptr);
#endif
    }

    [Conditional("UNITY_EDITOR")]
    public static void Cleanup()
    {
#if UNITY_EDITOR
      foreach (var ptr in allocations)
      {
        Marshal.FreeHGlobal(ptr);
      }

      allocations.Clear();
#endif
    }
  }
}