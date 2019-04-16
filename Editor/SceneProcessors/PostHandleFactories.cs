//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games

using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using static System.Char;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	public class PostHandleFactories : EndNameEditAction
	{

		public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpFactory.txt";
		const int MENU_ITEM_PRIORITY = 0;
		static Texture2D scriptIcon;

		public override void OnEnable()
		{
			base.OnEnable();
			scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);
		}

		[MenuItem("Assets/Create/Actors/Generate/Factory", false, MENU_ITEM_PRIORITY)]
		public static void CreateSample()
		{
			var path = HelperFramework.GetPathLibrary();
			if (path == string.Empty)
				path = PATH_TO_TEMPLATE;
			else path = string.Format($"{path}/Editor/Templates/TmpFactory.txt");

			CreateFromTemplate("FactoryDefault.cs", path);
		}

		public static void CreateFromTemplate(string name, string pathName)
		{
			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
					0,
					CreateInstance<PostHandleFactories>(),
					name,
					scriptIcon,
					pathName);
		}

		public static object CreateScript(string pathName, string templatePath)
		{
			var filePath                 = Path.GetFullPath(pathName);
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