using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  internal unsafe partial class ProcessorEcs
  {
    public enum Action : byte
    {
      Add = 0,
      ChangeTag,
      Remove,
      Kill,
      Empty,
      Activate
    }

    internal int operationsLength;
    internal EntityOperation[] operations = new EntityOperation[Kernel.Settings.SizeEntities];

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void SetOld(in ent entity, int arg, Action action)
    {
    }

    static readonly GroupCore[] groupsCheckedOld = new GroupCore[Kernel.Settings.SizeGroups];
    static int groupsCheckedLenOld;

    static bool AlreadyCheckedOld(GroupCore group)
    {
      for (var i = 0; i < groupsCheckedLenOld; i++)
        if (groupsCheckedOld[i].id == group.id)
          return true;

      return false;
    }

    [Conditional("ACTORS_DEBUG")]
    void DebugAlreadyHave(in EntityOperation operation, int generation, int mask, Storage storage)
    {
      ref var managed = ref EntitiesManaged[operation.entity.id];
      if ((managed.generations[generation] & mask) == mask)
      {
        Debug.Log($"{operation.entity.transform}");
        Kernel.Debugger.Log(LogType.ALREADY_HAVE, operation.entity.id, storage.GetComponentType().Name);
      }
    }

    public void Execute()
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
            operation.entity.RenameGameobject();
            for (int j = 0; j < eMeta->componentsAmount; j++)
            {
              var componentID = eMeta->signature[j];
              var storage     = Storage.All[componentID];
              var generation  = Storage.Generations[componentID];
              var mask        = Storage.Masks[componentID];

              DebugAlreadyHave(operation, generation, mask, storage);

              eManaged.generations[generation] |= mask;


              for (var l = 0; l < storage.groups.length; l++)
              {
                var group = storage.groups.Elements[l];
                if (group.composition.included.IsSubsetOf(ref eManaged)
                    && !group.composition.excluded.Overlaps(ref eManaged)
                    && group.composition.includedTags.IsSubsetOf(eMeta)
                    && !group.composition.excludedTags.Overlaps(eMeta))
                  group.Insert(operation.entity);
              }

              eMeta->isDirty = false;
            }
          }
            break;
          case Action.Add:
          {
            var componentID = operation.arg;
            var storage     = Storage.All[componentID];
            var generation  = Storage.Generations[componentID];
            var mask        = Storage.Masks[componentID];

            eManaged.generations[generation] |= mask;

            for (var l = 0; l < storage.groups.length; l++)
            {
              var group = storage.groups.Elements[l];

              if (group.composition.included.IsSubsetOf(ref eManaged)
                  && !group.composition.excluded.Overlaps(ref eManaged)
                  && group.composition.includedTags.IsSubsetOf(eMeta)
                  && !group.composition.excludedTags.Overlaps(eMeta))
                group.Insert(operation.entity);
              else group.TryRemove(entityID);
              //     && group.composition.tags.IsSubsetOf(eMeta)
              //     && !group.composition.tagsExclude.Overlaps(eMeta))
              //   group.Insert(operation.entity);
              // else group.TryRemove(entityID);
            }

            operation.entity.RenameGameobject();
          }
            break;
        }
      }

      operationsLength = 0;

      // public void Execute()
      //     {
      //       if (!Kernel.Instance) return;
      //
      //       for (var r = 0; r < 2; r++)
      //       {
      //         for (var i = 0; i < ProcessorEcs.len; i++)
      //         {
      //           ref var operation = ref ProcessorEcs.operations[i];
      //           var     entityID  = operation.entity.id;
      //
      //
      //           switch (operation.action)
      //           {
      //             case ProcessorEcs.Action.Add:
      //             {
      //               var componentID = operation.arg;
      //               var generation  = Storage.Generations[componentID];
      //               var mask        = Storage.Masks[componentID];
      //               var storage     = Storage.All[componentID];
      //
      //               EntityImplOld.Generations[entityID, generation] |= mask;
      //
      //               for (var l = 0; l < storage.groups.length; l++)
      //               {
      //                 var group = storage.groups.Elements[l];
      //                 if (!group.Composition.Check(entityID))
      //                   group.TryRemove(entityID);
      //                 else group.Insert(operation.entity);
      //               }
      //
      // #if ACTORS_DEBUG
      //               EntityImplOld.RenameGameobject(operation.entity);
      // #endif
      //             }
      //               break;
      //
      //
      //             case ProcessorEcs.Action.Kill:
      //             {
      //               ref var entityCache = ref entities[entityID];
      //
      //
      //               groupsCheckedLen = 0;
      //               for (var j = 0; j < entityCache.componentsAmount; j++)
      //               {
      //                 var componentID = entityCache.componentsIds[j];
      //                 var generation  = Storage.Generations[componentID];
      //                 var mask        = Storage.Masks[componentID];
      //
      //                 EntityImplOld.Generations[entityID, generation] &= ~mask;
      //                 Storage.All[entityCache.componentsIds[j]].toDispose.Add(entityID);
      //
      //                 var storage = Storage.All[componentID];
      //
      //
      //                 for (var l = 0; l < storage.groups.length; l++)
      //                 {
      //                   var group = storage.groups.Elements[l];
      //
      //                   if (!AlreadyChecked(group))
      //                   {
      //                     if (group.Composition.OverlapComponents(entityCache))
      //                     {
      //                       group.TryRemove(entityID);
      //
      //                       groupsChecked[groupsCheckedLen++] = group;
      //                     }
      //                   }
      //                 }
      //               }
      //
      //               groupsCheckedLen             = 0;
      //               entityCache.componentsAmount = 0;
      //
      //               if (!EntityImplOld.entities[entityID].isNested && EntityImplOld.Transforms.Length > entityID &&
      //                   EntityImplOld.Transforms[entityID] != null)
      //               {
      //                 EntityImplOld.Transforms[entityID].gameObject
      //                   .Release(EntityImplOld.entities[entityID].isPooled ? Pool.Entities : 0);
      //                 EntityImplOld.Transforms[entityID] = null;
      //               }
      // #if !ACTORS_TAGS_0
      //               EntityImplOld.Tags[entityID].Clear();
      // #endif
      //
      //
      //               if (ent.entStack.length >= ent.entStack.source.Length)
      //                 Array.Resize(ref ent.entStack.source, ent.entStack.length << 1);
      //
      //               EntityImplOld.alive.Remove(operation.entity);
      //
      //               unchecked
      //               {
      //                 operation.entity.age                 += 1;
      //                 EntityImplOld.entities[entityID].age += 1;
      //               }
      //
      //               ent.entStack.source[ent.entStack.length++] = operation.entity;
      //
      //               break;
      //             }
      //
      //             case ProcessorEcs.Action.Remove:
      //             {
      //               // important check
      //               if (!EntityImplOld.entities[entityID].isAlive) continue;
      //
      //               var generation = Storage.Generations[operation.arg];
      //               var mask       = Storage.Masks[operation.arg];
      //               var storage    = Storage.All[operation.arg];
      //
      //
      // #if UNITY_EDITOR
      //               if (EntityImplOld.entities[entityID].componentsAmount == 0)
      //               {
      //                 Kernel.Debugger.Log(LogType.REMOVE_NON_EXISTANT, entityID, storage.GetComponentType().Name);
      //                 continue;
      //               }
      // #endif
      //
      //
      //               EntityImplOld.Generations[entityID, generation] &= ~mask;
      //
      //               ref var components = ref EntityImplOld.entities[entityID];
      //
      //
      //               //===============================//
      //               // Remove Component
      //               //===============================//
      //               var typeConverted = (ushort) operation.arg;
      //
      //               for (var tRemoveIndex = 0; tRemoveIndex < components.componentsAmount; tRemoveIndex++)
      //               {
      //                 if (components.componentsIds[tRemoveIndex] == typeConverted)
      //                 {
      //                   Storage.All[typeConverted].toDispose.Add(entityID);
      //
      //                   for (var j = tRemoveIndex; j < components.componentsAmount - 1; ++j)
      //                     components.componentsIds[j] = components.componentsIds[j + 1];
      //
      //                   components.componentsAmount--;
      //
      //                   break;
      //                 }
      //               }
      //
      // #if ACTORS_DEBUG
      //               EntityImplOld.RenameGameobject(operation.entity);
      // #endif
      //
      //
      //               for (var l = 0; l < storage.groups.length; l++)
      //               {
      //                 var group = storage.groups.Elements[l];
      //
      //                 if (!group.Composition.Check(entityID))
      //                 {
      //                   group.TryRemove(entityID);
      //                 }
      //                 else
      //                 {
      //                   var inGroup = group.length == 0
      //                     ? -1
      //                     : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length - 1);
      //                   if (inGroup == -1)
      //                     group.Insert(operation.entity);
      //                 }
      //               }
      //
      //
      //               if (components.componentsAmount == 0)
      //               {
      //                 ProcessorEcs.Set(operation.entity, 0, ProcessorEcs.Action.Empty);
      //               }
      //
      //               break;
      //             }
      //
      //             case ProcessorEcs.Action.Empty:
      //             {
      //               //if (operation.entity.exist) continue;
      //
      //               if (!EntityImplOld.entities[entityID].isNested && EntityImplOld.Transforms.Length > entityID &&
      //                   EntityImplOld.Transforms[entityID] != null)
      //               {
      //                 EntityImplOld.Transforms[entityID].gameObject
      //                   .Release(EntityImplOld.entities[entityID].isPooled ? Pool.Entities : 0);
      //                 EntityImplOld.Transforms[entityID] = null;
      //               }
      // #if !ACTORS_TAGS_0
      //               EntityImplOld.Tags[entityID].Clear();
      // #endif
      //
      //               //Entity.Count--;
      //
      //               EntityImplOld.alive.Remove(operation.entity);
      //
      //               if (ent.entStack.length >= ent.entStack.source.Length)
      //                 Array.Resize(ref ent.entStack.source, ent.entStack.length << 1);
      //
      //
      //               unchecked
      //               {
      //                 operation.entity.age                 += 1;
      //                 EntityImplOld.entities[entityID].age += 1;
      //               }
      //
      //               ent.entStack.source[ent.entStack.length++] = operation.entity;
      //               EntityImplOld.entities[entityID].isAlive   = false;
      //               break;
      //             }
      //
      //             case ProcessorEcs.Action.ChangeTag:
      //             {
      //               // check if dead 
      //               if (EntityImplOld.entities[entityID].componentsAmount == 0) continue;
      //               if (!EntityImplOld.entities[entityID].isAlive) continue;
      //
      //               var groups = Actors.groups.ByTag.cache[operation.arg];
      //
      //               for (var l = 0; l < groups.length; l++)
      //               {
      //                 var group      = groups.Elements[l];
      //                 var canBeAdded = group.Composition.Check(entityID);
      //                 var inGroup = group.length == 0
      //                   ? -1
      //                   : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length - 1);
      //
      //                 if (inGroup == -1)
      //                 {
      //                   if (!canBeAdded) continue;
      //                   group.Insert(operation.entity);
      //                 }
      //                 else if (!canBeAdded)
      //                 {
      //                   group.Remove(inGroup);
      //                 }
      //               }
      //
      //               break;
      //             }
      //
      //             case ProcessorEcs.Action.Activate:
      //             {
      //               ref var entityCache = ref EntityImplOld.entities[entityID];
      //
      //               for (var j = 0; j < entityCache.componentsAmount; j++)
      //               {
      //                 var componentID = entityCache.componentsIds[j];
      //                 var storage     = Storage.All[componentID];
      //                 var generation  = Storage.Generations[componentID];
      //                 var mask        = Storage.Masks[componentID];
      //
      //
      // #if UNITY_EDITOR
      //                 if ((EntityImplOld.Generations[entityID, generation] & mask) == mask)
      //                 {
      //                   Debug.Log($"{operation.entity.transform}");
      //                   Kernel.Debugger.Log(LogType.ALREADY_HAVE, entityID, storage.GetComponentType().Name);
      //                   continue;
      //                 }
      // #endif
      //
      //
      //                 EntityImplOld.Generations[entityID, Storage.Generations[componentID]] |= Storage.Masks[componentID];
      //
      //
      // #if ACTORS_DEBUG
      //                 EntityImplOld.RenameGameobject(operation.entity);
      // #endif
      //
      //                 for (var l = 0; l < storage.groups.length; l++)
      //                 {
      //                   var group = storage.groups.Elements[l];
      //                   if (!group.Composition.Check(entityID)) continue;
      //                   group.Insert(operation.entity);
      //                 }
      //
      //                 EntityImplOld.entities[entityID].isDirty = false;
      //               }
      //
      //               break;
      //             }
      //           }
      //         }
      //
      //         if (ProcessorEcs.len > 0)
      //         {
      //           ProcessorEcs.len = 0;
      //
      //           for (var i = 0; i < Kernel.Processors.length; i++)
      //             Kernel.Processors.storage[i].HandleEvents();
      //
      // #if ACTORS_EVENTS_MANUAL
      //           for (var ii = 0; ii < groups.All.length; ii++)
      //           {
      //             var nextGroup = groups.All.Elements[ii];
      //
      //             if (nextGroup.hasEventRemove)
      //               nextGroup.removed.length = 0;
      //
      //
      //             if (nextGroup.hasEventAdd)
      //               nextGroup.added.length = 0;
      //           }
      // #else
      //           for (int ii = 0; ii < groups.All.length; ii++)
      //           {
      //             var nextGroup = groups.All.Elements[ii];
      //             nextGroup.removed.length = 0;
      //             nextGroup.added.length   = 0;
      //           }
      //
      // #endif
      //
      //
      //           for (var i = 0; i < Storage.lastID; i++)
      //           {
      //             var st = Storage.All[i];
      //             st.Dispose(st.toDispose);
      //             st.toDispose.length = 0;
      //           }
      //         }
      //       }
      //     }
    }
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  struct EntityOperation
  {
    public ent entity;
    public int arg;
    public ProcessorEcs.Action action;

    public EntityOperation(in ent entity, int arg, ProcessorEcs.Action action)
    {
      this.entity = entity;
      this.arg    = arg;
      this.action = action;
    }
  }
}