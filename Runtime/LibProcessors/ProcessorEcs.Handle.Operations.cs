using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.SceneManagement;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  internal unsafe partial class ProcessorEcs
  {
    internal enum Action : byte
    {
      Add = 0,
      ChangeTag,
      Remove,
      Kill,
      Empty,
      Activate
    }

    internal int operationsLength;
    internal EntityOperation[] operations = new EntityOperation[LayerKernel.Settings.SizeEntities];


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void SetOperation(in ent entity, int arg, Action action)
    {
      if (operationsLength == operations.Length)
        Array.Resize(ref operations, operationsLength << 1);

      ref var operation = ref operations[operationsLength++];
      operation.entity = entity;
      operation.arg    = arg;
      operation.action = action;
    }
 
    [Conditional("ACTORS_DEBUG")]
    void DebugDontExist(EntityMeta* meta, int entityID, Storage storage)
    {
      if (meta->componentsAmount != 0) return;
      LayerKernel.Debugger.Log(LogType.REMOVE_NON_EXISTANT, entityID, storage.GetComponentType().Name);
      throw new Exception();
    }

    internal void SwapLayerActor(ent entity, Layer otherLayer)
    {
      var     eMeta    = entity.meta;
      ref var eManaged = ref entity.managed;
      eManaged.layer = otherLayer;

      var actor = eManaged.transform.GetComponent<Actor>();
      actor.HandleDisable();
      actor.Layer = otherLayer;
      SceneManager.MoveGameObjectToScene(eManaged.transform.gameObject, otherLayer.gameObject.scene);


      for (var j = 0; j < eMeta->groupsAmount; j++)
      {
        var group = Groups[eMeta->groups[j]];
        group.Remove(entity.id);
      }

      eMeta->groupsAmount = 0;

      for (var j = 0; j < eMeta->componentsAmount; j++)
      {
        var componentID = eMeta->components[j];
        var storage     = Storage.All[componentID];
        var groups      = storage.groups[eManaged.layer.id];

        for (var l = 0; l < groups.length; l++)
        {
          var group = groups.Elements[l];
          if (group.composition.Check(eMeta, ref eManaged))
          {
            group.Insert(entity);
            eMeta->AddGroup(group.id);
          }
        }
      }

      actor.HandleEnable();

      foreach (var child in eManaged.childs)
      {
        SwapLayer(child, otherLayer);
      }
    }

    internal void SwapLayer(ent entity, Layer otherLayer)
    {
      var     eMeta    = entity.meta;
      ref var eManaged = ref entity.managed;
      eManaged.layer = otherLayer;

      if (eManaged.transform != null)
      {
        SceneManager.MoveGameObjectToScene(eManaged.transform.gameObject, otherLayer.gameObject.scene);
      }

      for (var j = 0; j < eMeta->groupsAmount; j++)
      {
        var group = Groups[eMeta->groups[j]];
        group.Remove(entity.id);
      }

      eMeta->groupsAmount = 0;

      for (var j = 0; j < eMeta->componentsAmount; j++)
      {
        var componentID = eMeta->components[j];
        var storage     = Actors.Storage.All[componentID];
        var groups      = storage.groups[eManaged.layer.id];

        for (var l = 0; l < groups.length; l++)
        {
          var group = groups.Elements[l];
          if (group.composition.Check(eMeta, ref eManaged))
          {
            group.Insert(entity);
            eMeta->AddGroup(group.id);
          }
        }
      }

      foreach (var child in eManaged.childs)
      {
        SwapLayer(child, otherLayer);
      }
    }

    internal void Execute()
    {
      for (var i = 0; i < operationsLength; i++)
      {
        ref var operation = ref operations[i];
        var     entityID  = operation.entity.id;
        var     eMeta     = Entities.Get<EntityMeta>(entityID); // POINTER
        ref var eManaged  = ref EntitiesManaged[entityID];
        switch (operation.action)
        {
          case Action.Activate:
          {
            for (int j = 0; j < eMeta->componentsAmount; j++)
            {
              var componentID = eMeta->components[j];
              var storage     = Storage.All[componentID];
              //var generation  = Storage.Generations[componentID];
              //var mask        = Storage.Masks[componentID];
              var groups = storage.groups[eManaged.layer.id];

              for (var l = 0; l < groups.length; l++)
              {
                var group = groups.Elements[l];
                if (group.composition.Check(eMeta, ref eManaged))
                {
                  if (eMeta->AlreadyInGroup(group.id)) continue;
                  group.Insert(operation.entity);
                  eMeta->AddGroup(group.id);
                }
              }

              eMeta->isDirty = false;
            }

            operation.entity.RenameGameobject();
          }
            break;
          case Action.Add:
          {
            var componentID = operation.arg;
            var storage     = Actors.Storage.All[componentID];
            //var generation  = Storage.Generations[componentID];
            //var mask        = Storage.Masks[componentID];
            var groups = storage.groups[eManaged.layer.id];

            //eManaged.generations[generation] |= mask;

            for (var l = 0; l < groups.length; l++)
            {
              var group = groups.Elements[l];

              if (group.composition.Check(eMeta, ref eManaged))
              {
                group.Insert(operation.entity);
                eMeta->AddGroup(group.id);
              }
              else
              {
                if (group.TryRemove(entityID))
                  eMeta->RemoveGroup(group.id);
              }
            }

            operation.entity.RenameGameobject();
          }
            break;
          case Action.ChangeTag:
          {
            // check if dead 
            if (eMeta->componentsAmount == 0) continue;

            var groups = eManaged.layer.processorEcs.familyTags.cache[operation.arg];

            for (var l = 0; l < groups.length; l++)
            {
              var group = groups.Elements[l];

              var canBeAdded = group.composition.Check(eMeta, ref eManaged);

              var inGroup = group.length == 0
                ? -1
                : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length - 1);

              if (inGroup == -1)
              {
                if (!canBeAdded) continue;
                group.Insert(operation.entity);
                eMeta->AddGroup(group.id);
              }
              else if (!canBeAdded)
              {
                group.Remove(inGroup);
                eMeta->RemoveGroup(group.id);
              }
            }
          }
            break;
          case Action.Kill:
          {
            for (var j = 0; j < eMeta->groupsAmount; j++)
            {
              var group = Groups[eMeta->groups[j]];
              group.RemoveFast(entityID);
            }

            eMeta->groupsAmount = 0;

            for (var j = 0; j < eMeta->componentsAmount; j++)
            {
              var componentID = eMeta->components[j];
              //var generation  = Storage.Generations[componentID];
              //var mask        = Storage.Masks[componentID];

              //eManaged.generations[generation] &= ~mask;
              Storage.All[componentID].toDispose.Add(entityID);
            }


            eMeta->componentsAmount = 0;

            for (var ii = 0; ii < LayerKernel.Settings.SizeGenerations; ii++)
              eManaged.signature[ii] = 0;


            eManaged.childs.length = 0;

            if (eManaged.transform != null)
            {
              eManaged.transform.gameObject.Release(eManaged.isPooled ? Pool.Entities : 0);
            }

            eMeta->tags.Clear();
            eMeta->isAlive = false;

            entities.Remove(operation.entity);

            operation.entity.age += 1;
            if (operation.entity.age == int.MaxValue)
              operation.entity.age = 0;

            ent.Released.Add(operation.entity);
          }
            break;
          case Action.Remove:
          {
            if (eMeta->componentsAmount == 0) continue;
            var componentID = operation.arg;
            var storage     = Actors.Storage.All[componentID];
            //var generation  = Storage.Generations[componentID];
            //var mask        = Storage.Masks[componentID];
            var groups = storage.groups[eManaged.layer.id];

            DebugDontExist(eMeta, entityID, storage);

            //eManaged.generations[generation] &= ~mask;

            eMeta->RemoveComponent(componentID, entityID);

            operation.entity.RenameGameobject();

            for (var l = 0; l < groups.length; l++)
            {
              var group = groups.Elements[l];

              if (!group.composition.Check(eMeta, ref eManaged))
              {
                if (group.TryRemove(entityID))
                  eMeta->RemoveGroup(group.id);
              }
              else
              {
                var inGroup = group.length == 0
                  ? -1
                  : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length - 1);
                if (inGroup == -1)
                {
                  group.Insert(operation.entity);
                  eMeta->AddGroup(group.id);
                }
              }
            }

            if (eMeta->componentsAmount == 0)
            {
              SetOperation(operation.entity, 0, Action.Empty);
            }
          }
            break;
          case Action.Empty:
          {
            if (eManaged.transform != null)
            {
              eManaged.transform.gameObject.Release(eManaged.isPooled ? Pool.Entities : 0);
            }

            foreach (var child in eManaged.childs)
              child.Release();

            eManaged.childs.length = 0;

            eMeta->tags.Clear();
            eMeta->isAlive = false;
            entities.Remove(operation.entity);

            operation.entity.age += 1;
            if (operation.entity.age == int.MaxValue)
              operation.entity.age = 0;

            ent.Released.Add(operation.entity);
          }
            break;
        }
      }


      if (operationsLength > 0)
      {
        operationsLength = 0;

        for (var i = 0; i < processors.Count; i++)
          processors[i].HandleEcsEvents();

#if ACTORS_EVENTS_MANUAL
        for (var ii = 0; ii < groups.Count; ii++)
        {
          var nextGroup = groups[ii];

          if (nextGroup.hasEventRemove)
            nextGroup.removed.length = 0;
          
          if (nextGroup.hasEventAdd)
            nextGroup.added.length = 0;
        }
#else
        for (var ii = 0; ii < groups.Count; ii++)
        {
          var nextGroup = groups[ii];

          nextGroup.removed.length = 0;
          nextGroup.added.length   = 0;
        }
#endif
        for (var i = 0; i < Storage.lastID; i++)
        {
          var storage = Storage.All[i];
          storage.Dispose(storage.toDispose);
          storage.toDispose.length = 0;
        }
      }
    }
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  struct EntityOperation
  {
    public ent entity;
    public int arg;
    public ProcessorEcs.Action action;
  }
}