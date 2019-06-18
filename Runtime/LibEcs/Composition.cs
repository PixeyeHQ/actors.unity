//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

// #define ACTORS_TAGS_FILTER_DEFAULT
// #if ACTORS_NO_TAGS
// #undef ACTORS_TAGS_FILTER_DEFAULT
// #endif

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public unsafe class Composition : IEquatable<Composition>
	{
		public int[] generations = new int[0];
		public int[] ids = new int[0];

		internal int[] includeTags = new int[0];
		internal int[] excludeTags = new int[0];

		public bool[] includeComponents = new bool[SettingsEngine.SizeComponents];
		internal bool[] excludeComponents = new bool[SettingsEngine.SizeComponents];

		internal HashCode hash;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool OverlapComponents(in BufferComponents entityComponents)
		{
			int match = 0;
			for (int i = 0; i < entityComponents.length; i++)
			{
				if (includeComponents[entityComponents.ids[i]])
					match++;
			}

			return ids.Length == match;
		}

		internal void AddTypesExclude(int[] types)
		{
			if (types != null)
				for (int i = 0; i < types.Length; i++)
				{
					var t = types[i];
					excludeComponents[t] = true;
				}
		}

		internal void SetupExcludeTypes(GroupCore g)
		{
			for (int i = 0; i < Storage.lastID; i++)
			{
				var t = excludeComponents[i];
				if (t) Storage.all[i].AddGroupExclude(g);
			}
		}

	 
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool Check(int entityID)
		{
			#if ACTORS_NO_TAGS
			return CanProceed(entityID) && !ExcludeTypes(entityID);
			#else
			return CanProceed(entityID) && (includeTags.Length == 0 || IncludeTags(entityID)) & (excludeTags.Length == 0 || ExcludeTags(entityID)) & !ExcludeTypes(entityID);
			#endif
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool CanProceed(int entityID)
		{
			for (int ll = 0; ll < ids.Length; ll++)
			{
				var mask = ids[ll];
				if ((Entity.generations[entityID, generations[ll]] & mask) != mask) return false;
			}

			return true;
		}

		internal bool IncludeTags(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var     len  = tags.Length;

			if (len == 0) return false;
			var match = 0;

			for (int l = 0; l < includeTags.Length; l++)
			{
				var tagToInclude = includeTags[l];
				for (int i = 0; i < len; i++)
				{
					ref var tag = ref tags.GetElementByRef(i);
					if (tag == tagToInclude) match++;
				}
			}

			return match == includeTags.Length;
		}

		internal bool ExcludeTags(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var     len  = tags.Length;
			if (len == 0) return true;

			for (int l = 0; l < excludeTags.Length; l++)
			{
				var tagToExclude = excludeTags[l];
				for (int i = 0; i < len; i++)
				{
					ref var tag = ref tags.GetElementByRef(i);
					if (tag == tagToExclude) return false;
				}
			}

			return true;
		}

		internal bool ExcludeTypes(int entityID)
		{
			ref var components = ref Entity.components[entityID];

			for (int i = 0; i < components.length; i++)
			{
				if (excludeComponents[components.ids[i]])
				{
					return true;
				}
			}

			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(Composition other)
		{
			return GetHashCode() == other.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode() => hash;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool Equals(object obj)
		{
			var other = obj as Composition;
			return other != null && Equals(other);
		}
	}
}