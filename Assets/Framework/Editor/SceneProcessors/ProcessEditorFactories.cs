//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games


using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using static System.Char;
using Object = UnityEngine.Object;

namespace Pixeye
{
	public class ProcessEditorFactories : EndNameEditAction
	{
		public const string PATH_TO_TEMPLATE = @"Assets\Source\Editor\Templates\TmpFactory.txt";
		const int MENU_ITEM_PRIORITY = 0;
		static Texture2D scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);

		[MenuItem("Tools/Actors/Add/Factory", false, MENU_ITEM_PRIORITY)]
		public static void CreateSample()
		{
			var path = EditorGenerator.GetPath();
			if (path == string.Empty)
				path = PATH_TO_TEMPLATE;
			else path = string.Format($"{path}/Editor/Templates/TmpFactory.txt");

			CreateFromTemplate("FactoryDefault.cs", path);
		}

		public static void CreateFromTemplate(string name, string pathName)
		{
			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
					0,
					CreateInstance<ProcessEditorFactories>(),
					name,
					scriptIcon,
					pathName);
		}

		public static object CreateScript(string pathName, string templatePath)
		{
			var filePath = Path.GetFullPath(pathName);

			var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
			var className                = fileNameWithoutExtension.Replace(" ", string.Empty);
			var templateContents         = string.Empty;

			if (!File.Exists(templatePath)) return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
			using (var t = new StreamReader(templatePath))
			{
				t.ReadLine();
				templateContents = t.ReadToEnd();
			}

			templateContents = templateContents.Replace("##NAME##", className);

			var n = className.Replace("Factory", "");

			n = ToUpperInvariant(n[0]) + n.Substring(1);

			templateContents = templateContents.Replace("&NAME&", n);

			var encoding = new UTF8Encoding(true, false);

			using (var tc = new StreamWriter(filePath, false, encoding))
			{
				tc.Write(templateContents);
			}


			AssetDatabase.ImportAsset(pathName);
			AssetDatabase.Refresh();


			return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
		}

		public override void Action(int instanceId, string pathName, string resourceFile)
		{
			var o = CreateScript(pathName, resourceFile);
			ProjectWindowUtil.ShowCreatedAsset((Object) o);
			AssetDatabase.Refresh();
		}
	}
}