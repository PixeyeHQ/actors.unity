/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/14/2018  12:07 PM
================================================================*/


using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Homebrew
{
    [System.Serializable]
    public class Blueprints : ScriptableObject, IAwake, IKernel
    {
        public List<Blueprint> blueprints = new List<Blueprint>();
     //   public List<ScriptableObject> scriptables = new List<ScriptableObject>();

        #if UNITY_EDITOR
        [MenuItem("Tools/Actors/PopulateBlueprints", priority = 200)]
        public static void Generate()
        {
            var bl = CreateOrGetAsset<Blueprints>("[2]Content/Resources/Data/Blueprints", "blueprints");
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


//            var len = scriptables.Count;
//            for (int i = 0; i < len; i++)
//            {
//                var s = scriptables[i];
//                Setup(s);
//            }
        }

   //     static void Setup(object b)
//        {
//            var type = b.GetType();
//
//            var included = ProcessingScripts.scripts.ContainsKey(type.GetHashCode());
//            if (included) return;
//
//            var  composition   = new CompositionScript();
//            bool shouldInclude = false;
//            var  atr           = type.GetCustomAttribute<RequireAttribute>();
//
//
//            if (atr != null)
//            {
//                shouldInclude = true;
//                var i = 0;
//                foreach (var atrType in atr.types)
//                {
//                    var typeArgument = atrType;
//                    var template     = typeof(Storage<>);
//                    var genericType  = template.MakeGenericType(typeArgument);
//
//                    object instance = null;
//                    var    field    = genericType.GetField("Instance");
//                    instance = field.GetValue(instance);
//                    if (instance == null)
//                    {
//                        instance = Activator.CreateInstance(genericType);
//                        field.SetValue(instance, instance);
//                    }
//
//                    composition.storages.Add(instance as Storage);
//                }
//            }
//
//            var atrTags = type.GetCustomAttribute<RequireTagsAttribute>();
//
//            if (atrTags != null)
//            {
//                shouldInclude = true;
//                composition.tags = atrTags.tags;
//            }
//
//            if (shouldInclude)
//                ProcessingScripts.scripts.Add(type.GetHashCode(), composition);
//        }
    }
}