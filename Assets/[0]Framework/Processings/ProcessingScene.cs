/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       11/10/2017 21:22
================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
	public class ProcessingScene : IDisposable
	{
		public static ProcessingScene Default;

		protected readonly Dictionary<string, Transform> sceneObjs = new Dictionary<string, Transform>();


		public void Dispose()
		{
			sceneObjs.Clear();
		}

		public Transform Get(string id)
		{
			Transform obj;
			var haveFound = sceneObjs.TryGetValue(id, out obj);
			if (!haveFound)
			{
				var o = GameObject.Find(id);
				if (o)
					obj = o.transform;
				if (obj) sceneObjs.Add(id, obj);
			}

			return obj;
		}

		public Transform Get(WorldParenters parent)
		{
			switch (parent)
			{
				case WorldParenters.Level:
					return Get("Dynamic");
				case WorldParenters.UI:
					return Get("[UI]");
				case WorldParenters.None:
					return Get("[SCENE]");
			}

			return null;
		}
	}

 
}