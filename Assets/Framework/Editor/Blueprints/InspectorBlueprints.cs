//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Graphs;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Pixeye
{
	[CustomEditor(typeof(Blueprint), true, isFallback = true)]
	public class InspectorBlueprints : Editor
	{

		const int stateMain = 0;
		const int stateFind = 1;
		const int stateMainShow = 2;

		public bool showComponents;
		public int state = stateMain;
		Vector2 scrollPos;

		readonly IEnumerable<Type> componentTypes = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(s => s.GetTypes())
				.Where(p => typeof(IComponent).IsAssignableFrom(p) && p.IsClass);

		readonly List<string> namespaces = new List<string>();

		bool addingComponents = false;
		string searchString = "Enter component";

		int namespaceIndex = -1;

		string[] allTypes;
		string[] currentTypes;

		IEnumerable<Type> GetByNamespace(int index)
		{
			var str = namespaces[index];
			return AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IComponent).IsAssignableFrom(p) && p.IsClass && p.Namespace == str);
		}

		void OnEnable()
		{
			var list = componentTypes.ToList();
			var len  = list.Count;
			for ( int i = 0; i < len; i++ )
			{
				var element = list[i];
				if (!namespaces.Contains(element.Namespace))
				{
					namespaces.Add(element.Namespace);
				}
			}

			allTypes = componentTypes.Select(s => s.Name).ToArray();
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI();
			HandleStateMain();
			HandleStateFind();
		}

		void HandleStateMain()
		{
			if (state != stateMain && state != stateMainShow) return;

			Style.Header.UseHorizontalLayout(() =>
			{
				EditorStyles.label.UseLabel(string.Format($"Components: {0} "));

				if (this.UseButton("Add Component", Style.Button))
				{
					state = stateFind;
				}

				GUILayout.Space(2f);

				if (state == stateMain && this.UseButton("▸", Style.Button))
				{
					state = stateMainShow;
				}

				if (state == stateMainShow && this.UseButton("▾", Style.Button))
				{
					state = stateMain;
				}
			});
		}
		void HandleStateFind()
		{
			if (state != stateFind) return;
			var index = -1;

			Style.Header.UseHorizontalLayout(() =>
			{
				EditorStyles.label.UseLabel("Find: ", 64);
				var col = GUI.backgroundColor;
				GUI.backgroundColor = Style.colDark;
				searchString = Style.Search.UseTextInput("", searchString);
				GUI.backgroundColor = col;
				//EditorStyles.label.UseLabel("Choose Namespace");

				if (state == stateFind && this.UseButton("Back", Style.Button))
				{
					if (namespaceIndex > -1)
					{
						namespaceIndex = -1;
						return;
					}

					state = stateMain;
				}
			});

			StateShowNamespaces();

			void StateShowNamespaces()
			{
				if (searchString.Length > 0)
				{
					var contents = allTypes.Where(p => p.Contains(searchString));
					var len      = contents.Count();
					var rowIndex = 0;
				 
						Style.Header.UseVerticalLayout(() =>
						{
							scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(EditorGUIUtility.currentViewWidth - 31f), GUILayout.Height(Mathf.Clamp(len * 26, 32, 400)));

							foreach ( var c in contents )
							{
								GUI.backgroundColor = rowIndex++ % 2 == 0 ? Style.colDark : Style.colLight;

								Style.ButtonSearch.UseHorizontalLayout(() =>
								{
									if (this.UseButton(c, Style.Row, 21))
									{
									}
								});
								GUILayout.Space(1f);
							}
							
						 

							EditorGUILayout.EndScrollView();
						});
				 
				}
				else if (namespaceIndex == -1)
				{
					Style.Header.UseVerticalLayout(() =>
					{
						var len = namespaces.Count;
						for ( int i = 0; i < len; i++ )
						{
							GUI.backgroundColor = i % 2 == 0 ? Style.colDark : Style.colLight;

							Style.ButtonSearch.UseHorizontalLayout(() =>
							{
								if (this.UseButton(namespaces[i], Style.Row, 21))
								{
									namespaceIndex = i;
									var types = GetByNamespace(i);
									currentTypes = types.Select(x => x.Name).ToArray();
								}

								if (this.UseButton("▸", Style.Row))
								{
									namespaceIndex = i;
									var types = GetByNamespace(i);
									currentTypes = types.Select(x => x.Name).ToArray();
								}
							});

							GUILayout.Space(1f);
						}
					});
				}
				else
				{
					Style.Header.UseVerticalLayout(() =>
					{
						scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(EditorGUIUtility.currentViewWidth - 31f), GUILayout.Height(Mathf.Clamp(currentTypes.Length * 26, 32, 400)));
						for ( int i = 0; i < currentTypes.Length; i++ )
						{
							GUI.backgroundColor = i % 2 == 0 ? Style.colDark : Style.colLight;

							Style.ButtonSearch.UseHorizontalLayout(() =>
							{
								if (this.UseButton(currentTypes[i], Style.Row, 21))
								{
								}
							});
							GUILayout.Space(1f);
						}

						EditorGUILayout.EndScrollView();
					});
				}
