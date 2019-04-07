//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#if ODIN_INSPECTOR
using System.IO;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

namespace Pixeye.Framework
{
	public class PostHandleBlueprintEntities : EndNameEditAction
	{
  
		const int MENU_ITEM_PRIORITY = 1;
		static Texture2D scriptIcon;

		public override void OnEnable()
		{
			base.OnEnable();
			scriptIcon = EditorGUIUtility.IconContent("ScriptableObject Icon").image as Texture2D;
		}
		[MenuItem("Assets/Create/Actors Framework/Add/Blueprints/Entity", false, MENU_ITEM_PRIORITY)]
		static void Add()
		{
			CreateFromTemplate("Blueprint.asset", HelperEditor.GetSelectedPathOrFallback());
		}

		static void CreateFromTemplate(string name, string path)
		{
			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, CreateInstance<PostHandleBlueprintEntities>(), name, scriptIcon, path);
		}

		static BlueprintEntity Create(string pathName, string templatePath)
		{
			BlueprintEntity instance;

			if (!File.Exists(templatePath))
			{
				instance = CreateInstance<BlueprintEntity>();
				AssetDatabase.CreateAsset(instance, pathName);
			}

			else
			{
				AssetDatabase.ImportAsset(pathName);
				AssetDatabase.Refresh();
				instance = AssetDatabase.LoadAssetAtPath<BlueprintEntity>(pathName);
			}

 

			return instance;
		}

		public override void Action(int instanceId, string name, string resourceFile)
		{
			var o = Create(name, resourceFile);
			AssetDatabase.SetLabels(o, new[] {"Blueprint", "Entity"});
			ProjectWindowUtil.ShowCreatedAsset(o);
			AssetDatabase.Refresh();
		}

		 

	}
}
#else

using System.IO;
using System.Text;
using Pixeye.Framework;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using static System.Char;

namespace Pixeye
{
	public class PostHandleBlueprintEntities : EndNameEditAction
	{

		public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpBlueprint.txt";
		const int MENU_ITEM_PRIORITY = 0;
		static Texture2D scriptIcon;

		public override void OnEnable()
		{
			base.OnEnable();
			scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);
		}
		[MenuItem("Assets/Create/Actors Framework/Generate/Blueprint", false, MENU_ITEM_PRIORITY)]
		public static void CreateSample()
		{
			var path = HelperFramework.GetPathLibrary();
			if (path == string.Empty)
				path = PATH_TO_TEMPLATE;
			else path = string.Format($"{path}/Editor/Templates/TmpBlueprint.txt");

			CreateFromTemplate("BlueprintDefault.cs", path);
		}

		public static void CreateFromTemplate(string name, string pathName)
		{
			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
					0,
					CreateInstance<PostHandleBlueprintEntities>(),
					name,
					scriptIcon,
					pathName);
		}

		public static Object CreateScript(string pathName, string templatePath)
		{
			var filePath = Path.GetFullPath(pathName);
			var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
			var className = fileNameWithoutExtension.Replace(" ", string.Empty);
			var templateContents = string.Empty;

			if (!File.Exists(templatePath)) return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
			using (var t = new StreamReader(templatePath))
			{
				t.ReadLine();
				templateContents = t.ReadToEnd();
			}

			var newNam = className.Insert(9, " ");

			templateContents = templateContents.Replace("##NAME##", className);
			templateContents = templateContents.Replace("##NAME FILE##", newNam);
			var n = className.Replace("Blueprint", "");

			n = $"{ToUpperInvariant(n[0])}{n.Substring(1)}";

			n = templateContents.Replace("&NAME&", n);

			var encoding = new UTF8Encoding(true, false);

			using (var tc = new StreamWriter(filePath, false, encoding))
			{
				tc.Write(n);
			}

			AssetDatabase.ImportAsset(pathName);
			AssetDatabase.Refresh();

			return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
		}

		public override void Action(int instanceId, string pathName, string resourceFile)
		{
			var o = CreateScript(pathName, resourceFile);
			ProjectWindowUtil.ShowCreatedAsset(o);
			AssetDatabase.Refresh();
		}

	}
}
#endif