using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  internal unsafe partial class ProcessorEcs : IRequireActorsLayer
  {
    internal static PoolMem Entities;
    internal static EntityManagedMeta[] EntitiesManaged;

    internal List<GroupCore> groups = new List<GroupCore>();
    internal ents entities = new ents();

    //internal static int[,] signature;        //ushort
    //internal static int[,] signature_temp;   //ushort double buffer, need for such methods as has/get and init operation
    //internal static int[,] signature_groups; //ushort what groups are already used

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
      
      //Create(out var entity);
      
    }

    internal void Create(out ent entity, bool isPooled = false, bool isNested = false)
    {
      if (ent.entStack.length > 0)
      {
        ref var pop = ref ent.entStack.source[--ent.entStack.length];
        entity.id = pop.id;
        unchecked
        {
          entity.age = pop.age;
        }
      }
      else
      {
        entity.id  = ent.lastID++;
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

      var ptr = Entities.Get<EntityMeta>(entity.id);
      //ref var managed = ref EntitiesManaged[entity.id];

      ptr->age      = entity.age;
      ptr->isNested = isNested;
      ptr->isPooled = isPooled;
      ptr->isAlive  = true;
      ptr->isDirty  = true;
    }

    internal static void CreateOld(out ent entity, bool isPooled = false, bool isNested = false)
    {
      if (ent.entStack.length > 0)
      {
        ref var pop = ref ent.entStack.source[--ent.entStack.length];
        entity.id = pop.id;
        unchecked
        {
          entity.age = pop.age;
        }
      }
      else
      {
        entity.id  = ent.lastID++;
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

      var ptr = Entities.Get<EntityMeta>(entity.id);
      //ref var managed = ref EntitiesManaged[entity.id];

      ptr->age      = entity.age;
      ptr->isNested = isNested;
      ptr->isPooled = isPooled;
      ptr->isAlive  = true;
      ptr->isDirty  = true;
    }

    public void Launch(LayerCore layer)
    {
    }
  }
}