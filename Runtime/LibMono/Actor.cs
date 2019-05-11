//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

//#if UNITY_EDITOR && ODIN_INSPECTOR && ACTORS_DEBUG
//using System.Collections.Generic;
//#endif

using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif

 

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class Actor : MonoBehaviour, IRequireStarter, IEntity
	{

		#region MEMBERS

		public ent entity = -1;

		#if UNITY_EDITOR
		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		internal int _entity = -1;
		#endif

		[FoldoutGroup("Main")]
		public bool isPooled;
 
	  [FoldoutGroup("Main")]
		public ScriptableBuild buildFrom;

		#endregion

		#region METHODS UNITY

		#if UNITY_EDITOR

		protected bool manualRemoved;

		protected virtual void OnEnable()
		{
			 
			if (!manualRemoved) return;
			manualRemoved = false;
			Entity.isAlive[entity.id] = true;
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		protected virtual void OnDisable()
		{
			if (Toolbox.applicationIsQuitting || !Entity.isAlive[entity.id]) return;
			manualRemoved = true;
			Entity.isAlive[entity.id] = false;
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Deactivate);
		}
		#endif

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnAdd()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnRemove()
		{
		}

		public virtual void Dispose()
		{
      
		}

		#endregion

		#region METHODS

		/// <summary>
		/// Don't use.
		/// </summary>
		public virtual void Launch()
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
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

			 
			entity = Entity. SetupWithTransform(id, isPooled, age);

			#if UNITY_EDITOR
			_entity = id;

			#endif

			Entity.transforms[id] = transform;

			Setup();
 
			if (buildFrom != null)
				buildFrom.Execute(entity,this);
			else 
			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		internal void LaunchFrom(HandleEntityComposer model)
		{
			int id;
			byte age = 0;

			if (ent.entityStackLength > 0)
			{
				var pop = ent.entityStack.Dequeue();
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

 

			entity = Entity.SetupWithTransform(id, isPooled, age);

			#if UNITY_EDITOR
			_entity = id;

			#endif

			Entity.transforms[id] = transform;

			Setup();

			EntityComposer.Default.entity = entity;
			EntityComposer.Default.actor = this;
			model(EntityComposer.Default);

			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		protected virtual void Setup()
		{
		}

		protected void Add(int tag)
		{
			entity.AddLater(tag);
		}

		protected void Add(params int[] tags)
		{
			entity.AddLater(tags);
		}

		protected T Add<T>() where T : IComponent, new()
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			return entity.AddLater<T>();
		}

		protected void Add<T>(T component) where T : IComponent, new()
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			entity.AddLater(component);
		}

		protected T AddLater<T>() where T : IComponent, new()
		{
			return entity.AddLater<T>();
		}

		protected void AddLater<T>(T component) where T : IComponent, new()
		{
			entity.AddLater(component);
		}

		#endregion

		public ref readonly ent GetEntity()
		{
			return ref entity;
		}

		public static Actor CreateFor(GameObject obj, HandleEntityComposer model, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(string prefabID, Vector3 position, HandleEntityComposer model, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(string prefabID, HandleEntityComposer model, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(GameObject prefab, HandleEntityComposer model, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);

			return actor;
		}

		public static Actor Create(string prefabID, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}
		
		public static Actor Create(string prefabID, Vector3 position, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}
		

		public static Actor Create(GameObject prefab, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

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

	}
}