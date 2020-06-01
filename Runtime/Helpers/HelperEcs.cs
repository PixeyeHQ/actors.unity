using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pixeye.Actors
{
  public static unsafe partial class HelperEcs
  {
    static readonly FastString fstr = new FastString(500);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Conditional("ACTORS_DEBUG")]
    public static void RenameGameobject(this ent entity)
    {
      if (!Kernel.Settings.DebugNames) return;
      var tr = ProcessorEcs.EntitiesManaged[entity.id].transform;
      if (tr != null)
      {
        var name             = tr.name;
        var index            = tr.name.LastIndexOf(':');
        if (index > -1) name = tr.name.Remove(0, index + 1);
        var id               = entity.id;

        name = name.Trim();
        fstr.Clear();
        fstr.Append($"{id.ToString().PadLeft(4, '0')}: ");

        fstr.Append("[ ");
        var ptr = ProcessorEcs.Entities.Get<EntityMeta>(entity.id);
        for (var j = 0; j < ptr->componentsAmount; j++)
        {
          var storage = Storage.All[ptr->signature[j]];
          var lex     = j < ptr->componentsAmount - 1 ? " " : "";
          fstr.Append($"{storage.GetComponentType().Name.Remove(0, 9)}{lex}");
        }

        fstr.Append(" ]: ");


        fstr.Append(name);

        tr.name = fstr.ToString();
      }
    }


    internal static bool IsSubsetOf(this int[] mask, EntityManagedMeta managed)
    {
      for (var i = 0; i < mask.Length; i++)
      {
        var componentID = mask[i];
        var generation  = Storage.Generations[componentID];
        if ((managed.generations[generation] & mask[i]) != mask[i])
          return false;
      }

      return true;
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    // internal bool CanProceed(int entityID)
    // {
    //   for (var ll = 0; ll < ids.Length; ll++)
    //     if ((EntityImplOld.Generations[entityID, generations[ll]] & ids[ll]) != ids[ll])
    //       return false;
    //
    //   return true;
    // }
  }
}