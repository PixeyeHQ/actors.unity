using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class Buffer<T> : IRequireActorsLayer, IDisposable, IEnumerable where T : struct
  {
    internal static Buffer<T>[] layers = new Buffer<T>[LayerKernel.LAYERS_AMOUNT_TOTAL];

    public void Bootstrap(Layer layer)
    {
      layerID         = layer.id;
      layers[layerID] = this;
    }

    public int length; 
    int layerID;

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

    public Buffer()
    {
      queue    = new int[64];
      pointers = new int[64];
      elements = new T[64];
    }

    public void Clear()
    {
      length     = 0;
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

    public void RemoveAt(int index)
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
        position    = buffer.length;
        this.buffer = buffer;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        return --position >= 0;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Reset()
      {
        position = buffer.length;
      }

      object IEnumerator.Current => Current;

      public int Current
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => position;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Dispose()
      {
        buffer = null;
      }
    }

    #endregion

    public void Dispose()
    {
      length          = 0;
      layers[layerID] = null;
    }
  }
}