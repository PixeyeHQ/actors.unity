//   Project : Battlecruiser3.0
//  Contacts : Pixeye - info@pixeye.games 
//      Date : 8/22/2018

using System.Collections.Generic;

public class FastDict : IEqualityComparer<int>
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