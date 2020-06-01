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
using UnityEngine.SceneManagement;

namespace Pixeye.Actors
{
  /// A scene point of entry. The developer defines here scene dependencies and processing that will work on the scene. 
  public abstract class Layer<T> : LayerCore
  {
    internal static Layer<T> layer;

    void Awake()
    {
      Bootstrap(); // Setup actors logic for a scene.
      Setup(); // Entry point for developers.
    }

    void Bootstrap()
    {
      #region Update Layers

      var buildIndex = gameObject.scene.buildIndex;
      if (buildIndex != -1)
      {
        if (Kernel.Layers.Count <= buildIndex)
        {
          var size = buildIndex - Kernel.Layers.Count + 1;
          for (int i = 0; i < size; i++)
          {
            Kernel.Layers.Add(null);
          }
        }

        Kernel.Layers[buildIndex] = this;
      }

      layer = this;

      #endregion

      #region Update Services

      processorUpdate = new ProcessorUpdate();
      processorUpdate.Add(this);

      processorCoroutine = Add<ProcessorCoroutine>();
      processorSignals   = Add<ProcessorSignals>();
      processorEcs       = Add<ProcessorEcs>();

      #endregion

      #region Update Active Layer

      if (gameObject.scene.name != Kernel.KernelSceneName)
        if (MainScene.NextActiveSceneName != null && MainScene.NextActiveSceneName == gameObject.scene.name)
        {
          MainScene.NextActiveSceneName = default;
          ActiveLayer                   = this;
          Run(CoWaitForSceneLoad());

          IEnumerator CoWaitForSceneLoad()
          {
            while (!gameObject.scene.isLoaded)
              yield return 0;

            SceneManager.SetActiveScene(gameObject.scene);
          }
        }

      #endregion
    }

    public static void Entity()
    {
    }


    #region Services

    public static Y Add<Y>() where Y : new()
    {
      var obj = new Y();
      if (obj is IRequireActorsLayer member)
        member.Launch(layer);
      layer.objects.Add(typeof(Y).GetHashCode(), obj);
      return obj;
    }

    public static Y Get<Y>() where Y : class
    {
      return layer.objects[typeof(Y).GetHashCode()] as Y;
    }

    #endregion

    #region Coroutines

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(IEnumerator routine)
    {
      return layer.processorCoroutine.Run(routine);
    }

    /// Run coroutine on the top of this layer.
    public static RoutineCall Run(float delay, IEnumerator routine)
    {
      return layer.processorCoroutine.Run(delay, routine);
    }

    /// Stop coroutine on the top of this layer.
    public static bool Stop(IEnumerator routine)
    {
      return layer.processorCoroutine.Stop(routine);
    }

    public static IEnumerator WaitFrame => null;

    public static IEnumerator Wait(float t)
    {
      layer.processorCoroutine.delays[layer.processorCoroutine.currentIndex] = t;
      return null;
    }

    public static RoutineCall WaitFor(float t, Action action)
    {
      var routine = Run(CoDelay());

      IEnumerator CoDelay()
      {
        yield return Wait(t);
        action();
      }

      return routine;
    }

    #endregion

    #region Signals

    public static void AddSignal(object obj)
    {
      layer.processorSignals.Add(obj);
    }

    public static void RemoveSignal(object obj)
    {
      layer.processorSignals.Remove(obj);
    }

    public static void SendSignal<Y>(in Y signal)
    {
      layer.processorSignals.Dispatch(signal);
    }

