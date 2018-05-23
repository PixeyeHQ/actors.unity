/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  4:30 PM
================================================================*/


using System;


namespace Homebrew
{
	public class FilterMask : IEquatable<FilterMask>
	{
 
		public int[] groupFilter = new int[0];
		public int[] groupFilterExclude = new int[0];


		public override bool Equals(object obj)
		{
			var other = obj as FilterMask;
			return other != null && Equals(other);
		}

		public override int GetHashCode()
		{
 
			int hc = groupFilter.Length;
			var len1 = groupFilter.Length;
			var len2 = groupFilterExclude.Length;
			
			unchecked
			{
				for (var i = 0; i < len1; ++i)
				{
					hc = unchecked(hc * 17 + groupFilter[i]);
				}

				hc += groupFilterExclude.Length;
				for (var i = 0; i < len2; ++i)
				{
					hc = unchecked(hc * 31 + groupFilterExclude[i]);
				}
			}

			return hc;
		}


		public bool Equals(FilterMask other)
		{
		 
	 
			if (groupFilter.Length != other.groupFilter.Length) return false;

			var len1 = groupFilter.Length;
			var len2 = groupFilterExclude.Length;
			
			for (var i = 0; i < len1; i++)
			{
				if (groupFilter[i] != other.groupFilter[i]) return false;
			}

			if (groupFilterExclude.Length != other.groupFilterExclude.Length) return false;

			for (var i = 0; i < len2; i++)
			{
				if (groupFilterExclude[i] != other.groupFilterExclude[i]) return false;
			}

			return true;
		}
	}
}