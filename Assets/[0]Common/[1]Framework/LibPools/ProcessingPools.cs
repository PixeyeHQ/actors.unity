/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/2/2018  9:47 AM
================================================================*/

using System;
using System.Collections.Generic;

namespace Homebrew
{
	public class ProcessingPools : IDisposable
	{
		public static ProcessingPools Default;

		public readonly Dictionary<int, ProcessingFastPool> poolsComponents = new Dictionary<int, ProcessingFastPool>();


		public T Spawn<T>() where T : new()
		{
			return GetPool(typeof(T).GetHashCode()).Spawn<T>();
		}

		public void Despawn<T>(T component, int Hashcode) where T : IComponent
		{
			GetPool(Hashcode).Despawn(component);
		}

		public void Despawn<T>(T component) where T : IComponent
		{
			GetPool(typeof(T).GetHashCode()).Despawn(component);
		}

		public void Populate<T>(int amount) where T : IComponent, new()
		{
			var chunk = new T[amount];
			var pool = GetPool(typeof(T).GetHashCode());
			for (int i = 0; i < amount; i++)
			{
				chunk[i] = pool.Spawn<T>();
			}

			for (int i = 0; i < amount; i++)
			{
				pool.Despawn(chunk[i]);
			}
		}

		ProcessingFastPool GetPool(int id)
		{
			ProcessingFastPool p;
			if (poolsComponents.TryGetValue(id, out p))
			{
				return p;
			}

			p = new ProcessingFastPool();
			poolsComponents.Add(id, p);
			return p;
		}


		public void Dispose()
		{
			foreach (var value in poolsComponents.Values)
			{
				value.Dispose();
			}

			poolsComponents.Clear();
		}
	}
	public class ProcessingFastPool : IDisposable
	{
		Stack<IComponent> pool = new Stack<IComponent>();

		public T Spawn<T>() where T : new()
		{
			if (pool.Count > 0)
			{
				return (T) pool.Pop();
			}

			var obj = new T();
			return obj;
		}

		public void Despawn<T>(T component) where T : IComponent
		{
			component.Dispose();
			AddToPool(component);
		}


		public void Dispose()
		{
			foreach (var poolValue in pool)
			{
				poolValue.Dispose();
			}
		}


		void AddToPool<T>(T obj) where T : IComponent
		{
			pool.Push(obj);
		}
	}
}