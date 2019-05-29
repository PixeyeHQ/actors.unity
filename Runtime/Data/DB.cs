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
			var d = Box.Get<CoreScriptableDB>(value);
			d.Setup();
			return new db(hash);
		}

		static public implicit operator int(db value)
		{
			return value.hash;
		}

		static public implicit operator CoreScriptableDB(db value)
		{
			return Box.Default.items[value.hash] as CoreScriptableDB;
		}

	}
}