    #endregion

//     public static bool initialized;
//
//
//     internal static Starter ActiveStarter;
//     internal static Dictionary<int, Starter> Starters = new Dictionary<int, Starter>();
//     internal static Scene ActiveScene => ActiveStarter.gameObject.scene;
//     internal static scn ActiveLayer => ActiveStarter.layer;
//
//     /// Always bigger than actual scene index by 1. This is because 0 index is reserved by framework. 
//     internal scn layer { get; set; }
//
//     internal ents entities = new ents();
//
//     [HideInInspector]
//     public List<PoolNode> nodes = new List<PoolNode>();
//
//  
//     void Awake()
//     {
//       layer = new scn(gameObject.scene.buildIndex);
//       BootStrap();
//
//       OnAwake();
//
    //   Kernel.Instance.StartCoroutine
    //   (ProcessorScene.Default.coSetup
    //   (this)
    // );
//     }
//
//     private void RegisterAttributeComponents(IEnumerable<Type> enumerable)
//     {
//       foreach (var type in enumerable.Where(t => t.IsDefined(typeof(ActorsComponent), false)))
//       {
//         var genericStorage = typeof(Storage<>);
//         var constructedStorage = genericStorage.MakeGenericType(type);
//         Activator.CreateInstance(constructedStorage);
//       }
//     }
//
//     protected virtual void OnAwake()
//     {
//     }
//
//
//     public void BindScene()
//     {
//       ProcessorScene.Default.OnSceneLoad = delegate { };
//       ProcessorScene.Default.OnSceneClose = delegate { };
//       ProcessorScene.Default.OnSceneClose += Dispose;
//
//       for (var i = 0; i < nodes.Count; i++)
//         nodes[i].Populate();
//
//       Setup();
//
//       for (var i = 0; i < SceneManager.sceneCount; i++)
//       {
//         var scene = SceneManager.GetSceneAt(i);
//         var objs = scene.GetRootGameObjects();
//         foreach (var obj in objs)
//         {
//           var transforms = obj.GetComponentsInChildren<Transform>();
//
//           foreach (var tr in transforms)
//           {
//             if (!tr.gameObject.activeInHierarchy) continue;
//             var oo = tr.GetComponents<MonoBehaviour>();
//             foreach (var o in oo)
//             {
//               if (o is IRequireStarter req && o.enabled)
//               {
//                 req.Launch();
//               }
//             }
//           }
//         }
//       }
//
//       initialized = true;
//
//       Timer.Add(time.deltaFixed, PostSetup);
//     }
//
//
//     protected T Add<T>(Type type = null) where T : Processor, new()
//     {
//       var o = new T();
//       o.Set(layer.id);
//       return o;
//     }
//
//     /// This method will execute when the scene loaded. Use it to add your processors.
//     protected abstract void Setup();
//
//     protected virtual void PostSetup()
//     {
//     }
//
//     protected virtual void OnDestroy()
//     {
//       initialized = false;
//     }
//
//     /// This method will execute when the scene get removed. Use this method for reference cleanup.
//     protected abstract void Dispose();
//
//     internal void ReleaseScene()
//     {
//       ProcessorUpdate.Default.updates[layer.id].Dispose();
//       ProcessorSignals.Default.handlers[layer.id].Dispose();
//       ProcessorTimer.timers[layer.id].Dispose();
//
//       foreach (var entity in entities)
//       {
//         entity.Release();
//       }
//
//
//       entities.length = 0;
//
//       Dispose();
//     }
//
//     void BootStrap()
//     {
//       if (ProcessorUpdate.Default == null)
//       {
//         ProcessorScene.Default.next_main_scene = gameObject.scene.name;
//
//
//         ActiveStarter = this;
//
//         // zero entity
//         Entity.CreateFirst();
//
//         LoadTypes();
//
//         ProcessorUpdate.Create();
//         routines.Init();
//
//         ProcessorUpdate.Default.updates.Add(new Updates());
//         ProcessorSignals.Default.handlers.Add(new SignalHandler());
//         ProcessorTimer.timers.Add(new StorageTimers());
//         var o = new ProcessorObserver();
//         o.Set(0);
//
//         LoadPlugins();
//         UpdateIndexes();
//       }
//
//
//       if (ProcessorScene.Default.next_main_scene == gameObject.scene.name)
//         routines.run(CoWaitForSceneLoading());
//       else
//       {
//         UpdateIndexes();
//       }
//
//       IEnumerator CoWaitForSceneLoading()
//       {
//         while (!gameObject.scene.isLoaded)
//         {
//           yield return 0;
//         }
//         SceneManager.SetActiveScene(gameObject.scene);
//         ActiveStarter = this;
//         UpdateIndexes();
//       }
//
//
//       if (!Starters.ContainsKey(layer.id))
//         Starters.Add(layer.id, this);
//
//       void UpdateIndexes()
//       {
//         if (ProcessorUpdate.Default.updates.Count <= layer.id)
//         {
//           var diff = layer.id - ProcessorUpdate.Default.updates.Count + 1;
//
//           for (var i = 0; i < diff; i++)
//           {
//             ProcessorUpdate.Default.updates.Add(new Updates());
//             ProcessorSignals.Default.handlers.Add(new SignalHandler());
//             ProcessorTimer.Default = new ProcessorTimer();
//             ProcessorUpdate.AddKernel(ProcessorTimer.Default);
//             ProcessorTimer.timers.Add(new StorageTimers());
//           }
//         }
//       }
//
//       void LoadPlugins()
//       {
//         var t = Resources.Load<TextAsset>("SettingsFramework");
//         if (t != null)
//         {
//           JsonUtility.FromJsonOverwrite(t.text, Kernel.Settings);
//           for (int i = 0; i < Kernel.Settings.Plugins.Length; i++)
//           {
//             var plugin = Resources.Load<Pluggable>(Kernel.Settings.Plugins[i]);
//             plugin.Plug();
//           }
//         }
//       }
//
//       void LoadTypes()
//       {
//         var asmFramework = Assembly.GetExecutingAssembly();
//         var asmDataRaw = Kernel.Settings.Namespace;
//         RegisterAttributeComponents(asmFramework.GetTypes());
//
//         var q = asmFramework.GetTypes().Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);
//
//         foreach (var item in q)
//         {
//           Activator.CreateInstance(item);
//         }
//
//         if (asmDataRaw != string.Empty)
//         {
//           var asmData = Assembly.Load(asmDataRaw);
//           RegisterAttributeComponents(asmData.GetTypes());
//           q = asmData.GetTypes().Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);
//
//           foreach (var item in q)
//           {
//             Activator.CreateInstance(item);
//           }
//         }
//         else
//         {
//           var types = AppDomain.CurrentDomain.GetAssemblies().Where(asm => asm != asmFramework).SelectMany(t => t.GetTypes());
//           RegisterAttributeComponents(types);
//           q = types.Where(t => t.IsSubclassOf(typeof(Storage)) && !t.ContainsGenericParameters);
//           foreach (var item in q)
//           {
//             Activator.CreateInstance(item);
//           }
//         }
//       }
//     }
//
//
// #if UNITY_EDITOR
//
//     public void ClearNodes()
//     {
//       for (int i = 0; i < nodes.Count; i++)
//       {
//         var n = nodes[i];
//         n.createdObjs.Clear();
//         n.prefab = null;
//       }
//
//       nodes.Clear();
//     }
//
//     public void AddToNode(GameObject prefab, GameObject instance, int pool)
//     {
//       var id = prefab.GetInstanceID();
//       var nodesValid = nodes.FindValidNodes(id);
//       var conditionNodeCreate = true;
//       var nodesToKill = new List<int>();
//
//       for (var i = 0; i < nodesValid.Count; i++)
//       {
//         var node = nodes[nodesValid[i]];
//
//         var index = node.createdObjs.FindInstanceID(instance);
//         if (index != -1 && pool != node.pool)
//         {
//           node.createdObjs.RemoveAt(index);
//         }
//         else if (index == -1 && pool == node.pool)
//         {
//           conditionNodeCreate = false;
//           node.createdObjs.Add(instance);
//         }
//
//         if (index != -1 && pool == node.pool)
//         {
//           conditionNodeCreate = false;
//         }
//
//         if (node.createdObjs.Count == 0)
//         {
//           node.prefab = null;
//           nodesToKill.Add(nodesValid[i]);
//         }
//       }
//
//       for (var i = 0; i < nodesToKill.Count; i++)
//       {
//         nodes.RemoveAt(nodesToKill[i]);
//       }
//
//       if (conditionNodeCreate)
//       {
//         var node = new PoolNode();
//         node.id = id;
//         node.prefab = prefab;
//         node.pool = pool;
//         node.createdObjs = new List<GameObject>();
//         node.createdObjs.Add(instance);
//         nodes.Add(node);
//       }
//     }
//
//     public void RemoveFromNode(GameObject instance, int pool)
//     {
// #if UNITY_2018_3_OR_NEWER
//       var prefab = PrefabUtility.GetCorrespondingObjectFromSource(instance);
// #else
//       var prefab = (GameObject)PrefabUtility.GetPrefabObject(instance);
// #endif
//
//       if (prefab == null) return;
//       var id = prefab.GetInstanceID();
//       var index = nodes.FindValidNode(id, pool);
//       if (index != -1)
//       {
//         var n = nodes[index];
//
//         n.createdObjs.Remove(instance);
//         if (n.createdObjs.Count == 0)
//         {
//           n.prefab = null;
//           nodes.RemoveAt(index);
//         }
//       }
//     }
//
// #endif
//   }
//
//   internal static class HelperStarter
//   {
//     internal static List<int> FindValidNodes(this List<PoolNode> list, int id)
//     {
//       var l = new List<int>();
//       for (int i = 0; i < list.Count; i++)
//       {
//         if (list[i].id == id)
//           l.Add(i);
//       }
//
//       return l;
//     }
//
//     internal static int FindValidNode(this List<PoolNode> list, int id, int pool)
//     {
//       for (int i = 0; i < list.Count; i++)
//       {
//         var l = list[i];
//         if (l.id == id && l.pool == pool)
//           return i;
//       }
//
//       return -1;
//     }
//
//     internal static int FindInstanceID<T>(this List<T> list, T target) where T : UnityEngine.Object
//     {
//       int targetID = target.GetInstanceID();
//
//       for (int i = 0; i < list.Count; i++)
//       {
//         if (list[i].GetInstanceID() == targetID)
//           return i;
//       }
//
//       return -1;
//     }
//   }
//   
  }
}