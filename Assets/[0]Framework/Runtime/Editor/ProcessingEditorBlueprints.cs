//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/21/2018

using System.IO;
using System.Text;
 
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using static System.Char;
using Object = UnityEngine.Object;
 

public class ProcessingEditorBlueprints : EndNameEditAction
{
    public const string PATH_TO_TEMPLATE = @"Assets\[0]Framework\Runtime\LibBlueprints\BlueprintTemplate.txt";
    private const int MENU_ITEM_PRIORITY = 70;
    private static Texture2D scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);

    [MenuItem("Tools/Actors/Add/Blueprint", false, MENU_ITEM_PRIORITY)]
    public static void CreateBlueprint()
    {
        CreateFromTemplate("BlueprintDefault.cs", PATH_TO_TEMPLATE);
    }


    public static void CreateFromTemplate(string name, string pathName)
    {
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
            0,
            CreateInstance<ProcessingEditorBlueprints>(),
            name,
            scriptIcon,
            pathName);
    }

    public static object CreateScript(string pathName, string templatePath)
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

        templateContents = templateContents.Replace("##NAME##", className);
   
        var n = className.Replace("Blueprint", "");
       
        n = ToUpperInvariant(n[0]) + n.Substring(1);
  
        templateContents = templateContents.Replace("&NAME&", n );

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