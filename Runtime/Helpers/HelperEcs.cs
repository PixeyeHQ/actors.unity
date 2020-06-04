using System.Diagnostics;
using System.Runtime.CompilerServices;
using Debug = UnityEngine.Debug;

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
          var storage = Storage.All[ptr->components[j]];
          var lex     = j < ptr->componentsAmount - 1 ? " " : "";
          fstr.Append($"{storage.GetComponentType().Name.Remove(0, 9)}{lex}");
        }

        fstr.Append(" ]: ");


        fstr.Append(name);

        tr.name = fstr.ToString();
      }
    }


    internal static bool IsSubsetOf(this bool[] signature, EntityMeta* meta)
    {
      int match = 0;
      for (int i = 0; i < meta->componentsAmount; i++)
      {
        if (signature[meta->components[i]])
          match++;
      }

      return meta->componentsAmount == match;
    }

    internal static bool IsSubsetOf(this ComponentMask[] signature, ref EntityManagedMeta managed)
    {
      ref var generations = ref managed.signature;

      for (var i = 0; i < signature.Length; i++)
      {
        if ((generations[signature[i].generation] & signature[i].mask) != signature[i].mask)
          return false;
      }

      return true;
    }

    internal static bool Overlaps(this ComponentMask[] signature, ref EntityManagedMeta managed)
    {
      ref var generations = ref managed.signature;
      
      for (var i = 0; i < signature.Length; i++)
      {
        if ((generations[signature[i].generation] & signature[i].mask) == signature[i].mask)
          return true;
      }

      return false;
    }
  }
}