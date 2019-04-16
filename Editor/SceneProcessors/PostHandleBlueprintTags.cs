//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	public static class PostHandleBlueprintTags
	{

		public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpBlueprintTags.txt";

		const int MENU_ITEM_PRIORITY = 0;
 

		public static void Generate()
		{
			var path = HelperFramework.GetPathLibrary();
			if (path == string.Empty)
				path = PATH_TO_TEMPLATE;
			else path = string.Format($"{path}/Editor/Templates/TmpBlueprintTags.txt");

	 
			var o = CreateScript(string.Format($"{Application.dataPath}/Source/Runtime/Tags/bp.cs"), path);
			ProjectWindowUtil.ShowCreatedAsset((Object) o);
			AssetDatabase.Refresh();
		}

		public static object CreateScript(string pathName, string templatePath)
		{
			var filePath                 = Path.GetFullPath(pathName);
		 
			var templateContents = string.Empty;

			if (!File.Exists(templatePath)) return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
			using (var t = new StreamReader(templatePath))
			{
				t.ReadLine();
				templateContents = t.ReadToEnd();
			}

			var encoding = new UTF8Encoding(true, false);

			using (var tc = new StreamWriter(filePath, false, encoding))
			{
				tc.Write(templateContents);
			}

			AssetDatabase.ImportAsset(pathName);
			AssetDatabase.Refresh();

			return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
		}

	}
}