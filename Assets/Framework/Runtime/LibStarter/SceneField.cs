//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif

// Author: JohannesMP (2018-08-12)
//
// A wrapper that provides the means to safely serialize Scene Asset References.
// 
// Internally we serialize an Object to the SceneAsset which only exists at editor time.
// Any time the object is serialized, we store the path provided by this Asset (assuming it was valid).
// 
// This means that, come build time, the string path of the scene asset is always already stored, which if 
// the scene was added to the build settings means it can be loaded.
// 
// It is up to the user to ensure the scene exists in the build settings so it is loadable at runtime.
// To help with this, a custom PropertyDrawer displays the scene build settings state.
// 
// Known issues:
//     -   When reverting back to a prefab which has the asset stored as null, Unity will show the property 
//         as modified despite having just reverted. This only happens the fist time, and reverting again 
//         fixes it. Under the hood the state is still always valid, and serialized correctly regardless.

namespace Pixeye
{
	/// <summary>
	/// A wrapper that provides the means to safely serialize Scene Asset References.
	/// </summary>
	[System.Serializable]
	public class SceneReference : ISerializationCallbackReceiver
	{

		#if UNITY_EDITOR
		// What we use in editor to select the scene
		[SerializeField]
		Object sceneAsset = null;

		bool IsValidSceneAsset
		{
			get
			{
				if (sceneAsset == null)
					return false;
				return sceneAsset.GetType().Equals(typeof(SceneAsset));
			}
		}
		#endif

		// This should only ever be set during serialization/deserialization!
		[SerializeField]
		string scenePath = string.Empty;

		// Use this when you want to actually have the scene path
		public string ScenePath
		{
			get
			{
				#if UNITY_EDITOR
				// In editor we always use the asset's path
				return GetScenePathFromAsset();
				#else
            // At runtime we rely on the stored path value which we assume was serialized correctly at build time.
            // See OnBeforeSerialize and OnAfterDeserialize
            return scenePath;
				#endif
			}
			set
			{
				scenePath = value;
				#if UNITY_EDITOR
				sceneAsset = GetSceneAssetFromPath();
				#endif
			}
		}

		public static implicit operator string(SceneReference sceneReference)
		{
			return sceneReference.ScenePath;
		}

		// Called to prepare this data for serialization. Stubbed out when not in editor.
		public void OnBeforeSerialize()
		{
			#if UNITY_EDITOR
			HandleBeforeSerialize();
			#endif
		}

		// Called to set up data for deserialization. Stubbed out when not in editor.
		public void OnAfterDeserialize()
		{
			#if UNITY_EDITOR
			// We sadly cannot touch assetdatabase during serialization, so defer by a bit.
			EditorApplication.update += HandleAfterDeserialize;
			#endif
		}

		#if UNITY_EDITOR
		private SceneAsset GetSceneAssetFromPath()
		{
			if (string.IsNullOrEmpty(scenePath))
				return null;
			return AssetDatabase.LoadAssetAtPath<SceneAsset>(scenePath);
		}

		private string GetScenePathFromAsset()
		{
			if (sceneAsset == null)
				return string.Empty;
			return AssetDatabase.GetAssetPath(sceneAsset);
		}

		private void HandleBeforeSerialize()
		{
			// Asset is invalid but have Path to try and recover from
			if (IsValidSceneAsset == false && string.IsNullOrEmpty(scenePath) == false)
			{
				sceneAsset = GetSceneAssetFromPath();
				if (sceneAsset == null)
					scenePath = string.Empty;

				UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
			}
			// Asset takes precendence and overwrites Path
			else
			{
				scenePath = GetScenePathFromAsset();
			}
		}

		private void HandleAfterDeserialize()
		{
			EditorApplication.update -= HandleAfterDeserialize;
			// Asset is valid, don't do anything - Path will always be set based on it when it matters
			if (IsValidSceneAsset)
				return;

			// Asset is invalid but have path to try and recover from
			if (string.IsNullOrEmpty(scenePath) == false)
			{
				sceneAsset = GetSceneAssetFromPath();
				// No asset found, path was invalid. Make sure we don't carry over the old invalid path
				if (sceneAsset == null)
					scenePath = string.Empty;

				if (Application.isPlaying == false)
					UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
			}
		}
		#endif

	}

