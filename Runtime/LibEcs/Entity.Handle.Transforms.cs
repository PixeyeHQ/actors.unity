 
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static partial class Entity
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform transform(this in ent entity, int index)
		{
			return transforms[entity].GetChild(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform transform(this in ent entity, int index1, int index2)
		{
			return transforms[entity].GetChild(index1).GetChild(index2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform transform(this in ent entity, int index1, int index2, int index3)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform transform(this in ent entity, int index1, int index2, int index3, int index4)
		{
			return transforms[entity].GetChild(index1).GetChild(index2).GetChild(index3).GetChild(index4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform transform(this in ent entity, int[] siblings)
		{
			var transform = transforms[entity];
			foreach (var sibling in siblings)
			{
				transform = transform.GetChild(sibling);
			}

			return transform;
		}
	}
}