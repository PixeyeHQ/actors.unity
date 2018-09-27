using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEditor;
using UnityEngine;

//template genent settings
public class settings : EditorWindow
{

    static readonly int version = 100;

    // public static string nameProgect;

    public static string xmlPath = @"Assets\[0]Framework\Editor\Template\Settings.xml";
    public static XmlDocument xmlDoc = new XmlDocument();


    private Vector2 scrollViewVector = Vector2.zero;
    public Rect dropDownRect = new Rect(220, 10, 125, 300);
    public static string[] list = new string[6] { "None", "slot_1", "slot_2", "slot_3", "slot_4", "slot_5" };

    static int indexNumber;
    bool show = false;

    static int fileVersion;

   //creating the settings window
   [MenuItem("Tools/Actors/Settings")]
    public static void ShowWindow()
    {
        GetWindow<settings>(false, "Settings", true);
        Debug.Log("Settings");

        //check for xml file
        if (!File.Exists(xmlPath)) { CreateFile(xmlPath); Debug.Log("файл не найден");  }

        xmlDoc.Load(xmlPath);

        //checking the current version of the xml file
        if (xmlDoc.SelectSingleNode("Settings/Version") == null) { CreateFile(xmlPath);}
        else
        {
            fileVersion = int.Parse(xmlDoc.SelectSingleNode("Settings/Version").InnerText);
            if (fileVersion != version) { CreateFile(xmlPath);}
        }

        //index of the selected project name
        indexNumber = int.Parse(xmlDoc.GetElementsByTagName("namespace").Item(0).Attributes.Item(0).Value);

        //checking the list of project names
        var Index = xmlDoc.GetElementsByTagName("List");
        for (int i = 0; i < Index.Count; i++)
        {
            list[i] = Index[i].Attributes.Item(0).Value;
        }

    }

    void OnGUI()
    {

        GUI.Label(new Rect((dropDownRect.x - 180), dropDownRect.y, dropDownRect.width, 20), "NameSpace: ");

        if (GUI.Button(new Rect((dropDownRect.x - 100), dropDownRect.y, dropDownRect.width, 18), ""))
        {
            if (!show)
            {
                show = true;
            }
            else
            {
                show = false;
                RefreshList(indexNumber);
            }
        }
        //display the drop-down list
        if (show)
        {
            scrollViewVector = GUI.BeginScrollView(new Rect((dropDownRect.x - 100), (dropDownRect.y + 20), dropDownRect.width, dropDownRect.height), scrollViewVector, new Rect(0, 0, dropDownRect.width, Mathf.Max(dropDownRect.height, (list.Length * 25))));

            GUI.Box(new Rect(0, 0, dropDownRect.width, Mathf.Max(dropDownRect.height, (list.Length * 25))), "");

            for (int index = 0; index < list.Length; index++)
            {

                if (index != 0) list[index] = GUI.TextField(new Rect(0, (20 + index * 40), dropDownRect.height, 20), list[index], 25);

                if (GUI.Button(new Rect(0, (index * 40), dropDownRect.height, 20), ""))
                {
                    show = false;
                    indexNumber = index;
                    RefreshList(index);
                }
                GUI.Label(new Rect(5, (index * 40), dropDownRect.height, 20), list[index]);

            }

            GUI.EndScrollView();
        }
        else
        {
            GUI.Label(new Rect((dropDownRect.x - 95), dropDownRect.y, 300, 20), list[indexNumber]);
        }


    }

    // creating xml file
    static void CreateFile(string xmlPath)
    {
        xmlDoc = new XmlDocument();

        XmlNode Node;
        XmlAttribute attribute;

        XmlNode MainNode = xmlDoc.CreateElement("Settings");
        xmlDoc.AppendChild(MainNode);

        Node = xmlDoc.CreateElement("Version");
        Node.InnerText = version.ToString();
        MainNode.AppendChild(Node);

        Node = xmlDoc.CreateElement("namespace");
        Node.InnerText = "None";
        MainNode.AppendChild(Node);

        attribute = xmlDoc.CreateAttribute("Index");
        attribute.Value = "0";
        Node.Attributes.Append(attribute);

        for (int i = 0; i < 6; i++)
        {
            Node = xmlDoc.CreateElement("List");
            Node.InnerText = "Slot_" + i;

            MainNode.AppendChild(Node);

            attribute = xmlDoc.CreateAttribute("Name");
            if (i == 0) attribute.Value = "None";
            else attribute.Value = "Slot_" + i.ToString();
            Node.Attributes.Append(attribute);
        }

        xmlDoc.Save(xmlPath);

        AssetDatabase.Refresh();
    }
    //updating the list of project names
    static void RefreshList(int index)
    {

        xmlDoc.Load(xmlPath);

        xmlDoc.SelectSingleNode("Settings/namespace").InnerText = list[index];
        xmlDoc.GetElementsByTagName("namespace").Item(0).Attributes.Item(0).Value = index.ToString();

        var Index = xmlDoc.GetElementsByTagName("List");

        for (int i = 1; i < Index.Count; i++)
        {
            Index[i].Attributes.Item(0).Value = list[i];

        }

        xmlDoc.Save(xmlPath);

        AssetDatabase.Refresh();
    }
}
