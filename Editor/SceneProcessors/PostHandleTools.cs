using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Reflection;
using UnityEditor;

/// Contributor : Dark-A-l https://github.com/Dark-A-l

namespace Pixeye.Actors
{
  [InitializeOnLoad]
  public class PostHandleTags
  {
    static int lastIndex;
    static readonly List<int> idTags = new List<int>(50);
    static readonly List<int> freeIdTags = new List<int>(50);

    static bool isReset;

    static readonly string debugLog1 = "Two or more tags use one ID: <color=red>{0}</color>";
    static readonly string debugLog2 = "Tags amount: {0} Last ID: <color=#66cc33ff>{1}</color>";


    static string path => DataFramework.pathTags;


    internal static List<Type> tagTypes = new List<Type>();

    static PostHandleTags()
    {
    }

#if !ACTORS_EVENTS_MANUAL

    [MenuItem("Tools/Actors/Set Manual Events", false, 2)]
    public static void SetManualEvents()
    {
      DataFramework.eventsManual = true;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_EVENTS_MANUAL"));
      if (index == -1)
      {
        allDefines.Add("ACTORS_EVENTS_MANUAL");
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }

#else
    [MenuItem("Tools/Actors/Set Auto Events", false, 2)]
    public static void SetNoManualEvents()
    {
      DataFramework.eventsManual = false;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_EVENTS_MANUAL"));
      if (index != -1)
      {
        allDefines[index] = string.Empty;
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#endif


#if !ACTORS_COMPONENTS_STRUCTS
    [MenuItem("Tools/Actors/Set Struct Components", false, 2)]
    public static void SetStructsChecks()
    {
      DataFramework.onStructs = true;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_COMPONENTS_STRUCTS"));
      if (index == -1)
      {
        allDefines.Add("ACTORS_COMPONENTS_STRUCTS");
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#else
    [MenuItem("Tools/Actors/Set Class Components", false, 2)]
    public static void SetNoStructsChecks()
    {
      DataFramework.onStructs = false;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_COMPONENTS_STRUCTS"));
      if (index != -1)
      {
        allDefines[index] = string.Empty;
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#endif

    [MenuItem("Tools/Actors/Tags", true, 50)]
    public static void Tags()
    {
    }

#if ACTORS_TAGS_CHECKS
    [MenuItem("Tools/Actors/Tags/Remove Tag Checks", false, -100)]
    public static void SetNoChecks()
    {
      DataFramework.tagsCheck = false;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS_CHECKS"));
      if (index != -1)
      {
        allDefines[index] = string.Empty;
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#else
    [MenuItem("Tools/Actors/Tags/Set Tag Checks", false, 0)]
    public static void SetChecks()
    {
      DataFramework.tagsCheck = true;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS_CHECKS"));
      if (index == -1)
      {
        allDefines.Add("ACTORS_TAGS_CHECKS");
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#endif


    [MenuItem("Tools/Actors/Tags/Size/24 Tags", false, 0)]
    public static void Set24()
    {
      DataFramework.sizeTags = 24;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
      allDefines[index] = "ACTORS_TAGS_24";
      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));

      //			allDefines.AddRange(Symbols.Except(allDefines));
      //			PlayerSettings.SetScriptingDefineSymbolsForGroup(
      //					EditorUserBuildSettings.selectedBuildTargetGroup,
      //					string.Join(";", allDefines.ToArray()));
    }

    [MenuItem("Tools/Actors/Tags/Size/12 Tags", false, 0)]
    public static void Set12()
    {
      DataFramework.sizeTags = 12;
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      List<string> allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
      allDefines[index] = "ACTORS_TAGS_12";
      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }

    [MenuItem("Tools/Actors/Tags/Size/6 Tags", false, 0)]
    public static void Set6()
    {
      DataFramework.sizeTags = 6;
      var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
      allDefines[index] = "ACTORS_TAGS_6";
      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
 
     

#if !ACTORS_DEBUG
    [MenuItem("Tools/Actors/Set Debug", false, 4)]
    public static void SetDebug()
    {
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_DEBUG"));
      if (index == -1)
      {
        allDefines.Add("ACTORS_DEBUG");
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }
#else
    [MenuItem("Tools/Actors/Set Release", false, 4)]
    public static void SetNoDebug()
    {
      string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
      var allDefines = definesString.Split(';').ToList();

      var index = allDefines.FindIndex(d => d.Contains("ACTORS_DEBUG"));
      if (index != -1)
      {
        allDefines[index] = string.Empty;
      }


      PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
    }

  #endif

    //	[MenuItem("Tools/Actors/Tags/Register", false, 1)]
    public static void Execute()
    {
      Init();
      TagRegist();
    }

    //	[MenuItem("Tools/Actors/Tags/Reset/Reset And Register", false, 1)]
    public static void ExecuteResetAndRegistration()
    {
      isReset = true;
      lastIndex = 0;
      TagRegist();
    }

    //	[MenuItem("Tools/Actors/Tags/Reset/Reset", false, 1)]
    public static void ExecuteReset()
    {
      isReset = true;
      lastIndex = 0;
    }

    static void Init()
    {
      try
      {
        if (File.Exists(path))
        {
          using (var sr = new StreamReader(path, System.Text.Encoding.Default))
          {
            lastIndex = int.Parse(sr.ReadLine());
            while (!sr.EndOfStream)
            {
              var str = sr.ReadLine();
              var e = int.Parse(str);
              freeIdTags.Add(e);
            }
          }
        }
      }
      catch (Exception e)
      {
        Debug.Log(e.Message);
      }
    }

    static void TagRegist()
    {
      var Files = Directory.GetFiles(path, "*.cs");
      int count = 0;
      for (int f = 0; f < Files.Length; f++)
      {
        var readPath = Files[f];
        string text = String.Empty;
        try
        {
          using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
          {
            text = sr.ReadToEnd();
          }

          var lines = text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
          for (int i = 0; i < lines.Length; i++)
          {
            var atr = lines[i].LastIndexOf('[');
            if (atr >= 0) continue;
            var ind = lines[i].LastIndexOf('=');
            if (ind <= 0) continue;

            if (lines[i][ind + 1] == ' ') ind += 2;
            else ind++;
            if (lines[i][ind] == '0' | isReset)
            {
              count++;
              // free id required
              int l_int = 0;
              if (freeIdTags.Count == 0)
              {
                do
                {
                  l_int = ++lastIndex;
                } while (idTags.Contains(l_int));
              }
              else
              {
                l_int = freeIdTags[0];
                freeIdTags.Remove(l_int);
              }

              lines[i] = lines[i].Remove(ind);
              lines[i] = lines[i].Insert(ind, l_int + ";");
              idTags.Add(l_int);
            }
            else
            {
              string line = lines[i].Substring(ind);
              line = line.Remove(line.LastIndexOf(';'));
              int idTag = int.Parse(line);
              if (idTags.Contains(idTag))
              {
                Debug.LogWarning(string.Format(debugLog1, idTag));
              }

              idTags.Add(idTag);
            }
          }

          using (var sw = new StreamWriter(readPath, false, System.Text.Encoding.Default))
          {
            foreach (var item in lines)
              sw.WriteLine(item);
          }
        }
        catch (Exception e)
        {
          Debug.Log(e.Message);
        }
      }

      for (int i = 1; i <= lastIndex; i++)
      {
        if (!idTags.Contains(i) & !freeIdTags.Contains(i))
          freeIdTags.Add(i);
      }

      if (idTags.Count > 0)
        Debug.Log(string.Format(debugLog2, idTags.Count, idTags[idTags.Count - 1]));

      isReset = false;
      idTags.Clear();
      freeIdTags.Clear();
    }
  }
}