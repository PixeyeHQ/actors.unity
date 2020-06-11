//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEditor;
using UnityEngine;


namespace Pixeye.Actors
{
  public class EditorWindowFramework : EditorWindow
  {
    [MenuItem("Tools/Actors/Preferences", priority = -200)]
    public static void ShowWindow()
    {
      GetWindow<EditorWindowFramework>(false, "Actors preferences");
    }

    void OnGUI()
    {
      DataFramework.nameSpace      = EditorGUILayout.TextField("Namespace: ", DataFramework.nameSpace);
      DataFramework.pathTagsEditor = EditorGUILayout.TextField("Tags path: ", DataFramework.pathTagsEditor);
    }
  }

#if !ODIN_INSPECTOR
  [InitializeOnLoad]
  public static class EditorFramework
  {
    internal static bool needToRepaint;

    internal static Event currentEvent;
    internal static float t;

    static EditorFramework()
    {
      EditorApplication.update += Updating;
    }


    static void Updating()
    {
      CheckMouse();

      if (needToRepaint)
      {
        t += UnityEngine.Time.deltaTime;

        if (t >= 0.3f)
        {
          t             -= 0.3f;
          needToRepaint =  false;
        }
      }
    }

    static void CheckMouse()
    {
      var ev = currentEvent;
      if (ev == null) return;

      if (ev.type == EventType.MouseMove)
        needToRepaint = true;
    }
  }
#endif
}