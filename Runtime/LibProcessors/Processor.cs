//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using UnityEngine;


namespace Pixeye.Actors
{
  internal interface IReceiveEcsEvent
  {
    void Receive();
  }

  public abstract class Processor : IDisposable, IRequireActorsLayer, ITick, IReceiveEcsEvent
  {
    internal static int NextID;
    internal int id;
    public LayerCore Layer;
    protected ImplObserver Observer;
    protected ImplActor Actor;
    protected ImplEntity Entity;
    protected ImplEcs Ecs;
    protected ImplTime Time;
    protected ImplObj Obj;
     

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      Layer = layer;
      id    = NextID++;

      layer.Updates.AddProc(this);
      layer.processorEcs.Add(this);
      layer.processorEcs.processors.Add(this);
      layer.processorSignals.Add(this);
      
      Entity   = layer.Entity;
      Ecs      = layer.Ecs;
      Observer = layer.Observer;
      Actor    = layer.Actor;
      Time     = layer.Time;
      Obj      = layer.Obj;

      OnLaunch();
      OnAwake();
    }

    protected virtual void OnAwake()
    {
      
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


    void ITick.Tick(float dt)
    {
    }

    void IReceiveEcsEvent.Receive()
    {
    }
  }

  #region PROCESSORS

  public class SignalsEcs<T>
  {
    internal static SignalsEcs<T>[] layers = new SignalsEcs<T>[64];

    internal BufferCircular<Element> elements = new BufferCircular<Element>(4);
    internal bool lockSignal; // prevents breaking ordering.

    internal bool Handle(int id)
    {
      if (elements.length == 0) return false;
      if (lockSignal)
      {
        lockSignal = false;
        return false;
      }

      ref var element = ref elements.Peek();
      if (element.firstReceiver == id)
      {
        lockSignal = true;
        elements.Dequeue();
        return false;
      }

      if (element.firstReceiver == -1)
      {
        element.firstReceiver = id;
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
    internal static SignalsEcs<T> signalsT = new SignalsEcs<T>();

    internal sealed override void OnLaunch() => SignalsEcs<T>.layers[Layer.id] = signalsT;

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
  }

  public abstract class Processore<T, Y> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();


    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();
    internal SignalsEcs<U> signalsU = new SignalsEcs<U>();

    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
      SignalsEcs<U>.layers[Layer.id] = signalsU;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();
    internal SignalsEcs<U> signalsU = new SignalsEcs<U>();
    internal SignalsEcs<I> signalsI = new SignalsEcs<I>();

    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
      SignalsEcs<U>.layers[Layer.id] = signalsU;
      SignalsEcs<I>.layers[Layer.id] = signalsI;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }
    }

    public abstract void ReceiveEcs(ref T signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref Y signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref U signal, ref bool stopSignal);
    public abstract void ReceiveEcs(ref I signal, ref bool stopSignal);
  }

  public abstract class Processor<T, Y, U, I, O> : Processor, IReceiveEcsEvent
  {
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();
    internal SignalsEcs<U> signalsU = new SignalsEcs<U>();
    internal SignalsEcs<I> signalsI = new SignalsEcs<I>();
    internal SignalsEcs<O> signalsO = new SignalsEcs<O>();

    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
      SignalsEcs<U>.layers[Layer.id] = signalsU;
      SignalsEcs<I>.layers[Layer.id] = signalsI;
      SignalsEcs<O>.layers[Layer.id] = signalsO;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsO.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsO.elements.Dequeue();
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
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();
    internal SignalsEcs<U> signalsU = new SignalsEcs<U>();
    internal SignalsEcs<I> signalsI = new SignalsEcs<I>();
    internal SignalsEcs<O> signalsO = new SignalsEcs<O>();
    internal SignalsEcs<P> signalsP = new SignalsEcs<P>();

    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
      SignalsEcs<U>.layers[Layer.id] = signalsU;
      SignalsEcs<I>.layers[Layer.id] = signalsI;
      SignalsEcs<O>.layers[Layer.id] = signalsO;
      SignalsEcs<P>.layers[Layer.id] = signalsP;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsO.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsO.elements.Dequeue();
      }

      if (signalsP.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsP.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsP.elements.Dequeue();
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
    internal SignalsEcs<T> signalsT = new SignalsEcs<T>();
    internal SignalsEcs<Y> signalsY = new SignalsEcs<Y>();
    internal SignalsEcs<U> signalsU = new SignalsEcs<U>();
    internal SignalsEcs<I> signalsI = new SignalsEcs<I>();
    internal SignalsEcs<O> signalsO = new SignalsEcs<O>();
    internal SignalsEcs<P> signalsP = new SignalsEcs<P>();
    internal SignalsEcs<A> signalsA = new SignalsEcs<A>();

    internal override void OnLaunch()
    {
      SignalsEcs<T>.layers[Layer.id] = signalsT;
      SignalsEcs<Y>.layers[Layer.id] = signalsY;
      SignalsEcs<U>.layers[Layer.id] = signalsU;
      SignalsEcs<I>.layers[Layer.id] = signalsI;
      SignalsEcs<O>.layers[Layer.id] = signalsO;
      SignalsEcs<P>.layers[Layer.id] = signalsP;
      SignalsEcs<A>.layers[Layer.id] = signalsA;
    }

    void IReceiveEcsEvent.Receive()
    {
      if (signalsT.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsO.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsO.elements.Dequeue();
      }

      if (signalsP.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsP.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsP.elements.Dequeue();
      }

      if (signalsA.Handle(id))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsA.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsA.elements.Dequeue();
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