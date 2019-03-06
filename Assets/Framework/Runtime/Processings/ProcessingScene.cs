//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye
{
	public class ProcessingScene : IDisposable, IKernel
	{
		public static ProcessingScene Default = new ProcessingScene();

		protected readonly Dictionary<string, Transform> sceneObjs = new Dictionary<string, Transform>();
 
		public void Dispose()
		{
			sceneObjs.Clear();
		}
		
		public static Transform Get(string id)
		{
	 
			Transform obj;
			var       haveFound = Default.sceneObjs.TryGetValue(id, out obj);
			if (!haveFound)
			{
				var o = GameObject.Find(id);
				if (o)
					obj = o.transform;
				if (obj) Default.sceneObjs.Add(id, obj);
			}

			return obj;
		}

		public static Transform Get(ref string id)
		{
	 
			Transform obj;
			var       haveFound = Default.sceneObjs.TryGetValue(id, out obj);
			if (!haveFound)
			{
				var o = GameObject.Find(id);
				if (o)
					obj = o.transform;
				if (obj) Default.sceneObjs.Add(id, obj);
			}

			return obj;
		}
	 
	}

 
}