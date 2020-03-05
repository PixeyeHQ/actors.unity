//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
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

  [Flags]
  public enum Op
  {
    Add = 1,
    Remove = 2,
    All = Add | Remove
  }


  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public abstract class GroupCore : IEnumerable, IEquatable<GroupCore>, IDisposable
  {
    public ent[] entities = new ent[Framework.Settings.SizeEntities];
    public int length;


    #if ACTORS_EVENTS_MANUAL
		public ents added;
		public ents removed;
		
		internal bool hasEventAdd;
		internal bool hasEventRemove;
    #else
    public ents added = new ents(Framework.Settings.SizeEntities);
    public ents removed = new ents(Framework.Settings.SizeEntities);
    #endif


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

    #if ACTORS_EVENTS_MANUAL
		internal void SetSelf(Op op, Processor pr)
		{
			if ((op & Op.Add) == Op.Add)
			{
				if (added == null)
					added = new ents(Framework.Settings.SizeEntities);

				hasEventAdd = true;
			}

			if ((op & Op.Remove) == Op.Remove)
			{
				if (removed == null)
					removed = new ents(Framework.Settings.SizeEntities);

				hasEventRemove = true;
			}
		}
    #endif

    internal virtual GroupCore Initialize(Composition composition)
    {
      this.composition = composition;
      #if !ACTORS_TAGS_0
      HelperTags.Add(this);
      #endif

      this.composition.SetupExcludeTypes(this);
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
        #if ACTORS_EVENTS_MANUAL
				if (hasEventAdd)
				Array.Resize(ref added.source, entity.id << 1);
				if (hasEventRemove)
				Array.Resize(ref removed.source, entity.id << 1);
        #else
        Array.Resize(ref added.source, entity.id << 1);
        Array.Resize(ref removed.source, entity.id << 1);
        #endif
      }
      else if (length >= entities.Length)
      {
        Array.Resize(ref entities, length << 1);
        #if ACTORS_EVENTS_MANUAL
				if (hasEventAdd)
				Array.Resize(ref added.source, length << 1);
				if (hasEventRemove)
				Array.Resize(ref removed.source, length << 1);
        #else
        Array.Resize(ref added.source, length << 1);
        Array.Resize(ref removed.source, length << 1);
        #endif
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
        #if ACTORS_EVENTS_MANUAL
				if (hasEventAdd)
					added.source[added.length++] = entity;
        #else
        added.source[added.length++] = entity;
        #endif
      }
      else
      {
        entities[right] = entity;
        #if ACTORS_EVENTS_MANUAL
				if (hasEventAdd)
					added.source[added.length++] = entity;
        #else
        added.source[added.length++] = entity;
        #endif
      }
    }


    //===============================//
    // Try Remove
    //===============================//


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void TryRemove(int entityID)
    {
      if (length == 0) return;

      var i = HelperArray.BinarySearch(ref entities, entityID, 0, length - 1);
      if (i == -1) return;

      #if ACTORS_EVENTS_MANUAL
			if (hasEventRemove)
				removed.source[removed.length++] = entities[i];
      #else
      removed.source[removed.length++] = entities[i];
      #endif

      if (i < --length)
        Array.Copy(entities, i + 1, entities, i, length - i);
    }


    //===============================//
    // Remove
    //===============================//
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void Remove(int i)
    {
      #if ACTORS_EVENTS_MANUAL
			if (hasEventRemove)
				removed.source[removed.length++] = entities[i];
      #else
      removed.source[removed.length++] = entities[i];
      #endif

      if (i < --length)
        Array.Copy(entities, i + 1, entities, i, length - i);
    }


    public virtual void Dispose()
    {
      #if ACTORS_EVENTS_MANUAL
			hasEventAdd = false;
			hasEventRemove = false;

			added = default;
			removed = default;
      #else

      added   = new ents(Framework.Settings.SizeEntities);
      removed = new ents(Framework.Settings.SizeEntities);
      #endif


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
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);

      Storage<T>.Instance.groups.Add(this);

      var len = 1;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0] = Storage<T>.Generation;
      composition.ids[0]         = Storage<T>.ComponentMask;

      composition.includeComponents[Storage<T>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);

      var len = 2;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);

      var len = 3;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);

      var len = 4;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      var len = 5;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0] = Storage<T>.Generation;
      composition.ids[0]         = Storage<T>.ComponentMask;

      composition.generations[1] = Storage<Y>.Generation;
      composition.ids[1]         = Storage<Y>.ComponentMask;

      composition.generations[2] = Storage<U>.Generation;
      composition.ids[2]         = Storage<U>.ComponentMask;

      composition.generations[3] = Storage<I>.Generation;
      composition.ids[3]         = Storage<I>.ComponentMask;

      composition.generations[4] = Storage<O>.Generation;
      composition.ids[4]         = Storage<O>.ComponentMask;

      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P> : GroupCore

  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      Storage<P>.Instance.groups.Add(this);

      var len = 6;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;

      composition.generations[4]                            = Storage<O>.Generation;
      composition.ids[4]                                    = Storage<O>.ComponentMask;
      composition.includeComponents[Storage<O>.componentId] = true;

      composition.generations[5]                            = Storage<P>.Generation;
      composition.ids[5]                                    = Storage<P>.ComponentMask;
      composition.includeComponents[Storage<P>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      Storage<P>.Instance.groups.Add(this);
      Storage<A>.Instance.groups.Add(this);

      var len = 7;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;

      composition.generations[4]                            = Storage<O>.Generation;
      composition.ids[4]                                    = Storage<O>.ComponentMask;
      composition.includeComponents[Storage<O>.componentId] = true;

      composition.generations[5]                            = Storage<P>.Generation;
      composition.ids[5]                                    = Storage<P>.ComponentMask;
      composition.includeComponents[Storage<P>.componentId] = true;

      composition.generations[6]                            = Storage<A>.Generation;
      composition.ids[6]                                    = Storage<A>.ComponentMask;
      composition.includeComponents[Storage<A>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      Storage<P>.Instance.groups.Add(this);
      Storage<A>.Instance.groups.Add(this);
      Storage<S>.Instance.groups.Add(this);

      var len = 8;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;

      composition.generations[4]                            = Storage<O>.Generation;
      composition.ids[4]                                    = Storage<O>.ComponentMask;
      composition.includeComponents[Storage<O>.componentId] = true;

      composition.generations[5]                            = Storage<P>.Generation;
      composition.ids[5]                                    = Storage<P>.ComponentMask;
      composition.includeComponents[Storage<P>.componentId] = true;

      composition.generations[6]                            = Storage<A>.Generation;
      composition.ids[6]                                    = Storage<A>.ComponentMask;
      composition.includeComponents[Storage<A>.componentId] = true;

      composition.generations[7]                            = Storage<S>.Generation;
      composition.ids[7]                                    = Storage<S>.ComponentMask;
      composition.includeComponents[Storage<S>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S, D> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      Storage<P>.Instance.groups.Add(this);
      Storage<A>.Instance.groups.Add(this);
      Storage<S>.Instance.groups.Add(this);
      Storage<D>.Instance.groups.Add(this);
      var len = 9;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;

      composition.generations[4]                            = Storage<O>.Generation;
      composition.ids[4]                                    = Storage<O>.ComponentMask;
      composition.includeComponents[Storage<O>.componentId] = true;

      composition.generations[5]                            = Storage<P>.Generation;
      composition.ids[5]                                    = Storage<P>.ComponentMask;
      composition.includeComponents[Storage<P>.componentId] = true;

      composition.generations[6]                            = Storage<A>.Generation;
      composition.ids[6]                                    = Storage<A>.ComponentMask;
      composition.includeComponents[Storage<A>.componentId] = true;

      composition.generations[7]                            = Storage<S>.Generation;
      composition.ids[7]                                    = Storage<S>.ComponentMask;
      composition.includeComponents[Storage<S>.componentId] = true;

      composition.generations[8]                            = Storage<D>.Generation;
      composition.ids[8]                                    = Storage<D>.ComponentMask;
      composition.includeComponents[Storage<D>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S, D, F> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition)
    {
      var gr = base.Initialize(composition);
      Storage<T>.Instance.groups.Add(this);
      Storage<Y>.Instance.groups.Add(this);
      Storage<U>.Instance.groups.Add(this);
      Storage<I>.Instance.groups.Add(this);
      Storage<O>.Instance.groups.Add(this);
      Storage<P>.Instance.groups.Add(this);
      Storage<A>.Instance.groups.Add(this);
      Storage<S>.Instance.groups.Add(this);
      Storage<D>.Instance.groups.Add(this);
      Storage<F>.Instance.groups.Add(this);
      var len = 10;

      composition.generations = new int[len];
      composition.ids         = new int[len];

      composition.generations[0]                            = Storage<T>.Generation;
      composition.ids[0]                                    = Storage<T>.ComponentMask;
      composition.includeComponents[Storage<T>.componentId] = true;

      composition.generations[1]                            = Storage<Y>.Generation;
      composition.ids[1]                                    = Storage<Y>.ComponentMask;
      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.generations[2]                            = Storage<U>.Generation;
      composition.ids[2]                                    = Storage<U>.ComponentMask;
      composition.includeComponents[Storage<U>.componentId] = true;

      composition.generations[3]                            = Storage<I>.Generation;
      composition.ids[3]                                    = Storage<I>.ComponentMask;
      composition.includeComponents[Storage<I>.componentId] = true;

      composition.generations[4]                            = Storage<O>.Generation;
      composition.ids[4]                                    = Storage<O>.ComponentMask;
      composition.includeComponents[Storage<O>.componentId] = true;

      composition.generations[5]                            = Storage<P>.Generation;
      composition.ids[5]                                    = Storage<P>.ComponentMask;
      composition.includeComponents[Storage<P>.componentId] = true;

      composition.generations[6]                            = Storage<A>.Generation;
      composition.ids[6]                                    = Storage<A>.ComponentMask;
      composition.includeComponents[Storage<A>.componentId] = true;

      composition.generations[7]                            = Storage<S>.Generation;
      composition.ids[7]                                    = Storage<S>.ComponentMask;
      composition.includeComponents[Storage<S>.componentId] = true;

      composition.generations[8]                            = Storage<D>.Generation;
      composition.ids[8]                                    = Storage<D>.ComponentMask;
      composition.includeComponents[Storage<D>.componentId] = true;

      composition.generations[9]                            = Storage<F>.Generation;
      composition.ids[9]                                    = Storage<F>.ComponentMask;
      composition.includeComponents[Storage<F>.componentId] = true;
      return gr;
    }
  }
}