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

    internal BufferCircular<Element> elements = new BufferCircular<Element>(4);

    // case: several processors gets signal.
    // without lock we get invalid signal receive order.
    // https://i.gyazo.com/22eb327ea969ba9ca7e608e5893d9449.png  <- without lock
    // https://i.gyazo.com/7c293f0d558496d78cde3897b6e72751.png  <- with    lock
    // there might be a better solution but I didn't find out yet.
    internal bool lockSignal;

    internal static SignalsEcs<T> Get(int layerID)
    {
      var s = Layers[layerID];

      if (s == null) s = Layers[layerID] = new SignalsEcs<T>();
      else
      {
        s.elements.length = 0;
        s.lockSignal      = false;
      }

      return s;
    }

    internal bool Handle(int processorID)
    {
      if (elements.length == 0) return false;
      if (lockSignal)
      {
        lockSignal = false;
        return false;
      }

      ref var element = ref elements.Peek();
      if (element.firstReceiver == processorID)
      {
        lockSignal = true;
        elements.Dequeue();
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(processorID))
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(processorID))
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(processorID))
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsO.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsO.elements.Dequeue();
      }

      if (signalsP.Handle(processorID))
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
      if (signalsT.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsT.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsT.elements.Dequeue();
      }

      if (signalsY.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsY.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsY.elements.Dequeue();
      }

      if (signalsU.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsU.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsU.elements.Dequeue();
      }

      if (signalsI.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsI.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsI.elements.Dequeue();
      }

      if (signalsO.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsO.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsO.elements.Dequeue();
      }

      if (signalsP.Handle(processorID))
      {
        var stopSignal = false;
        ReceiveEcs(ref signalsP.elements.Peek().signal, ref stopSignal);
        if (stopSignal) signalsP.elements.Dequeue();
      }

      if (signalsA.Handle(processorID))
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