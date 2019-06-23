using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	readonly struct EntityOperation
	{
		public readonly ent entity;
		public readonly int arg;
		public readonly EntityOperations.Action action;

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
			KillFinalize,
			Empty,
			Activate,
			Deactivate,
			Unbind,
		}

		public static EntityOperation[] operations = new EntityOperation[SettingsEngine.SizeEntities];
		public static int len;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Set(in ent entity, int arg, Action action)
		{
			if (len >= operations.Length)
			{
				var l = len << 1;
				Array.Resize(ref operations, l);
			}

			var     pointer   = len++;
			ref var operation = ref operations[pointer];
			operation = new EntityOperation(entity, arg, action);
		}
	}
}