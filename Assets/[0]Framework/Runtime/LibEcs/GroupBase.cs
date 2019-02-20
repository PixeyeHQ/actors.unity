/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       5/14/2018  6:32 PM
================================================================*/

using System;
using System.Collections;
using UnityEngine;

namespace Homebrew
{
	public abstract class GroupBase : IEnumerable, IDisposable
	{
		public int length;

		public int[] entities = new int[EngineSettings.MinEntities];
		public Composition composition;


		public Action<int> Add;
		public Action<int> Remove;
		public Action<int, int> TagsChange;

		protected int indexLast;

		internal void TagsHaveChanged(int entity)
		{
			int index = GetIndex(entity);

			if (index == -1)
			{
				if (!entity.Has(composition.include)) return;
				if (entity.HasAny(composition.exclude)) return;

				TryAdd(entity);
			}
			else
			{
				if (TagsChange != null)
					TagsChange(index, entity);

				if (!entity.Has(composition.include) || entity.HasAny(composition.exclude))

					RemoveAt(index);
			}
		}

		public bool Has(int entity)
		{
			for (int i = 0; i < length; i++)
			{
				if (entities[i] != entity) continue;
				return true;
			}

			return false;
		}

		public int GetIndex(int entity)
		{
			for (int i = 0; i < length; i++)
			{
				if (entities[i] != entity) continue;
				return i;
			}

			return -1;
		}

		public int GetEntity(int index) { return entities[index]; }

	//	public MonoEntity GetActor(int entity) { return ProcessingEntities.storage[entity]; }

		public bool CheckTags(int entity)
		{
			if (!entity.Has(composition.include))
				return false;

			return !entity.HasAny(composition.exclude);
		}


		public abstract void TryAdd(int entity);


		internal void OnRemove(int entity)
		{
			int i = GetIndex(entity);
			if (i == -1) return;
			RemoveAt(i);
		}


		public abstract void Populate();
		protected abstract void RemoveAt(int i);


		public void Dispose()
		{
			Add = null;
			Remove = null;
			length = 0;
			entities = new int[EngineSettings.MinEntities];
			OnDispose();
		}

		protected abstract void OnDispose();

		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

		public EntityEnumerator GetEnumerator() { return new EntityEnumerator(entities, length); }


		public T Get<T>() where T : IComponent, new() { return 0.Get<T>(); }
	}

	public struct EntityEnumerator : IEnumerator
	{
		public int[] entities;


		int position;
		private int length;

		public EntityEnumerator(int[] list, int length)
		{
			entities = list;
			position = -1;
			this.length = length;
		}

		public bool MoveNext()
		{
			position++;
			return position < length;
		}

		public void Reset() { position = -1; }

		object IEnumerator.Current => Current;

		public int Current => entities[position];
	}


