//  Project : ecs
// Contacts : Pix - ask@pixeye.games
#if !ODIN_INSPECTOR
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEditor;
//using UnityEngine;
//
//namespace Pixeye
//{
//	[CustomEditor(typeof(Blueprint), true, isFallback = true)]
//	public class InspectorBlueprints : Editor
//	{
//
//		const int stateMain = 0;
//		const int stateFind = 1;
//		const int stateMainShow = 2;
//
//		Blueprint blueprint;
//
//		public int state = stateMain;
//		Vector2 scrollPos;
//
//		readonly IEnumerable<Type> componentTypes = AppDomain.CurrentDomain.GetAssemblies()
//				.SelectMany(s => s.GetTypes())
//				.Where(p => typeof(IComponent).IsAssignableFrom(p) && p.IsClass);
//
//		readonly List<string> namespaces = new List<string>();
//
//		string searchString = "";
//		int namespaceIndex = -1;
//
//		string[] allTypes;
//		string[] currentTypes;
//		IEnumerable<string> contents;
//		int lenContents;
//		int prevCache;
//
//		IEnumerable<Type> GetByNamespace(int index)
//		{
//			var str = namespaces[index];
//			return AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IComponent).IsAssignableFrom(p) && p.IsClass && p.Namespace == str);
//		}
//
//		void OnEnable()
//		{
//			blueprint = target as Blueprint;
//
//			blueprint.component = new ComponentDefault();
//
//			var list = componentTypes.ToList();
//			var len  = list.Count;
//			for ( int i = 0; i < len; i++ )
//			{
//				var element = list[i];
//				if (!namespaces.Contains(element.Namespace))
//				{
//					namespaces.Add(element.Namespace);
//				}
//			}
//
//			allTypes = componentTypes.Select(s => s.Name).ToArray();
//		}
//
//		public override void OnInspectorGUI()
//		{
//			base.OnInspectorGUI();
//			HandleStateMain();
//			HandleStateFind();
//		}
//
//		void HandleStateMain()
//		{
//			if (state != stateMain && state != stateMainShow) return;
//
//			Style.Header.UseHorizontalLayout(() =>
//			{
//				EditorStyles.label.UseLabel(string.Format($"Components: {blueprint.components.Count} "));
//
//				if (this.UseButton("Add Component", Style.Button))
//				{
//					state = stateFind;
//				}
//
//				GUILayout.Space(2f);
//
//				if (state == stateMain && this.UseButton("▸", Style.Button))
//				{
//					state = stateMainShow;
//				}
//
//				if (state == stateMainShow && this.UseButton("▾", Style.Button))
//				{
//					state = stateMain;
//				}
//			});
//			InspectorComponent.ShowComponentProperties(blueprint.component);
//		}
//		void HandleStateFind()
//		{
//			if (state != stateFind) return;
//
//			var name = namespaceIndex != -1 && prevCache > 0 ? "X" : "Back";
//
//			Style.Header.UseHorizontalLayout(() =>
//			{
//				EditorStyles.label.UseLabel("Find: ", 64);
//				var col = GUI.backgroundColor;
//				GUI.backgroundColor = Style.colDark;
//
//				searchString = Style.Search.UseTextInput("", searchString);
//				GUI.SetNextControlName("search");
//				GUI.backgroundColor = col;
//
//				if (state == stateFind && this.UseButton(name, Style.Button))
//				{
//					if (namespaceIndex != -1)
//					{
//						searchString = "";
//						GUI.FocusControl("search");
//
//						namespaceIndex = -1;
//						return;
//					}
//
//					state = stateMain;
//				}
//			});
//
//			StateShowNamespaces();
//
//			void StateShowNamespaces()
//			{
//				if (searchString.Length != prevCache)
//				{
//					prevCache = searchString.Length;
//					if (prevCache > 0)
//					{
//						contents = allTypes.Where(p => p.Contains(searchString));
//						lenContents = contents.Count();
//						if (lenContents == 0) namespaceIndex = -2;
//						else namespaceIndex = 0;
//					}
//					else
//						namespaceIndex = -1;
//				}
//
//				if (namespaceIndex == -2)
//				{
//					EditorStyles.label.UseLabel("Nothing Found", EditorGUIUtility.currentViewWidth / 2);
//				}
//				else if (lenContents > 0 && searchString.Length > 0)
//				{
//					namespaceIndex = 0;
//					var rowIndex = 0;
//
//					if (Event.current.isKey)
//					{
//						if (Event.current.keyCode == KeyCode.Tab)
//						{
//						}
//					}
//
//					Style.Header.UseVerticalLayout(() =>
//					{
//						scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(EditorGUIUtility.currentViewWidth - 31f), GUILayout.Height(Mathf.Clamp(lenContents * 26, 32, 400)));
//
//						foreach ( var c in contents )
//						{
//							GUI.backgroundColor = rowIndex++ % 2 == 0 ? Style.colDark : Style.colLight;
//
//							Style.ButtonSearch.UseHorizontalLayout(() =>
//							{
//								if (this.UseButton(c, Style.Row, 21))
//								{
//									AddComponent(c);
//								}
//							});
//							GUILayout.Space(1f);
//						}
//
//						EditorGUILayout.EndScrollView();
//					});
//				}
//				else if (namespaceIndex == -1)
//				{
//					Style.Header.UseVerticalLayout(() =>
//					{
//						var len = namespaces.Count;
//						for ( int i = 0; i < len; i++ )
//						{
//							GUI.backgroundColor = i % 2 == 0 ? Style.colDark : Style.colLight;
//
//							Style.ButtonSearch.UseHorizontalLayout(() =>
//							{
//								if (this.UseButton(namespaces[i], Style.Row, 21))
//								{
//									namespaceIndex = i;
//									var types = GetByNamespace(i);
//									currentTypes = types.Select(x => x.Name).ToArray();
//								}
//
//								if (this.UseButton("▸", Style.Row))
//								{
//									namespaceIndex = i;
//									var types = GetByNamespace(i);
//									currentTypes = types.Select(x => x.Name).ToArray();
//								}
//							});
//
//							GUILayout.Space(1f);
//						}
//					});
//				}
//				else
//				{
//					Style.Header.UseVerticalLayout(() =>
//					{
//						scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(EditorGUIUtility.currentViewWidth - 31f), GUILayout.Height(Mathf.Clamp(currentTypes.Length * 26, 32, 400)));
//						for ( int i = 0; i < currentTypes.Length; i++ )
//						{
//							GUI.backgroundColor = i % 2 == 0 ? Style.colDark : Style.colLight;
//
//							Style.ButtonSearch.UseHorizontalLayout(() =>
//							{
//								if (this.UseButton(currentTypes[i], Style.Row, 21))
//								{
//									AddComponent(currentTypes[i]);
//								}
//							});
//							GUILayout.Space(1f);
//						}
//
//						EditorGUILayout.EndScrollView();
//					});
//				}
//			}
//		}
//
//		void AddComponent(string id)
//		{
//			blueprint.components.Add(Activator.CreateInstance<ComponentRelease>());
//		}
//
//		static class Style
//		{
//
//			public static Color colDark = new Color(51 / 255f, 51 / 255f, 51 / 255f, 1);
//			public static Color colLight = new Color(56 / 255f, 56 / 255f, 56 / 255f, 1);
//			public static Color colNormal = new Color(0.75f, 0.75f, 0.75f, 1);
//			public static GUIStyle Header;
//			public static GUIStyle Button;
//			public static GUIStyle ButtonSearch;
//			public static GUIStyle Input;
//			public static GUIStyle Arrow;
//			public static GUIStyle Row;
//			public static GUIStyle Search;
//			static Style()
//			{
//				Header = new GUIStyle(GUI.skin.box);
//				Header.padding = new RectOffset(6, 6, 6, 6);
//				Header.richText = true;
//
//				Button = new GUIStyle(GUI.skin.button);
//				Button.fontSize = 11;
//
//				ButtonSearch = new GUIStyle();
//				ButtonSearch.padding = new RectOffset(6, 6, 0, 0);
//				ButtonSearch.fontSize = 12;
//				ButtonSearch.alignment = TextAnchor.MiddleLeft;
//
//				ButtonSearch.fontStyle = FontStyle.Bold;
//				ButtonSearch.normal.textColor = colNormal;
//				ButtonSearch.normal.background = Texture2D.whiteTexture;
//
//				Arrow = new GUIStyle(GUI.skin.label);
//
//				Arrow.fontSize = 14;
//				Arrow.normal.textColor = colNormal;
//
//				Arrow.active.textColor = colNormal;
//
//				// 
//
//				Input = new GUIStyle(GUI.skin.textField);
//
//				Row = new GUIStyle(EditorStyles.label);
//				Row.padding = new RectOffset(3, 3, 3, 3);
//				Row.active.textColor = Color.white;
//
//				Search = new GUIStyle(Row);
//				Search.normal.background = Texture2D.whiteTexture;
//				Search.active.background = Texture2D.whiteTexture;
//				Search.hover.background = Texture2D.whiteTexture;
//				Search.focused.background = Texture2D.whiteTexture;
//
//				Search.active.textColor = Color.white;
//				Search.hover.textColor = Color.white;
//				Search.focused.textColor = Color.white;
//				Search.onActive.textColor = Color.white;
//				Search.onFocused.textColor = Color.white;
//				Search.onHover.textColor = Color.white;
//				Search.onNormal.textColor = Color.white;
//				//	Search.normal.textColor = Color.white;
//
//				Search.padding = new RectOffset(3, 3, 1, 1);
//			}
//
//		}
//
//		static class InspectorComponent
//		{
//
//			public static void ShowComponentProperties<T>(T component)
//					where T 
//			{
//				var componentFields = component.GetType().GetFields();
//
//				foreach ( var field in componentFields )
//				{
//					EditorGUILayout.BeginHorizontal();
//					var fieldType  = field.FieldType;
//					var fieldValue = field.GetValue(component);
//
//					var handler = DefaultEditorInputRegistry.GetHandlerFor(fieldType);
//					if (handler == null)
//					{
//						Debug.LogWarning("This type is not supported: " + fieldType.Name + " - In component: " + component.GetType().Name);
//						EditorGUILayout.EndHorizontal();
//						continue;
//					}
//
//					var updatedValue = handler.CreateUI(field.Name, fieldValue);
//
//					if (updatedValue != null)
//					{
//						field.SetValue(component, updatedValue);
//					}
//
//					EditorGUILayout.EndHorizontal();
//				}
//			}
//
//		}
//
//	}
//}
#endif