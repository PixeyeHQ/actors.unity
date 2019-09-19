//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 


using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

//todo; refactor ops
namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed unsafe class ProcessorEntities : Processor, ITick
	{
		GroupCore[] groupsChecked = new GroupCore[Entity.settings.SizeProcessors];
		int groupsCheckedLen;

		bool AlreadyChecked(GroupCore group)
		{
			for (int i = 0; i < groupsCheckedLen; i++)
				if (groupsChecked[i].id == group.id)
					return true;

			return false;
		}

		public void Tick(float delta)
		{
			if (!Starter.initialized) return;

			var amount = EntityOperations.len;
			EntityOperations.len = 0;
			for (int i = 0; i < amount; i++)
			{
				ref var operation = ref EntityOperations.operations[i];
				var     entityID  = operation.entity.id;

				switch (operation.action)
				{
					case EntityOperations.Action.Add:
					{
						// var componentID = operation.arg;
						// var storage     = Storage.all[componentID];
						//
						//
						// Entity.components[entityID].Add(componentID);
						//
						//
						// for (int l = 0; l < storage.groupsLen; l++)
						// {
						//  
						// 	var group = storage.groups[l];
						//  
						// 	if (!group.composition.Check(entityID))
						// 	{
						// 	 
						// 		group.TryRemove(entityID);
						// 	}
						// 	else
						// 		group.Insert(operation.entity);
						// }


						break;
					}

					case EntityOperations.Action.Kill:
					{
						ref var components = ref Entity.components[entityID];
						var     length     = components.amount;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation  = Storage.generations[componentID];
							var mask        = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.groupsLen; l++)
							{
								var group = storage.groups[l];

								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);


									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.amount; j++)
						{
							var cID = (int) components.ids[j];


							var str = Storage.all[cID];
							// if (entityID >= str.toDispose.Length)
							// 	Array.Resize(ref str.toDispose, entityID << 1);
							if (str.disposedLen >= str.disposed.Length)
								Array.Resize(ref str.disposed, str.disposedLen << 1);

							str.disposed[str.disposedLen++] = entityID;
						}

						components.amount = 0;

						if (Entity.transforms.Length > entityID && Entity.transforms[entityID] != null)
						{
							Entity.transforms[entityID].gameObject.Release(Entity.cache[entityID].isPooled ? Pool.Entities : 0);
							Entity.transforms[entityID] = null;
						}
						#if !ACTORS_TAGS_0
						Entity.tags[entityID].Clear();
						#endif
						Entity.cache[entityID].isAlive = false;

						// if (ent.entityStack.length >= ent.entityStack.source.Length)
						//  	Array.Resize(ref ent.entityStack.source, ent.entityStack.length << 1);
						// // ent.entityStack.source[ent.entityStack.length++] = operation.entity;
						//
						// var o = operation.entity;
						// Timer.Add(Time.deltaFixed, () => { ent.entityStack.source[ent.entityStack.length++] = o; });

						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.RemoveEntity);
						break;
					}


					case EntityOperations.Action.Unbind:
					{
						ref var components = ref Entity.components[entityID];
						var     length     = components.amount;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation  = Storage.generations[componentID];
							var mask        = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.groupsLen; l++)
							{
								var group = storage.groups[l];
								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.amount; j++)
						{
							var cID = (int) components.ids[j];


							var str = Storage.all[cID];

							if (str.disposedLen >= str.disposed.Length)
								Array.Resize(ref str.disposed, str.disposedLen << 1);

							str.disposed[str.disposedLen++] = entityID;
						}

						components.amount = 0;
						#if !ACTORS_TAGS_0
						Entity.tags[entityID].Clear();
						#endif
						Entity.cache[entityID].isAlive = false;


						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.RemoveEntity);

						break;
					}

					case EntityOperations.Action.RemoveEntity:
					{
						if (ent.entityStack.length >= ent.entityStack.source.Length)
							Array.Resize(ref ent.entityStack.source, ent.entityStack.length << 1);
						ent.entityStack.source[ent.entityStack.length++] = operation.entity;
					}
						break;

					case EntityOperations.Action.Remove:
					{
						var generation = Storage.generations[operation.arg];
						var mask       = Storage.masks[operation.arg];
						var storage    = Storage.all[operation.arg];

						#if UNITY_EDITOR
						if (Entity.components[entityID].amount == 0)
						{
							Debug.LogError($"-> You are trying remove a component from already deleted entity: [{entityID}],   [{storage.GetComponentType()}]");
							continue;
						}
						#endif


						Entity.generations[entityID, generation] &= ~mask;

						ref var components = ref Entity.components[entityID];

						//===============================//
						// Remove Component
						//===============================//
						var typeConverted = (ushort) operation.arg;

						for (int tRemoveIndex = 0; tRemoveIndex < components.amount; tRemoveIndex++)
						{
							if (components.ids[tRemoveIndex] == typeConverted)
							{
								var str = Storage.all[typeConverted];
								// if (entityID >= str.toDispose.Length)
								// 	Array.Resize(ref str.toDispose, entityID << 1);
								// else
								if (str.disposedLen >= str.disposed.Length)
									Array.Resize(ref str.disposed, str.disposedLen << 1);

								str.disposed[str.disposedLen++] = entityID;
								//Storage.all[typeConverted].DisposeAction(entityID);

								for (int j = tRemoveIndex; j < components.amount - 1; ++j)
									components.ids[j] = components.ids[j + 1];

								components.amount--;

								break;
							}
						}


						for (int l = 0; l < storage.groupsLen; l++)
						{
							var group = storage.groups[l];

							if (!group.composition.Check(entityID))
								group.TryRemove(entityID);
							else
							{
								var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
								if (inGroup == -1)
									group.Insert(operation.entity);
							}
						}


						if (components.amount == 0)
							EntityOperations.Set(operation.entity, 0, EntityOperations.Action.Empty);


						break;
					}

					case EntityOperations.Action.Empty:
					{
						if (!operation.entity.Exist) continue;

						if (Entity.transforms.Length > entityID && Entity.transforms[entityID] != null)
						{
							Entity.transforms[entityID].gameObject.Release(Entity.cache[entityID].isPooled ? Pool.Entities : 0);
							Entity.transforms[entityID] = null;
						}
						#if !ACTORS_TAGS_0
						Entity.tags[entityID].Clear();
						#endif
						Entity.cache[entityID].isAlive = false;
						Entity.Count--;


						if (ent.entityStack.length >= ent.entityStack.source.Length)
							Array.Resize(ref ent.entityStack.source, ent.entityStack.length << 1);
						ent.entityStack.source[ent.entityStack.length++] = operation.entity;


						break;
					}

					case EntityOperations.Action.ChangeTag:
					{
						#if !ACTORS_TAGS_0
						if (Entity.components[entityID].amount == 0) continue;

						var groups = HelperTags.inUseGroups.groupStorage[operation.arg]; // op.arg = index

						for (int l = 0; l < groups.len; l++)
						{
							var group = groups.storage[l];


							var canBeAdded = group.composition.Check(entityID);

							var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
							if (inGroup == -1)
							{
								if (!canBeAdded) continue;
								group.Insert(operation.entity);
							}
							else if (inGroup > -1 && !canBeAdded)
							{
								group.Remove(inGroup);
							}
						}
						#endif
						break;
					}

					case EntityOperations.Action.Activate:
					{
						ref var components = ref Entity.components[entityID];


						for (int j = 0; j < components.amount; j++)
						{
							var componentID = components.Get(j);

							var storage = Storage.all[componentID];

							Entity.generations[entityID, Storage.generations[componentID]] |= Storage.masks[componentID];

							for (int l = 0; l < storage.groupsLen; l++)
							{
								var group = storage.groups[l];
								if (!group.composition.Check(entityID)) continue;

								group.Insert(operation.entity);
							}
						}


						break;
					}

					case EntityOperations.Action.Deactivate:
					{
						ref var componenets = ref Entity.components[entityID];
						var     length      = componenets.amount;
						var     storage     = Storage.all[operation.arg];

						for (int j = 0; j < length; j++)
						{
							var componentID = componenets.Get(j);
							var generation  = Storage.generations[componentID];
							var mask        = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							storage = Storage.all[componentID];
							for (int l = 0; l < storage.groupsLen; l++)
							{
								var group = storage.groups[l];
								group.TryRemove(entityID);
							}
						}

						break;
					}
				}
			}


			for (int i = 0; i < GroupCore.allLen; i++)
			{
				var gr = GroupCore.all[i];


				for (int j = 0; j < gr.onRemoveLen; j++)
				{
					gr.onRemove[j].OnRemove(gr.entitiesToRemove, gr.entitiesToRemoveLen);
				}

				gr.entitiesToRemoveLen = 0;


				for (int j = 0; j < gr.onAddLen; j++)
				{
					gr.onAdd[j].OnAdd(gr.entitiesToAdd, gr.entitiesToAddLen);
				}

				gr.entitiesToAddLen = 0;
			}

			for (int i = 0; i < Storage.lastID; i++)
			{
				var st = Storage.all[i];
				st.Dispose();
				st.disposedLen = 0;
			}
		}


		protected override void OnDispose()
		{
		}
	}
}