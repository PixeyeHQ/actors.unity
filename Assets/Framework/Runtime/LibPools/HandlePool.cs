using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	internal static class HandlePool
	{

		internal static Dictionary<int, PoolContainer> pools = new Dictionary<int, PoolContainer>(4, new FastComparable());

		static HandlePool()
		{
			Add(Pool.Entities);
			Add(Pool.Audio);
			Add(Pool.UI);
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
			foreach ( var kvp in pools )
			{
				if (kvp.Value.globalPool) continue;
				kvp.Value.Dispose();
			}
		}

	}
}