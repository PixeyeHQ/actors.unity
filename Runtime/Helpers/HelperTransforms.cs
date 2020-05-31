using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class HelperTransforms
  {
    static FastString strPath = new FastString(256);

    public static string GetGameObjectPath(Transform transform)
    {
      string path = transform.name;
      if (transform.parent == null) return path;
      while (transform.parent.parent != null)
      {
        transform.GetSiblingIndex();
        transform = transform.parent;
        path = transform.name + "/" + path;
      }

      return path;
    }

    static internal string GetGameObjectPath(Transform transform, ref int[] sibligs)
    {
      string path = transform.name;
      if (transform.parent == null) return path;
      var sibls = new List<int>();
      var tr = transform;
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
        path = transform.name + "/" + path;
      }

      return path;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Actor AddGetActor(this Transform co)
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
  }
}