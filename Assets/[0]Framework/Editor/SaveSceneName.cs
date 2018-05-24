/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/9/2018  7:20 PM
================================================================*/

using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
namespace Homebrew{

public class SaveSceneName : MonoCached
{
	[MenuItem( "Scenes Names/Save Scenes Names %Q" )]
	private static void SaveScenesName()
	{
		EditorBuildSettingsScene[] scenes = EditorBuildSettings.scenes;
 
		// First, try to load the list if already exists
		ScenesList list = (ScenesList) AssetDatabase.LoadAssetAtPath("Assets/[0]Framework/Resources/ScenesList.asset", typeof(ScenesList)) ;
 
		// If doesn't exist, create it !
		if( list == null )
		{
			list = ScriptableObject.CreateInstance<ScenesList>() ;
			AssetDatabase.CreateAsset( list, "Assets/[0]Framework/Resources/ScenesList.asset" );
		}
		Regex regex = new Regex( @"([^/]*/)*([\w\d\-]*)\.unity" ) ;
		// Fill the array
		list.scenesNames = new List<string>();
		for ( int i = 0 ; i < scenes.Length ; ++i )
		{
                 

			list.scenesNames.Add(scenes[i].path); //[i] = scenes[i].path;
			list.scenesNames[i] = regex.Replace(scenes[i].path, "$2");
		}
		EditorUtility.SetDirty(list); 
	 
		// Writes all unsaved asset changes to disk
		AssetDatabase.SaveAssets();
	}
}

 
}