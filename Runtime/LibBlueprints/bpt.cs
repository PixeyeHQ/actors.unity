//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	public readonly struct bpt
	{

		public readonly string id;
		public readonly int hash;

		public bpt(string id, int hash)
		{
			this.id = id;
			this.hash = hash;
		}

		static public implicit operator string(bpt value)
		{
			return value.id;
		}

		static public implicit operator bpt(string value)
		{
			return new bpt(value, value.GetHashCode());
		}

	}

	public static class HelperBlueprints
	{

		public static BlueprintEntity Create(ref this bpt blueprint, string name = default)
		{
			var id = name == default ? blueprint.id : name;
			var bp = ScriptableObject.CreateInstance<BlueprintEntity>();

			if (name != default)
				blueprint = id;

			BlueprintEntity.storage.Add(blueprint.hash, bp);
			//BlueprintEntity.storage.Add(id, bp);

			return bp;
		}

	}
}