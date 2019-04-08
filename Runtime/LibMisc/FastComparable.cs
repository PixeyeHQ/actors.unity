//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using Pixeye.Framework;

public class FastComparable : IEqualityComparer<int>
{

	public static FastComparable Default = new FastComparable();

	public bool Equals(int x, int y)
	{
		return x == y;
	}

	public int GetHashCode(int obj)
	{
		return obj.GetHashCode();
	}

}

public class FastComparableEnt : IEqualityComparer<ent>
{

	public static FastComparableEnt Default = new FastComparableEnt();

	public bool Equals(ent x, ent y)
	{
		return x.id == y.id;
	}

	public int GetHashCode(ent obj)
	{
		return obj.GetHashCode();
	}

}

public class FastCompEnt : IComparer<ent>
{
	public static FastCompEnt Default = new FastCompEnt();
	
	public int Compare(ent x, ent y)
	{
		if (x.id == y.id)
			return 0;
		if (x.id < y.id)
			return -1;

		return 1;
	}

}