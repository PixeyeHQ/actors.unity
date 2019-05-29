//  Project : ecs
// Contacts : Pix - ask@pixeye.games

 
 
namespace Pixeye.Framework
{
	public readonly struct db
	{
		public readonly int hash;
		public db(int hash)
		{
			this.hash = hash;
		}

		static public implicit operator db(string value)
		{
			var hash = value.GetHashCode();
			var d = Box.Get<DBCore>(value);
			return new db(hash);
		}

		static public implicit operator int(db value)
		{
			return value.hash;
		}

		static public implicit operator DBCore(db value)
		{
			return Box.Default.items[value.hash] as DBCore;
		}

	}
}
 