	#if UNITY_EDITOR
	/// <summary>
	/// Display a Scene Reference object in the editor.
	/// If scene is valid, provides basic buttons to interact with the scene's role in Build Settings.
	/// </summary>
	[CustomPropertyDrawer(typeof(SceneReference))]
	public class SceneReferencePropertyDrawer : PropertyDrawer
	{

		// The exact name of the asset Object variable in the SceneReference object
		const string sceneAssetPropertyString = "sceneAsset";

		// The exact name of  the scene Path variable in the SceneReference object
		const string scenePathPropertyString = "scenePath";

		static readonly RectOffset boxPadding = EditorStyles.helpBox.padding;
		static readonly float padSize = 2f;
		static readonly float lineHeight = EditorGUIUtility.singleLineHeight;
		static readonly float paddedLine = lineHeight + padSize;
		static readonly float footerHeight = 4f;

		/// <summary>
		/// Drawing the 'SceneReference' property
		/// </summary>
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var sceneAssetProperty = GetSceneAssetProperty(property);

			// Draw the Box Background
			position.height -= footerHeight;
		  GUI.Box(EditorGUI.IndentedRect(position), GUIContent.none, EditorStyles.helpBox);
			position = boxPadding.Remove(position);
			position.height = lineHeight;
//			var r = new Rect(position.x, position.y-20, position.width, position.height);
//			if (DrawUtils.ButtonHelper(r, "New", "New", EditorStyles.miniButton, ""))
//			{
//				Debug.Log("HIHI");
//			}
			// Draw the main Object field
			label.tooltip = "The actual Scene Asset reference.\nOn serialize this is also stored as the asset's path.";

			EditorGUI.BeginProperty(position, GUIContent.none, property);
			EditorGUI.BeginChangeCheck();
			int                   sceneControlID = GUIUtility.GetControlID(FocusType.Passive);
			var                   selectedObject = EditorGUI.ObjectField(position, label, sceneAssetProperty.objectReferenceValue, typeof(SceneAsset), false);
			BuildUtils.BuildScene buildScene     = BuildUtils.GetBuildScene(selectedObject);

			if (EditorGUI.EndChangeCheck())
			{
				sceneAssetProperty.objectReferenceValue = selectedObject;

				// If no valid scene asset was selected, reset the stored path accordingly
				if (buildScene.scene == null)
					GetScenePathProperty(property).stringValue = string.Empty;
			}

			position.y += paddedLine;

			if (buildScene.assetGUID.Empty() == false)
			{
				// Draw the Build Settings Info of the selected Scene
				DrawSceneInfoGUI(position, buildScene, sceneControlID + 1);
			}

			EditorGUI.EndProperty();
		}

		/// <summary>
		/// Ensure that what we draw in OnGUI always has the room it needs
		/// </summary>
		public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
		{
			int                lines              = 2;
			SerializedProperty sceneAssetProperty = GetSceneAssetProperty(property);
			if (sceneAssetProperty.objectReferenceValue == null)
				lines = 1;

			return boxPadding.vertical + lineHeight * lines + padSize * (lines - 1) + footerHeight;
		}

