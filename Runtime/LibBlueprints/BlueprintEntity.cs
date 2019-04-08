//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#if ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
#if UNITY_EDITOR
using UnityEditor;

#if ODIN_INSPECTOR
using Sirenix.Utilities.Editor;

#endif
#endif

 
namespace Pixeye.Framework
{
	public class BlueprintEntity : SerializedScriptableObject
	{

		public static Dictionary<int, BlueprintEntity> storage = new Dictionary<int, BlueprintEntity>(new FastComparable());

		[Title("Setup")]
		public RefType refType = RefType.Entity;

		[SerializeField]
		internal GameObject model;

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAdd"), Title("Components")]
		internal IComponent[] onCreate = new IComponent[0];

		[SerializeField, HideInInspector]
		internal int lenOnCreate;

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAddLater")]
		internal IComponent[] onLater = new IComponent[0];

		[SerializeField, HideInInspector]
		internal int lenAddLater;

		//	[SerializeField, ListDrawerSettings(DraggableItems = false, Expanded = false, OnBeginListElementGUI = "BeginDrawListElement", OnEndListElementGUI = "EndDrawListElement", CustomAddFunction = "EditorAddRefType")]
		//	internal List<ReferenceType> references = new List<ReferenceType>();

		internal Dictionary<int, IComponent> components = new Dictionary<int, IComponent>(new FastComparable());

		[SerializeField, TagFilter(typeof(ITag))]
		internal int[] tags;

		internal IEnumerable<Type> GetFilteredTypeList()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies().Where(x => x != Assembly.GetExecutingAssembly());
			var types = q.SelectMany(x => x.GetTypes())
					.Where(x => !x.IsAbstract)
					.Where(x => typeof(IComponent).IsAssignableFrom(x))
					.Where(x => !ContainsAddLater(x));

			return types;

			bool ContainsAddLater(Type t)
			{
				if (lenAddLater > onLater.Length) return false;
				if (lenOnCreate > onCreate.Length) return false;
				for (int i = 0; i < lenAddLater; i++)
				{
					var c = onLater[i];
					if (c == null) continue;
					if (c.GetType() == t) return true;
				}

				if (onCreate != null)
					for (int i = 0; i < lenOnCreate; i++)
					{
						var c = onCreate[i];
						if (c == null) continue;
						if (c.GetType() == t) return true;
					}

				return false;
			}
		}

		public static BlueprintEntity Create(int id)
		{
			var instance = CreateInstance<BlueprintEntity>();
			storage.Add(id, instance);
			return instance;
		}

//		#region REFS
//
//		/// <summary>
//		/// Add reference to the Unity Component on root for the entity
//		/// </summary>
//		/// <typeparam name="T"></typeparam>
//		public void AddRef<T>() where T : Component
//		{
//			ReferenceType instance = new ReferenceType();
//			instance.type = typeof(T);
//			references.Add(instance);
//		}
//
//		/// <summary>
//		/// Add reference to the Unity Component by path  for the entity
//		/// </summary>
//		/// <param name="path"></param>
//		/// <typeparam name="T"></typeparam>
//		public void AddRef<T>(string path) where T : Component
//		{
//			ReferenceType instance = new ReferenceType();
//			instance.path = path;
//			instance.name = path;
//			instance.type = typeof(T);
//			instance.hash = path.GetHashCode();
//			references.Add(instance);
//		}
//
//		/// <summary>
//		/// Add reference to the Unity Component by path  for the entity with special name
//		/// </summary>
//		/// <param name="path"></param>
//		/// <param name="name"></param>
//		/// <typeparam name="T"></typeparam>
//		public void AddRef<T>(string path, string name) where T : Component
//		{
//			ReferenceType instance = new ReferenceType();
//			instance.name = name;
//			instance.path = path;
//			instance.type = typeof(T);
//			instance.hash = name.GetHashCode();
//			references.Add(instance);
//		}
//
//		#endregion

		#region REFS OBJECT

		/// <summary>
		/// <para>Adds tags to the entity</para>
		/// </summary>
		/// <param name="tags"></param>
		public void Add(params int[] tags)
		{
			this.tags = tags;
		}

