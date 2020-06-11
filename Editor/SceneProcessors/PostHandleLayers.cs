//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.IO;
using System.Text;

using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEditor.SceneManagement;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Actors
{
  public class PostHandleLayer : EndNameEditAction
  {
    public const string PATH_TO_TEMPLATE = @"Assets\Actors\Editor\Templates\TmpLayer.txt";
    const int MENU_ITEM_PRIORITY = 0;
    static Texture2D scriptIcon;

    public override void OnEnable()
    {
      base.OnEnable();
      scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);
    }

    [MenuItem("Assets/Create/Actors/Layer", false, -1)]
    public static void CreateSample()
    {
      var path = HelperEditor.GetPathLibrary();

      if (path == string.Empty)
        path = PATH_TO_TEMPLATE;
      else
        path = string.Format($"{path}/Editor/Templates/TmpLayer.txt");

      CreateFromTemplate("LayerDefault.cs", path);
    }

    public static void CreateFromTemplate(string name, string pathName)
    {
      ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
        0,
        CreateInstance<PostHandleLayer>(),
        name,
        scriptIcon,
        pathName);
    }

    public static Object CreateScript(string pathName, string templatePath)
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

      templateContents = templateContents.Replace("##NAMESPACE##",
        string.Format($"{Environment.NewLine}namespace {DataFramework.nameSpace}"));
      templateContents = templateContents.Replace("##NAME##", className);

      var encoding = new UTF8Encoding(true, false);

      using (var tc = new StreamWriter(filePath, false, encoding))
      {
        tc.WriteLine(templateContents);
      }

      AssetDatabase.ImportAsset(pathName, ImportAssetOptions.ForceUpdate);
      AssetDatabase.Refresh();

      return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
    }

    public override void Action(int instanceId, string pathName, string resourceFile)
    {
      var o = CreateScript(pathName, resourceFile);
      AssetDatabase.SetLabels(o, new[] {"Layer"});


      var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(pathName);
      var className                = fileNameWithoutExtension.Replace(" ", string.Empty);
      className = className.Replace("Layer", "");

      // DataFramework.nextLayerPath = pathName;
      AssetDatabase.ImportAsset(pathName, ImportAssetOptions.ForceUpdate);
      ProjectWindowUtil.ShowCreatedAsset(o);
      AssetDatabase.Refresh();

      ProcEditorSceneObserve.name   = $"Assets/Scenes/Scene {className}.unity";
     // ProcEditorSceneObserve.script = o as MonoScript;

      EditorSceneManager.newSceneCreated += ProcEditorSceneObserve.SceneCreating;
      const NewSceneSetup setup = NewSceneSetup.EmptyScene;
      var                 scene = EditorSceneManager.NewScene(setup);
      EditorSceneManager.SaveScene(scene, ProcEditorSceneObserve.name);
 
    }
  }
}