//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting;


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


  [Preserve]
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public abstract class GroupCore : IEnumerable, IEquatable<GroupCore>, IDisposable
  {
    public ent[] entities = new ent[Kernel.Settings.SizeEntities];
    public int length;

    internal ProcessorEcs processorEcs;
    internal LayerCore layer;

#if ACTORS_EVENTS_MANUAL
    public ents added;
    public ents removed;

    internal bool hasEventAdd;
    internal bool hasEventRemove;
#else
    public ents added = new ents(Kernel.Settings.SizeEntities);
    public ents removed = new ents(Kernel.Settings.SizeEntities);
#endif


    protected internal Composition composition;

    internal int id;

    int position;


    public ent this[int index]
    {
      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      get =>  entities[index];
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


    internal virtual GroupCore Initialize(Composition composition, LayerCore layer)
    {
      this.layer       = layer;
      this.composition = composition;
      Debug.Log("HOPA: " + layer.processorEcs);
      processorEcs     = layer.processorEcs;

#if ACTORS_TAGS_CHECKS
      Debug.Log("HOPA2: " + layer.processorEcs);
      HelperTags.RegisterGroup(this);
#endif
      Debug.Log("HOPA3: " + composition.excluded);
      Debug.Log("HOPA3: " + composition.excluded.Length);
      for (var i = 0; i < composition.excluded.Length; i++)
      {
        ref var m = ref composition.excluded[i];
          Debug.Log("HOPA6: " + Storage.All[m.id].groups[layer.id]);
       Debug.Log("HOPA4: " + m.id);
 
        Storage.All[m.id].groups[layer.id].Add(this);
      }
      Debug.Log("HOPA7: " + this);
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
    internal bool TryRemove(int entityID)
    {
      if (length == 0) return false;

      var i = HelperArray.BinarySearch(ref entities, entityID, 0, length - 1);
      if (i == -1) return false;

#if ACTORS_EVENTS_MANUAL
      if (hasEventRemove)
        removed.source[removed.length++] = entities[i];
#else
      removed.source[removed.length++] = entities[i];
#endif

      if (i < --length)
        Array.Copy(entities, i + 1, entities, i, length - i);

      return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal void RemoveFast(int entityID)
    {
      var i = HelperArray.BinarySearch(ref entities, entityID, 0, length - 1);
      
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
      added   = new ents(Kernel.Settings.SizeEntities);
      removed = new ents(Kernel.Settings.SizeEntities);
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
        var entitiesNext = 0;
        int threadsInWork;
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
      GroupCore groupEntities;
      int position;


      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      internal Enumerator(GroupCore groupEntities)
      {
        position           = -1;
        this.groupEntities = groupEntities;
        groupEntities.processorEcs.Execute();
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        if (++position < groupEntities.length)
        {
          groupEntities.processorEcs.Execute();
          return true;
        }

        return false;
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
        get => groupEntities.entities[position];
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Dispose()
      {
        groupEntities = null;
      }
    }

    #endregion
  }

  [Preserve]
  public class Group<T> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);

      Storage<T>.Instance.groups[layer.id].Add(this);

      const int len = 1;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;
      return gr;
    }
  }
  [Preserve]
  public class Group<T, Y> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);

      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);

      const int len = 2;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;

      composition.includeComponents[Storage<Y>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);


      const int len = 3;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;


      composition.includeComponents[Storage<Y>.componentId] = true;


      composition.includeComponents[Storage<U>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);


      const int len = 4;


      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;

      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.includeComponents[Storage<U>.componentId] = true;

      composition.includeComponents[Storage<I>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);

      const int len = 5;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;
      composition.includeComponents[Storage<Y>.componentId] = true;
      composition.includeComponents[Storage<U>.componentId] = true;
      composition.includeComponents[Storage<I>.componentId] = true;
      composition.includeComponents[Storage<O>.componentId] = true;

      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P> : GroupCore

  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);
      Storage<P>.Instance.groups[layer.id].Add(this);

      const int len = 6;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.included[5].generation = Storage<P>.Generation;
      composition.included[5].mask       = Storage<P>.ComponentMask;
      composition.included[5].id         = Storage<P>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;


      composition.includeComponents[Storage<Y>.componentId] = true;


      composition.includeComponents[Storage<U>.componentId] = true;


      composition.includeComponents[Storage<I>.componentId] = true;


      composition.includeComponents[Storage<O>.componentId] = true;


      composition.includeComponents[Storage<P>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);
      Storage<P>.Instance.groups[layer.id].Add(this);
      Storage<A>.Instance.groups[layer.id].Add(this);

      const int len = 7;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.included[5].generation = Storage<P>.Generation;
      composition.included[5].mask       = Storage<P>.ComponentMask;
      composition.included[5].id         = Storage<P>.componentId;


      composition.included[6].generation = Storage<A>.Generation;
      composition.included[6].mask       = Storage<A>.ComponentMask;
      composition.included[6].id         = Storage<A>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;


      composition.includeComponents[Storage<Y>.componentId] = true;


      composition.includeComponents[Storage<U>.componentId] = true;


      composition.includeComponents[Storage<I>.componentId] = true;


      composition.includeComponents[Storage<O>.componentId] = true;


      composition.includeComponents[Storage<P>.componentId] = true;


      composition.includeComponents[Storage<A>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);
      Storage<P>.Instance.groups[layer.id].Add(this);
      Storage<A>.Instance.groups[layer.id].Add(this);
      Storage<S>.Instance.groups[layer.id].Add(this);

      const int len = 8;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.included[5].generation = Storage<P>.Generation;
      composition.included[5].mask       = Storage<P>.ComponentMask;
      composition.included[5].id         = Storage<P>.componentId;


      composition.included[6].generation = Storage<A>.Generation;
      composition.included[6].mask       = Storage<A>.ComponentMask;
      composition.included[6].id         = Storage<A>.componentId;

      composition.included[7].generation = Storage<S>.Generation;
      composition.included[7].mask       = Storage<S>.ComponentMask;
      composition.included[7].id         = Storage<S>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;


      composition.includeComponents[Storage<Y>.componentId] = true;


      composition.includeComponents[Storage<U>.componentId] = true;


      composition.includeComponents[Storage<I>.componentId] = true;


      composition.includeComponents[Storage<O>.componentId] = true;


      composition.includeComponents[Storage<P>.componentId] = true;


      composition.includeComponents[Storage<A>.componentId] = true;


      composition.includeComponents[Storage<S>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S, D> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);
      Storage<P>.Instance.groups[layer.id].Add(this);
      Storage<A>.Instance.groups[layer.id].Add(this);
      Storage<S>.Instance.groups[layer.id].Add(this);
      Storage<D>.Instance.groups[layer.id].Add(this);

      const int len = 9;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.included[5].generation = Storage<P>.Generation;
      composition.included[5].mask       = Storage<P>.ComponentMask;
      composition.included[5].id         = Storage<P>.componentId;

      composition.included[6].generation = Storage<A>.Generation;
      composition.included[6].mask       = Storage<A>.ComponentMask;
      composition.included[6].id         = Storage<A>.componentId;

      composition.included[7].generation = Storage<S>.Generation;
      composition.included[7].mask       = Storage<S>.ComponentMask;
      composition.included[7].id         = Storage<S>.componentId;

      composition.included[8].generation = Storage<D>.Generation;
      composition.included[8].mask       = Storage<D>.ComponentMask;
      composition.included[8].id         = Storage<D>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;


      composition.includeComponents[Storage<Y>.componentId] = true;


      composition.includeComponents[Storage<U>.componentId] = true;


      composition.includeComponents[Storage<I>.componentId] = true;


      composition.includeComponents[Storage<O>.componentId] = true;


      composition.includeComponents[Storage<P>.componentId] = true;


      composition.includeComponents[Storage<A>.componentId] = true;


      composition.includeComponents[Storage<S>.componentId] = true;


      composition.includeComponents[Storage<D>.componentId] = true;
      return gr;
    }
  }

  public class Group<T, Y, U, I, O, P, A, S, D, F> : GroupCore
  {
    internal override GroupCore Initialize(Composition composition, LayerCore layer)
    {
      var gr = base.Initialize(composition, layer);
      Storage<T>.Instance.groups[layer.id].Add(this);
      Storage<Y>.Instance.groups[layer.id].Add(this);
      Storage<U>.Instance.groups[layer.id].Add(this);
      Storage<I>.Instance.groups[layer.id].Add(this);
      Storage<O>.Instance.groups[layer.id].Add(this);
      Storage<P>.Instance.groups[layer.id].Add(this);
      Storage<A>.Instance.groups[layer.id].Add(this);
      Storage<S>.Instance.groups[layer.id].Add(this);
      Storage<D>.Instance.groups[layer.id].Add(this);
      Storage<F>.Instance.groups[layer.id].Add(this);

      const int len = 10;

      composition.included               = new ComponentMask[len];
      composition.included[0].generation = Storage<T>.Generation;
      composition.included[0].mask       = Storage<T>.ComponentMask;
      composition.included[0].id         = Storage<T>.componentId;

      composition.included[1].generation = Storage<Y>.Generation;
      composition.included[1].mask       = Storage<Y>.ComponentMask;
      composition.included[1].id         = Storage<Y>.componentId;

      composition.included[2].generation = Storage<U>.Generation;
      composition.included[2].mask       = Storage<U>.ComponentMask;
      composition.included[2].id         = Storage<U>.componentId;

      composition.included[3].generation = Storage<I>.Generation;
      composition.included[3].mask       = Storage<I>.ComponentMask;
      composition.included[3].id         = Storage<I>.componentId;

      composition.included[4].generation = Storage<O>.Generation;
      composition.included[4].mask       = Storage<O>.ComponentMask;
      composition.included[4].id         = Storage<O>.componentId;

      composition.included[5].generation = Storage<P>.Generation;
      composition.included[5].mask       = Storage<P>.ComponentMask;
      composition.included[5].id         = Storage<P>.componentId;

      composition.included[6].generation = Storage<A>.Generation;
      composition.included[6].mask       = Storage<A>.ComponentMask;
      composition.included[6].id         = Storage<A>.componentId;

      composition.included[7].generation = Storage<S>.Generation;
      composition.included[7].mask       = Storage<S>.ComponentMask;
      composition.included[7].id         = Storage<S>.componentId;

      composition.included[8].generation = Storage<D>.Generation;
      composition.included[8].mask       = Storage<D>.ComponentMask;
      composition.included[8].id         = Storage<D>.componentId;

      composition.included[9].generation = Storage<F>.Generation;
      composition.included[9].mask       = Storage<F>.ComponentMask;
      composition.included[9].id         = Storage<F>.componentId;

      composition.includeComponents[Storage<T>.componentId] = true;

      composition.includeComponents[Storage<Y>.componentId] = true;

      composition.includeComponents[Storage<U>.componentId] = true;

      composition.includeComponents[Storage<I>.componentId] = true;

      composition.includeComponents[Storage<O>.componentId] = true;

      composition.includeComponents[Storage<P>.componentId] = true;

      composition.includeComponents[Storage<A>.componentId] = true;

      composition.includeComponents[Storage<S>.componentId] = true;

      composition.includeComponents[Storage<D>.componentId] = true;

      composition.includeComponents[Storage<F>.componentId] = true;
      return gr;
    }
  }

  public delegate void HandleSegmentGroup(SegmentGroup segment);

  public sealed class SegmentGroup
  {
    public GroupCore source;
    public float delta;

    public int indexFrom;
    public int indexTo;

    internal Thread thread;
    internal ManualResetEvent HasWork;
    internal ManualResetEvent WorkDone;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Enumerator GetEnumerator()
    {
      return new Enumerator(indexFrom, indexTo);
    }

    public struct Enumerator : IEnumerator<int>
    {
      readonly int length;
      int position;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      internal Enumerator(int from, int to)
      {
        position = from - 1;
        length   = to;
      }

      public int Current
      {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return position; }
      }

      object IEnumerator.Current => Current;

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool MoveNext()
      {
        return ++position < length;
      }


      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Dispose()
      {
      }


      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public void Reset()
      {
        position = -1;
      }
    }
  }
}