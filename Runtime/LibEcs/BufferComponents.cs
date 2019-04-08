//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.InteropServices;

namespace Pixeye
{
	[StructLayout(LayoutKind.Sequential)]
	public struct BufferComponents
	{

		private ushort[] components;
		public byte length;

		public ref ushort GetComponent(int id)
		{
			return ref components[id];
		}
		
		public BufferComponents(int size)
		{
			components = new ushort[size];
			length = 0;
		}

		public void Setup()
		{
			if (components == null) components = new ushort[1];
			length = 0;
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
				SetElement(i, GetElement(i + 1));

			length--;
		}
		
		public void SetElement(int index, int arg)
		{
		 
			components[index] = (ushort) arg;
 

		 
		}
		
		private ushort GetElement(int index)
		{
			 
				return components[index];
		}
		
	}
}