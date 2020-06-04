//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Actors
{
  public class ImplTime
  {
    public static float Fps = 60;
    public static float FpsPhysics = 50;
    internal static bool FpsLimit = false;

    public static int frame => Time.frameCount;
    public static float current => Time.time;

    /// The scale at which the time is passing. This can be used for slow motion effects.
    public float scale = 1.0f;

    public float deltaTimeFixed;
    public float deltaTime;
    public float deltaTimeUnscaled;

    internal float timescaleCacheOnFocus;

    public ImplTime()
    {
      deltaTimeFixed    = 1 / FpsPhysics;
      deltaTime         = 1 / Fps;
      deltaTimeUnscaled = 1 / Fps;
    }


    public void Tick()
    {
      deltaTimeUnscaled = Time.unscaledDeltaTime;

      if (FpsLimit)
        deltaTime = 1 / Fps * scale;
      else
        deltaTime = Time.deltaTime * scale;
      
      deltaTimeFixed = 1 / FpsPhysics * scale;
    }
  }
}