//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Linq;
using UnityEditor;


namespace Pixeye.Actors
{
  /// <summary>
  /// Adds the given define symbols to PlayerSettings define symbols.
  /// Just add your own define symbols to the Symbols property at the below.
  /// </summary>
  [InitializeOnLoad]
  public class PostHandleSymbols : Editor
  {
    /// <summary>
    /// Add define symbols as soon as Unity gets done compiling.
    /// </summary>
    static PostHandleSymbols()
    {
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
      var str = string.Empty;

      if (DataFramework.sizeTags == 24)
      {
        str = "ACTORS_TAGS_24";
      }
      else if (DataFramework.sizeTags == 12)
      {
        str = "ACTORS_TAGS_12";
      }
      else if (DataFramework.sizeTags == 6)
      {
        str = "ACTORS_TAGS_6";
      }
       


      if (index > -1)
      {
        allDefines[index] = str;
      }
      else allDefines.Add(str);


      index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS_CHECKS"));

      str = DataFramework.tagsCheck ? "ACTORS_TAGS_CHECKS" : string.Empty;
      if (index > -1)
      {
        allDefines[index] = str;
      }
      else
      {
        allDefines.Add(str);
      }

      index = allDefines.FindIndex(d => d.Contains("ACTORS_COMPONENTS_STRUCTS"));

      str = DataFramework.onStructs ? "ACTORS_COMPONENTS_STRUCTS" : string.Empty;
      if (index > -1)
      {
        allDefines[index] = str;
      }
      else
      {
        allDefines.Add(str);
      }

      index = allDefines.FindIndex(d => d.Contains("ACTORS_EVENTS_MANUAL"));

      str = DataFramework.eventsManual ? "ACTORS_EVENTS_MANUAL" : string.Empty;
      if (index > -1)
      {
        allDefines[index] = str;
      }
      else
      {
        allDefines.Add(str);
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
  }
}