//  Project : ecs.examples
// Contacts : Pix - ask@pixeye.games


using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Pixeye.Actors
{
  sealed public class debug
  {
    [Conditional("ACTORS_DEBUG")]
    public static void log(object context)
    {
      Debug.Log(context);
    }
  }
}