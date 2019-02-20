/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/27/2018  8:43 PM
================================================================*/

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Homebrew
{
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
			var poolStash = ProcessingPool.pools[pool];
			poolStash.RegisterObject(prefab);

			for (var i = 0; i < createdObjs.Count; i++)
			{
				poolStash.AddToPool(createdObjs[i], prefab);
			}
		}
	}
}