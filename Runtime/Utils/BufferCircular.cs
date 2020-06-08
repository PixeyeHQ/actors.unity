using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class BufferCircular<T> : IEnumerable
  {
    internal int head;
    internal int tail;
    internal int length;
    internal T[] source = new T[6];

    public BufferCircular(int size)
    {
      source = new T[size];
    }
    
    public void Add(T val)
    {
      if (length == source.Length)
      {
        Array.Resize(ref source, length << 1);
      }

      if (head == source.Length)
      {
        head = 0;
      }

      length++;
      source[head++] = val;
    }

    public ref T Add()
    {
      if (length == source.Length)
      {
        Array.Resize(ref source, length << 1);
      }

      if (head == source.Length)
      {
        head = 0;
      }

      length++;
      return ref source[head++];
    }

    T Default;

    /// FIFO
    public ref T Dequeue()
    {
      if (length == 0 || tail == head)
      {
        return ref Default;
      }

      var t = tail++;
      if (tail == source.Length)
        tail = 0;
      length--;
      return ref source[t];
    }

    /// FIFO
    public ref T Peek()
    {
      return ref source[tail];
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
      BufferCircular<T> buffer;
      int position;
      int length;

      // 0 1 2 3 4 5 6
      //   X
      //         Y
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      internal Enumerator(BufferCircular<T> buffer)
      {
        length      = buffer.length + buffer.tail;
        position    = buffer.tail - 1;
        this.buffer = buffer;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        return ++position < length;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Reset()
      {
        position = -1;
      }

      object IEnumerator.Current => Current;

      public ref T Current
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => ref buffer.source[(position) % length];
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