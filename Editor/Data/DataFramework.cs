//  Project : Actors
// Contacts : Pixeye - ask@pixeye.games

#if UNITY_EDITOR
using System.IO;
using UnityEditor;


namespace Pixeye.Actors
{
  static class DataFramework
  {
    

    public static bool eventsManual
    {
      get => EditorPrefs.GetBool("hba.data.eventsManual", false);
      set => EditorPrefs.SetBool("hba.data.eventsManual", value);
    }

    public static bool onStructs
    {
      get => EditorPrefs.GetBool("hba.data.onStructs", false);
      set => EditorPrefs.SetBool("hba.data.onStructs", value);
    }

    public static bool tagsCheck
    {
      get => EditorPrefs.GetBool("hba.data.tagsCheck", true);
      set => EditorPrefs.SetBool("hba.data.tagsCheck", value);
    }

    public static int sizeTags
    {
      get => EditorPrefs.GetInt("hba.data.tags", 6);
      set => EditorPrefs.SetInt("hba.data.tags", value);
    }

    public static string nameSpace
    {
      get => EditorPrefs.GetString("hba.data.namespace", "Game.Source");
      set => EditorPrefs.SetString("hba.data.namespace", value);
    }

    public static string pathPrefabsEditor
    {
      get => EditorPrefs.GetString("hba.path.prefabs", "");
      set => EditorPrefs.SetString("hba.path.prefabs", value);
    }

    public static string pathTagsEditor
    {
      get => EditorPrefs.GetString("hba.path.tags", @"\Assets\Runtime\Tags");
      set => EditorPrefs.SetString("hba.path.tags", value);
    }

    public static string pathTags => Directory.GetCurrentDirectory() +
                                     EditorPrefs.GetString("hba.path.tags", @"\Assets\Runtime\Tags");
  }
}

#endif