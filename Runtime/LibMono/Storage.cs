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
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public abstract class Storage
  {
    internal static Dictionary<int, int> typeNames = new Dictionary<int, int>(FastComparable.Default);
    internal static int lastID;
    internal static int[] Masks = new int[32];
    internal static int[] Generations = new int[32];
    internal static Storage[] All = new Storage[32];

    internal CacheGroup groups = new CacheGroup();

    internal indexes toDispose = new indexes(Kernel.Settings.SizeEntities);

    internal abstract Type GetComponentType();

    internal static void DisposeSelf()
    {
      //GroupInt

      for (int i = 0; i < lastID; i++)
      {
        All[i].Dispose(All[i].toDispose);
        All[i].toDispose.length = 0;
        //All[i].groups.length = 0;
      }
    }

    public virtual void Dispose(indexes disposed)
    {
    }
  }


  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class Storage<T> : Storage
  {
    public static Storage<T> Instance;
    public static int componentId;
    internal static int ComponentMask;
    internal static int Generation;

    public static T[] components = new T[Kernel.Settings.SizeEntities];
    internal int componentsLen = 0;


    public Storage()
    {
      Instance = this;

      if (lastID == All.Length)
      {
        var l = lastID << 1;
        Array.Resize(ref All, l);
        Array.Resize(ref Masks, l);
        Array.Resize(ref Generations, l);
      }

      componentId = lastID++;
      All[componentId] = this;

      Masks[componentId] = ComponentMask = 1 << (componentId % 32);
      Generations[componentId] = Generation = componentId / 32;

      // add componentID by type for exclude injection
      typeNames.Add(typeof(T).GetHashCode(), componentId);
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T Get(int entityID)
    {
      if (entityID >= components.Length)
        Array.Resize(ref components, entityID << 1);


#if !ACTORS_COMPONENTS_STRUCTS
      ref var val = ref components[entityID];
      if (val == null)
        val = Instance.Create();
#endif

      return ref components[entityID];
    }


#if !ACTORS_COMPONENTS_STRUCTS
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T TryGet(int entityID)
    {
      return (EntityImplOld.GenerationsInstant[entityID, Generation] & ComponentMask) == ComponentMask ? components[entityID] : default;
    }
#endif
  }
}