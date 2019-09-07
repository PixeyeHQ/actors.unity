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
				Array.Resize(ref source, length << 1);

			source[length++] = entity;
		}
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Remove(in ent entity)
		{
 
		  for (int i = 0; i < length; i++)
			{
				  var val =   source[i];
 
				if (entity.Equals(val))
				{
			  	source[i] = -1;
					Array.Copy(source, i + 1, source, i,  length-- - i);
		 
					break;
				}
			}
		}
		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Removed(in ent entity)
		{
			for (int i = 0; i < length; i++)
			{
				ref var val = ref source[i];
				if (entity.Equals(val))
				{
				 	source[i] = -1;
					Array.Copy(source, i + 1, source, i, length-- - i);
					return true;
				}
			}

			return false;
		}
	}
}