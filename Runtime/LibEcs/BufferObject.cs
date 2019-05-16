//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye.Framework
{
	public sealed class BufferObject<T> where T : class
	{

		public static BufferObject<T> Instance = new BufferObject<T>();
		public static Func<T> creator;

		public T[] source = new T[12];
		public int length;

		public void Add(T obj)
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = obj;
		}
		
		public T Add()
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);
			
			ref var obj = ref  source[length++];
			if (obj == null) obj = creator();

			return obj;
			
		}
		

		public void RemoveAt(int index)
		{
			if (index < --length)
				Array.Copy(source, index + 1, source, index, length - index);
		}

		public void SetElement(int index, T arg)
		{
			source[index] = arg;
		}

	 

		public static T AddDefault()
		{
			var source = Instance;
			if (source.length == source.source.Length)
				Array.Resize(ref source.source, source.length << 1);

		 
			ref var obj = ref source.source[source.length++];
			if (obj == null) obj = creator();

			return obj;
		}
 

	}
}