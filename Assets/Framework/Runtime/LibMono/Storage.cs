/*===============================================================
Product:    EntityEngine
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/25/2018 11:49 AM
================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Object = System.Object;

namespace Pixeye
{
	public abstract class Storage
	{
		public static int lastID;
		public static List<Storage> all = new List<Storage>(40);
		public abstract void RemoveNoCheck(int entityID);
		public abstract void Remove(int entityID);
		public abstract void Deploy(in ent entity);
	}

	public class Storage<T> : Storage where T : new()
	{
		public static int id;
		public static int generation;

		public static readonly Storage<T> Instance = new Storage<T>();
		public T[] components = new T[EngineSettings.SizeComponents];
		public bool conditionSetup;


		public List<GroupBase> groups = new List<GroupBase>(3);

		public Storage()
		{
			var idVal = lastID++;
			id = 1 << (idVal % 32);
			generation = idVal / 32;
			all.Add(this);
			var type = typeof(T);
			conditionSetup = type.GetInterface("Homebrew.ISetup") != null;
		}

		public override void Remove(int entityID)
		{
			RefEntity.generations[entityID, generation] &= ~id;
			int len = groups.Count;
			for (int i = 0; i < len; i++)
				groups[i].OnRemove(entityID);
		}

		public override void RemoveNoCheck(int entityID)
		{
			RefEntity.generations[entityID, generation] &= ~id;
		}


		public T TryGet(int entityID)
		{
			return RefEntity.generations[entityID, generation].BitCheck(id) ? components[entityID] : default;
		}

		internal T AddNoCheck(T component, in ent entity)
		{
			if (entity >= components.Length)
			{
				var l = entity << 1;
				Array.Resize(ref components, l);
			}

			components[entity] = component;

			if (conditionSetup)
			{
				var handle = (ISetup) components[entity];
				handle.Setup(entity);
			}

			RefEntity.generations[entity, generation] = RefEntity.generations[entity, generation].BitOn(id);
			return component;
		}

		public T AddNoCheck(in ent entity)
		{
			T val;

			if (entity >= components.Length)
			{
				var l = entity << 1;
				Array.Resize(ref components, l);
			}

			val = components[entity];

			if (val == null)
			{
				val = new T();
				components[entity] = val;
			}

			if (conditionSetup)
			{
				var handle = (ISetup) components[entity];
				handle.Setup(entity);
			}

			RefEntity.generations[entity, generation] = RefEntity.generations[entity, generation].BitOn(id);
			return val;
		}

		internal T Add(T component, in ent entity)
		{
			if (entity >= components.Length)
			{
				var l = entity << 1;
				Array.Resize(ref components, l);
			}

			components[entity] = component;

			if (conditionSetup)
			{
				var handle = (ISetup) components[entity];
				handle.Setup(entity);
			}

			RefEntity.generations[entity, generation] = RefEntity.generations[entity, generation].BitOn(id);


			int len = groups.Count;
			for (int i = 0; i < len; i++)
			{
				var gr = groups[i];

				int index = gr.GetIndex(entity);
				if (index == -1)
				{
					gr.TryAdd(entity);
				}
			}


			return component;
		}

		public T Add(in ent entity)
		{
			T val;

			if (entity >= components.Length)
			{
				var l = entity << 1;
				Array.Resize(ref components, l);
			}

			val = components[entity];

			if (val == null)
			{
				val = new T();
				components[entity] = val;
			}

			if (conditionSetup)
			{
				var handle = (ISetup) components[entity];
				handle.Setup(entity);
			}

			RefEntity.generations[entity, generation] = RefEntity.generations[entity, generation].BitOn(id);

			int len = groups.Count;
			for (int i = 0; i < len; i++)
			{
				var gr = groups[i];

				int index = gr.GetIndex(entity);
				if (index == -1)
				{
					gr.TryAdd(entity);
				}
			}

			return val;
		}

		public override void Deploy(in ent entity)
		{
			int len = groups.Count;

			if (conditionSetup)
			{
				var handle = (ISetup) components[entity];
				handle.Setup(entity);
			}

			for (int i = 0; i < len; i++)
			{
				var gr = groups[i];

				int index = gr.GetIndex(entity);
				if (index == -1)
				{
					gr.TryAdd(entity);
				}
			}
		}

//		public static bool TryGetComponentData(this ent entity, out ComponentData component)
//		{
//			component = Storage<ComponentData>.Instance.TryGet(entity);
//			return component != null;
//		}
//
//		public static bool HasComponentData(this ent entity)
//		{
//			return Storage<ComponentData>.Instance.HasComponent(entity);
//		}

//		internal T AddWithNoCheck(T component, ent entityID)
//		{
//			if (entityID >= components.Length)
//			{
//				var l = entityID << 1;
//
//				Array.Resize(ref components, l);
//				Array.Resize(ref entityHasComponent, l);
//			}
//
//			if (tags != null)
//			{
//				entityID.AddTagsRaw(tags);
//			}
//
//
//			components[entityID] = component;
//			entityHasComponent[entityID] = true;
//
//			return component;
//		}
//
//		public T Add(T component, ent entity)
//		{
//			if (entity >= components.Length)
//			{
//				var l = entity << 1;
//
//				Array.Resize(ref components, l);
//				Array.Resize(ref entityHasComponent, l);
//			}
//
//
//			components[entity] = component;
//			entityHasComponent[entity] = true;
//
//			if (tags != null)
//			{
//				entity.Add(tags);
//			}
//
//
//			int len = groups.Count;
//			for (int i = 0; i < len; i++)
//			{
//				var gr = groups[i];
//
//				if (gr.CheckTags(entity))
//				{
//					gr.TryAdd(entity);
//				}
//			}
//
//
//			return component;
//		}
//
//		public T Add(ent entity)
//		{
//			if (entity >= components.Length)
//			{
//				var l = entity << 1;
//
//				Array.Resize(ref components, l);
//				Array.Resize(ref entityHasComponent, l);
//			}
//
//			if (entityHasComponent[entity]) return components[entity];
//
//			if (components[entity] == null)
//				components[entity] = new T();
//
//			if (tags != null)
//			{
//				entity.Add(tags);
//			}
//
//			entityHasComponent[entity] = true;
//
//			int len = groups.Count;
//			for (int i = 0; i < len; i++)
//			{
//				var gr = groups[i];
//
//				if (gr.CheckTags(entity))
//				{
//					gr.TryAdd(entity);
//				}
//			}
//
//
//			return components[entity];
//		}
//
//		T Create(ent entity)
//		{
//			components[entity] = new T();
//			entityHasComponent[entity] = true;
//
//			if (tags != null)
//			{
//				entity.AddTagsRaw(tags);
//			}
//
//
//			return components[entity];
//		}
//
//		T CreateAndResize(ent entity)
//		{
//			var l = entity << 1;
//			Array.Resize(ref components, l);
//			Array.Resize(ref entityHasComponent, l);
//
//			components[entity] = new T();
//			entityHasComponent[entity] = true;
//
//			if (tags != null)
//			{
//				entity.AddTagsRaw(tags);
//			}
//
//
//			return components[entity];
//		}
//
//

//
//		public override void RemoveNoCheck(ent entity)
//		{
//			if (Toolbox.applicationIsQuitting) return;
//			if (entity >= entityHasComponent.Length) return;
//			if (!entityHasComponent[entity]) return;
//
//			entityHasComponent[entity] = false;
//
//			if (tags != null)
//				entity.RemoveTagsRaw(tags);
//		}
//
//
//		public override void Deploy(ent entity)
//		{
//			int len = groups.Count;
//
////			if (conditionSingle)
////			{
////				entity = 0;
////			}
//
//			if (requireSetup)
//			{
//				var handle = (ISetup) components[entity];
//				handle.Setup(entity);
//			}
//
//			if (tags != null)
//			{
//				foreach (var tag in tags)
//				{
//					Tags.HandleChange(entity, tag);
//				}
//			}
//
//			if (!entity.CheckMonoConditions()) return;
//
//			for (int i = 0; i < len; i++)
//			{
//				var gr = groups[i];
//
//				int index = gr.GetIndex(entity);
//				if (index == -1)
//				{
//					if (gr.CheckTags(entity))
//					{
//						gr.TryAdd(entity);
//					}
//				}
//			}
//		}
//
//
//		public override bool HasComponent(ent entity)
//		{
//			return entity >= components.Length ? false : entityHasComponent[entity];
//		}
//
//		public T TryGet(ent entity)
//		{
//			return entity >= components.Length || !entityHasComponent[entity] ? default(T) : components[entity];
//		}
//
//		public T GetOrCreate(ent entity)
//		{
////			if (conditionSingle)
////			{
////				entity = 0;
////			}
//
//			if (entity >= components.Length)
//			{
//				return CreateAndResize(entity);
//			}
//
//			if (components[entity] == null)
//			{
//				return Create(entity);
//			}
//
//			if (!entityHasComponent[entity])
//			{
//				entityHasComponent[entity] = true;
//
//				if (tags != null)
//				{
//					entity.AddTagsRaw(tags);
//				}
//			}
//
//			return components[entity];
//		}
		//	public override void Deploy(ent entity) { }
	}
}