//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 


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
			if (EntityOperations.len == 0) return;

			for (int i = 0; i < EntityOperations.len; i++)
			{
				ref var operation = ref EntityOperations.operations[i];
				var     entityID  = operation.entity.id;

				switch (operation.action)
				{
					case EntityOperations.Action.Add:
					{
						var componentID = operation.arg;
						var storage     = Storage.all[componentID];


						Entity.components[entityID].Add(componentID);


						for (int l = 0; l < storage.lenOfGroups; l++)
						{
							var group = storage.groups[l];
							if (!group.composition.Check(entityID))
								group.actionTryRemove(entityID);
							else
								group.actionInsert(operation.entity);
						}


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

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];

								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.actionTryRemove(entityID);


									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.amount; j++)
						{
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeAction(entityID);
						}

						components.amount = 0;

						if (Entity.transforms.Length > entityID && Entity.transforms[entityID] != null)
						{
							Entity.transforms[entityID].gameObject.Release(Entity.cache[entityID].isPooled ? Pool.Entities : 0);
							Entity.transforms[entityID] = null;
						}

						Entity.tags[entityID].Clear();
						Entity.cache[entityID].isAlive = false;
					  
						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;

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

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.actionTryRemove(entityID);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.amount; j++)
						{
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeAction(entityID);
						}

						components.amount = 0;
						Entity.tags[entityID].Clear();
						Entity.cache[entityID].isAlive = false;
						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;


						break;
					}

					case EntityOperations.Action.Remove:
					{
						var generation = Storage.generations[operation.arg];
						var mask       = Storage.masks[operation.arg];
						var storage    = Storage.all[operation.arg];

						#if UNITY_EDITOR
						if (Entity.components[entityID].amount == 0)
						{
							Debug.LogError($"-> You are trying remove a component from already deleted entity: [{entityID}],   [{storage.componentType}]");
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
								for (int j = tRemoveIndex; j < components.amount - 1; ++j)
									components.ids[j] = components.ids[j + 1];

								components.amount--;

								break;
							}
						}


						for (int l = 0; l < storage.lenOfGroups; l++)
						{
							var group = storage.groups[l];

							if (!group.composition.Check(entityID))
								group.actionTryRemove(entityID);
							else
							{
								var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
								if (inGroup == -1)
									group.actionInsert(operation.entity);
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

						Entity.tags[entityID].Clear();
						Entity.cache[entityID].isAlive = false;
						Entity.Count--;


						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;

						break;
					}

					case EntityOperations.Action.ChangeTag:
					{
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
								group.actionInsert(operation.entity);
							}
							else if (inGroup > -1 && !canBeAdded)
							{
								group.actionRemove(inGroup);
							}
						}

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

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								if (!group.composition.Check(entityID)) continue;
								group.actionInsert(operation.entity);
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
							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								group.actionTryRemove(entityID);
							}
						}

						break;
					}
				}
			}

			EntityOperations.len = 0;
		}

		protected override void OnDispose()
		{
		}
	}
}