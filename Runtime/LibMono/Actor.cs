//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;

#endif

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	public class Actor : MonoBehaviour, IRequireStarter
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

		void Awake()
		{
			manualRemoved = !enabled;
		}

		void OnEnable()
		{
			unsafe
			{
				if (!manualRemoved) return;
				manualRemoved = false;
				Entity.cache[entity.id].isAlive = true;
				Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
			}
		}

		void OnDisable()
		{
			unsafe
			{
				if (Toolbox.applicationIsQuitting || !Entity.cache[entity.id].isAlive) return;
				manualRemoved = true;
				Entity.cache[entity.id].isAlive = false;
				Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Deactivate);
			}
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
		public void Launch()
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

			entity = new ent(id, age);
			Entity.SetupWithTransform(id, isPooled, age);

			#if UNITY_EDITOR
			_entity = id;

			#endif

			Entity.transforms[id] = transform;

			Setup();

			if (buildFrom != null)
				buildFrom.Execute(entity, this);
			else
				Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		public virtual void LaunchOnStart()
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

			entity = new ent(id, age);
			Entity.SetupWithTransform(id, isPooled, age);

			#if UNITY_EDITOR
			_entity = id;

			#endif

			Entity.transforms[id] = transform;

			Setup();

			if (buildFrom != null)
				buildFrom.ExecuteOnStart(entity, this);
			else if (isActiveAndEnabled)
				Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		internal void LaunchFrom(ModelComposer model)
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

			entity = new ent(id, age);
			Entity.SetupWithTransform(id, isPooled, age);

			#if UNITY_EDITOR
			_entity = id;

			#endif

			Entity.transforms[id] = transform;

			Setup();

			model(entity, this);

			Entity.Delayed.Set(entity, 0, Entity.Delayed.Action.Activate);
		}

		protected virtual void Setup()
		{
		}

		protected void Add(int tag)
		{
			entity.Set(tag);
		}

		protected void Add(params int[] tags)
		{
			entity.Set(tags);
		}

		protected T Add<T>()
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			return entity.AddLater<T>();
		}

		protected void Add<T>(T component)
		{
			Entity.components[entity.id].Add(Storage<T>.componentID);
			entity.AddLater(component);
		}

		protected T AddLater<T>()
		{
			return entity.AddLater<T>();
		}

		protected void AddLater<T>(T component)
		{
			entity.AddLater(component);
		}

		#endregion

		public ref readonly ent GetEntity()
		{
			return ref entity;
		}

		public static Actor CreateFor(GameObject obj, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchOnStart();
			return actor;
		}

		public static Actor CreateFor(GameObject obj, ModelComposer model, bool pooled = false)
		{
			var actor = obj.transform.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(string prefabID, Vector3 position, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(string prefabID, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(GameObject prefab, Vector3 position, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab, position) : HelperFramework.SpawnInternal(prefab, position);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);
			return actor;
		}

		public static Actor Create(GameObject prefab, ModelComposer model, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.LaunchFrom(model);

			return actor;
		}

		public static Actor Create(string prefabID, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		public static Actor Create(string prefabID, Vector3 position, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID, position) : HelperFramework.SpawnInternal(prefabID, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		public static Actor Create(GameObject prefab, Vector3 position, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab, position) : HelperFramework.SpawnInternal(prefab, position);
			var actor = tr.AddGetActor();

			actor.isPooled = pooled;
			actor.Launch();

			return actor;
		}

		public static Actor Create(GameObject prefab, bool pooled = false)
		{
			var tr    = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

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