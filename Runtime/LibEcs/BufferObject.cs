//  Project : game.metro
// Contacts : Pix - ask@pixeye.games

using System;

namespace Pixeye.Framework
{
	public sealed class BufferObject<T>
			where T : class
	{

		public static BufferObject<T> Instance = new BufferObject<T>();
		public static Func<T> creator;

		public T[] container = new T[12];
		public int length;

		public void Add(T obj)
		{
			if (length == container.Length)
				Array.Resize(ref container, length << 1);

			container[length++] = obj;
		}

		public void RemoveAt(int i)
		{
			var l = length--;
			var next = i + 1;
			var size = l - i;
			Array.Copy(container, next, container, i, size);
		}

		public void SetElement(int index, T arg)
		{
			container[index] = arg;
		}

		public static T Add()
		{
			var source = Instance;
			if (source.length == source.container.Length)
				Array.Resize(ref source.container, source.length << 1);

			var l = source.length++;
			ref var obj = ref source.container[l];
			if (obj == null) obj = creator();

			return obj;
		}

		public static T Create()
		{
			var source = Instance;
			if (source.length == source.container.Length)
				Array.Resize(ref source.container, source.length << 1);

			var l = source.length;
			ref var obj = ref source.container[l];
			if (obj == null) obj = creator();

			return obj;
		}

		public static void Deploy()
		{
			Instance.length++;
		}

	}
}