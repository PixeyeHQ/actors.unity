//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System;
using System.Collections;
using Unity.IL2CPP.CompilerServices;

namespace Pixeye
{
	public abstract class GroupBase : IEnumerable, IDisposable
	{
		public int length;
		protected int indexLast;

		public ent[] entities = new ent[EngineSettings.SizeEntities];
		public Composition composition;

		public taskEntity Add;
		public taskEntity Remove;


		public bool Has(int entityID)
		{
			for (int i = 0; i < length; i++)
			{
				if (entities[i].id != entityID) continue;
				return true;
			}

			return false;
		}

		public int GetIndex(int entityID)
		{
			for (int i = 0; i < length; i++)
			{
				if (entities[i] != entityID) continue;
				return i;
			}

			return -1;
		}

		public ent GetEntity(int index)
		{
			return entities[index];
		}

		public abstract void TryAdd(in ent entity);

		public abstract void Initialize();

		protected abstract void RemoveAt(int i);

		internal void TagsHaveChanged(in ent entity)
		{
			int index = GetIndex(entity);

			if (index == -1)
			{
				TryAdd(entity);
			}
			else
			{
				if (!entity.HasRaw(composition.include) || entity.HasAnyRaw(composition.exclude))

					RemoveAt(index);
			}
		}

		internal void OnRemove(in ent entity)
		{
			int i = GetIndex(entity);
			if (i == -1) return;
			RemoveAt(i);
		}

		internal void HandleAddEntity(in ent entity)
		{
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

		public void Dispose()
		{
			Add = null;
			Remove = null;
			length = 0;
			entities = new ent[EngineSettings.SizeEntities];
			OnDispose();
		}

		protected abstract void OnDispose();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public ent this[int index] => entities[index];


		public EntityEnumerator GetEnumerator()
		{
			return new EntityEnumerator(entities, length);
		}

		public struct EntityEnumerator : IEnumerator
		{
			public ent[] entities;


			int position;
			int length;

			public EntityEnumerator(in ent[] list, in int length)
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

			public void Reset()
			{
				position = -1;
			}

			object IEnumerator.Current => Current;

			public ent Current => entities[position];
		}
	}
 
	public class Group<T> : GroupBase where T : IComponent, new()
	{
		Storage<T> storage = Storage<T>.Instance;
		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);

//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//
//				if (!storage.HasComponent(entity)) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//					Array.Resize(ref entities, len);
//				}
//
//				int entityID = entity;
//				indexLast = length++;
//
//				entities[indexLast] = entityID;
//			}
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

		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);


//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//
//				if (!storage.HasComponent(entity) || !storage2.HasComponent(entity)) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//				int entityID = entity;
//				indexLast = length++;
//
//
//				entities[indexLast] = entityID;
//			}
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

		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;


		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;


		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			) return;

			HandleAddEntity(entity);
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


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);


//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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

		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			) return;

			HandleAddEntity(entity);
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


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);

//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity)
//				) continue;
//
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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

		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		int generation5 = Storage<O>.generation;
		int id5 = Storage<O>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			    || !RefEntity.generations[entity, generation5].BitCheck(id5)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);


//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity) ||
//				    !storage5.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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


		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		int generation5 = Storage<O>.generation;
		int id5 = Storage<O>.id;

		int generation6 = Storage<P>.generation;
		int id6 = Storage<P>.id;


		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			    || !RefEntity.generations[entity, generation5].BitCheck(id5)
			    || !RefEntity.generations[entity, generation6].BitCheck(id6)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);

//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity) ||
//				    !storage5.HasComponent(entity) ||
//				    !storage6.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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


		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		int generation5 = Storage<O>.generation;
		int id5 = Storage<O>.id;

		int generation6 = Storage<P>.generation;
		int id6 = Storage<P>.id;

		int generation7 = Storage<A>.generation;
		int id7 = Storage<A>.id;


		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			    || !RefEntity.generations[entity, generation5].BitCheck(id5)
			    || !RefEntity.generations[entity, generation6].BitCheck(id6)
			    || !RefEntity.generations[entity, generation7].BitCheck(id7)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);
			storage7.groups.Add(this);

