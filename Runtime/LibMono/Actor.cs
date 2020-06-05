//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using Unity.IL2CPP.CompilerServices;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class Actor : MonoCached
  {
    public ent entity;

#if UNITY_EDITOR
    [FoldoutGroup("Main"), SerializeField, ReadOnly]
    internal int _entity;
#endif

    [FoldoutGroup("Main")] public bool isPooled;

    [FoldoutGroup("Main")] public ScriptableBuild buildFrom;

    //===============================//
    // Launch methods
    //===============================//

    public sealed override void Bootstrap(LayerCore layer)
    {
      Layer = layer;
      if (!entity.exist)
        entity = layer.Entity.CreateForActor(this, buildFrom, isPooled);
#if UNITY_EDITOR
      _entity = entity.id;
#endif
      Setup();
      HandleEnable();
    }

    internal void Bootstrap(LayerCore layer, ModelComposer model)
    {
      Layer = layer;
      if (!entity.exist)
        entity = layer.Entity.CreateForActor(this, model, isPooled);
#if UNITY_EDITOR
      _entity = entity.id;
#endif
      Setup();
      HandleEnable();
    }
  }
}