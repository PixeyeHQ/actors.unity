//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

using System;
 
namespace Pixeye.Framework
{
	public sealed class BufferObject<T> where T : class
	{

		public static BufferObject<T> Default = new BufferObject<T>();
		public static Func<T> creator;

		public T[] source = new T[12];
		public int length;

		public void Add(T obj)
		{
			if (length == source.Length)
				Array.Resize(ref source, length << 1);

			source[length++] = obj;
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

		public static T Add()
		{
			var source = Default;
			if (source.length == source.source.Length)
				Array.Resize(ref source.source, source.length << 1);

			var l = source.length++;
			ref var obj = ref source.source[l];
			if (obj == null) obj = creator();

			return obj;
		}

		public static T Create()
		{
			var source = Default;
			if (source.length == source.source.Length)
				Array.Resize(ref source.source, source.length << 1);

			var l = source.length;
			ref var obj = ref source.source[l];
			if (obj == null) obj = creator();

			return obj;
		}

		public static void Deploy()
		{
			Default.length++;
		}

	}
}