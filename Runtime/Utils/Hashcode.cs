//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using System.Collections.Generic;

namespace Pixeye.Actors
{
  public struct HashCode
  {
    public readonly int value;

    HashCode(int value) => this.value = value;

    public static implicit operator int(HashCode hashCode) => hashCode.value;

    public static HashCode Of<T>(T item) => new HashCode(GetHashCode(item));

    public static HashCode OfEach<T>(IEnumerable<T> items) => new HashCode(GetHashCode(items, 0));

    public HashCode And<T>(T item) => new HashCode(CombineHashCodes(value, GetHashCode(item)));

    public HashCode AndEach<T>(IEnumerable<T> items)
    {
      return items == null ? new HashCode(value) : new HashCode(GetHashCode(items, value));
    }

    static int CombineHashCodes(int h1, int h2)
    {
      unchecked
      {
        // Code copied from System.Tuple so it must be the best way to combine hash codes or at least a good one.
        return ((h1 << 5) + h1) ^ h2;
      }
    }

    static int GetHashCode<T>(T item) => item == null ? 0 : item.GetHashCode();

    static int GetHashCode<T>(IEnumerable<T> items, int startHashCode)
    {
      var temp = startHashCode;
      foreach (var item in items)
      {
        temp = CombineHashCodes(temp, GetHashCode(item));
      }

      return temp;
    }
  }
}