//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using Pixeye;

public class FastComparable : IEqualityComparer<int>
{
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
    public bool Equals(ent x, ent y)
    {
        return x == y;
    }

    public int GetHashCode(ent obj)
    {
        return obj.GetHashCode();
    }
}

 