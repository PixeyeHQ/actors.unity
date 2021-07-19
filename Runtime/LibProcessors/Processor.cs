//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;


namespace Pixeye.Actors
{
  internal interface IReceiveEcsEvent
  {
    void Receive();
  }

  public abstract class Processor : IDisposable, IRequireActorsLayer, IReceiveEcsEvent
  {
    internal static int NEXT_FREE_ID;
    internal int processorID;
    public Layer Layer;
    protected ImplObserver Observer;
    protected ImplActor Actor;
    protected ImplEntity Entity;
    protected ImplEcs Ecs;
    protected Time Time;
    protected ImplObj Obj;

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      // We don't use IRequireActorsLayer in processors. Instead we use constructor.
    }

    protected Processor()
    {
      // This will be always the layer that added the processor.
      Layer = LayerKernel.LayerCurrentInit;
      // This increment is dropped every added layer, check layer implementation.
      // The ID is used for working with ECS signals.
      processorID = NEXT_FREE_ID++;
      Layer.Engine.AddProc(this);
      Layer.processorEcs.Add(this);
      Layer.processorEcs.processors.Add(this);
     
      Layer.processorSignals.Add(this);

      Entity   = Layer.Entity;
      Ecs      = Layer.Ecs;
      Observer = Layer.Observer;
      Actor    = Layer.Actor;
      Time     = Layer.Time;
      Obj      = Layer.Obj;

      OnLaunch();
    }


    void IDisposable.Dispose() => OnDispose();

    internal virtual void OnLaunch()
    {
    }

    public virtual void HandleEcsEvents()
    {
    }

    protected virtual void OnDispose()
    {
    }

