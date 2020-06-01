using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pixeye.Actors
{
  internal partial class ProcessorEcs
  {
    public enum Action : byte
    {
      Add = 0,
      ChangeTag,
      Remove,
      Kill,
      Empty,
      Activate
    }

    public static int len;

    internal static EntityOperation[] operations = new EntityOperation[Kernel.Settings.SizeEntities];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void Set(in ent entity, int arg, ProcessorEcs.Action action)
    {
      if (len == operations.Length)
        Array.Resize(ref operations, len << 1);

      ref var operation = ref operations[len++];
      operation.entity = entity;
      operation.arg    = arg;
      operation.action = action;
    }
  }

  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  struct EntityOperation
  {
    public ent entity;
    public int arg;
    public ProcessorEcs.Action action;

    public EntityOperation(in ent entity, int arg, ProcessorEcs.Action action)
    {
      this.entity = entity;
      this.arg    = arg;
      this.action = action;
    }
  }
}