//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public sealed class EntityComposer
	{

		public static EntityComposer Default = new EntityComposer();
		internal Actor actor;
		public ent entity;

		/// <summary>
		///  Get actor with type cast
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>Actor</returns>
		public T GetActor<T>() where T: Actor
		{
			return actor as T;
		}
		
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

		public void Add(db db)
		{
			Entity.db[entity.id] = db;
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