    void IReceiveEcsEvent.Receive()
    {
    }
  }

  #region PROCESSORS

  [Il2CppSetOption(Option.NullChecks, false)]
  [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
  [Il2CppSetOption(Option.DivideByZeroChecks, false)]
  public class SignalsEcs<T>
  {
    internal static SignalsEcs<T>[] Layers = new SignalsEcs<T>[LayerKernel.LAYERS_AMOUNT_TOTAL];
    internal Element[] elements = new Element[8];
    internal int length;
    internal int head;

    internal static SignalsEcs<T> Get(int layerID)
    {
      var s = Layers[layerID];

      if (s == null) s = Layers[layerID] = new SignalsEcs<T>();
      else
      {
        s.length = 0;
        s.head = 0;
      }

      return s;
    }

    internal ref Element Add()
    {
      if (length == elements.Length)
      {
        Array.Resize(ref elements, length << 1);
      }

      return ref elements[length++];
    }

    private Element _default;
    internal ref Element Dequeue()
    {
      if (length == 0 || head == length)
      {
        head = 0;
        return ref _default;
      }

      return ref elements[head++];
    }
    
    public ref Element Peek()
    {
      return ref elements[head];
    }

    public ref Element GetByIndex(int index)
    {
      return ref elements[index];
    }

    internal bool Handle(int index, int processorID)
    {
      if (length == 0) return false;

      ref var element = ref elements[index];
      
      if (element.firstReceiver == processorID)
      {
        Dequeue();
        return false;
      }

      if (element.firstReceiver == -1)
      {
        element.firstReceiver = processorID;
      }
      
      return true;
    }

    public struct Element
    {
      public T signal;
      internal int firstReceiver;
    }
  }

  public abstract class Processor<T> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;

    internal sealed override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;


    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;
    internal SignalsEcs<U> signalsU;

    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
      signalsU = SignalsEcs<U>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
      
      for (int i = signalsU.head; i < signalsU.length; i++)
      {
        if (signalsU.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsU.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsU.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;
    internal SignalsEcs<U> signalsU;
    internal SignalsEcs<I> signalsI;

    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
      signalsU = SignalsEcs<U>.Get(Layer.id);
      signalsI = SignalsEcs<I>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
      
      for (int i = signalsU.head; i < signalsU.length; i++)
      {
        if (signalsU.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsU.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsU.Dequeue();
        }
      }
      
      for (int i = signalsI.head; i < signalsI.length; i++)
      {
        if (signalsI.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsI.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsI.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref I signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I, O> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;
    internal SignalsEcs<U> signalsU;
    internal SignalsEcs<I> signalsI;
    internal SignalsEcs<O> signalsO;

    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
      signalsU = SignalsEcs<U>.Get(Layer.id);
      signalsI = SignalsEcs<I>.Get(Layer.id);
      signalsO = SignalsEcs<O>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
      
      for (int i = signalsU.head; i < signalsU.length; i++)
      {
        if (signalsU.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsU.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsU.Dequeue();
        }
      }
      
      for (int i = signalsI.head; i < signalsI.length; i++)
      {
        if (signalsI.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsI.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsI.Dequeue();
        }
      }
      
      for (int i = signalsO.head; i < signalsO.length; i++)
      {
        if (signalsO.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsO.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsO.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref I signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref O signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I, O, P> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;
    internal SignalsEcs<U> signalsU;
    internal SignalsEcs<I> signalsI;
    internal SignalsEcs<O> signalsO;
    internal SignalsEcs<P> signalsP;

    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
      signalsU = SignalsEcs<U>.Get(Layer.id);
      signalsI = SignalsEcs<I>.Get(Layer.id);
      signalsO = SignalsEcs<O>.Get(Layer.id);
      signalsP = SignalsEcs<P>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
      
      for (int i = signalsU.head; i < signalsU.length; i++)
      {
        if (signalsU.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsU.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsU.Dequeue();
        }
      }
      
      for (int i = signalsI.head; i < signalsI.length; i++)
      {
        if (signalsI.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsI.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsI.Dequeue();
        }
      }
      
      for (int i = signalsO.head; i < signalsO.length; i++)
      {
        if (signalsO.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsO.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsO.Dequeue();
        }
      }
      
      for (int i = signalsP.head; i < signalsP.length; i++)
      {
        if (signalsP.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsP.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsP.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref I signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref O signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref P signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I, O, P, A> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT;
    internal SignalsEcs<Y> signalsY;
    internal SignalsEcs<U> signalsU;
    internal SignalsEcs<I> signalsI;
    internal SignalsEcs<O> signalsO;
    internal SignalsEcs<P> signalsP;
    internal SignalsEcs<A> signalsA;

    internal override void OnLaunch()
    {
      signalsT = SignalsEcs<T>.Get(Layer.id);
      signalsY = SignalsEcs<Y>.Get(Layer.id);
      signalsU = SignalsEcs<U>.Get(Layer.id);
      signalsI = SignalsEcs<I>.Get(Layer.id);
      signalsO = SignalsEcs<O>.Get(Layer.id);
      signalsP = SignalsEcs<P>.Get(Layer.id);
      signalsA = SignalsEcs<A>.Get(Layer.id);
    }

    void IReceiveEcsEvent.Receive()
    {
      for (int i = signalsT.head; i < signalsT.length; i++)
      {
        if (signalsT.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsT.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsT.Dequeue();
        }
      }

      for (int i = signalsY.head; i < signalsY.length; i++)
      {
        if (signalsY.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsY.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsY.Dequeue();
        }
      }
      
      for (int i = signalsU.head; i < signalsU.length; i++)
      {
        if (signalsU.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsU.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsU.Dequeue();
        }
      }
      
      for (int i = signalsI.head; i < signalsI.length; i++)
      {
        if (signalsI.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsI.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsI.Dequeue();
        }
      }
      
      for (int i = signalsO.head; i < signalsO.length; i++)
      {
        if (signalsO.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsO.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsO.Dequeue();
        }
      }
      
      for (int i = signalsP.head; i < signalsP.length; i++)
      {
        if (signalsP.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsP.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsP.Dequeue();
        }
      }
      
      for (int i = signalsA.head; i < signalsA.length; i++)
      {
        if (signalsA.Handle(i, processorID))
        {
          var stopSignal = false;
          ReceiveEcs(ref signalsA.GetByIndex(i).signal, ref stopSignal);
          if (stopSignal) signalsA.Dequeue();
        }
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref I signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref O signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref P signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref A signal, ref bool stopSignal);
  }

  #endregion


  internal class Dummy : ITick, IReceiveEcsEvent
  {
    public void Tick(float dt)
    {
    }

    public void Receive()
    {
    }
  }
}