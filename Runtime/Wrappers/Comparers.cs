//  Project  : ecs
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  public static class Comparers
  {
    internal static readonly Dictionary<int, object> storage = new Dictionary<int, object>(FastComparable.Default);


    internal static void Bootstrap()
    {
      storage.Add(typeof(float).GetHashCode(), EqualityFloat.Default);
      storage.Add(typeof(int).GetHashCode(), EqualityInt.Default);
      storage.Add(typeof(byte).GetHashCode(), EqualityByte.Default);
      storage.Add(typeof(bool).GetHashCode(), EqualityBool.Default);

      storage.Add(typeof(ent).GetHashCode(), EqualityEnt.Default);

      storage.Add(typeof(Vector2).GetHashCode(), EqualityVector2.Default);
      storage.Add(typeof(Vector3).GetHashCode(), EqualityVector3.Default);
      storage.Add(typeof(Vector4).GetHashCode(), EqualityVector4.Default);
      storage.Add(typeof(Color).GetHashCode(), EqualityColor.Default);
      storage.Add(typeof(Rect).GetHashCode(), EqualityRect.Default);
      storage.Add(typeof(Bounds).GetHashCode(), EqualityBounds.Default);
      storage.Add(typeof(Quaternion).GetHashCode(), EqualityQuaternion.Default);
      storage.Add(typeof(Color32).GetHashCode(), EqualityColor32.Default);

      storage.Add(typeof(Vector2Int).GetHashCode(), EqualityVector2Int.Default);
      storage.Add(typeof(Vector3Int).GetHashCode(), EqualityVector3Int.Default);
      storage.Add(typeof(RangeInt).GetHashCode(), EqualityRangeInt.Default);
      storage.Add(typeof(RectInt).GetHashCode(), EqualityRectInt.Default);
      storage.Add(typeof(BoundsInt).GetHashCode(), EqualityBoundsInt.Default);
    }

    public static void Add<T>(IEqualityComparer<T> comparer)
    {
      storage.Add(typeof(T).GetHashCode(), comparer);
    }
    
    public static IEqualityComparer<T> Get<T>()
    {
      return storage[typeof(T).GetHashCode()] as IEqualityComparer<T>;
    }

    //===============================//
    // PRIMITIVES 
    //===============================//

    sealed class EqualityFloat : IEqualityComparer<float>
    {
      internal static EqualityFloat Default = new EqualityFloat();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(float x, float y)
      {
        return x == y;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(float obj)
      {
        return (int) obj;
      }
    }

    sealed class EqualityInt : IEqualityComparer<int>
    {
      internal static EqualityInt Default = new EqualityInt();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(int x, int y)
      {
        return x == y;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(int obj)
      {
        return obj;
      }
    }

    sealed class EqualityByte : IEqualityComparer<byte>
    {
      internal static EqualityByte Default = new EqualityByte();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(byte x, byte y)
      {
        return x == y;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(byte obj)
      {
        return obj;
      }
    }

    sealed class EqualityBool : IEqualityComparer<bool>
    {
      internal static EqualityBool Default = new EqualityBool();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(bool x, bool y)
      {
        return x == y;
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(bool obj)
      {
        return obj.GetHashCode();
      }
    }

    sealed class EqualityEnt : IEqualityComparer<ent>
    {
      internal static EqualityEnt Default = new EqualityEnt();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(ent x, ent y)
      {
        return x.Equals(y);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(ent obj)
      {
        return obj.GetHashCode();
      }
    }

    //===============================//
    // UNITY 
    //===============================//

    sealed class EqualityVector2 : IEqualityComparer<Vector2>
    {
      internal static EqualityVector2 Default = new EqualityVector2();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Vector2 self, Vector2 vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Vector2 obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2;
      }
    }

    sealed class EqualityVector3 : IEqualityComparer<Vector3>
    {
      internal static EqualityVector3 Default = new EqualityVector3();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Vector3 self, Vector3 vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y) && self.z.Equals(vector.z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Vector3 obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2 ^ obj.z.GetHashCode() >> 2;
      }
    }

    sealed class EqualityVector4 : IEqualityComparer<Vector4>
    {
      internal static EqualityVector4 Default = new EqualityVector4();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Vector4 self, Vector4 vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y) && self.z.Equals(vector.z) && self.w.Equals(vector.w);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Vector4 obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2 ^ obj.z.GetHashCode() >> 2 ^ obj.w.GetHashCode() >> 1;
      }
    }

    sealed class EqualityColor : IEqualityComparer<Color>
    {
      internal static EqualityColor Default = new EqualityColor();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Color self, Color other)
      {
        return self.r.Equals(other.r) && self.g.Equals(other.g) && self.b.Equals(other.b) && self.a.Equals(other.a);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Color obj)
      {
        return obj.r.GetHashCode() ^ obj.g.GetHashCode() << 2 ^ obj.b.GetHashCode() >> 2 ^ obj.a.GetHashCode() >> 1;
      }
    }

    sealed class EqualityRect : IEqualityComparer<Rect>
    {
      internal static EqualityRect Default = new EqualityRect();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Rect self, Rect other)
      {
        return self.x.Equals(other.x) && self.width.Equals(other.width) && self.y.Equals(other.y) &&
               self.height.Equals(other.height);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Rect obj)
      {
        return obj.x.GetHashCode() ^ obj.width.GetHashCode() << 2 ^ obj.y.GetHashCode() >> 2 ^
               obj.height.GetHashCode() >> 1;
      }
    }

    sealed class EqualityBounds : IEqualityComparer<Bounds>
    {
      internal static EqualityBounds Default = new EqualityBounds();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Bounds self, Bounds vector)
      {
        return self.center.Equals(vector.center) && self.extents.Equals(vector.extents);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Bounds obj)
      {
        return obj.center.GetHashCode() ^ obj.extents.GetHashCode() << 2;
      }
    }

    sealed class EqualityQuaternion : IEqualityComparer<Quaternion>
    {
      internal static EqualityQuaternion Default = new EqualityQuaternion();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Quaternion self, Quaternion vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y) && self.z.Equals(vector.z) && self.w.Equals(vector.w);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Quaternion obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2 ^ obj.z.GetHashCode() >> 2 ^ obj.w.GetHashCode() >> 1;
      }
    }

    sealed class EqualityColor32 : IEqualityComparer<Color32>
    {
      internal static EqualityColor32 Default = new EqualityColor32();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Color32 self, Color32 vector)
      {
        return self.a.Equals(vector.a) && self.r.Equals(vector.r) && self.g.Equals(vector.g) && self.b.Equals(vector.b);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Color32 obj)
      {
        return obj.a.GetHashCode() ^ obj.r.GetHashCode() << 2 ^ obj.g.GetHashCode() >> 2 ^ obj.b.GetHashCode() >> 1;
      }
    }

    sealed class EqualityVector2Int : IEqualityComparer<Vector2Int>
    {
      internal static EqualityVector2Int Default = new EqualityVector2Int();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Vector2Int self, Vector2Int vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Vector2Int obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2;
      }
    }

    sealed class EqualityVector3Int : IEqualityComparer<Vector3Int>
    {
      internal static EqualityVector3Int Default = new EqualityVector3Int();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(Vector3Int self, Vector3Int vector)
      {
        return self.x.Equals(vector.x) && self.y.Equals(vector.y) && self.z.Equals(vector.z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(Vector3Int obj)
      {
        return obj.x.GetHashCode() ^ obj.y.GetHashCode() << 2 ^ obj.z.GetHashCode() >> 2;
      }
    }

    sealed class EqualityRangeInt : IEqualityComparer<RangeInt>
    {
      internal static EqualityVector3Int Default = new EqualityVector3Int();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(RangeInt self, RangeInt vector)
      {
        return self.start.Equals(vector.start) && self.length.Equals(vector.length);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(RangeInt obj)
      {
        return obj.start.GetHashCode() ^ obj.length.GetHashCode() << 2;
      }
    }

    sealed class EqualityRectInt : IEqualityComparer<RectInt>
    {
      internal static EqualityRectInt Default = new EqualityRectInt();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(RectInt self, RectInt other)
      {
        return self.x.Equals(other.x) && self.width.Equals(other.width) && self.y.Equals(other.y) &&
               self.height.Equals(other.height);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(RectInt obj)
      {
        return obj.x.GetHashCode() ^ obj.width.GetHashCode() << 2 ^ obj.y.GetHashCode() >> 2 ^
               obj.height.GetHashCode() >> 1;
      }
    }

    sealed class EqualityBoundsInt : IEqualityComparer<BoundsInt>
    {
      internal static EqualityBoundsInt Default = new EqualityBoundsInt();

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public bool Equals(BoundsInt self, BoundsInt vector)
      {
        return EqualityVector3Int.Default.Equals(self.position, vector.position) &&
               EqualityVector3Int.Default.Equals(self.size, vector.size);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining)]
      public int GetHashCode(BoundsInt obj)
      {
        return EqualityVector3Int.Default.GetHashCode(obj.position) ^
               EqualityVector3Int.Default.GetHashCode(obj.size) << 2;
      }
    }
  }
}