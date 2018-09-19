using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class ProcessingGoPool : IDisposable, IAwake, IKernel
    {
        public static ProcessingGoPool Default;

        public readonly Dictionary<int, PoolStash> pools = new Dictionary<int, PoolStash>(4, new FastComparable());


        public void AddPool(int id, bool reparent = true)
        {
            PoolStash pool;
            if (pools.TryGetValue(id, out pool) == false)
            {
                pool = new PoolStash();
                pools.Add(id, pool);
                if (!reparent) return;
                var poolsGO = GameObject.Find("[POOLS]") ?? new GameObject("[POOLS]");
                var poolGO = new GameObject("Pool_" + id);
                poolGO.transform.SetParent(poolsGO.transform);
                pool.SetPoolParent(poolGO.transform);
            }
        }

        public void Despawn(int id, GameObject obj)
        {
            pools[id].Despawn(obj);
        }

        public void Dispose()
        {
            foreach (var kvp in pools)
            {
                if (kvp.Value.globalPool) continue;
                kvp.Value.Dispose();
            }
        }


        public static GameObject HandleSpawn(int id, GameObject prefab, Vector3 position = default(Vector3),
            Quaternion rotation = default(Quaternion),
            Transform parent = null, bool isPosLocal = false)
        {
            var proc = Default;
            return proc.pools[id].Spawn(prefab, position, rotation, parent, isPosLocal);
        }


        public static void AddToTemp(int id, GameObject obj)
        {
            var mng = Default;
            mng.pools[id].activeObjs.Add(obj);
        }

        public static void ReleaseTemp(int id)
        {
            var mng = Default;
            mng.pools[id].DespawnAll();
        }


        public void OnAwake()
        {
            AddPool(Pool.UI);
            AddPool(Pool.Projectiles);
            AddPool(Pool.Entities);
            AddPool(Pool.Audio);
        }
    }


    #region DEPRECATED

    //		public PoolStash PopulateWith(Pool id, GameObject prefab, int amount, int amountPerTick = 10, int tickSize = 1)
    //		{
    //			var pool = pools[(int) id];
    //			pool.PopulateWith(prefab, amount, amountPerTick, tickSize);
    //			return pool;
    //		}

    //		public GameObject Spawn(Pool id, GameObject prefab, Vector3 position = default(Vector3),
    //			Quaternion rotation = default(Quaternion),
    //			Transform parent = null, bool isPosLocal = false)
    //		{
    //			return pools[(int) id].Spawn(prefab, position, rotation, parent, isPosLocal);
    //		}


    //		public T Spawn<T>(Pool id, GameObject prefab, Vector3 position = default(Vector3),
    //			Quaternion rotation = default(Quaternion),
    //			Transform parent = null, bool isPosLocal = false) where T : class
    //		{
    //			var val = pools[(int) id].Spawn(prefab, position, rotation, parent, isPosLocal);
    //			var returnTo = val.GetComponent<T>();
    //			return returnTo;
    //		}

    #endregion
}