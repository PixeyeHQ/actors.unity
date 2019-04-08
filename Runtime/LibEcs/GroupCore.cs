//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	internal delegate void CallBackDelete(int i);

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public abstract class GroupCore : IEnumerable, IEquatable<GroupCore>, IDisposable
	{

		public int length;

		public CallBackEntity onAdd;
		public CallBackEntity onRemove;

		/// don't use for iterating.
		public ref ent this[int index] => ref entities[index];

		internal ent[] entities = new ent[SettingsEngine.SizeEntities];
		internal Composition composition;

		private static int idCounter;

		private int id;
		private int indexLast;

		internal void Insert(in ent entity)
		{
			var entityID = entity.id;

			indexLast = length++;

			if (length >= entities.Length)
			{
				var l = length << 1;
				Array.Resize(ref entities, l);
			}

			var pointer = indexLast;

			var index = indexLast - 1;

			if (index > 0)
				if (entityID < entities[index].id)
				{
					var startIndex = 0;
					var endIndex = indexLast;

					while (endIndex > startIndex)
					{
						var area = endIndex - startIndex;
						var middleIndex = startIndex + area / 2;
						var middleValue = entities[middleIndex];

						if (middleValue.id == entityID)
						{
							pointer = middleIndex;
							break;
						}

						if (middleValue.id < entityID)
						{
							startIndex = middleIndex + 1;
							pointer = startIndex;
						}
						else
						{
							endIndex = middleIndex;
						}
					}
				}

			for (int i = indexLast; i >= pointer; i--)
				entities[i + 1] = entities[i];

			entities[pointer] = entity;

			if (onAdd != null) onAdd(entity);
		}

		internal void TryRemove(int entityID)
		{
			var i = HelperArray.BinarySearch(ref entities, entityID, 0, length);

			if (i == -1) return;

			if (onRemove != null)
				onRemove(entities[i]);

			var l = length--;
			indexLast--;
			var next = i + 1;
			var size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}

		internal void Remove(int i)
		{
			if (onRemove != null)
				onRemove(entities[i]);

			var l = length--;
			indexLast--;
			var next = i + 1;
			var size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetIndex(int id)
		{
			for (int i = 0; i <= length; i++)
			{
				if (entities[i].id == id) return i;
			}

			return -1;
		}

		public GroupCore()
		{
			id = idCounter++;
		}

		public abstract void Initialize();

		void RemoveAt(int i)
		{
			if (onRemove != null)
				onRemove(entities[i]);

			var l = length--;
			indexLast--;
			var next = i + 1;
			var size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}

		public void Dispose()
		{
			onAdd = null;
			onRemove = null;
			length = 0;
			entities = new ent[SettingsEngine.SizeEntities];
		}

		#region EQUALS

		public bool Equals(GroupCore other)
		{
			return id == other.id;
		}

		public bool Equals(int other)
		{
			return id == other;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((GroupCore) obj);
		}
		public override int GetHashCode()
		{
			return id;
		}

		#endregion

		#region ENUMERATOR

		public Enumerator GetEnumerator()
		{
			return new Enumerator(entities, length);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public struct Enumerator : IEnumerator
		{

			private ent[] entities;
			private int position;
			private int length;

			internal Enumerator(ent[] entities, int length)
			{
				position = -1;
				this.entities = entities;
				this.length = length;
			}

			public bool MoveNext()
			{
				position++;
				return position < length;
			}

			public void Reset()
			{
				position = -1;
			}

			object IEnumerator.Current => Current;

			public ent Current => entities[position];

			public void Dispose()
			{
			}

		}

		#endregion

	}

	public sealed class Group<T> : GroupCore where T : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);

			var len = 1;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;
		}

	}

	public sealed class Group<T, Y> : GroupCore where T : class, IComponent, new() where Y : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);

			var len = 2;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
		}

	}

	public sealed class Group<T, Y, U> : GroupCore where T : class, IComponent, new() where Y : class, IComponent, new() where U : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);

			var len = 3;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);

			var len = 4;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I, O> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			var len = 5;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I, O, P> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
			where P : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			Storage<P>.Instance.Add(this);

			var len = 6;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
			where P : class, IComponent, new()
			where A : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			Storage<P>.Instance.Add(this);
			Storage<A>.Instance.Add(this);

			var len = 7;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A, S> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
			where P : class, IComponent, new()
			where A : class, IComponent, new()
			where S : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			Storage<P>.Instance.Add(this);
			Storage<A>.Instance.Add(this);
			Storage<S>.Instance.Add(this);

			var len = 8;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A, S, D> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
			where P : class, IComponent, new()
			where A : class, IComponent, new()
			where S : class, IComponent, new()
			where D : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			Storage<P>.Instance.Add(this);
			Storage<A>.Instance.Add(this);
			Storage<S>.Instance.Add(this);
			Storage<D>.Instance.Add(this);
			var len = 9;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;

			composition.generations[8] = Storage<D>.generation;
			composition.ids[8] = Storage<D>.componentMask;
		}

	}
	public sealed class Group<T, Y, U, I, O, P, A, S, D, F> : GroupCore where T : class, IComponent, new()
			where Y : class, IComponent, new()
			where U : class, IComponent, new()
			where I : class, IComponent, new()
			where O : class, IComponent, new()
			where P : class, IComponent, new()
			where A : class, IComponent, new()
			where S : class, IComponent, new()
			where D : class, IComponent, new()
			where F : class, IComponent, new()
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);
			Storage<O>.Instance.Add(this);
			Storage<P>.Instance.Add(this);
			Storage<A>.Instance.Add(this);
			Storage<S>.Instance.Add(this);
			Storage<D>.Instance.Add(this);
			Storage<F>.Instance.Add(this);
			var len = 10;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;

			composition.generations[8] = Storage<D>.generation;
			composition.ids[8] = Storage<D>.componentMask;

			composition.generations[9] = Storage<F>.generation;
			composition.ids[9] = Storage<F>.componentMask;
		}

	}
}