//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
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

    [Tooltip("This is used to link pools with prefabs. Leave empty in case you don't use this actor with a pools.")]
    [FoldoutGroup("Main")] public string prefabReferenceName = String.Empty;

    protected sealed override void Start()
    {
    }

    //===============================//
    // Launch methods
    //===============================//

    // used when actor is created in session.
    internal void BootstrapCreated(Layer layer)
    {
      Layer = layer;

      if (!entity.exist)
        entity = layer.Entity.CreateForActor(this, (ScriptableBuild) null, prefabReferenceName != string.Empty);
#if UNITY_EDITOR
      _entity = entity.id;
#endif
      Setup();
      HandleEnable();
    }

    public sealed override void Bootstrap(Layer layer)
    {
      // Case: Session Start. 
      // When childs are initialized manually from the parent, layer will treat them as eligable
      // objects to bootstrap. To prevent double bootstrap we check the layer. If it is not null
      // then we know that the monocache was already activated.

      if (Layer != null) return;

      if (prefabReferenceName != string.Empty)
      {
        layer.Pool[Pool.Entities].RegisterAndAdd(Box.Load<GameObject>(prefabReferenceName), gameObject);
      }

      BootstrapCreated(layer);
    }

    internal void BootstrapCreated(Layer layer, ModelComposer model)
    {
      Layer = layer;
      if (!entity.exist)
        entity = layer.Entity.CreateForActor(this, model, prefabReferenceName != string.Empty);
#if UNITY_EDITOR
      _entity = entity.id;
#endif
      Setup();
      HandleEnable();
    }
  }
}