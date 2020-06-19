//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class PostHandleFrameworkPatch
  {


    static void ExecuteWithLocks(string path)
    {
    
      if (!File.Exists(path)) return;

      string text = String.Empty;
      using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
      {
        text = sr.ReadToEnd();
      }

      var lines = text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();


      var len             = lines.Count;
      var lineIndexBegin  = -1;
      var lineIndexFinish = -1;
      var hash            = string.Empty;
      for (int i = 0; i < len; i++)
      {
        var line = lines[i];

        if (line.Contains("\"com.pixeye.ecs\": {"))
        {
          lineIndexBegin = i;
      
        }
        if (lineIndexBegin != -1 && line.Contains("hash"))
        {
          hash = line;
        }
        if (lineIndexBegin != -1 && line.Contains("},"))
        {
          lineIndexFinish = i;
        }

        if (lineIndexBegin != -1 && i == lineIndexFinish + 1)
        {
          break;
        }
      }
 
      lines.RemoveRange(lineIndexBegin, lineIndexFinish+1);
      
      len = lines.Count;
      using (StreamWriter sr = new StreamWriter(path))
      {
        for (int i = 0; i < len; i++)
          sr.WriteLine(lines[i]);
      }
       
      hash = hash.Replace("\"hash\":", "").Trim(new Char[] { ' ', '"' });
      Debug.Log($"<b><size=14>Updating Actors to:</size></b>\nhttps://github.com/PixeyeHQ/actors.unity/tree/{hash}");

      AssetDatabase.Refresh(ImportAssetOptions.Default);
    }
    
#if UNITY_2019_4_OR_NEWER
    [MenuItem("Tools/Actors/Update Actors", priority = -300)]
    public static void ShowWindow()
    {
      var path_locks = Path.GetDirectoryName(Application.dataPath) + @"\Packages\packages-lock.json";
      ExecuteWithLocks(path_locks);
    }
#else
    [MenuItem("Tools/Actors/Update Actors", priority = -300)]
    public static void ShowWindow()
    {
      var path = Path.GetDirectoryName(Application.dataPath) + @"\Packages\manifest.json";
      var path_locks = Path.GetDirectoryName(Application.dataPath) + @"\Packages\packages-lock.json";

      if (File.Exists(path_locks))
      {
        ExecuteWithLocks(path_locks);
        return;
      }

      if (!File.Exists(path)) return;

      string text = String.Empty;
      using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
      {
        text = sr.ReadToEnd();
      }


      var lines = text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();

      var lineIndex = -1;
      var len = lines.Count;
      for (int i = 0; i < len; i++)
      {
        var line = lines[i];

        if (!line.Contains("\"lock\": {")) continue;

        lineIndex = i;
        break;
      }

      lines[lineIndex - 1] = "}";
      lines.RemoveRange(lineIndex, lines.Count - 1 - lineIndex);

      len = lines.Count;
      using (StreamWriter sr = new StreamWriter(path))
      {
        for (int i = 0; i < len; i++)
          sr.WriteLine(lines[i]);
      }

      AssetDatabase.Refresh(ImportAssetOptions.Default);
    }
#endif
  }
}