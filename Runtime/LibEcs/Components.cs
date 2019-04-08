//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using System.Runtime.InteropServices;

namespace Pixeye
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
	public struct Components
	{

		internal byte size;
		internal short[] id;

		public Components(byte size)
		{
			this.size = size;
			id = new short[size];
		}

		public void Add(short componentID)
		{
			for (int i = 0; i < id.Length; i++)
			{
				ref short possible = ref id[i];
				if (possible == -1)
				{
					possible = componentID;
					return;
				}
			}

			var last = size++;
			Array.Resize(ref id, size);
			id[last] = componentID;
		}

	}
}