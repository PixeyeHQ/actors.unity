using UnityEngine.Scripting;

namespace Pixeye.Actors
{
  [Preserve]
  internal struct ComponentMask
  {
    public int generation;
    public int mask;
    public int id;
  }
}