using System.IO;
using System.Text;
using System.Xml;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using static System.Char;

public class ProdessingEditorSystems :  EndNameEditAction
{

    public const string PATH_TO_TEMPLATE = @"Assets\[0]Framework\Editor\Template\ProcessingTemplate.txt";
    private const int MENU_ITEM_PRIORITY = 60;
    private static Texture2D scriptIcon = (EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D);

    [MenuItem("Assets/Create/ActorsTemplate/ProcessingDefault", false, MENU_ITEM_PRIORITY)]
    [MenuItem("Tools/Actors/Add/Processing", false, MENU_ITEM_PRIORITY)]
    public static void CreateSample()
    {
        CreateFromTemplate("Processing.cs", PATH_TO_TEMPLATE);
    }

    public static void CreateFromTemplate(string name, string pathName)
    {
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
            0,
            CreateInstance<ProdessingEditorSystems>(),
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
        string ProgectName = "";

        //loading of the runtime settings from the xml file
        string xmlPath = @"Assets\[0]Framework\Editor\Template\Settings.xml";
        if (File.Exists(xmlPath))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            ProgectName = xmlDoc.SelectSingleNode("Settings/namespace").InnerText;
        }

        if (!File.Exists(templatePath)) return (MonoScript)AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
        using (var t = new StreamReader(templatePath))
        {
            t.ReadLine();
            templateContents = t.ReadToEnd();
        }

        templateContents = templateContents.Replace("##NAME##", className);

        var n = className.Replace("Processing", "");

        n = ToLowerInvariant(n[0]) + n.Substring(1);

        //name of the project
        if (ProgectName == "" || ProgectName == "None")
        {
            templateContents = templateContents.Replace("&NameSpace&", "");
            n = templateContents.Replace("&NameSpaceEnd&", "");
        }
        else
        {
            templateContents = templateContents.Replace("&NameSpace&", "namespace " + ProgectName + "\n {");
            n = templateContents.Replace("&NameSpaceEnd&", "}");
        }

        var encoding = new UTF8Encoding(true, false);

        using (var tc = new StreamWriter(filePath, false, encoding))
        {
            tc.Write(n);
        }


        AssetDatabase.ImportAsset(pathName);
        AssetDatabase.Refresh();


        return (MonoScript)AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
    }

    public override void Action(int instanceId, string pathName, string resourceFile)
    {
        var o = CreateScript(pathName, resourceFile);
        ProjectWindowUtil.ShowCreatedAsset((Object)o);
        AssetDatabase.Refresh();
    }
}
