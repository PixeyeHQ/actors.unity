//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Actors
{
  [Serializable]
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class ents : IEnumerable
  {
    public ent[] source;
    public int length;

    public ref ent this[int index]
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => ref source[index];
    }
    
    public ents(int cap = 0)
    {
      source = new ent[cap > 0 ? cap : 5];
      length = 0;
    }

    public ents(ents list)
    {
      length = list.length;
      source = new ent[length + 1];
      for (int i = 0; i < length; i++)
      {
        source[i] = list[i];
      }
    }

    public bool Has(in ent entity)
    {
      for (var i = 0; i < length; i++)
      {
        ref var val = ref source[i];
        if (entity.id == val.id && entity.age == val.age)
          return true;
      }

      return false;
    }


    public void Add(ent entity)
    {
      if (length >= source.Length)
        Array.Resize(ref source, length << 1);

      source[length++] = entity;
    }


    public void Add(params ent[] entity)
    {
      foreach (var e in entity)
      {
        if (length >= source.Length)
          Array.Resize(ref source, length << 1);

        source[length++] = e;
      }
    }


    public void Add(ents entities)
    {
      for (int i = 0; i < entities.length; i++)
      {
        Add(entities[i]);
      }
    }


    public bool Remove(in ent entity)
    {
      var index = -1;

      for (var i = 0; i < length; i++)
      {
        ref var val = ref source[i];
        if (entity.id == val.id && entity.age == val.age)
        {
          index = i;
          break;
        }
      }

      var removed = index > -1;
      if (removed && index < --length)
        Array.Copy(source, index + 1, source, index, length - index);
      return removed;
    }


    public void RemoveAt(int index)
    {
      Array.Copy(source, index + 1, source, index, --length - index);
    }

    public override string ToString()
    {
      var s = "";
      for (int i = 0; i < length; i++)
      {
        s += $" {source[i]}";
      }

      return $"len: {length} |{s}";
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


    public struct Enumerator : IEnumerator<ent>
    {
      ents g;
      int position;


      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      internal Enumerator(ents g)
      {
        position = g.length;
        this.g   = g;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        return --position >= 0;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Reset()
      {
        position = g.length;
      }

      object IEnumerator.Current => Current;

      public ent Current
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return g.source[position]; }
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Dispose()
      {
        g = null;
      }
    }

    #endregion
  }

  [Serializable]
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class indexes : IEnumerable
  {
    public int[] source;
    public int length;

    public int this[int index]
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get => source[index];
    }

    public indexes(int cap = 0)
    {
      source = new int[cap > 0 ? cap : 5];
      length = 0;
    }

    public void Add(int id)
    {
      if (length >= source.Length)
        Array.Resize(ref source, length << 1);

      source[length++] = id;
    }

    public void Add(params int[] ids)
    {
      foreach (var id in ids)
      {
        if (length >= source.Length)
          Array.Resize(ref source, length << 1);

        source[length++] = id;
      }
    }

    public void Clear()
    {
      //source = new int[source.Length];
      length = 0;
    }

    public bool Remove(int id)
    {
      var index = -1;
      for (var i = 0; i < length; i++)
      {
        if (id == source[i])
        {
          index = i;
          break;
        }
      }

      var removed = index > -1;
      if (removed && index < --length)
        Array.Copy(source, index + 1, source, index, length - index);
      return removed;
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


    public struct Enumerator : IEnumerator<int>
    {
      indexes g;
      int position;


      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      internal Enumerator(indexes g)
      {
        position = g.length;
        this.g   = g;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        return --position >= 0;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Reset()
      {
        position = g.length;
      }

      object IEnumerator.Current => Current;

      public int Current
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return g.source[position]; }
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Dispose()
      {
        g = null;
      }
    }

    #endregion
  }
}