		/// <summary>
		/// Draws info box of the provided scene
		/// </summary>
		private void DrawSceneInfoGUI(Rect position, BuildUtils.BuildScene buildScene, int sceneControlID)
		{
			bool   readOnly        = BuildUtils.IsReadOnly();
			string readOnlyWarning = readOnly ? "\n\nWARNING: Build Settings is not checked out and so cannot be modified." : "";

			 
			
			// Label Prefix
			GUIContent iconContent  = new GUIContent();
			GUIContent labelContent = new GUIContent();

			// Missing from build scenes
			if (buildScene.buildIndex == -1)
			{
				iconContent = EditorGUIUtility.IconContent("d_winbtn_mac_close");
				labelContent.text = "NOT In Build";
				labelContent.tooltip = "This scene is NOT in build settings.\nIt will be NOT included in builds.";
			}
			// In build scenes and enabled
			else if (buildScene.scene.enabled)
			{
				iconContent = EditorGUIUtility.IconContent("d_winbtn_mac_max");
				labelContent.text = "BuildIndex: " + buildScene.buildIndex;
				labelContent.tooltip = "This scene is in build settings and ENABLED.\nIt will be included in builds." + readOnlyWarning;
			}
			// In build scenes and disabled
			else
			{
				iconContent = EditorGUIUtility.IconContent("d_winbtn_mac_min");
				labelContent.text = "BuildIndex: " + buildScene.buildIndex;
				labelContent.tooltip = "This scene is in build settings and DISABLED.\nIt will be NOT included in builds.";
			}

			// Left status label
			using (new EditorGUI.DisabledScope(readOnly))
			{
				
				Rect labelRect = DrawUtils.GetLabelRect(position);
				Rect iconRect  = labelRect;
				iconRect.width = iconContent.image.width + padSize;
				labelRect.width -= iconRect.width;
				labelRect.x += iconRect.width;
				EditorGUI.PrefixLabel(iconRect, sceneControlID, iconContent);
				EditorGUI.PrefixLabel(labelRect, sceneControlID, labelContent);
				
		 

				
			}

			// Right context buttons
			Rect buttonRect = DrawUtils.GetFieldRect(position);
			buttonRect.width = (buttonRect.width) / 3;

			string tooltipMsg = "";
			using (new EditorGUI.DisabledScope(readOnly))
			{

			 
				
				// NOT in build settings
				if (buildScene.buildIndex == -1)
				{
					buttonRect.width *= 2;
					int addIndex = EditorBuildSettings.scenes.Length;
					tooltipMsg = "Add this scene to build settings. It will be appended to the end of the build scenes as buildIndex: " + addIndex + "." + readOnlyWarning;
					if (DrawUtils.ButtonHelper(buttonRect, "Add...", "Add (buildIndex " + addIndex + ")", EditorStyles.miniButtonLeft, tooltipMsg))
						BuildUtils.AddBuildScene(buildScene);
					buttonRect.width /= 2;
					buttonRect.x += buttonRect.width;
				}
				// In build settings
				else
				{
					bool   isEnabled   = buildScene.scene.enabled;
					string stateString = isEnabled ? "Disable" : "Enable";
					tooltipMsg = stateString + " this scene in build settings.\n" + (isEnabled ? "It will no longer be included in builds" : "It will be included in builds") + "." + readOnlyWarning;

					if (DrawUtils.ButtonHelper(buttonRect, stateString, stateString + " In Build", EditorStyles.miniButtonLeft, tooltipMsg))
						BuildUtils.SetBuildSceneState(buildScene, !isEnabled);
					buttonRect.x += buttonRect.width;

					tooltipMsg = "Completely remove this scene from build settings.\nYou will need to add it again for it to be included in builds!" + readOnlyWarning;
					if (DrawUtils.ButtonHelper(buttonRect, "Remove...", "Remove from Build", EditorStyles.miniButtonMid, tooltipMsg))
						BuildUtils.RemoveBuildScene(buildScene);
				}
			}

			buttonRect.x += buttonRect.width;

			tooltipMsg = "Open the 'Build Settings' Window for managing scenes." + readOnlyWarning;
			if (DrawUtils.ButtonHelper(buttonRect, "Settings", "Build Settings", EditorStyles.miniButtonRight, tooltipMsg))
			{
				BuildUtils.OpenBuildSettings();
			}
		}

		static SerializedProperty GetSceneAssetProperty(SerializedProperty property)
		{
			return property.FindPropertyRelative(sceneAssetPropertyString);
		}

		static SerializedProperty GetScenePathProperty(SerializedProperty property)
		{
			return property.FindPropertyRelative(scenePathPropertyString);
		}

		private static class DrawUtils
		{

			/// <summary>
			/// Draw a GUI button, choosing between a short and a long button text based on if it fits
			/// </summary>
			static public bool ButtonHelper(Rect position, string msgShort, string msgLong, GUIStyle style, string tooltip = null)
			{
				GUIContent content = new GUIContent(msgLong);
				content.tooltip = tooltip;

				float longWidth = style.CalcSize(content).x;
				if (longWidth > position.width)
					content.text = msgShort;

				return GUI.Button(position, content, style);
			}

