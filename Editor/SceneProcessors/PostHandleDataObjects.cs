//  Project : ecs
// Contacts : Pix - ask@pixeye.games

//#if ODIN_INSPECTOR
//using System.IO;
//using UnityEditor;
//using UnityEditor.ProjectWindowCallback;
//using UnityEngine;
//
//namespace Pixeye.Framework
//{
//	public class PostHandleDataObjects : EndNameEditAction
//	{
//
//		const int MENU_ITEM_PRIORITY = 1;
//		static Texture2D scriptIcon;
//
//		public override void OnEnable()
//		{
//			base.OnEnable();
//			scriptIcon = EditorGUIUtility.IconContent("ScriptableObject Icon").image as Texture2D;
//		}
//
//		[MenuItem("Assets/Create/Actors/Add/Data/Object", false, MENU_ITEM_PRIORITY)]
//		static void Add()
//		{
//			CreateFromTemplate("Data.asset", HelperEditor.GetSelectedPathOrFallback());
//		}
//
//		static void CreateFromTemplate(string name, string path)
//		{
//			ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, CreateInstance<PostHandleDataObjects>(), name, scriptIcon, path);
//		}
//
//		static DataObject Create(string pathName, string templatePath)
//		{
//			DataObject instance;
//
//			if (!File.Exists(templatePath))
//			{
//				instance = CreateInstance<DataObject>();
//				AssetDatabase.CreateAsset(instance, pathName);
//			}
//
//			else
//			{
//				AssetDatabase.ImportAsset(pathName);
//				AssetDatabase.Refresh();
//				instance = AssetDatabase.LoadAssetAtPath<DataObject>(pathName);
//			}
//
//			return instance;
//		}
//
//		public override void Action(int instanceId, string name, string resourceFile)
//		{
//			var o = Create(name, resourceFile);
//			AssetDatabase.SetLabels(o, new[] {"DataObject", "Entity"});
//			ProjectWindowUtil.ShowCreatedAsset(o);
//			AssetDatabase.Refresh();
//		}
//
//	}
//}
//#endif