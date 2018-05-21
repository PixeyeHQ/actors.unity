using System;
using System.Collections.Generic;
using UnityEngine;
 
namespace Homebrew
{
	public class ProcessingGoPool : IDisposable, IAwake
	{

		public static ProcessingGoPool Default;
		
		public readonly Dictionary<int, PoolStash> pools = new Dictionary<int, PoolStash>();

 

		public void AddPool(Pool id, bool reparent = true)
		{
			PoolStash pool;
			if (pools.TryGetValue((int) id, out pool) == false)
			{
				pool = new PoolStash();
				pools.Add((int) id, pool);
				if (reparent)
				{
					var poolsGO = GameObject.Find("[POOLS]") ?? new GameObject("[POOLS]");
					var poolGO = new GameObject("Pool_" + id);
					poolGO.transform.SetParent(poolsGO.transform);
					pool.SetPoolParent(poolGO.transform);
				}
			}
		}

		public void Despawn(Pool id, GameObject obj)
		{
			pools[(int) id].Despawn(obj);
		}

		public void Dispose()
		{
			foreach (var kvp in pools)
			{
				if (kvp.Value.globalPool) continue;
				kvp.Value.Dispose();
			}
 
		}


		public static GameObject HandleSpawn(Pool id, GameObject prefab, Vector3 position = default(Vector3),
			Quaternion rotation = default(Quaternion),
			Transform parent = null, bool isPosLocal = false)
		{
			var proc = Default;   
			return proc.pools[(int) id].Spawn(prefab, position, rotation, parent, isPosLocal);
		}


		public static void AddToTemp(Pool id, GameObject obj)
		{
			var mng =  Default;
			mng.pools[(int) id].activeObjs.Add(obj);
		}

		public static void ReleaseTemp(Pool id)
		{
			var mng = Default;
			mng.pools[(int) id].DespawnAll();
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