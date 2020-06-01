using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
  public class EntityImpl
  {
    public LayerCore layer;

    public EntityImpl(LayerCore layer)
    {
      this.layer = layer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ent Create()
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
      else id = ent.lastID++;

      ent entity;
      entity.id  = id;
      entity.age = age;
      EntityImplOld.Initialize(id, age);
      EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
      return entity;
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // internal static void Create(int layerIndex, out ent entity)
    // {
    //   int  id;
    //   byte age = 0;
    //
    //   if (ent.entStack.length > 0)
    //   {
    //     ref var pop = ref ent.entStack.source[--ent.entStack.length];
    //     id = pop.id;
    //     unchecked
    //     {
    //       age = pop.age;
    //     }
    //   }
    //   else
    //     id = ent.lastID++;
    //
    //   entity.id  = id;
    //   entity.age = age;
    //   Initialize(id, age);
    //   EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
    //   // Starter.Starters[layerIndex].entities.Add(entity);
    // }
  }
}