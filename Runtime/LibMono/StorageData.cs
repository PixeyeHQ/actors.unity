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

		public readonly static StorageData<T> Instance = new StorageData<T>();

		public int id;
		public Func<T> create;

		public StorageData()
		{
			id = lastID++;
		}

	}
}