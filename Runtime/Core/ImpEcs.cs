namespace Pixeye.Actors
{
  public class ImplEcs : IRequireActorsLayer
  {
    LayerCore layer;

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      this.layer = layer;
    }

    public ref T Send<T>() where T : struct
    {
      var     q = SignalsEcs<T>.layers[layer.id];
      ref var e = ref q.elements.Add();
      e.firstReceiver = -1;
      return ref e.signal;
    }


    public void Send<T>(in T obj) where T : struct
    {
      if (SignalsEcs<T>.layers[layer.id] == null) return;
      var     q = SignalsEcs<T>.layers[layer.id];
      ref var e = ref q.elements.Add();
      e.firstReceiver = -1;
      e.signal        = obj;
    }
  }
}