namespace Pixeye.Actors
{
  public class ImplObserver : IRequireActorsLayer
  {
    internal LayerCore layer;

    public void Bootstrap(LayerCore layer)
    {
      this.layer = layer;
    }
  }
}