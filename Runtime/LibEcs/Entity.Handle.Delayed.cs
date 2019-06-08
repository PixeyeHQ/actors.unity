using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static partial class Entity
	{
		public static class Delayed
		{
			public enum Action : byte
			{
				Add,
				ChangeTag,
				Remove,
				Kill,
				KillFinalize,
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

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static void Set(in ent entity, Action action)
			{
				if (len >= operations.Length)
				{
					var l = len << 1;
					Array.Resize(ref operations, l);
				}

				var     pointer   = len++;
				ref var operation = ref operations[pointer];
				operation = new EntityOperation(entity, 0, action);
			}
		}
	}
}