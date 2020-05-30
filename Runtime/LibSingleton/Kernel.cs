using UnityEngine;

namespace Pixeye.Actors
{
  public class Kernel : MonoBehaviour
  {
    public static Kernel instance_local;

    public static Kernel Instance
    {
      get
      {
        if (applicationIsQuitting)
        {
          Debug.LogWarning("[Singleton] Instance '" + typeof(Kernel) +
                           "' already destroyed on application quit." +
                           " Won't create again - returning null.");
          return null;
        }

        if (instance_local != null) return instance_local;
        instance_local = (Kernel) FindObjectOfType(typeof(Kernel));

        if (FindObjectsOfType(typeof(Kernel)).Length > 1)
        {
          Debug.LogError("[Singleton] Something went really wrong " +
                         " - there should never be more than 1 singleton!" +
                         " Reopening the scene might fix it.");
          return instance_local;
        }

        if (instance_local != null) return instance_local;
        var singleton = new GameObject();
        instance_local = singleton.AddComponent<Kernel>();
        singleton.name = nameof(Kernel);

        DontDestroyOnLoad(singleton);

        return instance_local;
      }
    }

    public static bool isQuittingOrChangingScene()
    {
      return applicationIsQuitting || changingScene;
    }

    public static bool changingScene;
    public static bool applicationIsQuitting;
  }
}