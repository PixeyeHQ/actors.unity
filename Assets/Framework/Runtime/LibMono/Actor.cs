//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using UnityEngine;

#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif


namespace Pixeye
{
	/// <summary>
	/// <para>A base class of mono entity composer.</para>
	/// </summary>
	public abstract class Actor : MonoEntity, IRequireStarter
	{
		[FoldoutGroup("Main"), TagFilter(typeof(Pool))]
		public int pool;

		[NonSerialized]
		public bool conditionManualDeploy;

		#region METHODS

		protected virtual void Awake()
		{
			var entityID = ProcEntities.Create();
			entity = entityID;
			entity.AddReference(transform);


			#if UNITY_EDITOR
			_entity = entity;
			#endif

			if (pool > 0)
				entity.AddPool(pool);

			conditionManualDeploy = this is IManualDeploy;


			if (Starter.initialized == false) return;
			Setup();
		}


		/// <summary>
		/// <para>Setup is used to add components and tags to the entity. Use it instead of the Awake/Start methods.</para>
		/// </summary>
		protected abstract void Setup();


		public void SetupAfterStarter()
		{
			Setup();
			if (conditionManualDeploy) return;
			OnEnable();
		}


		public override void OnEnable()
		{
			if (Starter.initialized == false) return;
			if (conditionManualDeploy) return;
			RefEntity.isAlive[entity] = true;
			ProcEntities.Default.CheckGroups(entity, true);
		}

		#endregion

		#region ADD/REMOVE

		/// <summary>
		/// <para>Adds the tag to the entity.</para>
		/// </summary>
		/// <param name="tags"></param>
		protected void Add(int tags)
		{
			entity.AddTagsRaw(tags);
		}

		/// <summary>
		/// <para>Adds tags to the entity.</para>
		/// </summary>
		/// <param name="tags"></param>
		protected void Add(params int[] tags)
		{
			entity.AddTagsRaw(tags);
		}

		/// <summary>
		/// <para>Adds the component to the entity. Triggers Setup method on the components inherited from ISetup.</para>
		/// </summary>
		/// <param name="component"></param>
		/// <typeparam name="T"></typeparam>
		protected void Add<T>(T component) where T : IComponent, new()
		{
			Storage<T>.Instance.AddNoCheck(component, entity);
		}

		/// <summary>
		/// <para>Adds the component to the entity by type. Triggers Setup method on the components inherited from ISetup.</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns>Returns created component.</returns>
		protected T Add<T>() where T : IComponent, new()
		{
			var component = Storage<T>.Instance.AddNoCheck(entity);
			return component;
		}

		protected void AddRef<T>() where T : Component
		{
			entity.RefComponent(transform.GetComponent<T>());
		}

		protected void AddRef<T>(string path) where T : Component
		{
			entity.RefComponent(transform.Find(path).GetComponent<T>(), path);
		}

		protected void AddRef<T>(string path, string name) where T : Component
		{
			entity.RefComponent(transform.Find(path).GetComponent<T>(), name);
		}

		#endregion
	}
}