using UnityEngine;

namespace Pixeye.Actors
{
  public abstract class MonoComponent : MonoBehaviour
  {
    void OnEnable()
    {
      var mono = GetComponent<ActorMono>();

      if (mono.entity.exist)
        mono.entity.GetMonoCompInternal(this);
    }

    void OnDisable()
    {
#if UNITY_EDITOR
      if (LayerKernel.ApplicationIsQuitting) return;
#endif
      var mono = GetComponent<ActorMono>();
      if (mono.entity.exist)
        mono.entity.RemoveMonoComp(this);
    }
  }
}