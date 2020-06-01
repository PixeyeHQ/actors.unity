using System.Runtime.InteropServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential)]
  public struct EntityMeta
  {
    const int size = sizeof(ushort);

    public byte componentsAmount;
    public byte groupsAmount;
    public byte age;
    public bool isPooled;
    public bool isNested;
    public bool isDirty; //dirty allows to set all components for a new entity in one init command
    public bool isAlive;
    public ent parent;
    public CacheTags tags;
    public PoolMem signature;
    public PoolMem signatureGroups;

    public void Initialize()
    {
      signature.Alloc(6, size);
      signatureGroups.Alloc(6, size);
      groupsAmount     = 0;
      componentsAmount = 0;
    }
  }

  public struct EntityManagedMeta
  {
    internal Transform transform;
    internal int[] generations;
    internal int[] generationsInstant;
    internal ents childs;

    public void Initialize()
    {
      childs             = new ents();
      generations        = new int[Kernel.Settings.SizeGenerations];
      generationsInstant = new int[Kernel.Settings.SizeGenerations];
    }
  }
}