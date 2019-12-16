//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye.Actors
{
  public class time : IKernel
  {
    protected const float fps = 60;

    /// <summary>
    /// <para> Default Framework Time. Use it for independent timing</para>
    /// </summary>
    internal static time Default = new time();
    public static int frame => UnityEngine.Time.frameCount;


    /// <summary>
    ///   <para> The scale at which the time is passing. This can be used for slow motion effects.</para>
    /// </summary>
    public float timeScale = 1.0f;
    
    public float deltaTimeFixed;
    public float deltaTime;

    internal float timeScaleCached = 1.0f;

    public static float scale
    {
      get { return Default.timeScale; }
      set { Default.timeScale = value; }
    }

    /// <summary>
    /// <para> The time in seconds it took to complete the last frame</para>
    /// </summary>
    public static float delta => Default.deltaTime;

    /// <summary>
    /// <para> 1 / 60 constant time</para>
    /// </summary>
    public static float deltaFixed => Default.deltaTimeFixed;


    public time()
    {
      ProcessorUpdate.times.Add(this);
      ProcessorUpdate.timesLen++;
      deltaTimeFixed = 1 / fps;
      deltaTime      = deltaTimeFixed;
    }


    public void Tick()
    {
      deltaTime      = UnityEngine.Time.deltaTime * timeScale;
      deltaTimeFixed = 1 / fps * timeScale;
    }
  }
}