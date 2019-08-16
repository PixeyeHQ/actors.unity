//  Project : ecs.unity.structs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;

namespace Pixeye.Framework
{
	public class GroupExcludeAttribute : Attribute
	{
		public int[] filter = new int[0];
		public int[] filterType = new int[0];

		public GroupExcludeAttribute(params int[] filter)
		{
			this.filter = filter;
		}

		public GroupExcludeAttribute(params object[] args)
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