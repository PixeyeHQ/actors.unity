//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	[System.Serializable]
	public class SceneReference
	{

		[SerializeField]
		private Object sceneAsset;

		[SerializeField]
		private string sceneName = "";

		public string Path => sceneName;

		// makes it work with the existing Unity methods (LoadLevel/LoadScene)
		public static implicit operator string(SceneReference sceneReference)
		{
			return sceneReference.Path;
		}

	}
}

//	#if UNITY_EDITOR
//	[CustomPropertyDrawer(typeof(SceneReference))]
//	public class SceneFieldPropertyDrawer : PropertyDrawer
//	{
//
//		public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
//		{
//			EditorGUI.BeginProperty(_position, GUIContent.none, _property);
//			var sceneAsset = _property.FindPropertyRelative("m_SceneAsset");
//			var sceneName  = _property.FindPropertyRelative("m_SceneName");
//			_position = EditorGUI.PrefixLabel(_position, GUIUtility.GetControlID(FocusType.Passive), _label);
//			if (sceneAsset != null)
//			{
//				sceneAsset.objectReferenceValue = EditorGUI.ObjectField(_position, sceneAsset.objectReferenceValue, typeof(SceneAsset), false);
//				if (sceneAsset.objectReferenceValue != null)
//				{
//					sceneName.stringValue = (sceneAsset.objectReferenceValue as SceneAsset).name;
//				}
//			}
//
//			EditorGUI.EndProperty();
//		}
//
//	}
//	 #endif

//	/// <summary>
//	/// A wrapper that provides the means to safely serialize Scene Asset References.
//	/// </summary>
//	[Serializable]
//	public  class SceneReference
//	{
//
//		[SerializeField]
//		private Object sceneAsset;
//
//		[SerializeField]
//		private string sceneName = "";
//
//		public string Path => sceneName;
//
//		// makes it work with the existing Unity methods (LoadLevel/LoadScene)
//		public static implicit operator string(SceneReference sceneReference)
//		{
//			return sceneReference.Path;
//		}
//
//	}
//