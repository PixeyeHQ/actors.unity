using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
 
namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	struct EntityOperation
	{
		public ent entity;
		public int arg;
		public EntityOperations.Action action;

		public EntityOperation(in ent entity, int arg, EntityOperations.Action action)
		{
			this.entity = entity;
			this.arg    = arg;
			this.action = action;
		}
	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	static class EntityOperations
	{
		public enum Action : byte
		{
			Add,
			ChangeTag,
			Remove,
			Kill,
			Empty,
			Activate,
			Deactivate,
			Unbind,
		}

		internal static EntityOperation[] operationsDelayed = new EntityOperation[Entity.settings.SizeEntities];
		internal static EntityOperation[] operations = new EntityOperation[Entity.settings.SizeEntities];
		internal static int len;
		internal static int lenDelayed;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Set(in ent entity, int arg, Action action)
		{
			if (len == operations.Length)
				Array.Resize(ref operations, len << 1);
 
			ref var operation = ref operations[len++];
			operation.entity = entity;
			operation.arg    = arg;
			operation.action = action;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Delayed(in ent entity, int arg, Action action)
		{
			if (lenDelayed == operationsDelayed.Length)
				Array.Resize(ref operationsDelayed, lenDelayed << 1);
			
			ref var operation = ref operationsDelayed[lenDelayed++];
			operation.entity = entity;
			operation.arg    = arg;
			operation.action = action;
	 
		}

		internal static void SetDelayed()
		{
			for (int i = 0; i < lenDelayed; i++)
			{
				if (len == operations.Length)
					Array.Resize(ref operations, len << 1);

				ref var opDelayed = ref operationsDelayed[i];
				ref var operation = ref operations[len++];
				operation.entity = opDelayed.entity;
				operation.arg    = opDelayed.arg;
				operation.action = opDelayed.action;
			}
			lenDelayed = 0;
		}
	}
}