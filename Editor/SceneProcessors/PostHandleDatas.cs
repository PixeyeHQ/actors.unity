//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games
//#if ODIN_INSPECTOR
//using System.IO;
//using System.Text;
//using UnityEditor;
//using UnityEditor.ProjectWindowCallback;
//using UnityEngine;
//using static System.Char;
//
//namespace Pixeye.Framework
//{
//	public class PostHandleDatas : EndNameEditAction
//	{
//
//		public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpData.txt";
//		const int MENU_ITEM_PRIORITY = 0;
//		static Texture2D scriptIcon;
//
//		
//		public override void OnEnable()
//		{
//			base.OnEnable();
//			scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);
//		}
//		
//		[MenuItem("Assets/Create/Actors/Generate/Data", false, MENU_ITEM_PRIORITY)]
//		public static void CreateSample()
//		{
//			var path = HelperFramework.GetPathLibrary();
//			if (path == string.Empty)
//				path = PATH_TO_TEMPLATE;
//			else path = string.Format($"{path}/Editor/Templates/TmpData.txt");
//
//			CreateFromTemplate("DataDefault.cs", path);
//		}
//
//		public static void CreateFromTemplate(string name, string pathName)
//		{
//			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
//					0,
//					CreateInstance<PostHandleDatas>(),
//					name,
//					scriptIcon,
//					pathName);
//		}
//
//		public static object CreateScript(string pathName, string templatePath)
//		{
//			var filePath                 = Path.GetFullPath(pathName);
//			var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
//			var className                = fileNameWithoutExtension.Replace(" ", string.Empty);
//			var templateContents         = string.Empty;
//
//			if (!File.Exists(templatePath)) return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
//			using (var t = new StreamReader(templatePath))
//			{
//				t.ReadLine();
//				templateContents = t.ReadToEnd();
//			}
//
//			
//			var newNam = className.Insert(4, " ");
//
//			templateContents = templateContents.Replace("##NAME##", className);
//			templateContents = templateContents.Replace("##NAME FILE##", newNam);
//			var n = className.Replace("Data", "");
//
//			n = $"{ToUpperInvariant(n[0])}{n.Substring(1)}";
//
//			n = templateContents.Replace("&NAME&", n);
//	 
//			var encoding = new UTF8Encoding(true, false);
//
//			using (var tc = new StreamWriter(filePath, false, encoding))
//			{
//				tc.Write(n);
//			}
//
//			AssetDatabase.ImportAsset(pathName);
//			AssetDatabase.Refresh();
//
//			return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
//		}
//
//		public override void Action(int instanceId, string pathName, string resourceFile)
//		{
//			var o = CreateScript(pathName, resourceFile);
//			ProjectWindowUtil.ShowCreatedAsset((Object) o);
//			AssetDatabase.Refresh();
//		}
//
//	}
//}
//#endif