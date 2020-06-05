namespace Pixeye.Actors
{
  public class Groups
  {
    public static GroupCore Get(int id)
    {
      return ProcessorEcs.Bindings[id];
    }
  }
}