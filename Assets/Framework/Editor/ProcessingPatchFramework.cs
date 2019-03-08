//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
 
public static class ProcessingPatchFramework
{
	[MenuItem("Tools/Actors/Update Framework [GIT]", priority = -10)]
	public static void ShowWindow()
	{
		var path = Path.GetDirectoryName(Application.dataPath) + @"\Packages\manifest.json";


		if (!File.Exists(path)) return;

		string text = String.Empty;
		using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
		{
			text = sr.ReadToEnd();
		}


		var lines = text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();

		var lineIndex = -1;
		var len       = lines.Count;
		for (int i = 0; i < len; i++)
		{
			var line = lines[i];

			if (!line.Contains("\"lock\": {")) continue;

			lineIndex = i;
			break;
		}

		lines[lineIndex-1] = "}";
		lines.RemoveRange(lineIndex, lines.Count-1-lineIndex);
  
		len = lines.Count;
		using (StreamWriter sr = new StreamWriter(path))
		{
			for (int i = 0; i < len; i++)
				sr.WriteLine(lines[i]);
		}

		AssetDatabase.Refresh(ImportAssetOptions.Default);

	}
}