//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Pixeye
{
	[StructLayout(LayoutKind.Sequential)]
	public struct BufferComponents
	{

		public ushort[] components;
		public byte Length;

		public ref ushort GetComponent(int id)
		{
			return ref components[id];
		}

		public BufferComponents(int size)
		{
			components = new ushort[size];
			Length = 0;
		}

		public void Setup()
		{
			if (components == null) components = new ushort[1];
			Length = 0;
		}

		public void Clear()
		{
			Length = 0;
		}

		public void Add(int type)
		{
			if (Length == components.Length)
				Array.Resize(ref components, Length << 1);

			components[Length++] = (ushort) type;
		}

		public void Remove(int type)
		{
			var typeConverted = (ushort) type;

			for (int i = 0; i < Length; i++)
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
			for (int i = index; i < Length - 1; ++i)
				SetElement(i, components[i + 1]);

			Length--;
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