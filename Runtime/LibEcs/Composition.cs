//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

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
			}

			return hc;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool OverlapComponents(in BufferComponents entityComponents)
		{
			int match = 0;
			for (int i = 0; i < entityComponents.Length; i++)
			{
				if (components[entityComponents.components[i]])
					match++;
			}

			return ids.Length == match;
		}

		internal bool Include(int entityID)
		{
			ref var tags = ref Entity.tags[entityID];
			var length = tags.GetLength();
			if (length == 0) return false;
			var match = 0;

			for (int l = 0; l < tagsToInclude.Length; l++)
			{
				var tagToInclude = tagsToInclude[l];
				for (int i = 0; i < length; i++)
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
			var length = tags.GetLength();
			if (length == 0) return true;

			for (int l = 0; l < tagsToExclude.Length; l++)
			{
				var tagToExclude = tagsToExclude[l];
				for (int i = 0; i < length; i++)
				{
					ref var tag = ref tags.GetElementByRef(i);
					if (tag == tagToExclude) return false;
				}
			}

			return true;
		}

		public bool Equals(Composition other)
		{
			if (tagsToInclude.Length != other.tagsToInclude.Length) return false;
			int len1 = tagsToInclude.Length;
			int len2 = tagsToExclude.Length;
			for (int i = 0; i < len1; i++)
			{
				if (tagsToInclude[i] != other.tagsToInclude[i]) return false;
			}

			if (tagsToExclude.Length != other.tagsToExclude.Length) return false;

			for (int i = 0; i < len2; i++)
			{
				if (tagsToExclude[i] != other.tagsToExclude[i]) return false;
			}

			return true;
		}

	}
}