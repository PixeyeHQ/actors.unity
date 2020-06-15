//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public class Wrap<TSource, TProp> : IWrap<TProp>
  {
    public TSource source;
    public Func<TSource, TProp> prop;
    public Action<TProp> callback;
    public TProp val;

    public IEqualityComparer<TProp> comparer;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public IWrap<TProp> Subscribe(Action<TProp> callback)
    {
      this.callback = callback;
      return this;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void FirstTime()
    {
      var arg = prop(source);
      val = arg;
      callback(val);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Check()
    {
      var arg = prop(source);
      if (!comparer.Equals(arg, val))
      {
        val = arg;
        callback(val);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
      callback = null;
      prop     = null;
      comparer = null;
      source   = default;
      val      = default;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(TProp other)
    {
      return Equals(val, other);
    }
  }
}