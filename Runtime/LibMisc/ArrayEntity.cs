//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Serializable]
	public struct ArrayEntity
	{
		public int length;
		public ent[] source;
 
		public ref ent this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref source[index];
		}

		public ArrayEntity(int size)
		{
			source = new ent[size];
			length = 0;
		}
		
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(in ent entity)
		{
			if (length >= source.Length)
			{
				Array.Resize(ref source, length << 1);
			}
			source[length++] = entity;
		}
		
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Remove(in ent entity)
		{
			var i = 0;
			for (; i < length; i++)
			{
				ref var val = ref source[i];
				if (entity.id == val.id && entity.age == val.age)
				{
					val.id = -1;
					break;
				}
			}
			
			Array.Copy(source, i + 1, source, i, length-- - i);
			
		}
		
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Removed(in ent entity)
		{

			var i = 0;
			for (; i < length; i++)
			{
				ref var val = ref source[i];
				if (entity.id == val.id && entity.age == val.age)
				{
					val.id = -1;
					break;
				}
			}

			if (i != length)
			{
				Array.Copy(source, i + 1, source, i, length-- - i);
				return true;
			}
			else return false;
 
		}
	}
}