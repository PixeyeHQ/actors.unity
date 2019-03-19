using System.Collections.Generic;
using UnityEngine;

namespace Pixeye
{
	public class ProcPool
	{
		public static Dictionary<int, PoolContainer> pools = new Dictionary<int, PoolContainer>(4, new FastComparable());

		public static ProcPool Default = new ProcPool();

		public ProcPool()
		{
			Add(Pool.Projectiles);
			Add(Pool.Entities);
			Add(Pool.Audio);
			Add(Pool.UI);
		}

		public static void Add(int id)
		{
			PoolContainer pool;
			pool = new PoolContainer();
			pools.Add(id, pool);
		}

		public static void Despawn(int poolID, GameObject obj) { pools[poolID].Despawn(obj); }

		public void Dispose()
		{
			foreach (var kvp in pools)
			{
				if (kvp.Value.globalPool) continue;
				kvp.Value.Dispose();
			}
		}
	}
}