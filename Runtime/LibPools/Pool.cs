using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  public class Pool : IRequireActorsLayer, IDisposable
  {
    [TagField(categoryName = "Pool")] public const int None = -1;

    [TagField(categoryName = "Pool")] public const int Entities = 1;

    [TagField(categoryName = "Pool")] public const int UI = 2;

    [TagField(categoryName = "Pool")] public const int Audio = 3;

    internal Dictionary<int, PoolContainer> pools = new Dictionary<int, PoolContainer>(4, new FastComparable());

    public PoolContainer this[int index] => pools[index];

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      //this.layer = layer;
      Add(Entities);
      Add(Audio);
      Add(UI);
    }

    void Add(int id)
    {
      PoolContainer pool;
      pool = new PoolContainer();
      pools.Add(id, pool);
    }

    internal void Despawn(int poolID, GameObject obj)
    {
      pools[poolID].Despawn(obj);
    }

    void IDisposable.Dispose()
    {
      foreach (var kvp in pools)
      {
        kvp.Value.Dispose();
      }
    }
  }

  [Serializable]
  public class PoolNode
  {
    public int id;
    [TagFilter(typeof(Pool))] public int pool = Pool.None;

    public GameObject prefab;
    public List<GameObject> createdObjs = new List<GameObject>();

    public void Populate(Layer layer)
    {
      if (pool == Pool.None) return;
      var poolStash = layer.Pool.pools[pool];
      poolStash.RegisterObject(prefab);

      for (var i = 0; i < createdObjs.Count; i++)
      {
        poolStash.AddToPool(createdObjs[i], prefab);
      }
    }
  }
}