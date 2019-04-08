//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye.Framework
{
    public class HandleFastPool<T> : IKernel, IDisposable where T : new()
    {
        public static readonly HandleFastPool<T> Instance = new HandleFastPool<T>();
        public Stack<T> pool = new Stack<T>(200);

        public T Spawn()
        {
            if (pool.Count > 0)
            {
                var v = pool.Pop();
                return v;
            }

            var obj = new T();
            return obj;
        }


        public void Despawn(T component)
        {
            var disposable = component as IDisposable;

            if (disposable != null) disposable.Dispose();
            AddToPool(component);
        }


        public void Dispose()
        {
            foreach (var poolValue in pool)
            {
                var disposable = poolValue as IDisposable;
                if (disposable != null) disposable.Dispose();
            }
        }

        public void Populate(int amount)
        {
            var chunk = new T[amount];

            for (var i = 0; i < amount; i++)
            {
                chunk[i] = Spawn();
            }

            for (var i = 0; i < amount; i++)
            {
                Despawn(chunk[i]);
            }
        }


        void AddToPool(T obj)
        {
            pool.Push(obj);
        }
    }
}