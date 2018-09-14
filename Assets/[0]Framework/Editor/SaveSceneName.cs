/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  7:20 PM
================================================================*/


using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;


namespace Homebrew
{
    public class SaveSceneName
    {
        public const string PATH_TO_TEMPLATE = @"Assets\[0]Framework\Editor\ScenesTemplate.txt";

        [MenuItem("Tools/Actors/SaveScenes %Q", priority = 190)]
        public static void SaveScenesName()
        {
            var scene = EditorSceneManager.GetActiveScene();
            var original = EditorBuildSettings.scenes;

            var filePath = Path.GetFullPath(@"Assets/[0]Framework/LibStarter/Scenes.cs");
            var assetPath = AssetDatabase.GenerateUniqueAssetPath("Assets/[0]Framework/LibStarter/Scenes.cs");

            if (assetPath == string.Empty)
            {
                Directory.CreateDirectory(Application.dataPath + "/[0]Framework");
            }

            var templateContents = string.Empty;


            using (var t = new StreamReader(PATH_TO_TEMPLATE))
            {
                t.ReadLine();
                templateContents = t.ReadToEnd();
            }

            var scenes = EditorBuildSettings.scenes;
            var regex = new Regex(@"([^/]*/)*([\w\d\-]*)\.unity");
            string sceneNames = string.Empty;
            for (var i = 0; i < scenes.Length; ++i)
            {
                var t = i != scenes.Length - 1 ? ",\n" : "";
                sceneNames += regex.Replace(scenes[i].path, "$2") + " = " + i + t;
            }

            templateContents = templateContents.Replace("##SCENES##", sceneNames);

            var encoding = new UTF8Encoding(true, false);

            using (var tc = new StreamWriter(filePath, false, encoding))
            {
                tc.Write(templateContents);
            }


            foreach (var settingsScene in EditorBuildSettings.scenes)
            {
                if (settingsScene.path == scene.path) return;
            }


            var newSettings = new EditorBuildSettingsScene[original.Length + 1];
            Array.Copy(original, newSettings, original.Length);
            var sceneToAdd = new EditorBuildSettingsScene(scene.path, true);
            newSettings[newSettings.Length - 1] = sceneToAdd;
            EditorBuildSettings.scenes = newSettings;


            using (var t = new StreamReader(PATH_TO_TEMPLATE))
            {
                t.ReadLine();
                templateContents = t.ReadToEnd();
            }

            for (var i = 0; i < scenes.Length; ++i)
            {
                var t = i != scenes.Length - 1 ? ",\n" : "";
                sceneNames += regex.Replace(scenes[i].path, "$2") + " = " + i + t;
            }

            templateContents = templateContents.Replace("##SCENES##", sceneNames);


            using (var tc = new StreamWriter(filePath, false, encoding))
            {
                tc.Write(templateContents);
            }


            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }


//		 
    }
}