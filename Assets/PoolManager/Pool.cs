/*===============================================================
Product:    Unity3d Utilities
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       16/09/2017 01:51
================================================================*/


using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Homebrew
{

    public class Pool
    {

        private Transform parentPool;
        private Dictionary<int, Stack<GameObject>> cachedObjects = new Dictionary<int, Stack<GameObject>>();
        private Dictionary<int, int> cachedIds = new Dictionary<int, int>();
        protected int index;

        public Pool PopulateWith(GameObject prefab, int amount, int amountPerTick, int tickSize = 1)
        {
            var key = prefab.GetInstanceID();
            var stack = new Stack<GameObject>(amount);
            cachedObjects.Add(key, stack);

            Observable.IntervalFrame(tickSize, FrameCountType.EndOfFrame).Where(val => amount > 0).Subscribe(_loop =>
            {
                Observable.Range(0, amountPerTick).Where(check => amount > 0).Subscribe(_pop =>
                {
                    index = amount;
                    var go = Populate(prefab, Vector3.zero, Quaternion.identity, parentPool);
                    go.SetActive(false);
                    cachedIds.Add(go.GetInstanceID(), key);
                    cachedObjects[key].Push(go);
                    amount--;
                });
            });
            return this;
        }


        public void SetParent(Transform parent)
        {
            parentPool = parent;
        }


        public GameObject Spawn(GameObject prefab, Vector3 position = default(Vector3),
            Quaternion rotation = default(Quaternion), Transform parent = null)
        {
            index++;
            var key = prefab.GetInstanceID();
            Stack<GameObject> stack;
            var stacked = cachedObjects.TryGetValue(key, out stack);

            if (stacked && stack.Count > 0)
            {
                var transform = stack.Pop().transform;
                transform.SetParent(parent);
                transform.rotation = rotation;
                transform.gameObject.SetActive(true);
                if (parent) transform.position = position;
                else transform.localPosition = position;
                var poolable = transform.GetComponent<IPoolable>();
                if (poolable != null) poolable.OnSpawn();
                return transform.gameObject;
            }

            if (!stacked) cachedObjects.Add(key, new Stack<GameObject>());

            var createdPrefab = Populate(prefab, position, rotation, parent);
            cachedIds.Add(createdPrefab.GetInstanceID(), key);
            return createdPrefab;
        }


        public void Despawn(GameObject go)
        {
            index--;
            go.SetActive(false);
            cachedObjects[cachedIds[go.GetInstanceID()]].Push(go);
            var poolable = go.GetComponent<IPoolable>();
            if (poolable != null) poolable.OnDespawn();
            if (parentPool != null) go.transform.SetParent(parentPool);

        }


        public void Dispose()
        {
            parentPool = null;
            cachedObjects.Clear();
            cachedIds.Clear();
        }


        GameObject Populate(GameObject prefab, Vector3 position = default(Vector3),
            Quaternion rotation = default(Quaternion), Transform parent = null)
        {
            var go = Object.Instantiate(prefab, position, rotation, parent).transform;
            //go.name += "_" + index;
            if (parent == null) go.position = position;
            else go.localPosition = position;
            return go.gameObject;
        }


    }
}
