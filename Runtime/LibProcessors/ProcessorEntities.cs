//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 


using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed unsafe class ProcessorEntities
	{
		static GroupCore[] groupsChecked = new GroupCore[Framework.Settings.SizeGroups];
		static int groupsCheckedLen;

		static bool AlreadyChecked(GroupCore group)
		{
			for (int i = 0; i < groupsCheckedLen; i++)
				if (groupsChecked[i].id == group.id)
					return true;

			return false;
		}


		public static void Tick(float delta)
		{
			if (!Starter.initialized) return;

			for (int i = 0; i < EntityOperations.len; i++)
			{
				ref var operation = ref EntityOperations.operations[i];
				var     entityID  = operation.entity.id;

				if (Toolbox.changingScene) break;


				switch (operation.action)
				{
					case EntityOperations.Action.Add:
					{
						var componentID = operation.arg;
						var generation  = Storage.Generations[componentID];
						var mask        = Storage.Masks[componentID];
						var storage     = Storage.All[componentID];

						Entity.Generations[entityID, generation] |= mask;

						for (int l = 0; l < storage.groups.length; l++)
						{
							var group = storage.groups.Elements[l];
							if (!group.composition.Check(entityID))
								group.TryRemove(entityID);
							else group.Insert(operation.entity);
						}

						#if ACTORS_DEBUG
						Entity.RenameGameobject(operation.entity);
						#endif
					}
						break;


					case EntityOperations.Action.Kill:
					{
					 
						
						ref var entityCache = ref Entity.entities[entityID];

						for (int j = 0; j < entityCache.componentsAmount; j++)
						{
							var componentID = entityCache.componentsIds[j];
							var generation  = Storage.Generations[componentID];
							var mask        = Storage.Masks[componentID];

							Entity.Generations[entityID, generation] &= ~mask;
							Storage.All[entityCache.componentsIds[j]].toDispose.Add(entityID);

							var storage = Storage.All[componentID];

							for (int l = 0; l < storage.groups.length; l++)
							{
								var group = storage.groups.Elements[l];

								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(entityCache))
										group.TryRemove(entityID);


									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen             = 0;
						entityCache.componentsAmount = 0;

						if (!Entity.entities[entityID].isNested && Entity.Transforms.Length > entityID && Entity.Transforms[entityID] != null)
						{
							Entity.Transforms[entityID].gameObject.Release(Entity.entities[entityID].isPooled ? Pool.Entities : 0);
							Entity.Transforms[entityID] = null;
						}
						#if !ACTORS_TAGS_0
						Entity.Tags[entityID].Clear();
						#endif


						if (ent.entStack.length >= ent.entStack.source.Length)
							Array.Resize(ref ent.entStack.source, ent.entStack.length << 1);
						
						unchecked
						{
					   operation.entity.age += 1;
					   Entity.entities[entityID].age += 1;
						}
			 
						ent.entStack.source[ent.entStack.length++] = operation.entity;
						
						Entity.alive.Remove(operation.entity);
						break;
					}

					case EntityOperations.Action.Remove:
					{
						// important check
					  if (!Entity.entities[entityID].isAlive) continue;
						
						var generation = Storage.Generations[operation.arg];
						var mask       = Storage.Masks[operation.arg];
						var storage    = Storage.All[operation.arg];

						#if UNITY_EDITOR
						if (Entity.entities[entityID].componentsAmount == 0)
						{
							Framework.Debugger.Log(LogType.REMOVE_NON_EXISTANT, entityID, storage.GetComponentType().Name);
							continue;
						}
						#endif


						Entity.Generations[entityID, generation] &= ~mask;

						ref var components = ref Entity.entities[entityID];

						//===============================//
						// Remove Component
						//===============================//
						var typeConverted = (ushort) operation.arg;

						for (int tRemoveIndex = 0; tRemoveIndex < components.componentsAmount; tRemoveIndex++)
						{
							if (components.componentsIds[tRemoveIndex] == typeConverted)
							{
								Storage.All[typeConverted].toDispose.Add(entityID);

								for (int j = tRemoveIndex; j < components.componentsAmount - 1; ++j)
									components.componentsIds[j] = components.componentsIds[j + 1];

								components.componentsAmount--;

								break;
							}
						}

						#if ACTORS_DEBUG
						Entity.RenameGameobject(operation.entity);
						#endif


						for (int l = 0; l < storage.groups.length; l++)
						{
							var group = storage.groups.Elements[l];

							if (!group.composition.Check(entityID))
								group.TryRemove(entityID);
							else
							{
								var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length - 1);
								if (inGroup == -1)
									group.Insert(operation.entity);
							}
						}


						if (components.componentsAmount == 0)
						{
						 
							EntityOperations.Set(operation.entity, 0, EntityOperations.Action.Empty);
						}

						break;
					}

					case EntityOperations.Action.Empty:
					{
						if (operation.entity.exist) continue;

						if (!Entity.entities[entityID].isNested && Entity.Transforms.Length > entityID && Entity.Transforms[entityID] != null)
						{
							Entity.Transforms[entityID].gameObject.Release(Entity.entities[entityID].isPooled ? Pool.Entities : 0);
							Entity.Transforms[entityID] = null;
						}
						#if !ACTORS_TAGS_0
						Entity.Tags[entityID].Clear();
						#endif

						//Entity.Count--;


						if (ent.entStack.length >= ent.entStack.source.Length)
							Array.Resize(ref ent.entStack.source, ent.entStack.length << 1);


						unchecked
						{
							operation.entity.age += 1;
							Entity.entities[entityID].age += 1;
						}
						
						ent.entStack.source[ent.entStack.length++] = operation.entity;
						Entity.entities[entityID].isAlive = false;
						Entity.alive.Remove(operation.entity);
						break;
					}

					case EntityOperations.Action.ChangeTag:
					{
						// check if dead 
						if (Entity.entities[entityID].componentsAmount == 0) continue;
						if (!Entity.entities[entityID].isAlive) continue;
						
						var groups = Actors.groups.ByTag.cache[operation.arg];

						for (int l = 0; l < groups.length; l++)
						{
							var group      = groups.Elements[l];
							var canBeAdded = group.composition.Check(entityID);
							var inGroup    = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length-1);
						 
							if (inGroup == -1)
							{
							 	if (!canBeAdded) continue;
								group.Insert(operation.entity);
							}
							else if (!canBeAdded)
							{
								group.Remove(inGroup);
							}
						}

						break;
					}

					case EntityOperations.Action.Activate:
					{
						ref var entityCache = ref Entity.entities[entityID];


						for (int j = 0; j < entityCache.componentsAmount; j++)
						{
							var componentID = entityCache.componentsIds[j];
							var storage     = Storage.All[componentID];
							var generation  = Storage.Generations[componentID];
							var mask        = Storage.Masks[componentID];


							#if UNITY_EDITOR
							if ((Entity.Generations[entityID, generation] & mask) == mask)
							{
								Debug.Log($"{operation.entity.transform}");
								Framework.Debugger.Log(LogType.ALREADY_HAVE, entityID, storage.GetComponentType().Name);
								continue;
							}
							#endif


							Entity.Generations[entityID, Storage.Generations[componentID]] |= Storage.Masks[componentID];


							#if ACTORS_DEBUG
							Entity.RenameGameobject(operation.entity);
							#endif

							for (int l = 0; l < storage.groups.length; l++)
							{
								var group = storage.groups.Elements[l];
								if (!group.composition.Check(entityID)) continue;
								group.Insert(operation.entity);
							}

							Entity.entities[entityID].isDirty = false;
						}


						break;
					}
				}
			}


			if (EntityOperations.len > 0)
			{
				EntityOperations.len = 0;

				for (int i = 0; i < Framework.Processors.length; i++)
					Framework.Processors.storage[i].HandleEvents();

				#if ACTORS_EVENTS_MANUAL
			for (int ii = 0; ii < groups.All.length; ii++)
			{
				var nextGroup = groups.All.Elements[ii];

				if (nextGroup.hasEventRemove)
					nextGroup.removed.length = 0;


				if (nextGroup.hasEventAdd)
					nextGroup.added.length = 0;
			}
				#else
				for (int ii = 0; ii < groups.All.length; ii++)
				{
					var nextGroup = groups.All.Elements[ii];
					nextGroup.removed.length = 0;
					nextGroup.added.length   = 0;
				}
				#endif

				for (int i = 0; i < Storage.lastID; i++)
				{
					var st = Storage.All[i];
					st.Dispose(st.toDispose);
					st.toDispose.length = 0;
				}
			}
		}


		// Executed in processorScenes.load

		internal static void Clean()
		{
			if (Toolbox.applicationIsQuitting) return;

			//	Entity.Count                = 0;
			EntityOperations.len        = 0;
			Framework.Processors.length = 0;

			foreach (ent entity in Entity.alive)
			{
				ref var entityCache = ref Actors.Entity.entities[entity.id];
				ref var tagCache    = ref Actors.Entity.Tags[entity.id];

				tagCache.length = 0;

				for (int i = 0; i < entityCache.componentsAmount; i++)
					Storage.All[entityCache.componentsIds[i]].toDispose.Add(entity.id);

				for (int ii = 0; ii < Framework.Settings.SizeGenerations; ii++)
					Actors.Entity.Generations[entity.id, ii] = 0;

				entityCache.isAlive = false;
				entityCache.componentsAmount = 0;
			}

			Entity.alive.length = 0;
			ent.entStack.length = 0;
			ent.lastID          = 0;
		}
	}
}

//===============================//
// Deprecated
//===============================//

// case EntityOperations.Action.Deactivate:
// {
// 	ref var componenets = ref Entity.entities[entityID];
// 	var     length      = componenets.amount;
// 	var     storage     = Storage.All[operation.arg];
//
// 	for (int j = 0; j < length; j++)
// 	{
// 		var componentID = componenets.Get(j);
// 		var generation  = Storage.Generations[componentID];
// 		var mask        = Storage.Masks[componentID];
//
// 		Entity.Generations[entityID, generation] &= ~mask;
//
// 		storage = Storage.All[componentID];
// 		for (int l = 0; l < storage.Groups.length; l++)
// 		{
// 			var group = storage.Groups.elements[l];
// 			group.TryRemove(entityID);
// 		}
// 	}
//
// 	break;
// }