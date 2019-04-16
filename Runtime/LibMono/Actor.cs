//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

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
		public BlueprintEntity blueprint;

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

		 
		public void OnAdd(in ent entity)
		{
			OnAdd();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnAdd()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public virtual void OnRemove()
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

			Entity.SetupWithTransform(id, isPooled);

			entity = new ent(id, age);

			#if UNITY_EDITOR
			_entity = id;
			#endif

			Entity.transforms[id] = transform;

			Setup();

			if (blueprint != null)
				blueprint.Populate(entity);

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

		public static Actor Create(string prefabID, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefabID) : HelperFramework.SpawnInternal(prefabID);
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
			actor.blueprint = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

		public static Actor Create(GameObject prefab, BlueprintEntity bp, bool pooled = false)
		{
			var tr = pooled ? HelperFramework.SpawnInternal(Pool.Entities, prefab) : HelperFramework.SpawnInternal(prefab);
			var actor = tr.AddGetActor();
			actor.blueprint = bp;
			actor.isPooled = pooled;
			actor.Launch();
			return actor;
		}

	}
}