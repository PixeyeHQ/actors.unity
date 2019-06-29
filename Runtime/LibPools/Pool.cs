//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public static class Pool
	{
		[TagField(categoryName = "Pool")]
		public const int None = -1;

		[TagField(categoryName = "Pool")]
		public const int Entities = 1;

		[TagField(categoryName = "Pool")]
		public const int UI = 2;

		[TagField(categoryName = "Pool")]
		public const int Audio = 3;


		internal static Dictionary<int, PoolContainer> pools = new Dictionary<int, PoolContainer>(4, new FastComparable());

		static Pool()
		{
			Add(Entities);
			Add(Audio);
			Add(UI);
		}

		private static void Add(int id)
		{
			PoolContainer pool;
			pool = new PoolContainer();
			pools.Add(id, pool);
		}

		internal static void Despawn(int poolID, GameObject obj)
		{
			pools[poolID].Despawn(obj);
		}

		internal static void Dispose()
		{
			foreach (var kvp in pools)
			{
				if (kvp.Value.globalPool) continue;
				kvp.Value.Dispose();
			}
		}
		
	}

	[System.Serializable]
	public class PoolNode
	{
		public int id;
		[TagFilter(typeof(Pool))]
		public int pool = Pool.None;

		public GameObject prefab;
		public List<GameObject> createdObjs = new List<GameObject>();


		public void Populate()
		{
			if (pool == Pool.None) return;
			var poolStash = Pool.pools[pool];
			poolStash.RegisterObject(prefab);

			for (var i = 0; i < createdObjs.Count; i++)
			{
				poolStash.AddToPool(createdObjs[i], prefab);
			}
		}
	}
}