//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using UnityEditor;
#endif
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  /// <summary>
  /// <para>A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene.</para> 
  /// </summary>
  public class StarterCore : MonoBehaviour
  {
    public static bool initialized;

    internal static StarterCore ActiveStarter;

    /// Always bigger than actual scene index by 1. This is because 0 index is reserved by framework. 
    internal int sceneIndex => gameObject.scene.buildIndex + 1;

    internal Updates Update;

    [HideInInspector]
    public List<PoolNode> nodes = new List<PoolNode>();


    Dictionary<int, object> objectStorage = new Dictionary<int, object>(5, new FastComparable());


    void Awake()
    {
      BootStrap();

      OnAwake();

      Toolbox.Instance.StartCoroutine(ProcessorScene.Default.coSetup(this));
    }

    private void RegisterAttributeComponents(IEnumerable<Type> enumerable)
    {
      foreach (var type in enumerable.Where(t => t.IsDefined(typeof(ActorsComponent), false)))
      {
        var genericStorage = typeof(Storage<>);
        var constructedStorage = genericStorage.MakeGenericType(type);
        Activator.CreateInstance(constructedStorage);
      }
    }

    protected virtual void OnAwake()
    {
    }


    public static IEnumerable<Type> GetAllSubclassOf(Type parent)
    {
      foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        foreach (var t in a.GetTypes())
        {
          if (t.IsSubclassOf(parent))
            yield return t;
        }
    }


    public void BindScene()
    {
      ProcessorScene.Default.OnSceneLoad = delegate { };
      ProcessorScene.Default.OnSceneClose = delegate { };
      ProcessorScene.Default.OnSceneClose += Dispose;


      for (var i = 0; i < nodes.Count; i++)
        nodes[i].Populate();


      Add<ProcessorObserver>();


      Setup();


      for (var i = 0; i < SceneManager.sceneCount; i++)
      {
        var scene = SceneManager.GetSceneAt(i);
        var objs = scene.GetRootGameObjects();
        foreach (var obj in objs)
        {
          var transforms = obj.GetComponentsInChildren<Transform>();

          foreach (var tr in transforms)
          {
            if (!tr.gameObject.activeInHierarchy) continue;
            var oo = tr.GetComponents<MonoBehaviour>();
            foreach (var o in oo)
            {
              if (o is IRequireStarter req && o.enabled)
              {
                req.Launch();
              }
            }
          }
        }
      }

      initialized = true;


      Timer.Add(time.deltaFixed, PostSetup);
    }


    protected T Add<T>(Type type = null) where T : Processor, new()
    {
      var o = new T();
      o.Set(sceneIndex);
      return o;
    }

    /// Adds an object to the scene by type. It is mainly used to add processing scripts. 
    // protected T Add<T>(Type type = null) where T : new()
    // {
    //   var o = Kernel.Add<T>(objectStorage, type);
    //   if (o is Processor proc)
    //   {
    //     proc.Set(gameObject.scene.buildIndex);
    //   }
    //   return o;
    // }

    //  protected T Add<T>(Type type = null) where T : new() => Kernel.Add<T>(objectStorage, type);

    /// This method will execute when the scene loaded. Use it to add your processors.
    protected virtual void Setup()
    {
    }

    protected virtual void PostSetup()
    {
    }

    protected virtual void OnDestroy()
    {
      initialized = false;
    }


    /// This method will execute when the scene get removed. Use this method for reference cleanup.
    protected virtual void Dispose()
    {
    }


    internal void CleanScene()
    {
      ProcessorUpdate.Default.updates[sceneIndex].Dispose();
    }

    void BootStrap()
    {
      Update = new Updates();

      if (ProcessorUpdate.Default == null)
      {
        // zero entity
        Entity.Create();
        LoadTypes();
        LoadPlugins();
        ProcessorUpdate.Create();
        ActiveStarter = this;
      }


      if (ProcessorScene.Default.next_main_scene == gameObject.scene.name)
        routines.run(CoWaitForSceneLoading());
      else
      {
        UpdateIndexes();
      }

      IEnumerator CoWaitForSceneLoading()
      {
        while (!gameObject.scene.isLoaded)
        {
          yield return 0;
        }
        SceneManager.SetActiveScene(gameObject.scene);
        ActiveStarter = this;
        UpdateIndexes();
      }

      void UpdateIndexes()
      {
        if (ProcessorUpdate.Default.updates.Count <= sceneIndex)
        {
          var diff = sceneIndex - ProcessorUpdate.Default.updates.Count + 1;
          for (var i = 0; i < diff; i++)
          {
            ProcessorUpdate.Default.updates.Add(new Updates());
          }
        }
      }


      void LoadPlugins()
      {
        var t = Resources.Load<TextAsset>("SettingsFramework");
        if (t != null)
        {
          JsonUtility.FromJsonOverwrite(t.text, Kernel.Settings);
          for (int i = 0; i < Kernel.Settings.Plugins.Length; i++)
          {
            var plugin = Resources.Load<Pluggable>(Kernel.Settings.Plugins[i]);
            plugin.Plug();
          }
        }
      }

      void LoadTypes()
      {
        var asmFramework = Assembly.GetExecutingAssembly();
        var asmDataRaw = Kernel.Settings.Namespace;
        RegisterAttributeComponents(asmFramework.GetTypes());

        var q = asmFramework.GetTypes().Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);

        foreach (var item in q)
        {
          Activator.CreateInstance(item);
        }

        if (asmDataRaw != string.Empty)
        {
          var asmData = Assembly.Load(asmDataRaw);
          RegisterAttributeComponents(asmData.GetTypes());
          q = asmData.GetTypes().Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);

          foreach (var item in q)
          {
            Activator.CreateInstance(item);
          }
        }
        else
        {
          var types = AppDomain.CurrentDomain.GetAssemblies().Where(asm => asm != asmFramework).SelectMany(t => t.GetTypes());
          RegisterAttributeComponents(types);
          q = types.Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);
          foreach (var item in q)
          {
            Activator.CreateInstance(item);
          }
        }
      }
    }


