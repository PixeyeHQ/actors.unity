using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  internal unsafe partial class ProcessorEcs : IRequireActorsLayer, IDisposable
  {
    internal static PoolMem Entities;
    internal static EntityManagedMeta[] EntitiesManaged;


    internal ents entities;
    internal List<Processor> processors = new List<Processor>();

    Layer layer;

    internal static void Bootstrap()
    {
      var length = LayerKernel.Settings.SizeEntities;

      Entities.Alloc(length, UnsafeUtility.SizeOf<EntityMeta>());
      EntitiesManaged = new EntityManagedMeta[length];

      for (var i = 0; i < length; i++)
      {
        Entities.Get<EntityMeta>(i)->Initialize();
        EntitiesManaged[i].Initialize();
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void Create(out ent entity, bool isPooled = false)
    {
      if (ent.Released.length > 0)
      {
        ref var pop = ref ent.Released.source[--ent.Released.length];
        entity.id  = pop.id;
        entity.age = pop.age;
      }
      else
      {
        entity.id  = ent.NextID++;
        entity.age = 0;
      }

      var prevEntitiesLength = Entities.Length;
      if (entity.id >= prevEntitiesLength)
      {
        Entities.Realloc(entity.id + prevEntitiesLength / 5);
        Array.Resize(ref EntitiesManaged, Entities.Length);

        for (var i = prevEntitiesLength; i < Entities.Length; i++)
        {
          Entities.Get<EntityMeta>(i)->Initialize();
          EntitiesManaged[i].Initialize();
        }
      }

      var     ptr     = Entities.Get<EntityMeta>(entity.id);
      ref var managed = ref EntitiesManaged[entity.id];

      managed.layer    = layer;
      managed.isPooled = isPooled;
      // we always need to cleanup transforms as they can be pooled.
      // if the next entity id is not used in pool and will still have
      // a link to the transform it will destroy a transform.
      managed.transform = null;

      ptr->age              = entity.age;
      ptr->isAlive          = true;
      ptr->isDirty          = true;
      ptr->componentsAmount = 0;
      ptr->groupsAmount     = 0;

      entities.Add(entity);
    }

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      this.layer = layer;
      entities   = new ents(LayerKernel.Settings.SizeEntities);
    }


    public void Dispose()
    {
      if (LayerKernel.ApplicationIsQuitting) return;

      operationsLength = 0;
      operations       = null;
      processors.Clear();

      foreach (var entity in entities)
      {
        ref var managed = ref EntitiesManaged[entity.id];
        var     meta    = Entities.Get<EntityMeta>(entity.id);

        meta->tags.length = 0;

        for (var i = 0; i < meta->componentsAmount; i++)
          Storage.All[meta->components[i]].toDispose.Add(entity.id);

        for (var ii = 0; ii < LayerKernel.Settings.SizeGenerations; ii++)
        {
          managed.signature[ii] = 0;
        }

        meta->isAlive          = false;
        meta->componentsAmount = 0;
        meta->groupsAmount     = 0;
        meta->age              = 0;

        ent.Released.Add(new ent(entity.id));
      }

      entities.length = 0;
      entities        = null;

      for (var i = 0; i < Storage.lastID; i++)
      {
        var storage = Storage.All[i];
        storage.Dispose(storage.toDispose);
        storage.toDispose.length = 0;
      }

      for (int i = 0; i < groups.Count; i++)
      {
        groups[i].Dispose();
      }

      bindings.Clear();
      groups.Clear();
    }
  }
}