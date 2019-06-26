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
using Sirenix.OdinInspector;
#if UNITY_EDITOR
using UnityEditor;

#if ODIN_INSPECTOR
using Sirenix.Utilities.Editor;
#endif
#endif

namespace Pixeye.Framework
{
	public unsafe class BlueprintEntity : ScriptableBuild
	{
		public static Dictionary<int, BlueprintEntity> storage = new Dictionary<int, BlueprintEntity>(FastComparable.Default);


		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAdd"), Title("Components")]
		internal IComponentCopy[] onCreate = new IComponentCopy[0];

		[SerializeField, HideInInspector]
		internal int lenOnCreate;

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), OnValueChanged("HandleAddLater")]
		internal IComponentCopy[] onLater = new IComponentCopy[0];

		[SerializeField, HideInInspector]
		internal int lenAddLater;

		internal Dictionary<int, IComponentCopy> components = new Dictionary<int, IComponentCopy>(FastComparable.Default);

		[SerializeField, TagFilter(typeof(ITag))]
		internal int[] tags = new int[0];

		internal int[] hashesOnCreate = new int[0];

		internal IEnumerable<Type> GetFilteredTypeList()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies();
			var types = q.SelectMany(x => x.GetTypes())
					.Where(x => !x.IsAbstract)
					.Where(x => typeof(IComponentCopy).IsAssignableFrom(x))
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

		protected override void OnEnable()
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

		protected override void OnDisable()
		{
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

		internal override void Execute(in ent entity, Actor a = null)
		{
			var id = entity.id;

			for (int i = 0; i < lenOnCreate; i++)
			{
				var component = onCreate[i];
				
			 
				var componentID = Storage.typeNames[hashesOnCreate[i]];
		 
				component.Copy(id);
				Entity.components[id].Add(componentID);
			}

			for (int i = 0; i < lenAddLater; i++)
			{
				var component = onLater[i];
				component.Copy(id);
			}

			entity.Set(tags);
			EntityOperations.Set(entity, 0, EntityOperations.Action.Activate);
		}

		internal override void ExecuteOnStart(in ent entity, Actor a)
		{
			var id = entity.id;


			for (int i = 0; i < lenOnCreate; i++)
			{
				var component = onCreate[i];

				var componentID = Storage.typeNames[hashesOnCreate[i]];
				component.Copy(id);
				Entity.components[id].Add(componentID);
			}

			for (int i = 0; i < lenAddLater; i++)
			{
				var component = onLater[i];
				component.Copy(id);
			}

			entity.Set(tags);

			if (a.isActiveAndEnabled)
				EntityOperations.Set(entity, 0, EntityOperations.Action.Activate);
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
			string[]   guids1 = AssetDatabase.FindAssets("l:Blueprint", null);

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

	public interface IComponentCopy
	{
		void Copy(int entityID);
	}

 
	public readonly struct bpt
	{

		public readonly int hash;

		public bpt(int hash)
		{
			this.hash = hash;
		}

		static public implicit operator BlueprintEntity(bpt value)
		{
			return BlueprintEntity.storage[value.hash];
		}

		static public implicit operator bpt(string value)
		{
			var hash = value.GetHashCode();
			if (!BlueprintEntity.storage.TryGetValue(hash, out BlueprintEntity bp))
			{
				bp = Box.Get<BlueprintEntity>(value);
				BlueprintEntity.storage.Add(hash, bp);
			}

			return new bpt(hash);
		}

	}

	public static class HelperBlueprints
	{

		public static BlueprintEntity Get(in this bpt value)
		{
			return BlueprintEntity.storage[value.hash];
		}

	}


 
 

 
	
}
#endif