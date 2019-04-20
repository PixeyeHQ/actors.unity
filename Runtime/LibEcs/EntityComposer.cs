//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public sealed class EntityComposer
	{

		public static EntityComposer Default = new EntityComposer();

		public ent entity;

		public T Add<T>() where T : IComponent, new()
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			return Storage<T>.Instance.GetFromStorage(entity.id);
		}

		public T AddLater<T>() where T : IComponent, new()
		{
			return entity.AddLater<T>();
		}

		public void Add(int tag)
		{
			entity.AddLater(tag);
		}

		public void Add(params int[] tags)
		{
			entity.AddLater(tags);
		}

	}

	internal static class HelperEntityComposer
	{

		internal static EntityComposer Modify(in this ent entity)
		{
			EntityComposer.Default.entity = entity;
			return EntityComposer.Default;
		}

	}
}