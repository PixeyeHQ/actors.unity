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

			#if UNITY_EDITOR
			_entity = id;
			#endif

			entity = new ent(id, age);
			Entity.Initialize(id, age, isPooled);
			Entity.transforms[id] = transform;
			Setup();

			if (buildFrom != null)
				buildFrom.ExecuteOnStart(entity, this);
			else if (isActiveAndEnabled)
				Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);

 

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

			#if UNITY_EDITOR
			_entity = id;
			#endif

			entity = new ent(id, age);
			Entity.Initialize(id, age, isPooled);
			Entity.transforms[id] = transform;
			Setup();
	 
			model(entity, this);
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		void IRequireStarter.Launch()
		{
			Launch();
		}

		//===============================//
		// Add methods
		//===============================//

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void Add(int tag)
		{
			entity.Set(tag);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void Add(params int[] tags)
		{
			entity.Set(tags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected T Add<T>()
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			return entity.AddLater<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void Add<T>(T component)
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			entity.AddLater(component);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected T AddLater<T>()
		{
			return entity.AddLater<T>();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void AddLater<T>(T component)
		{
			entity.AddLater(component);
		}

		//===============================//
		// Create methods
		//===============================//


		public static Actor CreateFor(GameObject obj, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor CreateFor(GameObject obj, ModelComposer model, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID , ModelComposer model,  Vector3 position,  bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab , ModelComposer model, Vector3 position, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab, position) : HelperFramework.SpawnInternal(prefab, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);
			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch(model);

			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(string prefabID, Vector3 position, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, Vector3 position, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab, position) : HelperFramework.SpawnInternal(prefab, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Actor Create(GameObject prefab, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}


		#region OBSOLETE

		#if ODIN_INSPECTOR
 
		public static Actor Create(string prefabID, BlueprintEntity bp, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();
			actor.buildFrom = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}
 
		public static Actor Create(GameObject prefab, BlueprintEntity bp, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.buildFrom = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}
		#endif

		#endregion
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
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
			#endif
		}
	}
}