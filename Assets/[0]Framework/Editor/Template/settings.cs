using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEditor;
using UnityEngine;

//template genent settings
public class settings : EditorWindow
{

    public static string nameProgect;
    public static string xmlPath = @"Assets\[0]Framework\Editor\Template\Settings.xml";
    public static XmlDocument xmlDoc = new XmlDocument();

    //creating the settings window
    [MenuItem("Tools/Actors/Settings")]
    public static void ShowWindow()
    {
        GetWindow<settings>(false, "Settings", true);
        Debug.Log("Settings");

        //check for xml file
        if (!File.Exists(xmlPath)) CreateFile(xmlPath);
        {
            xmlDoc.Load(xmlPath);
            nameProgect = xmlDoc.SelectSingleNode("Settings/namespace").InnerText;
        }
    }

    void OnGUI()
    {

        nameProgect = EditorGUILayout.TextField("NameSpace: ", nameProgect);

        //save the settings to a file
        if (GUILayout.Button("Save Settings!"))
        {
            Debug.Log("Save Settings!");
            xmlDoc.Load(xmlPath);
            nameProgect = xmlDoc.SelectSingleNode("Settings/namespace").InnerText = nameProgect;
            xmlDoc.Save(xmlPath);
            AssetDatabase.Refresh();
        }
    }
    // creating xml file
    static void CreateFile(string xmlPath)
    {
        XmlNode MainNode = xmlDoc.CreateElement("Settings");
        xmlDoc.AppendChild(MainNode);

        XmlNode Node;

        Node = xmlDoc.CreateElement("namespace");
        Node.InnerText = "None";
        Node.AppendChild(Node);

        xmlDoc.Save(xmlPath);

        AssetDatabase.Refresh();

    }
}
