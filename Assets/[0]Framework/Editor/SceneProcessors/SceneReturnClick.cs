/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/5/2018  2:42 PM
================================================================*/


using UnityEditor;
using UnityEngine;

namespace Homebrew
{
	[InitializeOnLoad]
	public class SceneReturnClick
	{
		static SceneReturnClick()
		{
			SceneView.onSceneGUIDelegate += SceneGUI;
		}


		static void SceneGUI(SceneView sceneView)
		{
			if (!Event.current.alt) return;
			if (Event.current.button!=1) return;
			var pos = SceneView.currentDrawingSceneView.camera.ScreenToWorldPoint(Event.current.mousePosition);
			Debug.Log("Click position is: <b>" + pos + "</b>");
		}
	}
}