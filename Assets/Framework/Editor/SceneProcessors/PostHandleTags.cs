using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using UnityEditor;

/// Contributor : Dark-A-l https://github.com/Dark-A-l
namespace Pixeye.Framework
{
	public class PostHandleTags
	{

		static int lastIndex;
		static List<int> idTags = new List<int>(50);
		static List<int> freeIdTags = new List<int>(50);

		static bool isReset;

		static readonly string debugLog1 = "Two or more tags use one ID: <color=red>{0}</color>";
		static readonly string debugLog2 = "Tags amount: {0} Last ID: <color=#66cc33ff>{1}</color>";

		//	static string pathWithMeta => DataFramework.pathTags + DataFramework.pathTagsMeta;
		static string path => DataFramework.pathTags;

		[MenuItem("Tools/Actors/Tags/Size/24 Tags", false, 0)]
		static public void Set24()
		{
			DataFramework.sizeTags = 24;
			string       definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
			List<string> allDefines    = definesString.Split(';').ToList();

		  var index =	allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
		  allDefines[index] = "ACTORS_TAGS_24";
		  PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup,string.Join(";", allDefines.ToArray()));

//			allDefines.AddRange(Symbols.Except(allDefines));
//			PlayerSettings.SetScriptingDefineSymbolsForGroup(
//					EditorUserBuildSettings.selectedBuildTargetGroup,
//					string.Join(";", allDefines.ToArray()));
		}
		
		[MenuItem("Tools/Actors/Tags/Size/12 Tags", false, 0)]
		static public void Set12()
		{
			DataFramework.sizeTags = 12;
			string       definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
			List<string> allDefines    = definesString.Split(';').ToList();

			var index =	allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
			allDefines[index] = "ACTORS_TAGS_12";
			PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup,string.Join(";", allDefines.ToArray()));
		}
		
		[MenuItem("Tools/Actors/Tags/Size/6 Tags", false, 0)]
		static public void Set6()
		{
			DataFramework.sizeTags = 6;
			string       definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
			List<string> allDefines    = definesString.Split(';').ToList();

			var index =	allDefines.FindIndex(d => d.Contains("ACTORS_TAGS"));
			allDefines[index] = "ACTORS_TAGS_6";
			PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup,string.Join(";", allDefines.ToArray()));
		}
		
		
		[MenuItem("Tools/Actors/Tags/Register", false, 1)]
		static public void Execute()
		{
			Init();
			TagRegist();
		}

		[MenuItem("Tools/Actors/Tags/Reset/Reset And Register", false, 1)]
		static public void ExecuteResetAndRegistration()
		{
			isReset = true;
			lastIndex = 0;
			TagRegist();
		}

		[MenuItem("Tools/Actors/Tags/Reset/Reset", false, 1)]
		static public void ExecuteReset()
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
					using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
					{
						lastIndex = int.Parse(sr.ReadLine());
						while (!sr.EndOfStream)
						{
							var str = sr.ReadLine();
							var e   = int.Parse(str);
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

//		static void Save()
//		{
//			StreamWriter sr;
//			if (!File.Exists(pathWithMeta))
//			{
//				sr = File.CreateText(pathWithMeta);
//			}
//			else
//			{
//				sr = new StreamWriter(pathWithMeta, false, System.Text.Encoding.Default);
//			}
//
//			using (sr)
//			{
//				sr.WriteLine(lastIndex);
//				for (int i = 0; i < freeIdTags.Count; i++)
//				{
//					sr.WriteLine(freeIdTags[i]);
//				}
//			}
//		}

		static void TagRegist()
		{
			string[] Files = Directory.GetFiles(path, "*.cs");
			int      count = 0;
			for ( int f = 0; f < Files.Length; f++ )
			{
				var    readPath = Files[f];
				string text     = String.Empty;
				try
				{
					using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
					{
						text = sr.ReadToEnd();
					}

					var lines = text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
					for ( int i = 0; i < lines.Length; i++ )
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

					using (StreamWriter sw = new StreamWriter(readPath, false, System.Text.Encoding.Default))
					{
						foreach ( var item in lines )
							sw.WriteLine(item);
					}
				}
				catch (Exception e)
				{
					Debug.Log(e.Message);
				}
			}

			for ( int i = 1; i <= lastIndex; i++ )
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