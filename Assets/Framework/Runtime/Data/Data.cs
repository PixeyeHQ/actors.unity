//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/12/2019 

using System.Collections.Generic;

namespace Pixeye.Framework.Data
{
	public static class Data
	{
		internal static readonly Dictionary<int, Dictionary<int, object>> storage = new Dictionary<int, Dictionary<int, object>>(new FastComparable());

		public static T Get<T>(int id)
		{
			return (T) storage[id][typeof(T).GetHashCode()];
		}

		public static T Get<T>(int id, int hash)
		{
			return (T) storage[id][hash];
		}

		public static int settings(this ent e)
		{
			return 0;
	 
		}
	}
}