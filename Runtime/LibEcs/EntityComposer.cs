//  Project : ecs
// Contacts : Pix - ask@pixeye.games

namespace Pixeye.Framework
{
	public sealed class EntityComposer
	{

		public ent entity;
		internal int entityID;
		public static EntityComposer Default = new EntityComposer();

		public void Modify(in ent entity)
		{
			this.entity = entity;
			entityID = entity.id;
		}

		public T Add<T>() where T : IComponent, new()
		{
			EntityCore.components[entityID].Add(Storage<T>.componentID);
			return Storage<T>.Instance.GetFromStorage(entityID);
		}

		public void Deploy()
		{
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
		}
		
		public void Deploy(int tag)
		{
			entity.AddLater(tag);
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
		}

		public void Deploy(params int[] tags)
		{
			entity.AddLater(tags);
			EntityCore.Delayed.Set(entity, 0, EntityCore.Delayed.Action.Activate);
		}

	}

	public static class HelperEntityComposer
	{

		public static EntityComposer Modify(in this ent entity)
		{
			EntityComposer.Default.entity = entity;
			EntityComposer.Default.entityID = entity.id;
			return EntityComposer.Default;
		}

	}
}