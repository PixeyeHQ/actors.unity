//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public readonly struct bpt
	{
		public readonly int hash;

		public bpt(int hash)
		{
			this.hash = hash;
		}

		static public implicit operator BlueprintEntity(bpt value)
		{
			return BlueprintEntity.storage[value.hash];
		}

		static public implicit operator bpt(string value)
		{
			var hash = value.GetHashCode();
			if (!BlueprintEntity.storage.TryGetValue(hash, out BlueprintEntity bp))
			{
				bp = Box.Get<BlueprintEntity>(value);
				BlueprintEntity.storage.Add(hash, bp);
			}

			return new bpt(hash);
		}

	}

	public static class HelperBlueprints
	{

		public static BlueprintEntity Get(in this bpt value)
		{
			return BlueprintEntity.storage[value.hash];
		}

	}
}