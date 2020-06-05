using System;
using System.Reflection;
using Pixeye.Actors;
#if UNITY_EDITOR
using UnityEditor;
#endif
 

namespace Pixeye.Source
{
  public abstract class ModelCore : ScriptableBuild
  {
    // this allows you to create models as scriptable objects in the project and attach them to the actors in the inspector.
    protected override void OnEnable()
    {
#if UNITY_EDITOR
      if (!EditorApplication.isPlayingOrWillChangePlaymode)
        return;
#endif

      helpers.Add(GetInstanceID(), (ModelComposer) Delegate.CreateDelegate(typeof(ModelComposer), null, GetType().GetMethod(name.Substring(5).Replace(" ", string.Empty), BindingFlags.Static | BindingFlags.Public)));
    }

    protected override void OnDisable()
    {
      helpers.Clear();
    }
  }
}