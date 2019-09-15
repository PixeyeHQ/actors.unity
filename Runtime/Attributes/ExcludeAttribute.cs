//  Project : ecs.unity.structs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public class ExcludeAttribute : Attribute
	{
		public int[] filter = new int[0];
		public int[] filterType = new int[0];

		public ExcludeAttribute(params int[] filter)
		{
			this.filter = filter;
		}

		public ExcludeAttribute(params object[] args)
		{
			var f     = new List<int>();
			var fType = new List<int>();
			for (int i = 0; i < args.Length; i++)
			{
				var o = args[i];

				if (o is string)
				{
					fType.Add(Storage.typeNames[ByName(o.ToString()).GetHashCode()]);
				}
				else f.Add((int) o);
			}

			filterType = fType.ToArray();
			filter     = f.ToArray();
		}

		public ExcludeAttribute(params string[] args)
		{
			var fType = new List<int>();
			for (int i = 0; i < args.Length; i++)
			{
				fType.Add(ByName(args[i]).GetHashCode());
			}


			filterType = fType.ToArray();
		}


		public static Type ByName(string name)
		{
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				var tt = assembly.GetType(name);
				if (tt != null)
				{
					return tt;
				}
			}

			return null;
		}
	}
}