/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/14/2018  12:07 PM
================================================================*/


using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Homebrew
{
	[CreateAssetMenu(fileName = "Blueprints", menuName = "Data/Blueprints")]
	[System.Serializable]
	public class Blueprints : Pluggable, IAwake
	{
		public List<Blueprint> blueprints = new List<Blueprint>();

	 

//		[Button(ButtonSizes.Large)]
//		public void Populate()
//		{
//#if UNITY_EDITOR
//			var guids = AssetDatabase.FindAssets("bp_", new[] {"Assets/[2]Content/Blueprints"});
//			blueprints.Clear();
//			foreach (string guid in guids)
//			{
//				AssetDatabase.GUIDToAssetPath(guid);
//				Blueprint b = (Blueprint) AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid), typeof(Blueprint));
//				blueprints.Add(b);
//			}
//
//			EditorBinder.actionGenerateBluePrintKeys.Invoke();
//			EditorUtility.SetDirty(this);
//#endif
//		}

 
		
#if UNITY_EDITOR
		[MenuItem("Tools/PopulateBlueprints")]
		public static void Generate()
		{
			var bl = Resources.Load<Blueprints>("Blueprints");
			var guids = AssetDatabase.FindAssets("bp_", new[] {"Assets/[2]Content/Blueprints"});
			bl.blueprints.Clear();
			foreach (string guid in guids)
			{
				AssetDatabase.GUIDToAssetPath(guid);
				Blueprint b = (Blueprint) AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid), typeof(Blueprint));
				bl.blueprints.Add(b);
			}


			EditorUtility.SetDirty(bl);
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