//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity) ||
//				    !storage5.HasComponent(entity) ||
//				    !storage6.HasComponent(entity) ||
//				    !storage7.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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


		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		int generation5 = Storage<O>.generation;
		int id5 = Storage<O>.id;

		int generation6 = Storage<P>.generation;
		int id6 = Storage<P>.id;

		int generation7 = Storage<A>.generation;
		int id7 = Storage<A>.id;

		int generation8 = Storage<S>.generation;
		int id8 = Storage<S>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			    || !RefEntity.generations[entity, generation5].BitCheck(id5)
			    || !RefEntity.generations[entity, generation6].BitCheck(id6)
			    || !RefEntity.generations[entity, generation7].BitCheck(id7)
			    || !RefEntity.generations[entity, generation8].BitCheck(id8)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
		{
			storage.groups.Add(this);
			storage2.groups.Add(this);
			storage3.groups.Add(this);
			storage4.groups.Add(this);
			storage5.groups.Add(this);
			storage6.groups.Add(this);
			storage7.groups.Add(this);
			storage8.groups.Add(this);

//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity) ||
//				    !storage5.HasComponent(entity) ||
//				    !storage6.HasComponent(entity) ||
//				    !storage7.HasComponent(entity) ||
//				    !storage8.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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

		int generation = Storage<T>.generation;
		int id = Storage<T>.id;

		int generation2 = Storage<Y>.generation;
		int id2 = Storage<Y>.id;

		int generation3 = Storage<U>.generation;
		int id3 = Storage<U>.id;

		int generation4 = Storage<I>.generation;
		int id4 = Storage<I>.id;

		int generation5 = Storage<O>.generation;
		int id5 = Storage<O>.id;

		int generation6 = Storage<P>.generation;
		int id6 = Storage<P>.id;

		int generation7 = Storage<A>.generation;
		int id7 = Storage<A>.id;

		int generation8 = Storage<S>.generation;
		int id8 = Storage<S>.id;

		int generation9 = Storage<D>.generation;
		int id9 = Storage<D>.id;

		public override void TryAdd(in ent entity)
		{
			if (!entity.HasRaw(composition.include))
				return;
			if (entity.HasAnyRaw(composition.exclude))
				return;

			if (!RefEntity.generations[entity, generation].BitCheck(id)
			    || !RefEntity.generations[entity, generation2].BitCheck(id2)
			    || !RefEntity.generations[entity, generation3].BitCheck(id3)
			    || !RefEntity.generations[entity, generation4].BitCheck(id4)
			    || !RefEntity.generations[entity, generation5].BitCheck(id5)
			    || !RefEntity.generations[entity, generation6].BitCheck(id6)
			    || !RefEntity.generations[entity, generation7].BitCheck(id7)
			    || !RefEntity.generations[entity, generation8].BitCheck(id8)
			    || !RefEntity.generations[entity, generation9].BitCheck(id9)
			) return;

			HandleAddEntity(entity);
		}


		public override void Initialize()
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
//			for (ent i = 0; i < ProcessingEntities.lastID; i++)
//			{
//				var e      = EntityReferencesDepr.entityRefs[i];
//				var entity = i; //ProcessingEntities.entities[i];
//
//				if (!e.state.Check(ent.isEnabled)) continue;
//
//				if (composition.include.Length > 0)
//					if (!entity.Has(composition.include))
//						continue;
//
//				if (composition.exclude.Length > 0)
//					if (entity.HasAny(composition.exclude))
//						continue;
//
//				if (!storage.HasComponent(entity) ||
//				    !storage2.HasComponent(entity) ||
//				    !storage3.HasComponent(entity) ||
//				    !storage4.HasComponent(entity) ||
//				    !storage5.HasComponent(entity) ||
//				    !storage6.HasComponent(entity) ||
//				    !storage7.HasComponent(entity) ||
//				    !storage8.HasComponent(entity) ||
//				    !storage9.HasComponent(entity)
//				) continue;
//
//
//				if (length == entities.Length)
//				{
//					int len = length << 1;
//
//					Array.Resize(ref entities, len);
//				}
//
//
//				indexLast = length++;
//
//				entities[indexLast] = entity;
//			}
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