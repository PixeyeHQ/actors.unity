//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class Actor : MonoBehaviour, IRequireActorsLayer
  {
    public ent entity;
    LayerCore layer;


#if UNITY_EDITOR
    [FoldoutGroup("Main"), SerializeField, ReadOnly]
    internal int _entity;
#endif

    [FoldoutGroup("Main")] public bool isPooled;

    [FoldoutGroup("Main")] public ScriptableBuild buildFrom;


    /// <summary>
    /// Initialize entity here.
    /// </summary>
    protected virtual void Setup()
    {
    }
    
    //===============================//
    // Launch methods
    //===============================//
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Launch(int layer)
    {
      int  id;
      byte age = 0;

      if (ent.entStack.length > 0)
      {
        ref var pop = ref ent.entStack.source[--ent.entStack.length];
        id = pop.id;
        unchecked
        {
          age = pop.age;
        }
      }
      else
        id = ent.lastID++;

      entity.id  = id;
      entity.age = age;


#if UNITY_EDITOR
      _entity = id;
#endif


      Actors.Entity.Initialize(id, age, isPooled);
      Actors.Entity.Transforms[id] = transform;
      //    Starter.Starters[layer].entities.Add(entity);
      if (buildFrom != null)
      {
        buildFrom.ExecuteOnStart(entity, this);
        Setup();
      }
      else
      {
        Setup();
        EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Launch()
    {
      int  id;
      byte age = 0;

      if (ent.entStack.length > 0)
      {
        ref var pop = ref ent.entStack.source[--ent.entStack.length];
        id = pop.id;
        unchecked
        {
          age = (byte) (pop.age);
        }
      }
      else
        id = ent.lastID++;

      entity.id  = id;
      entity.age = age;


#if UNITY_EDITOR
      _entity = id;
#endif


      Actors.Entity.Initialize(id, age, isPooled);
      Actors.Entity.Transforms[id] = transform;

      if (buildFrom != null)
      {
        buildFrom.ExecuteOnStart(entity, this);
        Setup();
      }
      else
      {
        Setup();
        EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Launch(ModelComposer model)
    {
      int  id;
      byte age = 0;

      if (ent.entStack.length > 0)
      {
        ref var pop = ref ent.entStack.source[--ent.entStack.length];
        id = pop.id;
        unchecked
        {
          age = (byte) (pop.age);
        }
      }
      else
        id = ent.lastID++;

      entity.id  = id;
      entity.age = age;

#if UNITY_EDITOR
      _entity = id;
#endif

      Actors.Entity.Initialize(id, age, isPooled);
      Actors.Entity.Transforms[id] = transform;
      model(entity);
      Setup();
      EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    void IRequireActorsLayer.Launch(LayerCore layer)
    {
      this.layer = layer;
      if (!entity.exist)
      {
        Launch();
      }
    }

    //===============================//
    // Create methods
    //===============================//

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Actor Create(GameObject prefab, Vector3 position = default, bool pooled = false)
    {
      var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
      var actor = tr.AddGetActor();

      actor.isPooled = pooled;
      actor.Launch();

      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Actor Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
    {
      var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, parent, position) : Obj.Spawn(prefab, parent, position);
      var actor = tr.AddGetActor();

      actor.isPooled = pooled;
      actor.Launch();

      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Actor Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
      var actor = tr.AddGetActor();
      actor.isPooled = pooled;
      actor.Launch(model);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Actor Create(string prefabID, Vector3 position = default, bool pooled = false)
    {
      var tr    = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      var actor = tr.AddGetActor();

      actor.isPooled = pooled;
      actor.Launch();

      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Actor Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      var tr    = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      var actor = tr.AddGetActor();
      actor.isPooled = pooled;
      actor.Launch(model);
      return actor;
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // public static Actor Create(scn layer, string prefabID, Vector3 position = default, bool pooled = false)
    // {
    //   SceneManager.SetActiveScene(layer.scene);
    //   var tr = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
    //   var actor = tr.AddGetActor();
    //   actor.isPooled = pooled;
    //   actor.Launch(layer.id);
    //   SceneManager.SetActiveScene(Starter.ActiveScene);
    //   return actor;
    // }
    //
    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // public static Actor Create(string sceneName, string prefabID, Vector3 position = default, bool pooled = false)
    // {
    //   var layer = Starter.Starters[SceneManager.GetSceneByName(sceneName).buildIndex+1].layer;
    //   SceneManager.SetActiveScene(layer.scene);
    //   var tr = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
    //   var actor = tr.AddGetActor();
    //   actor.isPooled = pooled;
    //   actor.Launch(layer.id);
    //   SceneManager.SetActiveScene(Starter.ActiveScene);
    //   return actor;
    // }
  }
}