		/// <summary>
		/// Add Prefab from Resources folder
		/// </summary>
		/// <param name="path"></param>
		/// <returns>Transform of the prefab</returns>
		public Transform Add(string path)
		{
			var instance = Box.Get<GameObject>(path);
			model = instance;
			return instance.transform;
		}

		#endregion

		#region ADD COMPONENTS

		/// <summary>
		/// Add a component when creating an entity.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T Add<T>() where T : IComponent, new()
		{
			var instance = new T();
			if (onCreate.Length == 0) onCreate = new IComponent[1];
			if (lenOnCreate >= onCreate.Length)
			{
				var l = lenOnCreate << 1;
				Array.Resize(ref onCreate, l);
			}

			var index = lenOnCreate++;
			onCreate[index] = instance;
			components.Add(Storage<T>.componentID, instance);
			return instance;
		}

		/// <summary>
		/// Setup a component when creating an entity but don't add it.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public T AddLater<T>() where T : IComponent, new()
		{
			var instance = new T();
			if (onLater.Length == 0) onLater = new IComponent[1];

			if (lenAddLater >= onLater.Length)
			{
				var l = lenAddLater << 1;
				Array.Resize(ref onLater, l);
			}

			var index = lenAddLater++;
			onLater[index] = instance;
			components.Add(Storage<T>.componentID, instance);
			return instance;
		}

		public T Add<T>(T component) where T : IComponent, new()
		{
			if (onCreate.Length == 0) onCreate = new IComponent[1];
			if (lenOnCreate >= onCreate.Length)
			{
				var l = lenOnCreate << 1;
				Array.Resize(ref onCreate, l);
			}

			var index = lenOnCreate++;
			onCreate[index] = component;
			components.Add(Storage<T>.componentID, component);
			return component;
		}

		public T AddLater<T>(T component) where T : IComponent, new()
		{
			if (onLater.Length == 0) onLater = new IComponent[1];

			if (lenAddLater >= onLater.Length)
			{
				var l = lenAddLater << 1;
				Array.Resize(ref onLater, l);
			}

			var index = lenAddLater++;
			onLater[index] = component;
			components.Add(Storage<T>.componentID, component);
			return component;
		}

		#endregion

		void OnEnable()
		{
	 
	 
			components.Clear();
	  
			storage.Add(name.GetHashCode(), this);

			for (int i = 0; i < lenOnCreate; i++)
			{
				var c = onCreate[i];
				components.Add(c.GetType().GetHashCode(), c);
			}

			for (int i = 0; i < lenAddLater; i++)
			{
				var c = onLater[i];
				components.Add(c.GetType().GetHashCode(), c);
			}
		}

		#if UNITY_EDITOR

		void HandleAdd()
		{
			lenOnCreate = onCreate.Length;
		}

		void HandleAddLater()
		{
			lenAddLater = onLater.Length;
		}

		[Sirenix.OdinInspector.Button(ButtonSizes.Large)]
		internal void GenerateBlueprintTags()
		{
			PostHandleBlueprintTags.Generate();
		}

//		ReferenceType EditorAddRefType()
//		{
//			return new ReferenceType();
//		}

		#endif

	}

