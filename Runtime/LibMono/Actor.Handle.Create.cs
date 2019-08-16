//  Project : ecs.unity
// Contacts : Pix - ask@pixeye.games


using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	public partial class Actor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref ent GetEntity()
		{
			return ref entity;
		}

	 

		/// <summary>
		/// Initialize entity here.
		/// </summary>
		protected virtual void Setup()
		{
		}

		//===============================//
		// Launch methods
		//===============================//
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Launch()
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

			entity.id  = id;
			entity.age = age;


			#if UNITY_EDITOR
			_entity = id;
			#if ACTORS_DEBUG
	  	var utils = GetComponent<ActorUtil>();
		 	if (utils == null) utils = gameObject.AddComponent<ActorUtil>();
	   	utils.Setup(entity,isActiveAndEnabled);
			#endif
			#endif


			Entity.Initialize(id, age, isPooled);
			Entity.transforms[id] = transform;

			if (isActiveAndEnabled)
			{
				if (buildFrom != null)
				{
					buildFrom.ExecuteOnStart(entity, this);
					Setup();
				}
				else
				{
					Setup();
					EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Launch(ModelComposer model)
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

			entity.id  = id;
			entity.age = age;

			#if UNITY_EDITOR
			_entity = id;
			#if ACTORS_DEBUG
			var utils = GetComponent<ActorUtil>();
			if (utils == null) utils = gameObject.AddComponent<ActorUtil>();
			utils.Setup(entity, isActiveAndEnabled);
			#endif
			#endif

			Entity.Initialize(id, age, isPooled);
			Entity.transforms[id] = transform;
			model(entity);
			Setup();
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		void IRequireStarter.Launch()
		{
 
			if (!entity.Exist)
			{
				Launch();
			}
		}


		//===============================//
		// Create methods
		//===============================//


		/// <summary>
		/// Add Actor to existing game object.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="pooled"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor CreateFor(GameObject obj, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

		/// <summary>
		/// Add Actor to existing game object.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="pooled"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor CreateFor(GameObject obj, ModelComposer model, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, Vector3 position = default, bool pooled = false)
		{
			var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
		{
			var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, parent, position) : Obj.Spawn(prefab, parent, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			var tr    = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID, Vector3 position = default, bool pooled = false)
		{
			var tr    = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
		{
			var tr    = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}
	}

	public static class HelperActor
	{
		/// <summary>
		/// Use only for first time activation of "sleeping" actors on the scene
		/// </summary>
		/// <param name="entity"></param>
		public static void ActivateActor(in this ent entity)
		{
			entity.transform.GetComponent<Actor>().enabled = true;
			#if !UNITY_EDITOR
			EntityOperations.Set(entity, -1, EntityOperations.Action.Activate);
			#endif
		}
	}
}