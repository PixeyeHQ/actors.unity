namespace Pixeye.Actors
{
  public static class Every
  {
    public static class Ecs
    {
      public static void Send<T>(T obj) where T : struct
      {
        foreach (var layer in Kernel.LayersInUse)
          layer.implEcs.Send(obj);
      }
    }

    public static class Layer
    {
      public static void Send<Y>(in Y signal)
      {
        foreach (var layer in Kernel.LayersInUse)
          layer.processorSignals.Dispatch(signal);
      }
    }
  }
}