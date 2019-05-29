//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;

namespace Pixeye.Framework
{

	abstract class StorageDataCore
	{

		public static int lastID;

	}

	class StorageData<T> : StorageDataCore
	{

		public static int id;
		public static Func<T> create;

		public StorageData(Func<T> method)
		{
			id = lastID++;
			create = method;
		}

	}
}