			/// <summary>
			/// Given a position rect, get its field portion
			/// </summary>
			static public Rect GetFieldRect(Rect position)
			{
				position.width -= EditorGUIUtility.labelWidth;
				position.x += EditorGUIUtility.labelWidth;
				return position;
			}
			/// <summary>
			/// Given a position rect, get its label portion
			/// </summary>
			static public Rect GetLabelRect(Rect position)
			{
				position.width = EditorGUIUtility.labelWidth - padSize;
				return position;
			}

		}

		/// <summary>
		/// Various BuildSettings interactions
		/// </summary>
		static private class BuildUtils
		{

			// time in seconds that we have to wait before we query again when IsReadOnly() is called.
			public static float minCheckWait = 3;

			static float lastTimeChecked = 0;
			static bool cachedReadonlyVal = true;

			/// <summary>
			/// A small container for tracking scene data BuildSettings
			/// </summary>
			public struct BuildScene
			{

				public int buildIndex;
				public GUID assetGUID;
				public string assetPath;
				public EditorBuildSettingsScene scene;

			}

			/// <summary>
			/// Check if the build settings asset is readonly.
			/// Caches value and only queries state a max of every 'minCheckWait' seconds.
			/// </summary>
			static public bool IsReadOnly()
			{
				float curTime            = UnityEngine.Time.realtimeSinceStartup;
				float timeSinceLastCheck = curTime - lastTimeChecked;

				if (timeSinceLastCheck > minCheckWait)
				{
					lastTimeChecked = curTime;
					cachedReadonlyVal = QueryBuildSettingsStatus();
				}

				return cachedReadonlyVal;
			}

			/// <summary>
			/// A blocking call to the Version Control system to see if the build settings asset is readonly.
			/// Use BuildSettingsIsReadOnly for version that caches the value for better responsivenes.
			/// </summary>
			static private bool QueryBuildSettingsStatus()
			{
				// If no version control provider, assume not readonly
				if (UnityEditor.VersionControl.Provider.enabled == false)
					return false;

				// If we cannot checkout, then assume we are not readonly
				if (UnityEditor.VersionControl.Provider.hasCheckoutSupport == false)
					return false;

				//// If offline (and are using a version control provider that requires checkout) we cannot edit.
				//if (UnityEditor.VersionControl.Provider.onlineState == UnityEditor.VersionControl.OnlineState.Offline)
				//    return true;

				// Try to get status for file
				var status = UnityEditor.VersionControl.Provider.Status("ProjectSettings/EditorBuildSettings.asset", false);
				status.Wait();

				// If no status listed we can edit
				if (status.assetList == null || status.assetList.Count != 1)
					return true;

				// If is checked out, we can edit
				if (status.assetList[0].IsState(UnityEditor.VersionControl.Asset.States.CheckedOutLocal))
					return false;

				return true;
			}

			/// <summary>
			/// For a given Scene Asset object reference, extract its build settings data, including buildIndex.
			/// </summary>
			static public BuildScene GetBuildScene(Object sceneObject)
			{
				BuildScene entry = new BuildScene()
				{
					buildIndex = -1,
					assetGUID = new GUID(string.Empty)
				};

				if (sceneObject as SceneAsset == null)
					return entry;

				entry.assetPath = AssetDatabase.GetAssetPath(sceneObject);
				entry.assetGUID = new GUID(AssetDatabase.AssetPathToGUID(entry.assetPath));

				for ( int index = 0; index < EditorBuildSettings.scenes.Length; ++index )
				{
					if (entry.assetGUID.Equals(EditorBuildSettings.scenes[index].guid))
					{
						entry.scene = EditorBuildSettings.scenes[index];
						entry.buildIndex = index;
						return entry;
					}
				}

				return entry;
			}

