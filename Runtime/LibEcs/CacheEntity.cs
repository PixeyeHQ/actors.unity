//  Project : ecs
// Contacts : Pix - ask@pixeye.games


using System;
using System.Runtime.InteropServices;

namespace Pixeye.Actors
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct CacheEntity
	{
		public ushort* componentsIds;
		public byte age; // not cool. need to find way to change id directly in ents that released.
		public byte componentsAmount;
		public byte length;
		public bool isPooled;
		public bool isNested;
		public bool isDirty;
		public bool isAlive;

		public CacheEntity(int size)
		{
			componentsIds    = (ushort*) Marshal.AllocHGlobal(size * sizeof(ushort));
			length           = (byte) size;
			isPooled         = false;
			isNested         = false;
			isDirty          = false;
			isAlive          = false;
			age              = 0;
			componentsAmount = 0;
		}

		public void Clear()
		{
			componentsAmount = 0;
		}

		public void Add(int type)
		{
			if (length == componentsAmount)
			{
				length        = (byte) (componentsAmount << 1); // not safe
				componentsIds = (ushort*) Marshal.ReAllocHGlobal((IntPtr) componentsIds, (IntPtr) (length * sizeof(ushort)));
			}

			componentsIds[componentsAmount++] = (ushort) type;
		}

		public void Remove(int type)
		{
			var typeConverted = (ushort) type;

			for (int i = componentsAmount - 1; i >= 0; i--)
			{
				if (componentsIds[i] == typeConverted)
				{
					for (int j = i; j < --componentsAmount; ++j)
						componentsIds[j] = componentsIds[j + 1];

					break;
				}
			}
		}
	}
}