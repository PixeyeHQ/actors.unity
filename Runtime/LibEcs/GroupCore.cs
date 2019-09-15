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
	class GroupCoreComparer : IEqualityComparer<GroupCore>
	{
		public static GroupCoreComparer Default = new GroupCoreComparer();

		public bool Equals(GroupCore x, GroupCore y)
		{
			return y.id == x.id;
		}

		public int GetHashCode(GroupCore obj)
		{
			return obj.composition.hash;
		}
	}


	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public abstract class GroupCore : GroupEvents, IEnumerable, IEquatable<GroupCore>, IDisposable
	{
		internal static GroupCore[] all = new GroupCore[10];
		internal static int allLen;

		static int idCounter;

		public ent[] entities = new ent[Entity.settings.SizeEntities];
		public int length;


		internal GroupEvents[] onAdd = new GroupEvents[1];
		internal int onAddLen = 0;
		internal GroupEvents[] onRemove = new GroupEvents[1];
		internal int onRemoveLen = 0;


		//public EntityActionArray onAdd;
		//	public EntityActionArray onRemove;


		internal ent[] entitiesToAdd = new ent[Entity.settings.SizeEntities];
		internal ent[] entitiesToRemove = new ent[Entity.settings.SizeEntities];

		internal int entitiesToAddLen;
		internal int entitiesToRemoveLen;


		protected internal Composition composition;

		internal int id;

		int position;


		public ref ent this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref entities[index];
		}

		public void Release(int index)
		{
			if (length == 0) return;
			entities[index].Release();
		}


		internal void SetSelf(Op op, GroupEvents gr)
		{
			if ((op & Op.Add) == Op.Add)
			{
				if (onAdd.Length <= onAddLen)
					Array.Resize(ref onAdd, onAddLen << 1);

				onAdd[onAddLen++] = gr;
			}


			if ((op & Op.Remove) <= Op.Remove)
			{
				if (onRemove.Length == onRemoveLen)
					Array.Resize(ref onRemove, onRemoveLen << 1);


				onRemove[onRemoveLen++] = gr;
			}
		}


		public T Set<T>(Op op, Processor proc = null) where T : GroupEvents, new()
		{
			var evs = new T();
			evs.AddProcessor(proc);

			if ((op & Op.Add) == Op.Add)
			{
				if (onAdd.Length == onAddLen)
					Array.Resize(ref onAdd, onAddLen << 1);

				onAdd[onAddLen++] = evs;
			}

			if ((op & Op.Remove) == Op.Remove)
			{
				if (onRemove.Length == onRemoveLen)
					Array.Resize(ref onRemove, onRemoveLen << 1);

				onRemove[onRemoveLen++] = evs;
			}

			return evs;
		}


		public GroupCore()
		{
			id = idCounter++;

			if (allLen == all.Length)
				Array.Resize(ref all, allLen << 1);

			all[allLen++] = this;
		}


		internal GroupCore Start(Composition composition)
		{
 
			this.composition = composition;
		 
			#if !ACTORS_TAGS_0
			HelperTags.Add(this);
			#endif

			this.composition.SetupExcludeTypes(this);
		
			Initialize();
		
			
		 
			return this;
		}


		//===============================//
		// Insert
		//===============================//
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Insert(in ent entity)
		{
			var left  = 0;
			var index = 0;
			var right = length++;

			if (entity.id >= entities.Length)
			{
				Array.Resize(ref entities, entity.id << 1);
				Array.Resize(ref entitiesToAdd, entity.id << 1);
				Array.Resize(ref entitiesToRemove, entity.id << 1);
			}
			else if (length >= entities.Length)
			{
				Array.Resize(ref entities, length << 1);
				Array.Resize(ref entitiesToAdd, length << 1);
				Array.Resize(ref entitiesToRemove, length << 1);
			}

			var consitionSort = right - 1;
			if (consitionSort > -1 && entity.id < entities[consitionSort].id)
			{
				while (right > left)
				{
					var midIndex = (right + left) / 2;

					if (entities[midIndex].id == entity.id)
					{
						index = midIndex;
						break;
					}

					if (entities[midIndex].id < entity.id)
						left = midIndex + 1;
					else
						right = midIndex;

					index = left;
				}


				Array.Copy(entities, index, entities, index + 1, length - index);
				entities[index] = entity;


				if (onAddLen > 0)
					entitiesToAdd[entitiesToAddLen++] = entity;
			}
			else
			{
				entities[right] = entity;
				if (onAddLen > 0)
					entitiesToAdd[entitiesToAddLen++] = entity;
			}
		}


		//===============================//
		// Try Remove
		//===============================//
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void TryRemove(int entityID)
		{
			if (length == 0) return;
			var i = HelperArray.BinarySearch(ref entities, entityID, 0, length);
			if (i == -1) return;


			if (onRemoveLen > 0)
				entitiesToRemove[entitiesToRemoveLen++] = entities[i];


			Array.Copy(entities, i + 1, entities, i, length-- - i);
		}


		//===============================//
		// Remove
		//===============================//
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Remove(int i)
		{
			//	onRemove(entities[i]);

			// if ((object) onRemove != null)
			// 	entsToRemove.Add(entities[i]);

			if (onRemoveLen > 0)
				entitiesToRemove[entitiesToRemoveLen++] = entities[i];


			Array.Copy(entities, i + 1, entities, i, length-- - i);
		}


		public abstract void Initialize();

		public virtual void Dispose()
		{
			// base
			onAdd    = new GroupEvents[1];
			onRemove = new GroupEvents[1];
			length   = 0;


			onAddLen    = 0;
			onRemoveLen = 0;

			entitiesToAdd    = new ent[Entity.settings.SizeEntities];
			entitiesToRemove = new ent[Entity.settings.SizeEntities];

			entitiesToAddLen    = 0;
			entitiesToRemoveLen = 0;


			//parallel
			if (segmentGroups != null)
				for (int i = 0; i < segmentGroups.Length; i++)
				{
					var d = segmentGroups[i];
					d.thread.Interrupt();
					d.thread.Join(5);
					syncs[i].Close();
					segmentGroups[i] = null;
				}

			segmentGroupLocal = null;
		}

		//===============================//
		// Concurrent
		//===============================//

		SegmentGroup segmentGroupLocal;
		SegmentGroup[] segmentGroups;
		ManualResetEvent[] syncs;


		int threadsAmount = Environment.ProcessorCount - 1;
		int entitiesPerThreadMin = 5000;
		int entitiesPerThread;

		HandleSegmentGroup jobAction;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MakeConcurrent(int minEntities, int threads, HandleSegmentGroup jobAction)
		{
			this.jobAction = jobAction;

			segmentGroupLocal        = new SegmentGroup();
			segmentGroupLocal.source = this;


			segmentGroups = new SegmentGroup[threadsAmount];
			syncs         = new ManualResetEvent[threadsAmount];

			for (int i = 0; i < threadsAmount; i++)
			{
				ref var nextSegment = ref segmentGroups[i];
				nextSegment                     = new SegmentGroup();
				nextSegment.thread              = new Thread(HandleThread);
				nextSegment.thread.IsBackground = true;
				nextSegment.HasWork             = new ManualResetEvent(false);
				nextSegment.WorkDone            = new ManualResetEvent(true);
				nextSegment.source              = this;

				syncs[i] = nextSegment.WorkDone;

				nextSegment.thread.Start(nextSegment);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Execute(float delta)
		{
			if (length > 0)
			{
				var entitiesNext      = 0;
				var threadsInWork     = 0;
				var entitiesPerThread = length / (threadsAmount + 1);
				if (entitiesPerThread > entitiesPerThreadMin)
				{
					threadsInWork = threadsAmount + 1;
				}
				else
				{
					threadsInWork     = length / entitiesPerThreadMin;
					entitiesPerThread = entitiesPerThreadMin;
				}


				for (var i = 0; i < threadsInWork - 1; i++)
				{
					var nextSegmentGroup = segmentGroups[i];
					nextSegmentGroup.delta     = delta;
					nextSegmentGroup.indexFrom = entitiesNext;
					nextSegmentGroup.indexTo   = entitiesNext += entitiesPerThread;

					nextSegmentGroup.WorkDone.Reset();
					nextSegmentGroup.HasWork.Set();
				}

				segmentGroupLocal.indexFrom = entitiesNext;
				segmentGroupLocal.indexTo   = length;
				segmentGroupLocal.delta     = delta;
				jobAction(segmentGroupLocal);

				for (var i = 0; i < syncs.Length; i++)
				{
					syncs[i].WaitOne();
				}
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Execute()
		{
			if (length > 0)
			{
				var entitiesNext      = 0;
				var threadsInWork     = 0;
				var entitiesPerThread = length / (threadsAmount + 1);
				if (entitiesPerThread > entitiesPerThreadMin)
				{
					threadsInWork = threadsAmount + 1;
				}
				else
				{
					threadsInWork     = length / entitiesPerThreadMin;
					entitiesPerThread = entitiesPerThreadMin;
				}


				for (var i = 0; i < threadsInWork - 1; i++)
				{
					var nextSegmentGroup = segmentGroups[i];
					nextSegmentGroup.indexFrom = entitiesNext;
					nextSegmentGroup.indexTo   = entitiesNext += entitiesPerThread;

					nextSegmentGroup.WorkDone.Reset();
					nextSegmentGroup.HasWork.Set();
				}

				segmentGroupLocal.indexFrom = entitiesNext;
				segmentGroupLocal.indexTo   = length;
				jobAction(segmentGroupLocal);

				for (var i = 0; i < syncs.Length; i++)
				{
					syncs[i].WaitOne();
				}
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void HandleThread(object objSegmentGroup)
		{
			var segmentGroup = (SegmentGroup) objSegmentGroup;
			try
			{
				while (Thread.CurrentThread.IsAlive)
				{
					segmentGroup.HasWork.WaitOne();
					segmentGroup.HasWork.Reset();

					jobAction(segmentGroup);
					segmentGroup.WorkDone.Set();
				}
			}
			catch
			{
			}
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
			return obj.GetType() == GetType() && Equals((GroupCore) obj);
		}

		public override int GetHashCode()
		{
			return id;
		}

		#endregion

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
			GroupCore g;
			int position;


			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(GroupCore g)
			{
				position = -1;
				this.g   = g;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				return ++position < g.length;
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
				get { return g.entities[position]; }
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
				g = null;
			}
		}

		#endregion
	}


	public class Group<T> : GroupCore
	{
		public override void Initialize()
		{
	 
			Storage<T>.Instance.Add(this);

			var len = 1;

			composition.generations = new int[len];
			composition.ids         = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0]         = Storage<T>.componentMask;

			composition.includeComponents[Storage<T>.componentID] = true;
		}
	}

	public class Group<T, Y> : GroupCore
	{
		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);

			var len = 2;

			composition.generations = new int[len];
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;
		}
	}

	public class Group<T, Y, U> : GroupCore
	{
		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);

			var len = 3;

			composition.generations = new int[len];
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I> : GroupCore
	{
		public override void Initialize()
		{
			Storage<T>.Instance.Add(this);
			Storage<Y>.Instance.Add(this);
			Storage<U>.Instance.Add(this);
			Storage<I>.Instance.Add(this);

			var len = 4;

			composition.generations = new int[len];
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I, O> : GroupCore
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
			composition.ids         = new int[len];

			composition.generations[0] = Storage<T>.generation;
			composition.ids[0]         = Storage<T>.componentMask;

			composition.generations[1] = Storage<Y>.generation;
			composition.ids[1]         = Storage<Y>.componentMask;

			composition.generations[2] = Storage<U>.generation;
			composition.ids[2]         = Storage<U>.componentMask;

			composition.generations[3] = Storage<I>.generation;
			composition.ids[3]         = Storage<I>.componentMask;

			composition.generations[4] = Storage<O>.generation;
			composition.ids[4]         = Storage<O>.componentMask;
		}
	}

	public class Group<T, Y, U, I, O, P> : GroupCore

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
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4]                            = Storage<O>.generation;
			composition.ids[4]                                    = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5]                            = Storage<P>.generation;
			composition.ids[5]                                    = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I, O, P, A> : GroupCore
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
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4]                            = Storage<O>.generation;
			composition.ids[4]                                    = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5]                            = Storage<P>.generation;
			composition.ids[5]                                    = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6]                            = Storage<A>.generation;
			composition.ids[6]                                    = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I, O, P, A, S> : GroupCore
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
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4]                            = Storage<O>.generation;
			composition.ids[4]                                    = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5]                            = Storage<P>.generation;
			composition.ids[5]                                    = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6]                            = Storage<A>.generation;
			composition.ids[6]                                    = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7]                            = Storage<S>.generation;
			composition.ids[7]                                    = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I, O, P, A, S, D> : GroupCore
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
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4]                            = Storage<O>.generation;
			composition.ids[4]                                    = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5]                            = Storage<P>.generation;
			composition.ids[5]                                    = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6]                            = Storage<A>.generation;
			composition.ids[6]                                    = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7]                            = Storage<S>.generation;
			composition.ids[7]                                    = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;

			composition.generations[8]                            = Storage<D>.generation;
			composition.ids[8]                                    = Storage<D>.componentMask;
			composition.includeComponents[Storage<D>.componentID] = true;
		}
	}

	public class Group<T, Y, U, I, O, P, A, S, D, F> : GroupCore
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
			composition.ids         = new int[len];

			composition.generations[0]                            = Storage<T>.generation;
			composition.ids[0]                                    = Storage<T>.componentMask;
			composition.includeComponents[Storage<T>.componentID] = true;

			composition.generations[1]                            = Storage<Y>.generation;
			composition.ids[1]                                    = Storage<Y>.componentMask;
			composition.includeComponents[Storage<Y>.componentID] = true;

			composition.generations[2]                            = Storage<U>.generation;
			composition.ids[2]                                    = Storage<U>.componentMask;
			composition.includeComponents[Storage<U>.componentID] = true;

			composition.generations[3]                            = Storage<I>.generation;
			composition.ids[3]                                    = Storage<I>.componentMask;
			composition.includeComponents[Storage<I>.componentID] = true;

			composition.generations[4]                            = Storage<O>.generation;
			composition.ids[4]                                    = Storage<O>.componentMask;
			composition.includeComponents[Storage<O>.componentID] = true;

			composition.generations[5]                            = Storage<P>.generation;
			composition.ids[5]                                    = Storage<P>.componentMask;
			composition.includeComponents[Storage<P>.componentID] = true;

			composition.generations[6]                            = Storage<A>.generation;
			composition.ids[6]                                    = Storage<A>.componentMask;
			composition.includeComponents[Storage<A>.componentID] = true;

			composition.generations[7]                            = Storage<S>.generation;
			composition.ids[7]                                    = Storage<S>.componentMask;
			composition.includeComponents[Storage<S>.componentID] = true;

			composition.generations[8]                            = Storage<D>.generation;
			composition.ids[8]                                    = Storage<D>.componentMask;
			composition.includeComponents[Storage<D>.componentID] = true;

			composition.generations[9]                            = Storage<F>.generation;
			composition.ids[9]                                    = Storage<F>.componentMask;
			composition.includeComponents[Storage<F>.componentID] = true;
		}
	}
}