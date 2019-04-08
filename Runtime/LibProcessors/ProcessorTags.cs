//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	/// <summary>
	/// <para>Tags of the entities.</para>
	/// </summary>
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static class ProcessorTags
	{

		#region TAGS

		public static void ClearTags(in this ent entity)
		{
			CoreEntity.tags[entity.id].Clear();
		}

		public static void RemoveAll(this in ent entity, params int[] tagsID)
		{
//			ref var tags    = ref CoreEntity.tags[entity.id];
//			ref var storage = ref tags.pool;
//
//			if (storage == null) return;
//
//			foreach (var tagID in tagsID)
//			{
//				for (int i = 0; i < tags.length; i++)
//				{
//					ref var tag = ref storage[i];
//
//					if (tag.id != tagID) continue;
//
//					var l    = --tags.length;
//					var next = i + 1;
//					var size = l - i;
//
//					Array.Copy(storage, next, storage, i, size);
//					HandleChange(entity, tagID);
//					break;
//				}
//			}
		}

		public static void RemoveAll(this in ent entity, int tagID)
		{
//			ref var tags    = ref CoreEntity.tags[entity.id];
//			ref var storage = ref tags.pool;
//
//			if (storage == null) return;
//
//			for (int i = 0; i < tags.length; i++)
//			{
//				ref var tag = ref storage[i];
//
//				if (tag.id != tagID) continue;
//
//				var l    = --tags.length;
//				var next = i + 1;
//				var size = l - i;
//
//				Array.Copy(storage, next, storage, i, size);
//				HandleChange(entity, tagID);
//				break;
//			}
		}

//		public static bool Has(in this ent entity, int tagID)
//		{
//			return false;
////			ref var tags    = ref CoreEntity.tags[entity.id];
////			ref var storage = ref tags.pool;
////			return storage != null && tags.length != 0 && Get(ref storage, tags.length, tagID);
//		}

	 
		#endregion

	 

	}
}