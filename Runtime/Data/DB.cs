//  Project : ecs
// Contacts : Pix - ask@pixeye.games
#if ODIN_INSPECTOR
using UnityEngine;

namespace Pixeye.Framework
{
	public readonly struct db
	{

		public readonly int hash;

		public db(int hash)
		{
			this.hash = hash;
		}

		static public implicit operator db(string value)
		{
			var hash = value.GetHashCode();
			if (!DataObject.all.TryGetValue(hash, out DataObject db))
			{
				db = Resources.Load<DataObject>(value);
				db.id = hash;
			 
				DataObject.all.Add(hash, db);
			}

			return new db(hash);
		}

	}

	public class DB<T>
	{

		public static int id;

	}
}
#endif