using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static partial class Entity
	{
		public static ent Create()
		{
	 
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
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

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
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

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
			model(entity);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);

			return entity;
		}

		public static ent Create(GameObject prefab, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;


			ent entity;
			entity.id  = id;
			entity.age = age;


			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);

			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;


			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
			model(entity);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}

		public static ent CreateFor(GameObject prefab, ModelComposer model, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			transforms[id] = prefab.transform;
			model(entity);
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
		public static ent CreateFor(GameObject obj, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop    = ent.entityStack.Dequeue();
				byte ageOld = pop.age;
				id = pop.id;
				unchecked
				{
					age = (byte) (ageOld + 1);
				}

				ent.entityStackLength--;
			}
			else
				id = ent.lastID++;

			ent entity;
			entity.id  = id;
			entity.age = age;

			Initialize(id, age, pooled);
			transforms[id] = obj.transform;
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			return entity;
		}
	}
}