//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
	[Serializable]
	public class ents : IEnumerable
	{
		public ent[] source;
		public int length;

		public ref ent this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref source[index];
		}


		public ents(int cap = 0)
		{
			source = new ent[cap > 0 ? cap : 5];
			length = 0;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public bool Has(in ent entity)
		{
			for (var i = 0; i < length; i++)
			{
				ref var val = ref source[i];
				if (entity.id == val.id && entity.age == val.age)
					return true;
			}

			return false;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void Add(in ent entity)
		{
			if (length >= source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = entity;
		}


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public bool Remove(in ent entity)
		{
			var index = -1;

			for (var i = 0; i < length; i++)
			{
				ref var val = ref source[i];
				if (entity.id == val.id && entity.age == val.age)
				{
					index = i;
					break;
				}
			}

			var removed = index > -1;
			if (removed && index < --length)
				Array.Copy(source, index + 1, source, index, length - index);
			return removed;
		}


		#region ENUMERATOR

		public Enumerator GetEnumerator()
		{
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		public struct Enumerator : IEnumerator<ent>
		{
			ents g;
			int position;


			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(ents g)
			{
				position = g.length;
				this.g   = g;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return --position >= 0;
			 
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
				position = g.length;
			}

			object IEnumerator.Current => Current;

			public ent Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get { return g.source[position]; }
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
				 
				g = null;
			}
		}

		#endregion
	}

	[Serializable]
	public class indexes : IEnumerable
	{
		public int[] source;
		public int length;

		public int this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => source[index];
		}


		public indexes(int cap = 0)
		{
			source = new int[cap > 0 ? cap : 5];
			length = 0;
		}


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void Add(int id)
		{
			if (length >= source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = id;
		}

		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public void Add(params int[] ids)
		{
			foreach (var id in ids)
			{
				if (length >= source.Length)
					Array.Resize(ref source, length << 1);

				source[length++] = id;
			}
			 
		}
		


		[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks, false)]
		public bool Remove(int id)
		{
			var index = -1;
			for (var i = 0; i < length; i++)
			{
				if (id == source[i])
				{
					index = i;
					break;
				}
			}

			var removed = index > -1;
			if (removed && index < --length)
				Array.Copy(source, index + 1, source, index, length - index);
			return removed;
		}


		#region ENUMERATOR

		public Enumerator GetEnumerator()
		{
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		public struct Enumerator : IEnumerator<int>
		{
			indexes g;
			int position;


			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(indexes g)
			{
				position = g.length;
				this.g   = g;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return --position >= 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
				position = g.length;
			}

			object IEnumerator.Current => Current;

			public int Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get { return g.source[position]; }
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
				g = null;
			}
		}

		#endregion
	}
}