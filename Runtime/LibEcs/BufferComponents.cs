//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.InteropServices;

namespace Pixeye.Framework
{
	[StructLayout(LayoutKind.Sequential)]
	public struct BufferComponents
	{

		public ushort[] components;
		public byte length;
		public byte ageCache;  // caching age of entity for retrivieng it in future. ( ParseBy method )

		public ref ushort GetComponent(int id)
		{
			return ref components[id];
		}

		public BufferComponents(int size)
		{
			components = new ushort[size];
			length = 0;
			ageCache = 0;
		}

		public void Setup(byte ageCache)
		{
			length = 0;
			this.ageCache = ageCache;
			if (components == null) components = new ushort[1];
		}

		public void Clear()
		{
			length = 0;
		}

		public void Add(int type)
		{
			if (length == components.Length)
				Array.Resize(ref components, length << 1);

			components[length++] = (ushort) type;
		}

		public void Remove(int type)
		{
			var typeConverted = (ushort) type;

			for (int i = 0; i < length; i++)
			{
				if (components[i] == typeConverted)
				{
					RemoveAt(i);
					break;
				}
			}
		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < length - 1; ++i)
				SetElement(i, components[i + 1]);

			length--;
		}

		public void SetElement(int index, int arg)
		{
			components[index] = (ushort) arg;
		}

//		private ushort GetElement(int index)
		//		{
		//			return components[index];
		//		}

	}
}