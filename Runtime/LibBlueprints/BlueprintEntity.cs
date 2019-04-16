//  Project : ecs
// Contacts : Pix - ask@pixeye.games

#if ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

		public static Dictionary<int, BlueprintEntity> storage = new Dictionary<int, BlueprintEntity>(FastComparable.Default);

		public DataObject db;

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAdd"), Title("Components")]
		internal IComponent[] onCreate = new IComponent[0];

		[SerializeField, HideInInspector]
		internal int lenOnCreate;

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAddLater")]
		internal IComponent[] onLater = new IComponent[0];

		[SerializeField, HideInInspector]
		internal int lenAddLater;

		internal Dictionary<int, IComponent> components = new Dictionary<int, IComponent>(FastComparable.Default);

		[SerializeField, TagFilter(typeof(ITag))]
		internal int[] tags;

		internal int[] hashesOnCreate = new int[0];

		internal IEnumerable<Type> GetFilteredTypeList()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies();
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

		void OnEnable()
		{
			components.Clear();
			hashesOnCreate = new int[lenOnCreate];

			for (int i = 0; i < lenOnCreate; i++)
			{
				var c = onCreate[i];
				var hash = c.GetType().GetHashCode();
				components.Add(hash, c);
				hashesOnCreate[i] = hash;
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

		#endif

		
		
		 
internal void Populate(in ent entity)
		{
			var id = entity.id;
	Entity.BindDB(id, db.id);
			for (int i = 0; i < lenOnCreate; i++)
			{
				var component = onCreate[i];

				var storage = Storage.allDict[hashesOnCreate[i]];
				component.Copy(id);
				Entity.components[id].Add(storage.GetComponentID());
			}

			for (int i = 0; i < lenAddLater; i++)
			{
				var component = onLater[i];
				component.Copy(id);
			}

			entity.AddLater(tags);
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}
	}

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
				gen.Append($"		public static bpt {strName}= \"{name}\";{Environment.NewLine}");
			}

			templateContents = templateContents.Replace("##CODEGEN1##", gen.ToString());

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
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Pixeye.Framework
{
	public class BlueprintEntity : ScriptableObject
	{

		[NonSerialized]
		public static Dictionary<int, BlueprintEntity> storage = new Dictionary<int, BlueprintEntity>(new FastComparable());

		internal int lenOnCreate;
		internal int lenAddLater;

		internal List<IComponent> onCreate = new List<IComponent>();
		internal List<IComponent> onLater = new List<IComponent>();

		internal int[] hashesOnCreate = new int[1];

		//[FoldoutGroup("Setup")]
		//[TagFilter(typeof(ITag))]
		[HideInInspector]
		public int[] tags = new int[0];

		void OnEnable()
		{
			lenOnCreate = 0;
			lenAddLater = 0;
			tags = new int[0];
			hashesOnCreate = new int[10];
			Setup();
		}

		protected virtual void Setup()
		{
		}

		internal void Populate(in ent entity)
		{
			var id = entity.id;

			for (int i = 0; i < lenOnCreate; i++)
			{
				var component = onCreate[i];

				var storage = Storage.allDict[hashesOnCreate[i]];
				component.Copy(id);
				Entity.components[id].Add(storage.GetComponentID());
			}

			for (int i = 0; i < lenAddLater; i++)
			{
				var component = onLater[i];
				component.Copy(id);
			}

			entity.AddLater(tags);
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		#region REFS OBJECT

		/// <summary>
		/// <para>Adds tags to the entity</para>
		/// </summary>
		/// <param name="tags"></param>
		public void Add(params int[] tags)
		{
			this.tags = tags;
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

			if (lenOnCreate == hashesOnCreate.Length)
			{
				Array.Resize(ref hashesOnCreate, lenOnCreate << 1);
			}
			hashesOnCreate[lenOnCreate++] = typeof(T).GetHashCode();

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
			if (lenOnCreate == hashesOnCreate.Length)
			{
				Array.Resize(ref hashesOnCreate, lenOnCreate << 1);
			}
			hashesOnCreate[lenOnCreate++] = typeof(T).GetHashCode();
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