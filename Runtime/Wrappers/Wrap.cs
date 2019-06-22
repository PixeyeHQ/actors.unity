//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
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
			prop = null;
			comparer = null;
			source = default;
			val = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(TProp other)
		{
			return Equals(val, other);
		}

	}

	public static class HelperWrapper
	{

		public static void ValueChange<TSource, TProp>(this TSource source, Func<TSource, TProp> propertySelector, Action<TProp> callback, ent e)
		{
			Wrap<TSource, TProp> w = new Wrap<TSource, TProp>();
			w.source = source;
			w.prop = propertySelector;
			w.callback = callback;

			#if UNITY_EDITOR

			if (Comparers.storage.TryGetValue(typeof(TProp).GetHashCode(), out object comparer))
				w.comparer = comparer as IEqualityComparer<TProp>;
			else
			{
				Debug.LogError($"Comparer for {typeof(TProp)} not found.");
			}

			#else
			w.comparer = Comparers.storage[typeof(TProp).GetHashCode()]  as IEqualityComparer<TProp>;
			#endif

			var cObserver = e.Add<ComponentObserver>();

			if (cObserver.length == cObserver.wrappers.Length)
				Array.Resize(ref cObserver.wrappers, cObserver.length << 1);

			cObserver.wrappers[cObserver.length++] = w;
		}

		public static ent ValueChange<TSource, TProp>(this TSource source, Func<TSource, TProp> propertySelector, Action<TProp> callback)
		{
			Wrap<TSource, TProp> w = new Wrap<TSource, TProp>();
			w.source = source;
			w.prop = propertySelector;
			w.callback = callback;

			#if UNITY_EDITOR

			if (Comparers.storage.TryGetValue(typeof(TProp).GetHashCode(), out object comparer))
				w.comparer = comparer as IEqualityComparer<TProp>;
			else
			{
				Debug.LogError($"Comparer for {typeof(TProp)} not found.");
			}

			#else
			w.comparer = Comparers.storage[typeof(TProp).GetHashCode()]  as IEqualityComparer<TProp>;
			#endif

			var e = Entity.Create();
			var cObserver = e.Add<ComponentObserver>();

			if (cObserver.length == cObserver.wrappers.Length)
				Array.Resize(ref cObserver.wrappers, cObserver.length << 1);

			cObserver.wrappers[cObserver.length++] = w;

			return e;
		}

		public static void ReleaseObservers(in this ent entity)
		{
			Components.DisposeComponentObserver(Storage<ComponentObserver>.Instance.components[entity.id]);
		}

	}

}