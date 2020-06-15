/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Actors
{
 
  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public abstract class Storage
  {
    internal static Dictionary<int, int> TypeNames = new Dictionary<int, int>(FastComparable.Default);
    internal static int lastID;
    internal static int[] Masks = new int[32];
    internal static int[] Generations = new int[32];
    internal static Storage[] All = new Storage[32];

    internal CacheGroup[] groups = new CacheGroup[LayerKernel.LAYERS_AMOUNT_TOTAL];

    internal indexes toDispose = new indexes(LayerKernel.Settings.SizeEntities);

    internal abstract Type GetComponentType();

    public abstract void Dispose(indexes disposed);
  }


  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public abstract class Storage<T> : Storage
  {
    public static Storage<T> Instance;
    public static int componentId;
    internal static int ComponentMask;
    internal static int Generation;

    public static T[] components = new T[LayerKernel.Settings.SizeEntities / 2];
    internal int componentsLen = 0;


    public Storage()
    {
      Instance = this;

      for (var i = 0; i < groups.Length; i++)
      {
        groups[i] = new CacheGroup();
      }

      if (lastID == All.Length)
      {
        var l = lastID << 1;
        Array.Resize(ref All, l);
        Array.Resize(ref Masks, l);
        Array.Resize(ref Generations, l);
      }

      componentId      = lastID++;
      All[componentId] = this;

      Masks[componentId]       = ComponentMask = 1 << (componentId % 32);
      Generations[componentId] = Generation    = componentId / 32;

      TypeNames.Add(typeof(T).GetHashCode(), componentId);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public virtual T Create()
    {
      return Activator.CreateInstance<T>();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal override Type GetComponentType()
    {
      return typeof(T);
    }


#if !ACTORS_COMPONENTS_STRUCTS
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T TryGet(int entityID)
    {
      return (ProcessorEcs.EntitiesManaged[entityID].signature[Generation] & ComponentMask) == ComponentMask
        ? components[entityID]
        : default;
    }
#endif
  }
}