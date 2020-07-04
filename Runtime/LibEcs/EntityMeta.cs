using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;


namespace Pixeye.Actors
{
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct EntityMeta
  {
    const int size = sizeof(ushort);

    public byte componentsLength;
    public byte componentsAmount;
    public byte groupsLength;
    public byte groupsAmount;
    
    public bool isDirty; //dirty allows to set all components for a new entity in one init command
    public bool isAlive;
    
    public EcsTags tags;

    public int age;
    
    public ushort* components;
    public ushort* groups;


    public void Initialize()
    {
      componentsLength = 6;
      groupsLength     = 6;

      components = (ushort*) Marshal.AllocHGlobal(componentsLength * size);
      groups     = (ushort*) Marshal.AllocHGlobal(groupsLength * size);

      componentsAmount = 0;
      groupsAmount     = 0;

      tags = new EcsTags();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AddComponent(int type)
    {
      if (componentsLength == componentsAmount)
      {
        componentsLength = (byte) (componentsAmount << 1); // not safe
        components =
          (ushort*) Marshal.ReAllocHGlobal((IntPtr) components, (IntPtr) (componentsLength * sizeof(ushort)));
      }

      components[componentsAmount++] = (ushort) type;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void RemoveComponent(int type, int entityID)
    {
      for (var tRemoveIndex = 0; tRemoveIndex <= componentsAmount; tRemoveIndex++)
      {
        if (components[tRemoveIndex] == type)
        {
          Storage.All[type].toDispose.Add(entityID);
          for (var j = tRemoveIndex; j < componentsAmount; ++j)
            components[j] = components[j + 1];
          componentsAmount--;
          break;
        }
      }
    }

    public void AddGroup(int type)
    {
      if (groupsLength == groupsAmount)
      {
        groupsLength = (byte) (groupsAmount << 1); // not safe
        groups =
          (ushort*) Marshal.ReAllocHGlobal((IntPtr) groups, (IntPtr) (groupsLength * sizeof(ushort)));
      }

      groups[groupsAmount++] = (ushort) type;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void RemoveGroup(int type)
    {
      for (var tRemoveIndex = 0; tRemoveIndex <= groupsAmount; tRemoveIndex++)
      {
        if (groups[tRemoveIndex] == type)
        {
          for (var j = tRemoveIndex; j < groupsAmount; ++j)
            groups[j] = groups[j + 1];
          groupsAmount--; 
          break;
        }
      }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool AlreadyInGroup(int groupID)
    {
      for (var gIndex = 0; gIndex < groupsAmount; gIndex++)
      {
        if (groups[gIndex] == groupID) return true;
      }

      return false;
    }
    
  }

  public struct EntityManagedMeta
  {
    public bool isPooled;
    internal Layer layer;
    internal Transform transform;
    internal int[] signature;
    internal ents childs;
    public ent parent;

    public void Initialize()
    {
      childs    = new ents();
      signature = new int[LayerKernel.Settings.SizeGenerations];
    }
  }
}