//	[HideReferenceObjectPicker]
//	public class ReferenceType
//	{
//
//		[ShowInInspector, ReadOnly]
//		public int[] siblings;
//
//		[ReadOnly]
//		public int hash;
//
//		[ReadOnly]
//		public string path;
//
//		[OnValueChanged("GenerateHash")]
//		public string name;
//
//		public Type type;
//
//		#if UNITY_EDITOR
//		[Tooltip("A special variable that helps to setup reference. Not included in build.")]
//		[OnValueChanged("GenerateType")]
//		public Component component;
//
//		void GenerateHash()
//		{
//			hash = name.GetHashCode();
//		}
//
//		void GenerateType()
//		{
//			if (component == null)
//			{
//				type = null;
//				return;
//			}
//
//			type = component.GetType();
//
////			if (typeof(Collider2D).IsAssignableFrom(type))
////			{
////				type = typeof(Collider2D);
////			}
////			else if (typeof(Collider).IsAssignableFrom(type))
////			{
////				type = typeof(Collider);
////			}
//
//			Transform transform = component.transform;
//			siblings = new int[0];
//			path = HelperFramework.GetGameObjectPath(transform, ref siblings);
//			name = transform.parent == null ? "self" : path;
//			hash = name.GetHashCode();
//		}
//		#endif
//
//	}

	#if UNITY_EDITOR
	public static class PostHandleBlueprintTags
	{

		public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpBlueprintTags.txt";

		public static void Generate()
		{
			var path = HelperFramework.GetPathLibrary();
			if (path == string.Empty)
				path = PATH_TO_TEMPLATE;
			else path = string.Format($"{path}/Editor/Templates/TmpBlueprintTags.txt");

			var o = CreateScript("Assets/Source/Runtime/Tags/Blueprints.cs", path);
			ProjectWindowUtil.ShowCreatedAsset((Object) o);
			AssetDatabase.Refresh();
		}

		public static object CreateScript(string pathName, string templatePath)
		{
			var filePath = Path.GetFullPath(pathName);

			var templateContents = string.Empty;

			if (!File.Exists(templatePath)) return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
			using (var t = new StreamReader(templatePath))
			{
				t.ReadLine();
				templateContents = t.ReadToEnd();
			}

			FastString gen = new FastString(6000);
			string[] guids1 = AssetDatabase.FindAssets("l:Blueprint", null);

			foreach (var guid in guids1)
			{
				var name = Path.GetFileNameWithoutExtension(AssetDatabase.GUIDToAssetPath(guid));

				var strName = name.Split(' ')[1];
				gen.Append($"public static bpt {strName} = \"{name}\".GetHashCode();{Environment.NewLine}");
			}

			templateContents = templateContents.Replace("##CODEGEN##", gen.ToString());

			var encoding = new UTF8Encoding(true, false);

			using (var tc = new StreamWriter(filePath, false, encoding))
			{
				tc.Write(templateContents);
			}

			AssetDatabase.ImportAsset(pathName);
			AssetDatabase.Refresh();

			return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
		}

	}
	#endif
}
#else

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public class BlueprintEntity : ScriptableObject
	{

		[NonSerialized]
		public static Dictionary<int, BlueprintEntity> storage = new Dictionary<int, BlueprintEntity>(new FastComparable());

		//internal int id;

		[FoldoutGroup("Setup")]
		public RefType refType = RefType.Entity;

		[FoldoutGroup("Setup")]
		[SerializeField]
		internal GameObject model;

		internal int lenOnCreate;
		internal int lenAddLater;

		internal List<IComponent> onCreate = new List<IComponent>();
		internal List<IComponent> onLater = new List<IComponent>();

		[FoldoutGroup("Setup")]
		[TagFilter(typeof(ITag))]
		public int[] tags = new int[0];

		void OnEnable()
		{
			lenOnCreate = 0;
			lenAddLater = 0;
			tags = new int[0];
			if (name != string.Empty)
			{
				storage.Add(name.GetHashCode(), this);
			}

			Setup();
		}

		protected virtual void Setup()
		{
		}

		#region REFS OBJECT

		/// <summary>
		/// <para>Adds tags to the entity</para>
		/// </summary>
		/// <param name="tags"></param>
		public void AddTags(params int[] tags)
		{
			this.tags = tags;
		}

		/// <summary>
		/// Add Prefab from Resources folder
		/// </summary>
		/// <param name="path"></param>
		/// <returns>Transform of the prefab</returns>
		public Transform AddPrefab(string path)
		{
			var instance = Box.Get<GameObject>(path);
			model = instance;
			return instance.transform;
		}

		#endregion

		#region ADD COMPONENTS

		/// <summary>
		/// Add a component when creating an entity.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T Add<T>() where T : class, IComponent, new()
		{
			var instance = new T();
			onCreate.Add(instance);
			lenOnCreate++;
			return instance;
		}
		/// <summary>
		/// Setup a component when creating an entity but don't add it.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public T AddLater<T>() where T : class, IComponent, new()
		{
			var instance = new T();
			onLater.Add(instance);
			lenAddLater++;
			return instance;
		}

		public T Add<T>(T component) where T : class, IComponent, new()
		{
			onCreate.Add(component);
			lenOnCreate++;
			return component;
		}

		public T AddLater<T>(T component) where T : class, IComponent, new()
		{
			onLater.Add(component);
			lenAddLater++;
			return component;
		}

		#endregion

	}
}

#endif