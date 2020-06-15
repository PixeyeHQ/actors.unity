namespace Pixeye.Actors
{
  public static class Every
  {
    public static class Ecs
    {
      public static void Send<T>(T obj) where T : struct
      {
        foreach (var layer in LayerKernel.LayersInUse)
          layer.Ecs.Send(obj);
      }

      public static int GetAliveAmount()
      {
        int amount = 0;
        foreach (var layer in LayerKernel.LayersInUse)
          amount += layer.processorEcs.entities.length;

        return amount;
      }
    }

    public static class Layer
    {
      public static void Send<Y>(in Y signal)
      {
        foreach (var layer in LayerKernel.LayersInUse)
          layer.processorSignals.Dispatch(signal);
      }
    }
  }
}