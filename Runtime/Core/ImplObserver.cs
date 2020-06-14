using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public class ImplObserver : IRequireActorsLayer
  {
    internal Layer layer;

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      this.layer = layer;
    }

    public ent Add<TSource, TProp>(TSource source, Func<TSource, TProp> propertySelector, Action<TProp> callback)
    {
      var w = new Wrap<TSource, TProp>();
      w.source   = source;
      w.prop     = propertySelector;
      w.callback = callback;
#if UNITY_EDITOR

      if (Comparers.storage.TryGetValue(typeof(TProp).GetHashCode(), out object comparer))
        w.comparer = comparer as IEqualityComparer<TProp>;
      else
      {
        Debug.LogError($"Comparer for {typeof(TProp)} not found.");
      }
#else
       w.comparer = Comparers.storage[typeof(TProp).GetHashCode()] as IEqualityComparer<TProp>;
#endif
      var     e         = layer.Entity.Create();
      ref var cObserver = ref e.Set<ComponentObserver>();
#if ACTORS_COMPONENTS_STRUCTS
            if (cObserver.wrappers == null)
              cObserver.wrappers = new IWrap[2];
#endif
      if (cObserver.length == cObserver.wrappers.Length)
        Array.Resize(ref cObserver.wrappers, cObserver.length << 1);
      cObserver.wrappers[cObserver.length++] = w;

      return e;
    }
    public void Add<TSource, TProp>(TSource source, Func<TSource, TProp> propertySelector,
      Action<TProp> callback, ref ent e)
    {
      var w = new Wrap<TSource, TProp>();
      w.source   = source;
      w.prop     = propertySelector;
      w.callback = callback;

#if UNITY_EDITOR

      if (Comparers.storage.TryGetValue(typeof(TProp).GetHashCode(), out object comparer))
        w.comparer = comparer as IEqualityComparer<TProp>;
      else
      {
        Debug.LogError($"Comparer for {typeof(TProp)} not found.");
      }

#else
          w.comparer = Comparers.storage[typeof(TProp).GetHashCode()] as IEqualityComparer<TProp>;
#endif
      var cObserver = default(ComponentObserver);
      if (!e.exist)
      {
        e         = layer.Entity.Create();
        cObserver = e.Set<ComponentObserver>();
      }
      else
      {
        cObserver = e.ComponentObserver();
      }

#if ACTORS_COMPONENTS_STRUCTS
          if (cObserver.wrappers == null)
            cObserver.wrappers = new IWrap[2];
#endif

      if (cObserver.length >= cObserver.wrappers.Length)
        Array.Resize(ref cObserver.wrappers, cObserver.length << 1);

      cObserver.wrappers[cObserver.length++] = w;
    }
  }
}