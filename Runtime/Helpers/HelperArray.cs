//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public static class HelperArray
  {
    public static void ResizeInt(ref int[,] original, int newLength, int cols)
    {
      var newArray = new int[newLength, cols];
      int minRows  = Math.Min(newLength, original.GetLength(0));
      int minCols  = Math.Min(cols, original.GetLength(1));
      for (int i = 0; i < minRows; i++)
      for (int j = 0; j < minCols; j++)
        newArray[i, j] = original[i, j];
      original = newArray;
    }

    public static void Resize<T>(ref T[,] original, int newLength, int cols)
    {
      var newArray = new T[newLength, cols];
      int minRows  = Math.Min(newLength, original.GetLength(0));
      int minCols  = Math.Min(cols, original.GetLength(1));
      for (int i = 0; i < minRows; i++)
      for (int j = 0; j < minCols; j++)
        newArray[i, j] = original[i, j];
      original = newArray;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ResizeTags<Tag>(ref Tag[][] original, int newLength)
    {
      var newArray = new Tag[newLength][];

      var min = Math.Min(newLength, original.GetLength(0));

      for (int i = 0; i < min; i++)
        newArray[i] = original[i];

      original = newArray;
    }

    public static void Resize<T>(ref T[][] original, int newLength)
    {
      var newArray = new T[newLength][];

      var min = Math.Min(newLength, original.GetLength(0));

      for (int i = 0; i < min; i++)
        newArray[i] = original[i];

      original = newArray;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, int start, int end)
    {
      int len = end - start;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, string from, int end) where T : UnityEngine.Object
    {
      Predicate<T> predicate = s => s.name == from;
      var          start     = -1;

      for (int i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = start + end - start;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, Predicate<T> predicate, int end)
    {
      var start = -1;

      for (int i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = start + end - start;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i + start];
      }

      return res;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] Slice<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (int i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = (start + end - start) * times;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i / times + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] SliceFlip<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (int i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = (start + end - start - 1) * times;

      // Return new array.
      var res = new T[len];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[(len - i) / times + start];
      }

      return res;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T[] SliceLastIsNull<T>(this T[] source, Predicate<T> predicate, int end, int times)
    {
      var start = -1;

      for (int i = 0; i < source.Length; i++)
      {
        ref var val = ref source[i];
        if (predicate(val))
        {
          start = i;
          break;
        }
      }

#if UNITY_EDITOR
      if (start == -1)
        throw new Exception($"Couldn't find object typeof {typeof(T)}");
#endif

      int len = (start + end - start) * times;
      // Return new array.
      var res = new T[len + 1];
      for (int i = 0; i < len; i++)
      {
        res[i] = source[i / times + start];
      }

      return res;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int BinarySearch(ref int[] entries, int value, int left, int right)
    {
      while (left <= right)
      {
        var m = (left + right) / 2;
        if (entries[m] == value) return m;
        if (entries[m] < value) left = m + 1;
        else right                   = m - 1;
      }

      return -1;
    }


    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // public unsafe static int BinarySearch(ent* entries, int value, int left, int right)
    // {
    //   while (left <= right)
    //   {
    //     var m = (left + right) / 2;
    //     if (entries[m].id == value) return m;
    //     if (entries[m].id < value) left = m + 1;
    //     else right                      = m - 1;
    //   }
    //
    //   return -1;
    // }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int BinarySearch(ref ent[] entries, int value, int left, int right)
    {
      while (left <= right)
      {
        var m = (left + right) / 2;
        if (entries[m].id == value) return m;
        if (entries[m].id < value) left = m + 1;
        else right                      = m - 1;
      }

      return -1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FindIndex<T>(this T[] array, Predicate<T> predicate)
    {
      return Array.FindIndex(array, predicate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FindIndexFast<T>(this T[] array, Predicate<T> predicate)
    {
      for (int i = 0; i < array.Length; i++)
      {
        ref var val = ref array[i];
        if (predicate(val)) return i;
      }

      return -1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this T[] array, Predicate<T> predicate)
    {
      for (int index = 0; index < array.Length; ++index)
      {
        ref T local = ref array[index];
        if (predicate(local))
          return local;
      }

      return default;
    }

    internal class ArrayTraverse
    {
      public int[] Position;
      int[] maxLengths;

      public ArrayTraverse(Array array)
      {
        maxLengths = new int[array.Rank];
        for (int i = 0; i < array.Rank; ++i)
        {
          maxLengths[i] = array.GetLength(i) - 1;
        }

        Position = new int[array.Rank];
      }

      public bool Step()
      {
        for (int i = 0; i < Position.Length; ++i)
        {
          if (Position[i] >= maxLengths[i]) continue;

          Position[i]++;
          for (int j = 0; j < i; j++)
          {
            Position[j] = 0;
          }

          return true;
        }

        return false;
      }
    }

    public static T[,] ResizeArray<T>(this T[,] original, in int rows, in int cols)
    {
      var newArray = new T[rows, cols];
      int minRows  = Math.Min(rows, original.GetLength(0));
      int minCols  = Math.Min(cols, original.GetLength(1));
      for (int i = 0; i < minRows; i++)
      for (int j = 0; j < minCols; j++)
        newArray[i, j] = original[i, j];
      return newArray;
    }

    public static void InsertCheck(this int[] a, int id, ref int length, ref int indexLast)
    {
      if (length == 0)
      {
        indexLast = 0;
        length++;
        return;
      }

      if (id > a[0])
      {
        length++;
        indexLast = 0;
      }
      else if (id < a[length - 1])
      {
        indexLast = length;
        length++;
      }
      else
      {
        if (id < a[indexLast])
        {
          length++;

          if (id > a[indexLast + 1])
          {
            indexLast = indexLast + 1;
          }
          else
          {
            int indexNext = indexLast;
            while (true)
            {
              if (id > a[indexNext])
              {
                indexLast = indexNext;

                break;
              }

              indexNext += 1;
            }
          }
        }
        else if (id > a[indexLast])
        {
          length++;

          if (id < a[indexLast - 1])
          {
          }
          else
          {
            int indexPrev = indexLast;
            while (true)
            {
              if (id < a[indexPrev])
              {
                indexLast = indexPrev + 1;
                break;
              }

              indexPrev -= 1;
            }
          }
        }
      }
    }

    public static void Insert<T>(T[] a, T val, int length, int indexLast)
    {
      Array.Copy(a, indexLast, a, indexLast + 1, length - indexLast - 1);
      a[indexLast] = val;
    }

    public static void Insert(this int[] a, ref int length, ref int idLast, ref int indexLast, int id)
    {
      if (id < a[0])
      {
        if (length == a.Length)
          Array.Resize(ref a, (length << 1) + 1);

        length++;
        Array.Copy(a, 0, a, 1, length - 1);
        a[0]      = id;
        idLast    = id;
        indexLast = 0;
      }
      else if (id > a[length - 1])
      {
        if (length == a.Length)
          Array.Resize(ref a, (length << 1) + 1);

        idLast      = id;
        indexLast   = length;
        a[length++] = id;
      }
      else
      {
        if (id > a[indexLast])
        {
          if (length == a.Length)
            Array.Resize(ref a, (length << 1) + 1);

          length++;

          if (id < a[indexLast + 1])
          {
            Array.Copy(a, indexLast + 1, a, indexLast + 2, length - indexLast - 1);
            idLast       = id;
            indexLast    = indexLast + 1;
            a[indexLast] = id;
          }
          else
          {
            int indexNext = indexLast + 2;
            while (true)
            {
              if (id < a[indexNext])
              {
                Array.Copy(a, indexNext, a, indexNext + 1, length - indexNext - 1);
                idLast       = id;
                indexLast    = indexNext;
                a[indexLast] = id;
                break;
              }

              indexNext += 1;
            }
          }
        }
        else if (id < a[indexLast])
        {
          if (length == a.Length)
            Array.Resize(ref a, (length << 1) + 1);

          length++;

          if (id > a[indexLast - 1])
          {
            Array.Copy(a, indexLast, a, indexLast + 1, length - indexLast - 1);
            idLast       = id;
            indexLast    = indexLast - 1;
            a[indexLast] = id;
          }
          else
          {
            int indexPrev = indexLast - 2;
            while (true)
            {
              if (id > a[indexPrev])
              {
                Array.Copy(a, indexPrev, a, indexPrev + 1, length - indexPrev - 1);
                idLast       = id;
                indexLast    = indexPrev;
                a[indexLast] = id;
                break;
              }

              indexPrev -= 1;
            }
          }
        }
      }
    }

    public static void Add<T>(this T[] a, T element, ref int length) where T : class
    {
      int index = 0;
      int len   = a.Length;
      for (int i = 0; i < len; i++)
      {
        if (a[i] != null) index++;
        else break;
      }

      if (index >= len)
      {
        len = index << 1;
        Array.Resize(ref a, len);
      }

      a[length++] = element;
    }

    public static void Remove<T>(this T[] a, T element, ref int length) where T : class
    {
      for (int i = 0; i < length; i++)
      {
        if (a[i] != element) continue;
        --length;
        Array.Copy(a, i + 1, a, i, length - i);
        break;
      }
    }

    public static void InsertionSort(int[] array)
    {
      for (int i = 0; i < array.Length - 1; i++)
      {
        int j   = i + 1;
        int tmp = array[j];
        while (j > 0 && tmp < array[j - 1])
        {
          array[j] = array[j - 1];
          j--;
        }

        array[j] = tmp;
      }
    }

    public static void Quicksort(int[] array, int left, int right)
    {
      while (true)
      {
        if (left < right)
        {
          int boundary = left;
          for (int i = left + 1; i < right; i++)
          {
            if (array[i] > array[left])
            {
              PerformSwap(i, ++boundary);
            }
          }

          PerformSwap(left, boundary);
          Quicksort(array, left, boundary);
          left = boundary + 1;
          continue;
        }

        break;
      }

      void PerformSwap(int l, int r)
      {
        int tmp = array[right];
        array[r] = array[l];
        array[l] = tmp;
      }
    }

    private static void Swap(int[] array, int left, int right)
    {
      int tmp = array[right];
      array[right] = array[left];
      array[left]  = tmp;
    }

    public static int SearchLinear(this int[] array, int value)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == value)
          return i;
      }

      return -1;
    }

    public static int SearchBinary(this int[] array, int rightIndex, int value, int prev)
    {
      int leftIndex = 0;

      if (array[leftIndex] == value) return 0;
      if (array[rightIndex - 1] == value) return rightIndex - 1;

      while (true)
      {
        if (leftIndex == rightIndex && array[leftIndex] != value) return -1;
        int middleIndex = (rightIndex + leftIndex) / 2;

        if (array[middleIndex] == value) return middleIndex;
        if (middleIndex == prev) return -1;

        if (array[middleIndex] > value)
        {
          leftIndex = middleIndex + 1;
          prev      = middleIndex;
          continue;
        }

        rightIndex = middleIndex - 1;
        prev       = middleIndex;
      }
    }
  }
}