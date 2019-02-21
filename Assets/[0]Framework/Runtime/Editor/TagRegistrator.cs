using UnityEngine;
using Homebrew;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System;
using UnityEditor;

[ExecuteInEditMode]
public class TagRegistrator : MonoBehaviour
{
    static int lastIndex;
    static List<int> idTags = new List<int>();
    static List<int> freeIdTags = new List<int>();

    static bool isReset;

    static string metafilePath = @"\MetaTags.txt";
    static string dir = Directory.GetCurrentDirectory();

    static string path = dir + @"\Assets\[1]Source\Runtime\Tags";

#if UNITY_EDITOR    
    void Awake()
    {
        if (Application.isPlaying) return;
        Execute();
    }
#endif

    [MenuItem("Tools/Tags/Registration")]
    static public void Execute()
    {
        Init();
        TagRegist();
    }

    [MenuItem("Tools/Tags/Reset/Reset And Registration")]
    static public void ExecuteResetAndRegistration()
    {
        isReset = true;
        lastIndex = 0;
        TagRegist();
    }

    [MenuItem("Tools/Tags/Reset/Reset")]
    static public void ExecuteReset()
    {
        isReset = true;
        lastIndex = 0;
    }

    static void Init()
    {
        try
        {
            if (File.Exists(dir + metafilePath))
            {
                using (StreamReader sr = new StreamReader(dir + metafilePath, System.Text.Encoding.Default))
                {
                    lastIndex = int.Parse(sr.ReadLine());
                    while (!sr.EndOfStream)
                    {
                        var str = sr.ReadLine();
                        // Debug.Log(str);
                        // if (str != "")
                        // {
                        var e = int.Parse(str);
                        freeIdTags.Add(e);
                        // }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    static void Save()
    {
        StreamWriter sr;
        if (!File.Exists(dir + metafilePath))
        {
            sr = File.CreateText(dir + metafilePath);
        }
        else
        {
            sr = new StreamWriter(dir + metafilePath, false, System.Text.Encoding.Default);
        }
        using (sr)
        {
            sr.WriteLine(lastIndex);
            for (int i = 0; i < freeIdTags.Count; i++)
            {
                sr.WriteLine(freeIdTags[i]);
            }
        }
    }

    static void TagRegist()
    {
        // Debug.Log(freeIdTags.Count);
        string[] Files = Directory.GetFiles(path, "*.cs");

        int count = 0;

        for (int f = 0; f < Files.Length; f++)
        {
            var readPath = Files[f];

            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

                var lines = text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i++)
                {
                    int ind = lines[i].LastIndexOf('=');
                    if (ind <= 0) continue;

                    if (lines[i][ind + 1] == ' ') ind += 2;
                    else ind++;
                    if (lines[i][ind] == '0' | isReset)
                    {
                        count++;
                        // Находим свободный id
                        int l_int = 0;
                        if (freeIdTags.Count == 0)
                        {
                            do
                            {
                                l_int = ++lastIndex;
                            } while (idTags.Contains(l_int));

                        }
                        else
                        {
                            l_int = freeIdTags[0];
                            freeIdTags.Remove(l_int);
                        }

                        lines[i] = lines[i].Remove(ind);
                        lines[i] = lines[i].Insert(ind, l_int + ";");
                        idTags.Add(l_int);
                    }
                    else
                    {
                        string line = lines[i].Substring(ind);
                        line = line.Remove(line.LastIndexOf(';'));
                        int idTag = int.Parse(line);
                        idTags.Add(idTag);
                    }
                }

                using (StreamWriter sw = new StreamWriter(readPath, false, System.Text.Encoding.Default))
                {
                    foreach (var item in lines)
                        sw.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }

        for (int i = 1; i <= lastIndex; i++)
        {
            if (!idTags.Contains(i) & !freeIdTags.Contains(i))
                freeIdTags.Add(i);
        }

        // Debug.Log("Count "+ freeIdTags.Count);
        Save();

        isReset = false;
        idTags.Clear();
        freeIdTags.Clear();
        Debug.Log("Теги идентифицированы в кол-ве: " + count + " [lastId]:" + lastIndex);
    }
}