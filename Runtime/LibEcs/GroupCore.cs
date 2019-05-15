//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	delegate void CallBackDelete(int i);

	class GroupCoreComparer : IEqualityComparer<GroupCore>
	{

		public static GroupCoreComparer Default = new GroupCoreComparer();

		public bool Equals(GroupCore x, GroupCore y)
		{
			return y.id == x.id;
		}

		public int GetHashCode(GroupCore obj)
		{
			return obj.id;
		}

	}

	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public abstract class GroupCore : IEnumerable, IEquatable<GroupCore>, IDisposable
	{

		static int idCounter;

		public int length;

		public EntityAction onAdd;
		public EntityAction onRemove;

		public ref ent this[int index] => ref entities[index];
		public ent[] entities = new ent[SettingsEngine.SizeEntities];

		int position;

		internal Composition composition;
		internal int id;

		public void Release(int index)
		{
			if (length == 0) return;
			entities[index].Release();
		}

		internal GroupCore Start(Composition composition)
		{
			this.composition = composition;
			composition.SetupExcludeTypes(this);
			HelperTags.Add(this);
			Initialize();
			return this;
		}

		internal void Insert(in ent entity)
		{
			var entityID = entity.id;

			var indexLast = length++;

			if (length >= entities.Length)
				Array.Resize(ref entities, length << 1);

			var pointer = indexLast;
			var index = indexLast - 1;

			if (index >= 0) {
				if (entityID < entities[index].id) {
					var startIndex = 0;
					var endIndex = indexLast;

					while (endIndex > startIndex) {
						var middleIndex = (endIndex + startIndex) / 2;
						var middleValue = entities[middleIndex].id;

						if (middleValue == entityID) {
							pointer = middleIndex;

							break;
						}

						if (middleValue < entityID) {
							startIndex = middleIndex + 1;
							pointer = startIndex;
						}
						else {
							endIndex = middleIndex;
							pointer = endIndex;
						}
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
			if (onRemove != null) onRemove(entities[i]);
		 
			Array.Copy(entities, i + 1, entities, i, length-- - i);
		}

		internal void Remove(int i)
		{
			if (onRemove != null)
				onRemove(entities[i]);

			Array.Copy(entities, i + 1, entities, i, length-- - i);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetIndex(int id)
		{
			for (int i = 0; i < length; i++) {
				if (entities[i].id == id) return i;
			}

			return -1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool next(out ent entity)
		{
			if (length == 0) {
				entity = -1;
				return false;
			}
			if (position == length)
				position = 0;

			entity = entities[position++];
			return true;
		}

		public GroupCore()
		{
			id = idCounter++;
		}

		public abstract void Initialize();

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

		public struct Enumerator : IEnumerator<ent>
		{

			ent[] entities;
			int position;
			int length;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(ent[] entities, int length)
			{
				position = -1;
				this.entities = entities;
				this.length = length;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return ++position < length;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
				position = -1;
			}

			object IEnumerator.Current => Current;

			public ent Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get { return entities[position]; }
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose() { }

		}

		#endregion

	}

	public sealed class Group<T> : GroupCore
	{

		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);

			var len = 1;

			composition.generations = new int[len];
			composition.ids = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0] = Storage<T>.componentMask;

			composition.includeComponents[Storage<T>.componentID] = true;
		}

	}

	public sealed class Group<T, Y> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U, I> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U, I, O> : GroupCore
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

	public sealed class Group<T, Y, U, I, O, P> : GroupCore

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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A, S> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;
		}

	}

	public sealed class Group<T, Y, U, I, O, P, A, S, D> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;

			composition.generations[8] = Storage<D>.generation;
			composition.ids[8] = Storage<D>.componentMask;
			composition.includeComponents[Storage<D>.componentID] = true;
		}

	}
	public sealed class Group<T, Y, U, I, O, P, A, S, D, F> : GroupCore
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
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1] = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2] = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3] = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4] = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5] = Storage<P>.generation;
			composition.ids[5] = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6] = Storage<A>.generation;
			composition.ids[6] = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7] = Storage<S>.generation;
			composition.ids[7] = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;

			composition.generations[8] = Storage<D>.generation;
			composition.ids[8] = Storage<D>.componentMask;
			composition.includeComponents[Storage<D>.componentID] = true;

			composition.generations[9] = Storage<F>.generation;
			composition.ids[9] = Storage<F>.componentMask;
			composition.includeComponents[Storage<F>.componentID] = true;
		}

	}
}