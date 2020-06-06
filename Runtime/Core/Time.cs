//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Actors
{
  public class Time
  {
    public static float Fps = 60;
    public static float FpsPhysics = 50;
    public static bool FpsLimit = false;

    public static int Frame => UnityEngine.Time.frameCount;
    public static float Current => UnityEngine.Time.time;

    /// The scale at which the time is passing. This can be used for slow motion effects.
    public float scale = 1.0f;

    public float deltaTimeFixed;
    public float deltaTime;
    public float deltaTimeUnscaled;

    internal float timescaleCacheOnFocus;

    public Time()
    {
      timescaleCacheOnFocus = 1;
      if (Application.targetFrameRate == -1)
        Fps = 300;
      else
        Fps = Application.targetFrameRate;
      deltaTimeFixed    = 1 / FpsPhysics;
      deltaTime         = 1 / Fps;
      deltaTimeUnscaled = 1 / Fps;
    }


    public void Tick()
    {
      deltaTimeUnscaled = UnityEngine.Time.unscaledDeltaTime;

      if (FpsLimit)
        deltaTime = 1 / Fps * scale;
      else
        deltaTime = UnityEngine.Time.deltaTime * scale;

      deltaTimeFixed = 1 / FpsPhysics * scale;
    }
  }
}