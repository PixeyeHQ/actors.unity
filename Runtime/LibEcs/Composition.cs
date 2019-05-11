//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class Composition : IEquatable<Composition>
	{

		internal int[] tagsToInclude = new int[0];
		internal int[] tagsToExclude = new int[0];

		internal int[] generations = new int[0];
		internal int[] ids = new int[0];

		internal bool[] components = new bool[SettingsEngine.SizeComponents];
		internal bool[] typesToExclude = new bool[SettingsEngine.SizeComponents];

		public override bool Equals(object obj)
		{
			var other = obj as Composition;
			return other != null && Equals(other);
		}

		public override int GetHashCode()
		{
			int hc = tagsToInclude.Length;
			int len1 = tagsToInclude.Length;
			int len2 = tagsToExclude.Length;
			//	int len3 = typesToExclude.Length;

			unchecked
			{
				for (int i = 0; i < len1; ++i)
				{
					hc = unchecked(hc * 17 + tagsToInclude[i]);
				}

				hc += tagsToExclude.Length;
				for (int i = 0; i < len2; ++i)
				{
					hc = unchecked(hc * 31 + tagsToExclude[i]);
				}

//				hc += typesToExclude.Length;
//
//				for (int i = 0; i < len3; ++i)
//				{
//					hc = typesToExclude[i].GetHashCode();
//				}
			}

			return hc;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool OverlapComponents(in BufferComponents entityComponents)
		{
			int match = 0;
			for (int i = 0; i < entityComponents.length; i++)
			{
				if (components[entityComponents.components[i]])
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
					typesToExclude[t] = true;
				}
		}

		internal void SetupExcludeTypes(GroupCore g)
		{
			for (int i = 0; i < Storage.lastID; i++)
			{
				var t = typesToExclude[i];
				if (t)
				{
					Storage.all[i].AddGroupExclude(g);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool Check(int entityID)
		{
			return (tagsToInclude.Length == 0 || Include(entityID)) & (tagsToExclude.Length == 0 || Exclude(entityID));
		}

		internal bool Include(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var len = tags.Length;

			if (len == 0) return false;
			var match = 0;

			for (int l = 0; l < tagsToInclude.Length; l++)
			{
				var tagToInclude = tagsToInclude[l];
				for (int i = 0; i < len; i++)
				{
					ref var tag = ref tags.GetElementByRef(i);
					if (tag == tagToInclude) match++;
				}
			}

			return match == tagsToInclude.Length;
		}

		internal bool Exclude(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var len = tags.Length;
			if (len == 0) return true;

			for (int l = 0; l < tagsToExclude.Length; l++)
			{
				var tagToExclude = tagsToExclude[l];
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
			BufferComponents entityComponents = Entity.components[entityID];

			for (int i = 0; i < entityComponents.length; i++)
			{
				if (typesToExclude[entityComponents.components[i]])
				{
					return false;
				}
			}
			return true;
		}

		public bool Equals(Composition other)
		{
			if (tagsToInclude.Length != other.tagsToInclude.Length) return false;
			//	if (typesToExclude.Length != other.typesToExclude.Length) return false;

			int len1 = tagsToInclude.Length;
			int len2 = tagsToExclude.Length;
			//int len3 = typesToExclude.Length;

			for (int i = 0; i < len1; i++)
			{
				if (tagsToInclude[i] != other.tagsToInclude[i]) return false;
			}

			if (tagsToExclude.Length != other.tagsToExclude.Length) return false;

			for (int i = 0; i < len2; i++)
			{
				if (tagsToExclude[i] != other.tagsToExclude[i]) return false;
			}

//			for (int i = 0; i < len3; i++)
//			{
//				if (typesToExclude[i] != other.typesToExclude[i]) return false;
//			}

			return true;
		}

	}
}