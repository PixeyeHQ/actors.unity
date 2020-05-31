//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Actors
{
  public class time : IKernel
  {
    public const float fps = 60;
    public static bool fpslimit = false;

    /// <summary>
    /// <para> Default Framework Time. Use it for independent timing</para>
    /// </summary>
    public static readonly time Default = new time();

    public static int frame => UnityEngine.Time.frameCount;
    public static float fromStart => Time.time;


    /// <summary>
    ///   <para> The scale at which the time is passing. This can be used for slow motion effects.</para>
    /// </summary>
    public float timeScale = 1.0f;

    public float deltaTimeFixed;
    public float deltaTime;
    public float deltaTimeUnscaled;

    //internal float timeScaleCached = 1.0f;

    public static float scale
    {
      get => Default.timeScale;
      set
      {
        Default.timeScale = value; 
        Debug.Log("HULA");
      }
    }

    /// <summary>
    /// <para> The time in seconds it took to complete the last frame</para>
    /// </summary>
    public static float delta => Default.deltaTime;

    public static float deltaUnscaled => Default.deltaTime;

    /// <summary>
    /// <para> 1 / 60 constant time</para>
    /// </summary>
    public static float deltaFixed => Default.deltaTimeFixed;


    public time()
    {
      ProcessorUpdateOld.times.Add(this);
      ProcessorUpdateOld.timesLen++;
      deltaTimeFixed = 1 / fps;
      deltaTime = deltaTimeFixed;
      deltaTimeUnscaled = deltaTimeFixed;
    }


    public void Tick()
    {
      deltaTimeUnscaled = UnityEngine.Time.deltaTime;

      if (fpslimit == true)
      {
        deltaTimeUnscaled = Mathf.Clamp(deltaTimeUnscaled, 0, 1 / fps);
      }

      deltaTime = deltaTimeUnscaled * timeScale;
      deltaTimeFixed = 1 / fps * timeScale;
    }
  }
}