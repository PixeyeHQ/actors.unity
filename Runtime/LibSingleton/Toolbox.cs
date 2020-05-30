//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Actors
{
  /// <summary>
  /// <para>Service locator</para>
  /// </summary>
  /// 

  // todo: redesign class.
  public class Toolbox : Singleton<Toolbox>
  {
    [SerializeField]
    Dictionary<int, object> data = new Dictionary<int, object>(5, new FastComparable());

    public static bool Contains<T>()
    {
      return Instance.data.ContainsKey(typeof(T).GetHashCode());
    }

    public static List<IDisposable> disposables = new List<IDisposable>(64);
    public static Action OnDestroyAction = delegate { };
 
    /// <summary>
    /// <para>Creates an object to the toolbox by type.</para> 
    /// </summary>
    public static T Add<T>(Type type = null) where T : new()
    {
      object o;
      var    hash = type == null ? typeof(T).GetHashCode() : type.GetHashCode();
      if (Instance.data.TryGetValue(hash, out o))
      {
        InitializeObject(o);
        return (T) o;
      }

      var created = new T();

      var proc = typeof(T).IsSubclassOf(typeof(Processor));
      if (!proc)
      {
        InitializeObject(created);
      }

      Instance.data.Add(hash, created);

      return created;
    }

    public static object Get(Type t)
    {
      Instance.data.TryGetValue(t.GetHashCode(), out var resolve);
      return resolve;
    }

    /// <summary>
    /// <para>Adds an object to the toolbox</para>
    /// </summary>
    public static void Add(object obj)
    {
      if (Instance.data.TryGetValue(obj.GetType().GetHashCode(), out var possibleObj))
      {
        InitializeObject(possibleObj);
      }

      var add             = obj;
      var scriptable      = obj as ScriptableObject;
      if (scriptable) add = Instantiate(scriptable);


      InitializeObject(obj);
      Instance.data.Add(obj.GetType().GetHashCode(), add);
    }

    public static void Remove(object obj)
    {
      if (applicationIsQuitting) return;
      Instance.data.Remove(obj.GetType().GetHashCode());
    }

    public static void InitializeObject(object obj)
    {
      if (obj is IAwake awakeble) awakeble.OnAwake();
      ProcessorUpdate.Add(obj);
    }

    /// <summary>
    /// <para>Gets an object from the toolbox by type</para>
    /// </summary>
    public static T Get<T>()
    {
      var    hasValue = Instance.data.TryGetValue(typeof(T).GetHashCode(), out var resolve);
      return hasValue ? (T) resolve : default(T);
    }

    internal void ClearSessionData()
    {
      if (applicationIsQuitting) return;

      var toWipe = new List<int>();

      foreach (var pair in data)
      {
        if (!(pair.Value is IKernel))
          toWipe.Add(pair.Key);

        if (!(pair.Value is IDisposable needToBeCleaned)) continue;

        needToBeCleaned.Dispose();
      }

      Instance.StopAllCoroutines();
      ProcessorTimer.Default.Dispose();
 
      Box.Default.Dispose();
      Pool.Dispose();
      Storage.DisposeSelf();
      Framework.Cleanup();
      ProcessorScene.Default.Dispose();
      ProcessorUpdate.Default.Dispose();


      foreach (var t in toWipe)
      {
        data.Remove(t);
      }
    }

    public static void DisposeObject(object obj)
    {
      if (isQuittingOrChangingScene()) return;

      if (obj is IDisposable disposable)
      {
        disposable.Dispose();
      }
    }

    void OnDestroy()
    {
      for (var i = 0; i < disposables.Count; i++)
      {
        disposables[i].Dispose();
      }
    }

    protected override void OnApplicationQuit()
    {
      
      for (var i = 0; i < ProcessorCoroutines.coroutine_handlers_global.Count; i++)
      {
        ProcessorCoroutines.coroutine_handlers_global[i].StopAll();
      }
 
     
      base.OnApplicationQuit();
      OnDestroyAction();
    }
  }
}