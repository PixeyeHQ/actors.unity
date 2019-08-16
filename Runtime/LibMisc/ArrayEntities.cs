//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	class ArrayEntities
	{
		internal ent[] storage = new ent[Entity.settings.SizeEntities];
		internal int len;

		internal void TryAdd(in ent entity)
		{
			for (int i = 0; i < len; i++)
			{
				ref var entityFromStorage = ref storage[i];

				if (entity.id == entityFromStorage.id) return;
			}

			if (len == storage.Length)
			{
				var l = len << 1;
				Array.Resize(ref storage, l);
			}

			storage[len++] = entity;
		}

		internal void Add(in ent entity)
		{
			if (len == storage.Length)
			{
				var l = len << 1;
				Array.Resize(ref storage, l);
			}

			storage[len++] = entity;
		}
	}
}