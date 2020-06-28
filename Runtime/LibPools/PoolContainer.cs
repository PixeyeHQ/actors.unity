using System.Collections;
using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class PoolContainer
  {
    List<GameObject> activeObjs = new List<GameObject>(500);

    Dictionary<int, Stack<GameObject>> cachedObjects =
      new Dictionary<int, Stack<GameObject>>(500, new FastComparable());

    Dictionary<int, int> cachedIds = new Dictionary<int, int>(500, new FastComparable());


    internal void RegisterAndAdd(GameObject prefab, GameObject obj)
    {
      var               key = prefab.GetInstanceID();
      Stack<GameObject> stack;
      var               hasValue = cachedObjects.TryGetValue(key, out stack);

      if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
      cachedIds.Add(obj.GetInstanceID(), key);
    }

    public void RegisterObject(GameObject prefab)
    {
      var               key = prefab.GetInstanceID();
      Stack<GameObject> stack;
      var               hasValue = cachedObjects.TryGetValue(key, out stack);

      if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
    }


    public void Prepopulate(GameObject prefab, GameObject obj)
    {
      var               key = prefab.GetInstanceID();
      Stack<GameObject> stack;
      var               hasValue = cachedObjects.TryGetValue(key, out stack);

      if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>());
      else
      {
        cachedIds.Add(obj.GetInstanceID(), key);
      }
    }

    public void AddToPool(GameObject go, GameObject prefab)
    {
      cachedIds.Add(go.GetInstanceID(), prefab.GetInstanceID());
    }

    public PoolContainer PopulateWith(GameObject prefab, int amount, int amountPerTick = 10, int timeRate = 1)
    {
      var               key = prefab.GetInstanceID();
      Stack<GameObject> stack;
      var               hasValue = cachedObjects.TryGetValue(key, out stack);
      if (!hasValue) cachedObjects.Add(key, new Stack<GameObject>(amount));

      LayerKernel.Run(CoPop());

      IEnumerator CoPop()
      {
        var delay = LayerKernel.Time.deltaTime;
        yield return LayerKernel.Wait(delay);

        for (var i = 0; i < amountPerTick; i++)
        {
          if (amount == 0) break;
          Populate(prefab, key);
          amount--;
        }

        if (amount > 0)
        {
          PopulateWith(prefab, amount, amountPerTick, timeRate);
        }
      }

      return this;
    }

    public bool Spawn(GameObject prefab, out GameObject obj, Transform parent = null)
    {
      var key = prefab.GetInstanceID();

      Stack<GameObject> objs;
      var               stacked = cachedObjects.TryGetValue(key, out objs);

      if (stacked && objs.Count > 0)
      {
        obj = objs.Pop();
        var transform = obj.transform;
        if (transform.parent != parent)
          transform.SetParent(parent);

        transform.gameObject.SetActive(true);

        return true;
      }

      if (!stacked)
      {
        cachedObjects.Add(key, new Stack<GameObject>(500));
      }

      var createdPrefab = Object.Instantiate(prefab, parent);

      var k = createdPrefab.GetInstanceID();

      cachedIds.Add(k, key);
      obj = createdPrefab;
      return false;
    }

    public GameObject Spawn(GameObject prefab, Transform parent = null)
    {
      var key = prefab.GetInstanceID();

      Stack<GameObject> objs;
      var               stacked = cachedObjects.TryGetValue(key, out objs);

      if (stacked && objs.Count > 0)
      {
        var obj       = objs.Pop();
        var transform = obj.transform;
        if (transform.parent != parent)
          transform.SetParent(parent);

        transform.gameObject.SetActive(true);

        return obj;
      }

      if (!stacked)
      {
        cachedObjects.Add(key, new Stack<GameObject>(600));
      }

      var createdPrefab = Object.Instantiate(prefab, parent);

      var k = createdPrefab.GetInstanceID();

      cachedIds.Add(k, key);
      return createdPrefab;
    }

    public GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation, Transform parent = null)
    {
      var key = prefab.GetInstanceID();

      Stack<GameObject> objs;
      var               stacked = cachedObjects.TryGetValue(key, out objs);

      if (stacked && objs.Count > 0)
      {
        var obj       = objs.Pop();
        var transform = obj.transform;
        if (transform.parent != parent)
          transform.SetParent(parent);

        transform.position = position;
        transform.rotation = rotation;
        transform.gameObject.SetActive(true);

        return obj;
      }

      if (!stacked)
      {
        cachedObjects.Add(key, new Stack<GameObject>(600));
      }

      if (parent != null)
      {
        position =  parent.TransformPoint(position);
        rotation *= parent.rotation;
      }

      var createdPrefab = Object.Instantiate(prefab, position, rotation, parent);

      var k = createdPrefab.GetInstanceID();

      cachedIds.Add(k, key);
      return createdPrefab;
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    public void Despawn(GameObject go)
    {
      go.SetActive(false);
      cachedObjects[cachedIds[go.GetInstanceID()]].Push(go);
    }

    public void DespawnAll()
    {
      for (var i = 0; i < activeObjs.Count; i++)
      {
        Despawn(activeObjs[i]);
      }

      activeObjs.Clear();
    }

    public void Dispose()
    {
      cachedObjects.Clear();
      cachedIds.Clear();
    }

    [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
    void Populate(GameObject prefab, int key)
    {
      var go = Object.Instantiate(prefab);
      go.SetActive(false);
      cachedIds.Add(go.GetInstanceID(), key);
      cachedObjects[key].Push(go);
    }
  }
}