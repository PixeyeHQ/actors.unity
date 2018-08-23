/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       17/09/2017 11:58
================================================================*/


using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public class ProcessingResources
	{
		public static ProcessingResources Default;

		private Dictionary<string, Object> items = new Dictionary<string, Object>();


		public static T Get<T>(string id) where T : Object
		{
#if HOMEBREW_EDIT
			return Resources.Load<T>(id);
#else
	Object obj;
			var hasValue = Default.items.TryGetValue(id, out obj);
			if (hasValue == false)
			{
				obj = Resources.Load<T>(id);
				Default.items.Add(id, obj);
			}

			return obj as T;
#endif
		}

		public static T GetPrefab<T>(string id) where T : Object
		{
			Object obj;
			var hasValue = Default.items.TryGetValue(id, out obj);

			if (hasValue == false)
			{
				obj = Resources.Load("Prefabs/" + id) as GameObject;
				Default.items.Add(id, obj);
			}

			return obj as T;
		}
	}
}