			/// <summary>
			/// Enable/Disable a given scene in the buildSettings
			/// </summary>
			static public void SetBuildSceneState(BuildScene buildScene, bool enabled)
			{
				bool                       modified       = false;
				EditorBuildSettingsScene[] scenesToModify = EditorBuildSettings.scenes;
				foreach ( var curScene in scenesToModify )
				{
					if (curScene.guid.Equals(buildScene.assetGUID))
					{
						curScene.enabled = enabled;
						modified = true;
						break;
					}
				}

				if (modified)
					EditorBuildSettings.scenes = scenesToModify;
			}

			/// <summary>
			/// Display Dialog to add a scene to build settings
			/// </summary>
			static public void AddBuildScene(BuildScene buildScene, bool force = false, bool enabled = true)
			{
				if (force == false)
				{
					int selection = EditorUtility.DisplayDialogComplex(
							"Add Scene To Build",
							"You are about to add scene at " + buildScene.assetPath + " To the Build Settings.",
							"Add as Enabled",       // option 0
							"Add as Disabled",      // option 1
							"Cancel (do nothing)"); // option 2

					switch (selection)
					{
						case 0: // enabled
							enabled = true;
							break;
						case 1: // disabled
							enabled = false;
							break;
						default:
						case 2: // cancel
							return;
					}
				}

				EditorBuildSettingsScene       newScene   = new EditorBuildSettingsScene(buildScene.assetGUID, enabled);
				List<EditorBuildSettingsScene> tempScenes = EditorBuildSettings.scenes.ToList();
				tempScenes.Add(newScene);
				EditorBuildSettings.scenes = tempScenes.ToArray();
			}

			/// <summary>
			/// Display Dialog to remove a scene from build settings (or just disable it)
			/// </summary>
			static public void RemoveBuildScene(BuildScene buildScene, bool force = false)
			{
				bool onlyDisable = false;
				if (force == false)
				{
					int selection = -1;

					string title = "Remove Scene From Build";
					string details = string.Format("You are about to remove the following scene from build settings:\n    {0}\n    buildIndex: {1}\n\n{2}",
							buildScene.assetPath, buildScene.buildIndex,
							"This will modify build settings, but the scene asset will remain untouched.");
					string confirm = "Remove From Build";
					string alt     = "Just Disable";
					string cancel  = "Cancel (do nothing)";

					if (buildScene.scene.enabled)
					{
						details += "\n\nIf you want, you can also just disable it instead.";
						selection = EditorUtility.DisplayDialogComplex(title, details, confirm, alt, cancel);
					}
					else
					{
						selection = EditorUtility.DisplayDialog(title, details, confirm, cancel) ? 0 : 2;
					}

					switch (selection)
					{
						case 0: // remove
							break;
						case 1: // disable
							onlyDisable = true;
							break;
						default:
						case 2: // cancel
							return;
					}
				}

				// User chose to not remove, only disable the scene
				if (onlyDisable)
				{
					SetBuildSceneState(buildScene, false);
				}
				// User chose to fully remove the scene from build settings
				else
				{
					List<EditorBuildSettingsScene> tempScenes = EditorBuildSettings.scenes.ToList();
					tempScenes.RemoveAll(scene => scene.guid.Equals(buildScene.assetGUID));
					EditorBuildSettings.scenes = tempScenes.ToArray();
				}
			}

			/// <summary>
			/// Open the default Unity Build Settings window
			/// </summary>
			static public void OpenBuildSettings()
			{
				EditorWindow.GetWindow(typeof(BuildPlayerWindow));
			}

		}

	}
}
#endif

#region DEPRECATED
//namespace Pixeye
//{
//	using UnityEngine;
//	#if UNITY_EDITOR
//	using UnityEditor;
//
//	#endif
//	[System.Serializable]
//	public class SceneField
//	{
//		[SerializeField] private Object m_SceneAsset;
//		[SerializeField] private string m_SceneName = "";
//
//		public string SceneName => m_SceneName;
//
//		// makes it work with the existing Unity methods (LoadLevel/LoadScene)
//		public static implicit operator string(SceneField sceneField)
//		{
//			return sceneField.SceneName;
//		}
//	}
//	#if UNITY_EDITOR
//	[CustomPropertyDrawer(typeof(SceneField))]
//	public class SceneFieldPropertyDrawer : PropertyDrawer
//	{
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
//	}
//	#endif
//}
#endregion
 