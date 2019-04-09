//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

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

		[FoldoutGroup("Main")]
		[TagFilter(typeof(Pool))]
		public int pool = -1;

		protected ent entity;

		#if UNITY_EDITOR

		[FoldoutGroup("Main"), SerializeField, ReadOnly]
		protected int _entity;

		#endif

		[FoldoutGroup("Main")]
		public BlueprintEntity blueprint;

		#endregion

		#region METHODS UNITY

		private void Awake()
		{
			if (!Starter.initialized) return;

			Generate();
		}

		private void OnEnable()
		{
			if (Starter.initialized == false) return;

			CoreEntity.isAlive[entity] = true;

			CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.Activate);
		}

		private void OnDisable()
		{
			if (!CoreEntity.isAlive[entity]) return;

			CoreEntity.isAlive[entity] = false;
			CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.Deactivate);
		}

		#endregion

		#region METHODS

		private void Generate()
		{
			entity = ent.Create();
			#if UNITY_EDITOR
			_entity = entity.id;
			#endif

			entity.Add(transform);
			Setup();

			SetupBlueprint();
		}

		public void AwakeAfterStarter()
		{
			Generate();
			CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.Activate);
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
			CoreEntity.components[entity.id].Add(Storage<T>.componentID);
			return entity.AddLater<T>();
		}

		protected void Add<T>(T component) where T : IComponent, new()
		{
			CoreEntity.components[entity.id].Add(Storage<T>.componentID);
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

		private void SetupBlueprint()
		{
			if (blueprint == null)
				return;
			var entityID = entity.id;

			for (int i = 0; i < blueprint.lenOnCreate; i++)
			{
				var component = blueprint.onCreate[i];
				var hash = component.GetType().GetHashCode();
				var storage = Storage.allDict[hash];
				component.Copy(entityID);
				CoreEntity.components[entityID].Add(storage.GetComponentID());
			}

			for (int i = 0; i < blueprint.lenAddLater; i++)
			{
				var component = blueprint.onLater[i];
				component.Copy(entityID);
			}

			entity.AddLater(blueprint.tags);
		}

		#endregion

		public ref readonly ent GetEntity()
		{
			return ref entity;
		}
	 

	}
}