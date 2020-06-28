using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class HelperGameObjects
  {
    public static Layer GetLayer(this GameObject go)
    {
      return LayerKernel.Layers[go.scene.buildIndex];
    }

    public static Layer GetLayer(this Transform tr)
    {
      return LayerKernel.Layers[tr.gameObject.scene.buildIndex];
    }

    public static string GetGameObjectPath(Transform transform)
    {
      string path = transform.name;
      if (transform.parent == null) return path;
      while (transform.parent.parent != null)
      {
        transform.GetSiblingIndex();
        transform = transform.parent;
        path      = transform.name + "/" + path;
      }

      return path;
    }

    static internal string GetGameObjectPath(Transform transform, ref int[] sibligs)
    {
      string path = transform.name;
      if (transform.parent == null) return path;
      var sibls = new List<int>();
      var tr    = transform;
      while (tr.parent != null)
      {
        sibls.Add(tr.GetSiblingIndex());
        tr = tr.parent;
      }

      sibls.Reverse();
      sibligs = sibls.ToArray();

      while (transform.parent.parent != null)
      {
        transform = transform.parent;
        path      = transform.name + "/" + path;
      }

      return path;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Actor GetActor(this Transform co)
    {
      var c = co.GetComponent<Actor>();
      if (c == null)
        c = co.gameObject.AddComponent<Actor>();
      return c;
    }

    public static T AddGet<T>(this GameObject co) where T : Component
    {
      var c = co.GetComponent<T>();
      if (c == null)
        c = co.AddComponent<T>();

      return c;
    }

    public static T AddGet<T>(this Transform co) where T : Component
    {
      var c = co.GetComponent<T>();
      if (c == null)
        c = co.gameObject.AddComponent<T>();

      return c;
    }

    public static T Find<T>(this GameObject go, string path)
    {
      return go.transform.Find(path).GetComponent<T>();
    }

    public static Transform FindDeep(this Transform obj, string id)
    {
      if (obj.name == id)
      {
        return obj;
      }

      int count = obj.childCount;
      for (int i = 0; i < count; ++i)
      {
        var posObj = obj.GetChild(i).FindDeep(id);
        if (posObj != null)
        {
          return posObj;
        }
      }

      return null;
    }

    public static List<T> GetAll<T>(this Transform obj)
    {
      var results = new List<T>();
      obj.GetComponentsInChildren(results);
      return results;
    }

    public static List<T> GetAll<T>(this Transform obj, string path)
    {
      var results = new List<T>();
      obj.Find(path).GetComponentsInChildren(results);
      return results;
    }

    public static void Release(this GameObject o, int poolID = 0)
    {
      if (poolID <= 0)
        GameObject.Destroy(o);
      else
      {
        var layer = LayerKernel.Layers[o.gameObject.scene.buildIndex];
        layer.Pool.Despawn(poolID, o);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this GameObject obj, string path)
    {
      return obj.transform.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Transform tr, string path)
    {
      return tr.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Behaviour obj, string path)
    {
      return obj.transform.Find(path).GetComponent<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Get<T>(this Behaviour obj)
    {
      return obj.GetComponent<T>();
    }

    public static List<int> FindValidNodes(this List<PoolNode> list, int id)
    {
      var l = new List<int>();
      for (int i = 0; i < list.Count; i++)
      {
        if (list[i].id == id)
          l.Add(i);
      }

      return l;
    }

    public static int FindValidNode(this List<PoolNode> list, int id, int pool)
    {
      for (int i = 0; i < list.Count; i++)
      {
        var l = list[i];
        if (l.id == id && l.pool == pool)
          return i;
      }

      return -1;
    }

    public static int FindInstanceID<T>(this List<T> list, T target) where T : Object
    {
      var targetID = target.GetInstanceID();

      for (var i = 0; i < list.Count; i++)
      {
        if (list[i].GetInstanceID() == targetID)
          return i;
      }

      return -1;
    }

    public static void Destroy(this Transform tr)
    {
      GameObject.Destroy(tr.gameObject);
    }
  }
}