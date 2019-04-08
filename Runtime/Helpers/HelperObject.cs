//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
using System.Reflection;

namespace System
{
	public class ReferenceEqualityComparer : EqualityComparer<Object>
	{

		public override bool Equals(object x, object y)
		{
			return ReferenceEquals(x, y);
		}

		public override int GetHashCode(object obj)
		{
			return obj == null ? 0 : obj.GetHashCode();
		}

	}

	 
}