//			var index = -1;
//			searchString = EditorGUILayout.TextField(searchString, EditorStyles.toolbarTextField);
//
//			if (namespaceIndex == -1)
//			{
//				var len = namespaces.Count;
//				for ( int i = 0; i < len; i++ )
//				{
//					if (this.UseUIButton(namespaces[i], EditorStyles.label, 12, EditorGUIUtility.currentViewWidth - 100))
//					{
//						namespaceIndex = i;
//						var types = GetByNamespace(i);
////						Debug.Log(types.ToArray().Length);
////						var v = types.Select(x => x.Name).ToArray();
//						currentTypes = types.Select(x => x.Name).ToArray();
//					}
//				}
//			}
//			else
//			{
//				for ( int i = 0; i < currentTypes.Length; i++ )
//				{
//					if (currentTypes[i].Contains(searchString))
//					{
//						if (this.UseUIButton(currentTypes[i], EditorStyles.label, 12, EditorGUIUtility.currentViewWidth - 100))
//						{
//							Debug.Log(currentTypes[i]);
//						}
//					}
//				}
//			}

				//	this.UseLabel(string.Format($"→ {searchString} "), EditorStyles.label);

//			this.UseHorizontalLayout(() =>
//			{
//				this.UseHorizontalLayout(() =>
//				{
//					this.UseLabel("Find →", EditorStyles.label);
//
//					// 	this.UseLabel(string.Format($"→ {searchString} "), EditorUIStyles.text);
//				}, EditorUIStyles.box);
//
//				searchString = EditorGUILayout.TextField(searchString, EditorStyles.toolbarTextField);
//			}, EditorStyles.label);

//			if (this.UseUIButtonExtended("Add New Component", EditorUIStyles.button, 16))
//			{
//				addingComponents = true;
//			}

				//	if (addingComponents)
				//{

				//	index = EditorGUILayout.Popup("Add Component", index, types);

				// Do comparison here. For example
//
//			if (index >= 0)
//			{
//			}

//				var availableTypes = allComponentTypes
//						.Where(x => !_entityView.Entity.Components.Select(y => y.GetType()).Contains(x))
//						.ToArray();
//
//				var types = availableTypes.Select(x => string.Format("{0} [{1}]", x.Name, x.Namespace)).ToArray();
//				var index = -1;
//			index = EditorGUILayout.Popup("Add Component", index, types);
//			if (index >= 0)
//			{
//				addingComponents = false;
//			}

//					var component = (IComponent)Activator.CreateInstance(availableTypes[index]);
//					_entityView.Entity.AddComponents(component);
//				}
//			}
				//}
			}
		}

		static class Style
		{

			public static Color colDark = new Color(51 / 255f, 51 / 255f, 51 / 255f, 1);
			public static Color colLight = new Color(56 / 255f, 56 / 255f, 56 / 255f, 1);
			public static Color colNormal = new Color(0.75f, 0.75f, 0.75f, 1);
			public static GUIStyle Header;
			public static GUIStyle Button;
			public static GUIStyle ButtonSearch;
			public static GUIStyle Input;
			public static GUIStyle Arrow;
			public static GUIStyle Row;
			public static GUIStyle Search;
			static Style()
			{
				var uiTex_in    = Resources.Load<Texture2D>("IN foldout focus-6510");
				var uiTex_in_on = Resources.Load<Texture2D>("IN foldout focus on-5718");

				Header = new GUIStyle(GUI.skin.box);
				Header.padding = new RectOffset(6, 6, 6, 6);
				Header.richText = true;

				Button = new GUIStyle(GUI.skin.button);
				Button.fontSize = 11;

				ButtonSearch = new GUIStyle();
				ButtonSearch.padding = new RectOffset(6, 6, 0, 0);
				ButtonSearch.fontSize = 12;
				ButtonSearch.alignment = TextAnchor.MiddleLeft;

				ButtonSearch.fontStyle = FontStyle.Bold;
				ButtonSearch.normal.textColor = colNormal;
				ButtonSearch.normal.background = Texture2D.whiteTexture;

				Arrow = new GUIStyle(GUI.skin.label);

				Arrow.fontSize = 14;
				Arrow.normal.textColor = colNormal;
				Arrow.normal.background = uiTex_in;
				Arrow.active.textColor = colNormal;
				Arrow.active.background = uiTex_in;
				// 

				Input = new GUIStyle(GUI.skin.textField);

				Row = new GUIStyle(EditorStyles.label);
				Row.padding = new RectOffset(3, 3, 3, 3);
				Row.active.textColor = Color.white;

				Search = new GUIStyle(Row);
				Search.normal.background = Texture2D.whiteTexture;
				Search.active.background = Texture2D.whiteTexture;
				Search.hover.background = Texture2D.whiteTexture;
				Search.focused.background = Texture2D.whiteTexture;

				Search.active.textColor = Color.white;
				Search.hover.textColor = Color.white;
				Search.focused.textColor = Color.white;
				Search.onActive.textColor = Color.white;
				Search.onFocused.textColor = Color.white;
				Search.onHover.textColor = Color.white;
				Search.onNormal.textColor = Color.white;
				//	Search.normal.textColor = Color.white;

				Search.padding = new RectOffset(3, 3, 1, 1);
			}

		}

	}
}