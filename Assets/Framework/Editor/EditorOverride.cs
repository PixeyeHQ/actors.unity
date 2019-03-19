#if!ODIN_INSPECTOR


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye
{
	[CustomEditor(typeof(Object), true, isFallback = true)]
	[CanEditMultipleObjects]
	public class EditorOverride : Editor
	{
		Dictionary<string, Cache> cache = new Dictionary<string, Cache>();
		List<SerializedProperty> props = new List<SerializedProperty>();
		SerializedProperty propScript;
		Type type;
		int length;
		List<FieldInfo> objectFields;

		bool initialized;
		FoldoutGroupAttribute prevFold;


		void OnEnable()
		{
			Repaint();
			initialized = false;
		}

		void OnDisable()
		{
			foreach (var cach in cache)
			{
				cach.Value.Dispose();
			}
		}


		public override void OnInspectorGUI()
		{
			serializedObject.Update();


			if (!initialized)
			{
				var t        = target.GetType();
				var typeTree = t.GetTypeTree();
				objectFields = target.GetType()
						.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
						           BindingFlags.Instance)
						.OrderByDescending(x => typeTree.IndexOf(x.DeclaringType))
						.ToList();


				length = objectFields.Count;


				for (var i = 0; i < length; i++)
				{
					var fold = Attribute.GetCustomAttribute(objectFields[i], typeof(FoldoutGroupAttribute)) as FoldoutGroupAttribute;

					Cache c;
					if (fold == null)
					{
						if (prevFold != null && prevFold.foldEverything)
						{
							if (!cache.TryGetValue(prevFold.name, out c))
							{
								cache.Add(prevFold.name, new Cache {atr = prevFold, types = new HashSet<string> {objectFields[i].Name}});
							}
							else
							{
								c.types.Add(objectFields[i].Name);
							}
						}

						continue;
					}

					prevFold = fold;
					if (!cache.TryGetValue(fold.name, out c))
					{
						cache.Add(fold.name, new Cache {atr = fold, types = new HashSet<string> {objectFields[i].Name}});
					}
					else
					{
						c.types.Add(objectFields[i].Name);
					}
				}


				var property = serializedObject.GetIterator();
				var next     = property.NextVisible(true);
				if (next)
				{
					do
					{
						HandleProp(property);
					} while (property.NextVisible(false));
				}
			}

			if (props.Count == 0)
			{
				DrawDefaultInspector();
				return;
			}

			initialized = true;

			using (new EditorGUI.DisabledScope("m_Script" == props[0].propertyPath))
			{
				EditorGUILayout.Space();
				EditorGUILayout.PropertyField(props[0], true);
				EditorGUILayout.Space();
			}

			foreach (var pair in cache)
			{
				this.UseVerticalBoxLayout(() => Foldout(pair.Value), EditorUIStyles.box);
				EditorGUI.indentLevel = 0;
			}

			EditorGUILayout.Space();

			for (var i = 1; i < props.Count; i++)
			{
				EditorGUILayout.PropertyField(props[i], true);
			}


			serializedObject.ApplyModifiedProperties();
			EditorGUILayout.Space();


			void Foldout(Cache cache)
			{
				cache.expanded = EditorGUILayout.Foldout(cache.expanded, cache.atr.name, true,
						EditorUIStyles.foldout);

				if (cache.expanded)
				{
					EditorGUI.indentLevel = 1;
					for (int i = 0; i < cache.props.Count; i++)
					{
						this.UseVerticalBoxLayout(() => Child(i), EditorUIStyles.boxChild);
					}
				}

				void Child(int i)
				{
					//	GUI.color = Color.cyan;
					EditorGUILayout.PropertyField(cache.props[i],
							new GUIContent(cache.props[i].name.FirstLetterToUpperCase()), true);

					//	GUI.color = Color.white;
				}
			}
			Repaint();
		}


		public void HandleProp(SerializedProperty prop)
		{
			bool shouldBeFolded = false;

			foreach (var pair in cache)
			{
				if (pair.Value.types.Contains(prop.name))
				{
					shouldBeFolded = true;
					pair.Value.props.Add(prop.Copy());

					break;
				}
			}

			if (shouldBeFolded == false)
			{
				props.Add(prop.Copy());
			}
		}


		class Cache
		{
			public HashSet<string> types = new HashSet<string>();
			public List<SerializedProperty> props = new List<SerializedProperty>();
			public FoldoutGroupAttribute atr;
			public bool expanded;

			public void Dispose()
			{
				props.Clear();
				types.Clear();
				atr = null;
			}
		}
	}
}
#endif