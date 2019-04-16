//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/12/2019 

#if ODIN_INSPECTOR

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using Unity.IL2CPP.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using Object = UnityEngine.Object;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class DataObject : SerializedScriptableObject
	{

		internal static Dictionary<int, DataObject> all = new Dictionary<int, DataObject>(FastComparable.Default);

		#if UNITY_EDITOR
		internal static bool changed;
		#endif

		internal static int lastID;

		[HideInInspector]
		public int id;

		[SerializeField, HideInInspector]
		internal List<IData> containerRuntime = new List<IData>();

		#if UNITY_EDITOR
		[InfoBox("DONT FORGET TO UPDATE")]
		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), Title("Setup")]
		internal List<IData> container = new List<IData>();
		#endif

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Get<T>(in ent entity, int tag) where T : class
		{
			return all[Entity.db[entity.id]].containerRuntime[tag] as T;
		}

		#if UNITY_EDITOR

		internal IEnumerable<Type> GetFilteredTypeList()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies().Where(x => x != Assembly.GetExecutingAssembly());
			var types = q.SelectMany(x => x.GetTypes())
					.Where(x => !x.IsAbstract)
					.Where(x => typeof(IData).IsAssignableFrom(x))
					.Where(x => !Contains(x));

			return types;

			bool Contains(Type t)
			{
				if (container.Count == 0) return false;
				for (int i = 0; i < container.Count; i++)
				{
					var c = container[i];
					if (c == null) continue;
					if (c.GetType() == t) return true;
				}

				return false;
			}
		}

		internal void OnAdd()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies().Where(x => x != Assembly.GetExecutingAssembly());
			var qTypes = q.SelectMany(x => x.GetTypes())
					.Where(x => !x.IsAbstract)
					.Where(x => typeof(IData).IsAssignableFrom(x));

			var types = qTypes.ToArray();
			containerRuntime = new List<IData>(types.Length);

			for (int i = 0; i < types.Length; i++)
			{
				var t = types[i];
				containerRuntime.Add(null);
				var o = container.Find(v => v.GetType() == t);
				if (o != null)
				{
					byte[] bytes = SerializationUtility.SerializeValue(o, DataFormat.Binary);
					containerRuntime[i] = SerializationUtility.DeserializeValue<IData>(bytes, DataFormat.Binary);
				}
			}
		}

		[Sirenix.OdinInspector.Button(ButtonSizes.Large)]
		public void Update()
		{
			OnAdd();
		}

		[Sirenix.OdinInspector.Button(ButtonSizes.Large)]
		public void GenerateDatas()
		{
			var arr = GetFilteredTypeList().ToList();
			changed = arr.Count > 0;
			for (int i = 0; i < arr.Count; i++)
			{
				container.Add(Activator.CreateInstance(arr[i]) as IData);
			}
			if (changed)
				PostHandleDataTags.Generate();
			changed = false;
		}
		#endif

		#if UNITY_EDITOR
		public static class PostHandleDataTags
		{

			public const string PATH_TO_TEMPLATE = @"Assets\Framework\Editor\Templates\TmpDataTags.txt";

			public static void Generate()
			{
				var path = HelperFramework.GetPathLibrary();
				if (path == string.Empty)
					path = PATH_TO_TEMPLATE;
				else path = string.Format($"{path}/Editor/Templates/TmpDataTags.txt");

				var o = CreateScript("Assets/Source/Runtime/Tags/DataBase.cs", path);
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

				var vals = GetFilteredTypeList();

				string[] guids1 = AssetDatabase.FindAssets("l:DataObject", null);

				foreach (var guid in guids1)
				{
					var name = Path.GetFileNameWithoutExtension(AssetDatabase.GUIDToAssetPath(guid));

					var strName = name.Split(' ')[1];
					gen.Append($"public static db {strName}= \"{name}\";{Environment.NewLine}");
				}

				templateContents = templateContents.Replace("##CODEGEN1##", gen.ToString());

				gen.Clear();
				int index = 0;
				foreach (var guid in vals)
				{
					gen.Append($"DB<{guid.Name}>.id  =  {index++};{Environment.NewLine}");
				}

				templateContents = templateContents.Replace("##CODEGEN2##", gen.ToString());
				var encoding = new UTF8Encoding(true, false);

				using (var tc = new StreamWriter(filePath, false, encoding))
				{
					tc.Write(templateContents);
				}

				AssetDatabase.ImportAsset(pathName);
				AssetDatabase.Refresh();

				return (MonoScript) AssetDatabase.LoadAssetAtPath(pathName, typeof(MonoScript));
			}

			internal static IEnumerable<Type> GetFilteredTypeList()
			{
				var q = AppDomain.CurrentDomain.GetAssemblies().Where(x => x != Assembly.GetExecutingAssembly());
				var types = q.SelectMany(x => x.GetTypes())
						.Where(x => !x.IsAbstract)
						.Where(x => typeof(IData).IsAssignableFrom(x));

				return types;
			}

		}
		#endif

	}
	 
}
#endif