//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Framework
{

	public abstract class StorageDataCore
	{

		public static int lastID;

	}

	public class StorageData<T> : StorageDataCore
	{

		public static StorageData<T> Instance;

		public int id;
		public Func<T> create;

		public StorageData(Func<T> create)
		{
			id = lastID++;
			this.create = create;
		}

	}
}