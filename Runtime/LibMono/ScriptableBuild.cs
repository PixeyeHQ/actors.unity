//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif

namespace Pixeye.Actors
{
  public class ScriptableBuild : ScriptableObject
  {
    public Dictionary<int, ModelComposer> helpers = new Dictionary<int, ModelComposer>();

    internal virtual void Execute(in ent entity, Actor a = null)
    {
      helpers[GetInstanceID()](entity);
      entity.layer.processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
    }

    internal virtual void ExecuteOnStart(in ent entity, Actor a)
    {
      helpers[GetInstanceID()](entity);
      if (!a.isActiveAndEnabled) return;
      entity.layer.processorEcs.SetOperation(entity, -1, ProcessorEcs.Action.Activate);
    }

    protected virtual void OnEnable()
    {
#if UNITY_EDITOR
      if (!EditorApplication.isPlayingOrWillChangePlaymode) return;
#endif

      var t = GetType();
      var n = name.Substring(5).Replace(" ", string.Empty);
      helpers.Add(GetInstanceID(),
        (ModelComposer) Delegate.CreateDelegate(typeof(ModelComposer), null,
          t.GetMethod(n, BindingFlags.Public | BindingFlags.Static | BindingFlags.Default)));
    }

    protected virtual void OnDisable()
    {
      helpers.Clear();
    }
  }

  public static class HelperScriptableBuild
  {
    public static ModelComposer GetModelComposer(this ScriptableBuild sb)
    {
      return sb.helpers[sb.GetHashCode()];
    }
  }
}