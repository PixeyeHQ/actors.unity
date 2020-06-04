namespace Pixeye.Actors
{
  public static class LayerMain
  {
    public static ImplEntity Entity => LayerCore.ActiveLayer.Entity;
    public static ImplEcs Ecs => LayerCore.ActiveLayer.Ecs;
    public static ImplObserver Observer => LayerCore.ActiveLayer.Observer;
    public static ImplActor Actor => LayerCore.ActiveLayer.Actor;
  }
}