//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Pixeye
{
	public static class EditorGenerator
	{
		public static string GetPath()
		{
			var path = Application.dataPath;
			path = String.Format($"{path.Remove(path.LastIndexOf("/"))}/Library/PackageCache");
			var dir = Directory.GetDirectories(path).Where(s => s.Contains("com.pixeye.ecs")).ToArray();

			return dir.Length == 0 ? string.Empty : dir[0];
		}
	}
}