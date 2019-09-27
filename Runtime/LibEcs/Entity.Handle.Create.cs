using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static partial class Entity
	{
		public static ent Create()
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;
			Initialize(id, age);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent Create(ModelComposer model)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age);

			model(entity);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}


		public static ent Create(string prefabID, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefabID) : Obj.Spawn(prefabID);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}

		public static ent Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefabID) : Obj.Spawn(prefabID);
			model(entity);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);

			return entity;
		}
		public static ent Create(string prefabID, Transform parent, Vector3 position = default, bool pooled = false)
		{
			byte age = 0;
			int  id;
			if (ent.entStack.length > 0)
			{
				ent ent = ent.entStack.source[--ent.entStack.length];
				id  = ent.id;
				age = (byte) ((uint) ent.age + 1U);
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;
			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(1, prefabID, parent, position, new Quaternion()) : Obj.Spawn(prefabID, parent, position, new Quaternion());
			EntityOperations.Set(in entity, -1, EntityOperations.Action.Activate);
			return entity;
		}


		public static ent Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
		{
			byte age = 0;
			int  id;
			if (ent.entStack.length > 0)
			{
				ent ent = ent.entStack.source[--ent.entStack.length];
				id  = ent.id;
				age = (byte) (ent.age + 1U);
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;
			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(1, prefab, parent, position) : Obj.Spawn(prefab, parent, position);
			EntityOperations.Set(in entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent Create(GameObject prefab, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;


			ent entity;
			entity.id  = id;
			entity.age = age;


			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;


			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			Transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
			model(entity);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}

		public static ent CreateFor(GameObject prefab, ModelComposer model)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age);
			Transforms[id] = prefab.transform;
			model(entity);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent CreateFor(GameObject obj)
		{
			int  id;
			byte age = 0;

			if (ent.entStack.length > 0)
			{
				var pop = ent.entStack.source[--ent.entStack.length];
				id = pop.id;
				unchecked
				{
					age = (byte) (pop.age + 1);
				}
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age);
			Transforms[id] = obj.transform;
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
	}
}