	public class Group<T> : GroupBase where T : IComponent, new()
	{
		private Storage<T> storage = Storage<T>.Instance;


		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity)) return;


			if (entities.Length <= length)
			{
				int len = length << 1;
				Array.Resize(ref entities, len);
			}


			indexLast = length++;

			entities[indexLast] = entity;

			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);

			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];
				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;


				if (!storage.HasComponent(e.entity)) continue;


				if (length == entities.Length)
				{
					int len = length << 1;
					Array.Resize(ref entities, len);
				}

				int entityID = e.entity;
				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}

		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);


			int l = --length;

			int next = i + 1;
			int size = l - i;


			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}

	public class Group<T, Y> : GroupBase where T : IComponent, new() where Y : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;


		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) || !storage2.HasComponent(entity)) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}


			if (Add != null)
				Add(entity);

			indexLast = length++;
			entities[indexLast] = entity;
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);


			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];
				if (e == null || !e.conditionEnabled) continue;
				
				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;


				if (!storage.HasComponent(e.entity) || !storage2.HasComponent(e.entity)) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}

				int entityID = e.entity;
				indexLast = length++;


				entities[indexLast] = entityID;
			}
		}

		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}

	public class Group<T, Y, U> : GroupBase where T : IComponent, new() where Y : new() where U : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;

		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}

		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity)
			) return;


			if (entities.Length <= length)
			{
				int len = length << 1;
				Array.Resize(ref entities, len);
			}


			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);


			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];
				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;

				int entityID = e.entity;

				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}

				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void OnDispose() { }
	}

	public class Group<T, Y, U, I> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;

		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}

		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}

			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);

			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];
				if (e == null || !e.conditionEnabled) continue;


				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID)
				) continue;


				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}

				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void OnDispose() { }
	}

	public class Group<T, Y, U, I, O> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
			where O : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;
		Storage<O> storage5 = Storage<O>.Instance;


		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity) ||
				!storage5.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = entity == 0 ? EngineSettings.MinComponents : length << 1;

				Array.Resize(ref entities, len);
			}

			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);


			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];

				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;
				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID) ||
					!storage5.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}


				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;

			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}


	public class Group<T, Y, U, I, O, P> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
			where O : new()
			where P : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;
		Storage<O> storage5 = Storage<O>.Instance;
		Storage<P> storage6 = Storage<P>.Instance;


		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity) ||
				!storage5.HasComponent(entity) ||
				!storage6.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}


			if (Add != null)
				Add(entity);

			indexLast = length++;
			entities[indexLast] = entity;
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);

			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];

				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;
				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID) ||
					!storage5.HasComponent(entityID) ||
					!storage6.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}


				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;


			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}


	public class Group<T, Y, U, I, O, P, A> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
			where O : new()
			where P : new()
			where A : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;
		Storage<O> storage5 = Storage<O>.Instance;
		Storage<P> storage6 = Storage<P>.Instance;
		Storage<A> storage7 = Storage<A>.Instance;

		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity) ||
				!storage5.HasComponent(entity) ||
				!storage6.HasComponent(entity) ||
				!storage7.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}

			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);
			storage7.groups.Add(this);

			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];

				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;
				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID) ||
					!storage5.HasComponent(entityID) ||
					!storage6.HasComponent(entityID) ||
					!storage7.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}


				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;


			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}


	public class Group<T, Y, U, I, O, P, A, S> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
			where O : new()
			where P : new()
			where A : new()
			where S : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;
		Storage<O> storage5 = Storage<O>.Instance;
		Storage<P> storage6 = Storage<P>.Instance;
		Storage<A> storage7 = Storage<A>.Instance;
		Storage<S> storage8 = Storage<S>.Instance;

		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity) ||
				!storage5.HasComponent(entity) ||
				!storage6.HasComponent(entity) ||
				!storage7.HasComponent(entity) ||
				!storage8.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}

			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);
			storage7.groups.Add(this);
			storage8.groups.Add(this);

			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];

				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;
				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID) ||
					!storage5.HasComponent(entityID) ||
					!storage6.HasComponent(entityID) ||
					!storage7.HasComponent(entityID) ||
					!storage8.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}


				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;


			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}


	public class Group<T, Y, U, I, O, P, A, S, D> : GroupBase where T : IComponent, new()
			where Y : new()
			where U : new()
			where I : new()
			where O : new()
			where P : new()
			where A : new()
			where S : new()
			where D : new()
	{
		Storage<T> storage = Storage<T>.Instance;
		Storage<Y> storage2 = Storage<Y>.Instance;
		Storage<U> storage3 = Storage<U>.Instance;
		Storage<I> storage4 = Storage<I>.Instance;
		Storage<O> storage5 = Storage<O>.Instance;
		Storage<P> storage6 = Storage<P>.Instance;
		Storage<A> storage7 = Storage<A>.Instance;
		Storage<S> storage8 = Storage<S>.Instance;
		Storage<D> storage9 = Storage<D>.Instance;

		public override void TryAdd(int entity)
		{
			if (!storage.HasComponent(entity) ||
				!storage2.HasComponent(entity) ||
				!storage3.HasComponent(entity) ||
				!storage4.HasComponent(entity) ||
				!storage5.HasComponent(entity) ||
				!storage6.HasComponent(entity) ||
				!storage7.HasComponent(entity) ||
				!storage8.HasComponent(entity) ||
				!storage9.HasComponent(entity)
			) return;

			if (entities.Length <= length)
			{
				int len = length << 1;

				Array.Resize(ref entities, len);
			}

			indexLast = length++;

			entities[indexLast] = entity;


			if (Add != null)
				Add(entity);
		}


		public override void Populate()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);
			storage7.groups.Add(this);
			storage8.groups.Add(this);
			storage9.groups.Add(this);
			for (int i = 0; i < ProcessingEntities.lastID; i++)
			{
				var e = ProcessingEntities.storageActor[i];

				if (e == null || !e.conditionEnabled) continue;

				if (composition.include.Length > 0)
					if (!e.entity.Has(composition.include))
						continue;

				if (composition.exclude.Length > 0)
					if (e.entity.HasAny(composition.exclude))
						continue;
				int entityID = e.entity;
				if (!storage.HasComponent(entityID) ||
					!storage2.HasComponent(entityID) ||
					!storage3.HasComponent(entityID) ||
					!storage4.HasComponent(entityID) ||
					!storage5.HasComponent(entityID) ||
					!storage6.HasComponent(entityID) ||
					!storage7.HasComponent(entityID) ||
					!storage8.HasComponent(entityID) ||
					!storage9.HasComponent(entityID)
				) continue;


				if (length == entities.Length)
				{
					int len = length << 1;

					Array.Resize(ref entities, len);
				}


				indexLast = length++;

				entities[indexLast] = entityID;
			}
		}


		protected override void RemoveAt(int i)
		{
			if (Remove != null)
				Remove(entities[i]);

			int l    = --length;
			int next = i + 1;
			int size = l - i;


			Array.Copy(entities, next, entities, i, size);
		}


		protected override void OnDispose() { }
	}
}