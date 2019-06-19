#if ODIN_INSPECTOR
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{


	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public static partial class Entity
	{
 
		public static ent Create(BlueprintEntity bpAsset)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop = ent.entityStack.Dequeue();
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

			var entity = new ent(id, age);
			Initialize(id, age);
			bpAsset.Execute(entity);
			return entity;
		}

		public static ent Create(string prefabID, BlueprintEntity bpAsset, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop = ent.entityStack.Dequeue();
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

			var entity = new ent(id, age);
			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefabID) : Obj.Spawn(prefabID);
			bpAsset.Execute(entity);
			return entity;
		}

		public static ent Create(GameObject prefab, BlueprintEntity bpAsset, bool pooled = false)
		{
			int  id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var  pop = ent.entityStack.Dequeue();
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

			var entity = new ent(id, age);
			Initialize(id, age, pooled);
			transforms[id] = pooled ? Obj.Spawn(Pool.Entities, prefab) : Obj.Spawn(prefab);
			bpAsset.Execute(entity);
			return entity;
		}
 
	}
}
#endif