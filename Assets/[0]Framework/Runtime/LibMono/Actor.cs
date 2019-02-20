/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:32 AM
================================================================*/


using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Homebrew
{
	[ExecuteInEditMode]
	public abstract class Actor : MonoEntity, IRequireStarter
	{
		[HideInInspector]
		public int prefabID = -1;

		[FoldoutGroup("Main"), TagFilter(typeof(Pool))]
		public int pool;

		[NonSerialized]
		public bool conditionManualDeploy;

		#region METHODS

		protected virtual void Awake()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{

				#if UNITY_2018_3_OR_NEWER
				bool isPrefabInstance = PrefabUtility.GetCorrespondingObjectFromSource(gameObject) == null;
				#else
				 bool isPrefabInstance = PrefabUtility.GetPrefabObject(gameObject) == null;
			    #endif
				if (isPrefabInstance) return;
				if (prefabID != -1) return;
				var starter = FindObjectOfType<Starter>();
				var o       = Resources.Load<GameObject>("Prefabs/" + gameObject.name);


				prefabID = starter.AddToNode(o, gameObject, pool);
				return;
			}
			#endif

			ProcessingEntities.Create(this);
			conditionManualDeploy = this is IManualDeploy;
			var cObject = Add<ComponentObject>();
			cObject.transform = transform;
			Setup();
		}

		protected abstract void Setup();


		public void SetupAfterStarter()
		{
			if (conditionManualDeploy) return;
			OnEnable();
		}

		public virtual void OnEnable()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				return;
			}
			#endif
			if (Starter.initialized == false) return;
			if (conditionManualDeploy) return;
			conditionEnabled = true;
			ProcessingEntities.Default.CheckGroups(entity, true);
		}

		public virtual void OnDisable()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				return;
			}
			#endif
			conditionEnabled = false;
			ProcessingEntities.Default.CheckGroups(entity, false);
		}

		protected void OnDestroy()
		{
			#if UNITY_EDITOR
			if (!Application.isPlaying)
			{
				var starter = FindObjectOfType<Starter>();
				if (starter == null) return;
				starter.RemoveFromNode(prefabID, gameObject);
				return;
			}
			#endif
			int len = Storage.all.Count;

			for (int j = 0; j < len; j++)
			{
				Storage.all[j].RemoveNoCheck(entity);
			}

			Tags.Clear(entity);
			ProcessingEntities.prevID.Push(entity);
		}

		public override void Release()
		{
			if (pool == Pool.None)
			{
				Destroy(gameObject, 0.03f);
				return;
			}

			gameObject.Release(pool);
		}

		#endregion

		#region ADD/REMOVE

		protected void Add(int tags) { Tags.AddTagsRaw(entity, tags); }

		protected void Add(params int[] tags) { Tags.AddTagsRaw(entity, tags); }

		protected void Add<T>(T component) where T : IComponent, new()
		{
			var setupable = component as ISetup;
			if (setupable != null)
			{
				setupable.Setup(entity);
			}

			Storage<T>.Instance.AddWithNoCheck(component, entity);
		}

		protected T Add<T>() where T : IComponent, new()
		{
			var component = Storage<T>.Instance.GetOrCreate(entity);
			var setupable = component as ISetup;
			if (setupable != null)
			{
				setupable.Setup(entity);
			}

			return component;
		}

		#endregion
	}
}