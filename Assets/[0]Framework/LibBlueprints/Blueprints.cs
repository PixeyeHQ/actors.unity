/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/14/2018  12:07 PM
================================================================*/


using System;
using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Homebrew
{
    
    [System.Serializable]
    public class Blueprints : Pluggable, IAwake
    {
        public List<Blueprint> blueprints = new List<Blueprint>();


        #if UNITY_EDITOR
        [MenuItem("Tools/Actors/PopulateBlueprints", priority = 200)]
        public static void Generate()
        {
            var bl = CreateOrGetAsset<Blueprints>("[2]Content/Resources/Data/Blueprints","blueprints");
                //Resources.Load<Blueprints>("Data/Blueprints/blueprints");
            var guids = AssetDatabase.FindAssets("bp_", new[] {"Assets/[2]Content/Resources/Data/Blueprints"});
            bl.blueprints.Clear();
            foreach (var guid in guids)
            {
                AssetDatabase.GUIDToAssetPath(guid);
                var b = (Blueprint) AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid),
                    typeof(Blueprint));
                bl.blueprints.Add(b);
            }


            EditorUtility.SetDirty(bl);
        }
//        [MenuItem("Tools/Actors/CreateDataBlueprints", priority = 210)]
//        public static void CreateOrReturnBlueprints()
//        {
//            var bl = 
//                Resources.Load<Blueprints>("Data/Blueprints/blueprints");
//            if (bl==null)
//                bl = ScriptableObjectUtility
//            Debug.Log(bl);
////            var guids = AssetDatabase.FindAssets("bp_", new[] {"Assets/[2]Content/Resources/BluePrints"});
////            bl.blueprints.Clear();
////            foreach (var guid in guids)
////            {
////                AssetDatabase.GUIDToAssetPath(guid);
////                var b = (Blueprint) AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid),
////                    typeof(Blueprint));
////                bl.blueprints.Add(b);
////            }
////
////
////            EditorUtility.SetDirty(bl);
//        }
        
        public static T CreateOrGetAsset<T>(string p, string n) where T : ScriptableObject
        {
            var asset = AssetDatabase.LoadAssetAtPath<T>("Assets/" + p + "/" + n + ".asset");

            var assetPathAndName = AssetDatabase.GenerateUniqueAssetPath("Assets/" + p + "/" + n + ".asset");
            if (asset != null) return asset;
            asset = ScriptableObject.CreateInstance<T>();


            if (assetPathAndName == string.Empty)
            {
                Directory.CreateDirectory(Application.dataPath + "/" + p);
                assetPathAndName = AssetDatabase.GenerateUniqueAssetPath("Assets/" + p + "/" + n + ".asset");
            }


            AssetDatabase.CreateAsset(asset, assetPathAndName);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return asset;
        }
        
        #endif

        public void OnAwake()
        {
            for (var i = 0; i < blueprints.Count; i++)
            {
                blueprints[i].Setup();
                 
            }
        }

        public override void Plug()
        {
            Toolbox.Add(this);
        }
    }
}