//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Pixeye.Framework
{
	/// <summary>
	/// Adds the given define symbols to PlayerSettings define symbols.
	/// Just add your own define symbols to the Symbols property at the below.
	/// </summary>
	[InitializeOnLoad]
	public class PostHandleSymbols : Editor
	{

//		/// <summary>
//		/// Symbols that will be added to the editor
//		/// </summary>
//		public static readonly string[] Symbols =
//		{
////			"ACTORS_TAGS_24"
//		};

		/// <summary>
		/// Add define symbols as soon as Unity gets done compiling.
		/// </summary>
		static PostHandleSymbols()
		{
//		  string       definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
//			List<string> allDefines    = definesString.Split(';').ToList();
//			allDefines.AddRange(Symbols.Except(allDefines));
//			PlayerSettings.SetScriptingDefineSymbolsForGroup(
//					EditorUserBuildSettings.selectedBuildTargetGroup,
//					string.Join(";", allDefines.ToArray()));

			string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
			List<string> allDefines = definesString.Split(';').ToList();

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
			else
			{
				str = "ACTORS_TAGS_6";
			}

			if (index > -1)
			{
				allDefines[index] = str;
			}
			else allDefines.Add(str);

			PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, string.Join(";", allDefines.ToArray()));
		}

	}
}