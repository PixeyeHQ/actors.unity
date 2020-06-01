using System;
using System.Runtime.InteropServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct EntityMeta
  {
    const int size = sizeof(ushort);

    public byte groupsLength;
    public byte componentsLength;
    public byte componentsAmount;
    public byte groupsAmount;
    public byte age;
    public bool isPooled;
    public bool isNested;
    public bool isDirty; //dirty allows to set all components for a new entity in one init command
    public bool isAlive;
    public ent parent;
    public CacheTags tags;
    public ushort* signature;
    public ushort* signatureGroups;

    public void Initialize()
    {
      componentsLength = 6;
      groupsLength     = 6;

      signature       = (ushort*) Marshal.AllocHGlobal(componentsLength * sizeof(ushort));
      signatureGroups = (ushort*) Marshal.AllocHGlobal(groupsLength * sizeof(ushort));

      groupsAmount     = 0;
      componentsAmount = 0;
    }

    public void AddComponent(int type)
    {
      if (componentsLength == componentsAmount)
      {
        componentsLength = (byte) (componentsAmount << 1); // not safe
        signature = (ushort*) Marshal.ReAllocHGlobal((IntPtr) signature, (IntPtr) (componentsLength * sizeof(ushort)));
      }

      signature[componentsAmount++] = (ushort) type;
      
      
      
    }

    public void CleanMask(int id)
    {
      for (int i = componentsAmount - 1; i >= 0; i--)
      {
        var generation = Storage.Generations[signature[i]];
        var mask       = Storage.Masks[signature[i]];
        ProcessorEcs.EntitiesManaged[id].generations[generation] &= ~mask;
      }
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