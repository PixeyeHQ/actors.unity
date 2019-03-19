//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pixeye
{
	public delegate void taskEntity(ent entity);

	public delegate void taskEntityTick(ent entity, float tick);


	public class ProcEntities : IDisposable, IKernel
	{
		public static ProcEntities Default = new ProcEntities();
		internal static Stack<int> prevID = new Stack<int>(100);
		internal static int lastID;
		internal GroupBase[] GroupsBase = new GroupBase[64];
		internal int groupLength;


		public static int Create()
		{
			int id;
			if (prevID.Count > 0)
			{
				id = prevID.Pop();
			}
			else

				id = lastID++;

			Tags.Add(id);
			return id;
		}

		internal GroupBase SetupGroup(Type groupType, Composition filter)
		{
			int i = groupLength - 1;
			for (; i >= 0; i--)
			{
				if (GroupsBase[i].GetType() != groupType) continue;
				if (GroupsBase[i].composition.Equals(filter))
				{
					break;
				}
			}

			if (i != -1) return GroupsBase[i];
			i = groupLength;
			var group = Activator.CreateInstance(groupType, true) as GroupBase;
			group.composition = filter;
			List<GroupBase> groups;
			foreach (var tag in filter.include)
			{
				if (Tags.groupsInclude.TryGetValue(tag, out groups))
				{
					groups.Add(group);
				}
				else
				{
					groups = new List<GroupBase>(5);
					groups.Add(group);
					Tags.groupsInclude.Add(tag, groups);
				}
			}

			foreach (var tag in filter.exclude)
			{
				if (Tags.groupsDeclude.TryGetValue(tag, out groups))
				{
					groups.Add(group);
				}
				else
				{
					groups = new List<GroupBase>(5);
					groups.Add(group);
					Tags.groupsDeclude.Add(tag, groups);
				}
			}

			group.Initialize();


			if (groupLength == GroupsBase.Length)
			{
				Array.Resize(ref GroupsBase, groupLength << 1);
			}

			GroupsBase[groupLength++] = group;

			return GroupsBase[i];
		}


		public void CheckGroups(in ent entity, bool active)
		{
			if (Toolbox.applicationIsQuitting) return;

			if (active)
			{
				for (int i = 0; i < groupLength; i++)
					GroupsBase[i].TryAdd(entity);
			}
			else
			{
				for (int i = 0; i < groupLength; i++)
					GroupsBase[i].OnRemove(entity);
			}
		}


		public void Dispose()
		{
			for (int i = 0; i < groupLength; i++)
				GroupsBase[i].Dispose();
		}
	}

	public struct EntityComposer
	{
		public ent entity;
		Storage[] storages;
		int length;


		public EntityComposer(int components = 1)
		{
			storages = new Storage[components];
			entity = ProcEntities.Create();

			length = 0;
		}

		public EntityComposer(in ent entity, int components = 1)
		{
			storages = new Storage[components];
			this.entity = entity;
			length = 0;
		}

		public T Add<T>(T component) where T : new()
		{
			var storage = Storage<T>.Instance;
			storages[length++] = storage;
			return Storage<T>.Instance.AddNoCheck(component, entity);
		}

		public T Add<T>() where T : new()
		{
			var storage = Storage<T>.Instance;
			storages[length++] = storage;

			return storage.AddNoCheck(entity);
		}

		public Transform AddReference(Transform transform)
		{
			entity.AddReference(transform);
			return transform;
		}

		public Transform AddReferenceMono(Transform transform)
		{
			entity.AddReferenceMono(transform);
			return transform;
		}

		public void Deploy()
		{
			foreach (var storage in storages)
			{
				storage.Deploy(entity);
			}

			storages = null;
			length = 0;
		}

		public void Deploy(params int[] tags)
		{
			entity.AddTagsRaw(tags);
			Deploy();
		}

		public void Deploy(int tag)
		{
			entity.AddTagsRaw(tag);
			Deploy();
		}
	}
}