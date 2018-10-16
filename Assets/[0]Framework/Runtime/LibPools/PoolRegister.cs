/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/27/2018  8:43 PM
================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class PoolRegister : MonoBehaviour
    {
        public PoolNode[] nodes;


        public void Reigster()
        {
            foreach (var node in nodes)
            {
                node.Populate();
            }
        }


        [System.Serializable]
        public class PoolNode
        {
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
}