#if UNITY_EDITOR

    public void ClearNodes()
    {
      for (int i = 0; i < nodes.Count; i++)
      {
        var n = nodes[i];
        n.createdObjs.Clear();
        n.prefab = null;
      }

      nodes.Clear();
    }

    public void AddToNode(GameObject prefab, GameObject instance, int pool)
    {
      var id = prefab.GetInstanceID();
      var nodesValid = nodes.FindValidNodes(id);
      var conditionNodeCreate = true;
      var nodesToKill = new List<int>();

      for (var i = 0; i < nodesValid.Count; i++)
      {
        var node = nodes[nodesValid[i]];

        var index = node.createdObjs.FindInstanceID(instance);
        if (index != -1 && pool != node.pool)
        {
          node.createdObjs.RemoveAt(index);
        }
        else if (index == -1 && pool == node.pool)
        {
          conditionNodeCreate = false;
          node.createdObjs.Add(instance);
        }

        if (index != -1 && pool == node.pool)
        {
          conditionNodeCreate = false;
        }

        if (node.createdObjs.Count == 0)
        {
          node.prefab = null;
          nodesToKill.Add(nodesValid[i]);
        }
      }

      for (var i = 0; i < nodesToKill.Count; i++)
      {
        nodes.RemoveAt(nodesToKill[i]);
      }

      if (conditionNodeCreate)
      {
        var node = new PoolNode();
        node.id = id;
        node.prefab = prefab;
        node.pool = pool;
        node.createdObjs = new List<GameObject>();
        node.createdObjs.Add(instance);
        nodes.Add(node);
      }
    }

    public void RemoveFromNode(GameObject instance, int pool)
    {
#if UNITY_2018_3_OR_NEWER
      var prefab = PrefabUtility.GetCorrespondingObjectFromSource(instance);
#else
      var prefab = (GameObject)PrefabUtility.GetPrefabObject(instance);
#endif

      if (prefab == null) return;
      var id = prefab.GetInstanceID();
      var index = nodes.FindValidNode(id, pool);
      if (index != -1)
      {
        var n = nodes[index];

        n.createdObjs.Remove(instance);
        if (n.createdObjs.Count == 0)
        {
          n.prefab = null;
          nodes.RemoveAt(index);
        }
      }
    }

#endif
  }
}