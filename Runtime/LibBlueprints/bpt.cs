//  Project : ecs
// Contacts : Pix - ask@pixeye.games

using UnityEngine;

namespace Pixeye.Framework
{
	public readonly struct bpt
	{

		public readonly int id;

		public bpt(int id = 0)
		{
			this.id = id;
		}

		static public implicit operator int(bpt value)
		{
			return value.id;
		}

		static public implicit operator bpt(int value)
		{
			return new bpt(value);
		}

	}

	public static class HelperBlueprints
	{

		public static BlueprintEntity Create(ref this bpt blueprint, string name = default)
		{
			var id = name == default ? blueprint.id : name.GetHashCode();
			var bp = ScriptableObject.CreateInstance<BlueprintEntity>();

			if (name != default)
				blueprint = id;

			BlueprintEntity.storage.Add(id, bp);

			return bp;
		}

	}
}