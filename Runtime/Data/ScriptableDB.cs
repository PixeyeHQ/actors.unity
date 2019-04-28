//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

#if ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using System.Linq;
using Pixeye.Framework;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Pixeye
{
	[CreateAssetMenu(fileName = "DB", menuName = "Actors/Add/Data/Base")]
	[ShowOdinSerializedPropertiesInInspector]
	public class ScriptableCoreDb : CoreDB, ISerializationCallbackReceiver
	{

		[SerializeField, HideReferenceObjectPicker, TypeFilter("GetFilteredTypeList"), Title("Setup"), ListDrawerSettings(DraggableItems = false)]
		public IData[] components = new IData[0];

		#region SERILIZATION

		[SerializeField, HideInInspector, ExcludeDataFromInspector]
		private SerializationData serializationData;

		public void OnBeforeSerialize()
		{
			UnitySerializationUtility.SerializeUnityObject(this, ref serializationData);
		}

		public void OnAfterDeserialize()
		{
			UnitySerializationUtility.DeserializeUnityObject(this, ref serializationData);
		}

		#endregion

		#if UNITY_EDITOR

		internal IEnumerable<Type> GetFilteredTypeList()
		{
			var q = AppDomain.CurrentDomain.GetAssemblies();
			var types = q.SelectMany(x => x.GetTypes())
					.Where(x => !x.IsAbstract)
					.Where(x => typeof(IData).IsAssignableFrom(x))
					.Where(x => !Contains(x));

			return types;

			bool Contains(Type t)
			{
				if (components.Length == 0) return false;
				for (int i = 0; i < components.Length; i++)
				{
					var c = components[i];
					if (c == null) continue;
					if (c.GetType() == t) return true;
				}

				return false;
			}
		}
		#endif

		public override void Setup()
		{
			foreach (IData component in components)
			{
				Add(component);
			}
		}

	}
}
#endif