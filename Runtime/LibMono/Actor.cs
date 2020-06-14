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

    //[FoldoutGroup("Main")] public ScriptableBuild buildFrom;


    protected sealed override void Start()
    {
    }

    //===============================//
    // Launch methods
    //===============================//

    public sealed override void Bootstrap(Layer layer)
    {
      // Case: Session Start. 
      // When childs are initialized manually from the parent, layer will treat them as eligable
      // objects to bootstrap. To prevent double bootstrap we check the layer. If it is not null
      // then we know that the monocache was already activated.
      if (Layer != null) return;

      Layer = layer;
      if (!entity.exist)
        entity = layer.Entity.CreateForActor(this, (ScriptableBuild) null, isPooled);
#if UNITY_EDITOR
      _entity = entity.id;
#endif
      Setup();
      HandleEnable();
    }

    internal void Bootstrap(Layer layer, ModelComposer model)
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