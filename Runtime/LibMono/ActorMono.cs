namespace Pixeye.Actors
{
  public class ActorMono : Actor
  {
    protected override void Setup()
    {
      var components = GetComponents<MonoComponent>();
      foreach (var component in components)
      {
        if (component.enabled)
          entity.SetMonoComp(component);
      }
    }
  }
}