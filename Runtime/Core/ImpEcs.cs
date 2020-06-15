namespace Pixeye.Actors
{
  public class ImplEcs : IRequireActorsLayer
  {
    Layer layer;

    void IRequireActorsLayer.Bootstrap(Layer layer)
    {
      this.layer = layer;
    }

    public ents Alive => layer.processorEcs.entities;

    /// Get group by binding id.
    public GroupCore Group(int index) => layer.processorEcs.bindings[index];

    public ref T Send<T>() where T : struct
    {
      var     q = SignalsEcs<T>.Layers[layer.id];
      ref var e = ref q.elements.Add();
      e.firstReceiver = -1;
      return ref e.signal;
    }

    public void Send<T>(in T obj) where T : struct
    {
      if (SignalsEcs<T>.Layers[layer.id] == null) return;
      var     q = SignalsEcs<T>.Layers[layer.id];
      ref var e = ref q.elements.Add();
      e.firstReceiver = -1;
      e.signal        = obj;
    }

    /// Updates operations for groups.
    public void Update()
    {
      layer.processorEcs.Execute();
    }
  }
}