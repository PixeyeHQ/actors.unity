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
		public byte componentsAmount;
		public byte length;
		public bool isPooled;
		public bool isNested;
		public bool isDirty;

	 
		public CacheEntity(int size)
		{
			componentsIds    = (ushort*) Marshal.AllocHGlobal(size * sizeof(ushort));
			length           = (byte) size;
			isPooled         = false;
			isNested         = false;
			isDirty          = false;
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

			for (int i = componentsAmount-1; i >= 0; i--)
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