using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  internal unsafe partial class ProcessorEcs : IRequireActorsLayer, IDisposable
  {
    internal static PoolMem Entities;
    internal static EntityManagedMeta[] EntitiesManaged;

    internal ents entities = new ents();
    internal List<Processor> processors = new List<Processor>();

    LayerCore layer;

    internal static void Bootstrap()
    {
      var length = Kernel.Settings.SizeEntities;

      Entities.Alloc(length, UnsafeUtility.SizeOf<EntityMeta>());
      EntitiesManaged = new EntityManagedMeta[length];

      for (int i = 0; i < length; i++)
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
        entity.id = pop.id;
        unchecked
        {
          entity.age = pop.age;
        }
      }
      else
      {
        entity.id  = ent.NextID++;
        entity.age = 0;
      }

      var prevEntitiesLength = Entities.Length;
      if (entity.id >= prevEntitiesLength)
      {
        Entities.Realloc(entity.id << 1);
        Array.Resize(ref EntitiesManaged, Entities.Length);

        for (int i = prevEntitiesLength; i < Entities.Length; i++)
        {
          Entities.Get<EntityMeta>(i)->Initialize();
          EntitiesManaged[i].Initialize();
        }
      }

      var     ptr     = Entities.Get<EntityMeta>(entity.id);
      ref var managed = ref EntitiesManaged[entity.id];

      managed.layer    = layer;
      managed.isPooled = isPooled;

      ptr->age     = entity.age;
      ptr->isAlive = true;
      ptr->isDirty = true;
    }

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      this.layer = layer;
    }


    public void Dispose()
    {
      if (Kernel.ApplicationIsQuitting) return;

      operationsLength = 0;
      processors.Clear();

      foreach (var entity in entities)
      {
        ref var managed = ref EntitiesManaged[entity.id];
        var     meta    = Entities.Get<EntityMeta>(entity.id);

        meta->tags.length = 0;

        for (var i = 0; i < meta->componentsAmount; i++)
          Storage.All[meta->components[i]].toDispose.Add(entity.id);

        for (var ii = 0; ii < Kernel.Settings.SizeGenerations; ii++)
        {
          managed.signature[ii] = 0;
        }

        meta->isAlive          = false;
        meta->componentsAmount = 0;
        meta->age              = 0;

        ent.Released.Add(new ent(entity.id));
      }

      entities.length = 0;
    }
  }
}