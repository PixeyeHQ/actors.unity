//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using System;
using Unity.IL2CPP.CompilerServices;


namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed unsafe class ProcessorEntities : Processor, ITick
	{
		GroupCore[] groupsChecked = new GroupCore[256];
		int groupsCheckedLen;

		bool AlreadyChecked(GroupCore group)
		{
			for (int i = 0; i < groupsCheckedLen; i++)
			{
				if (groupsChecked[i].id == group.id) return true;
			}

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
						var generation  = Storage.generations[componentID];
						var mask        = Storage.masks[componentID];


						if ((Entity.generations[entityID, generation] & mask) == mask) continue;


						Entity.components[entityID].Add(componentID);
						Entity.generations[entityID, generation] |= mask;

						for (int l = 0; l < storage.lenOfGroups; l++)
						{
							var group = storage.groups[l];
							if (!group.composition.Check(entityID)) continue;
							group.actionInsert(operation.entity);
						}


						for (int l = 0; l < storage.lenOfGroupsToCheck; l++)
						{
							var group = storage.groupsToCheck[l];
							if (!group.composition.CanProceed(entityID)) continue;
							group.actionTryRemove(entityID);
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

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

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

						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.KillFinalize);
						break;
					}

					case EntityOperations.Action.KillFinalize:
					{
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

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

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

						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.KillFinalize);
						break;
					}

					case EntityOperations.Action.Remove:
					{
						var generation = Storage.generations[operation.arg];
						var mask       = Storage.masks[operation.arg];
						var storage    = Storage.all[operation.arg];

						Entity.generations[entityID, generation] &= ~mask;

						for (int l = 0; l < storage.lenOfGroups; l++)
							storage.groups[l].actionTryRemove(entityID);


						for (int l = 0; l < storage.lenOfGroupsToCheck; l++)
						{
							var group = storage.groupsToCheck[l];

							var composition = group.composition;
							if (composition.Check(entityID)) continue;

							var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch( ref  group.entities, entityID, 0, group.length);
							if (inGroup == -1)
								group.actionInsert(operation.entity);
						}

						ref var components = ref Entity.components[entityID];
						components.Remove(operation.arg);

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

						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.KillFinalize);


						break;
					}

					case EntityOperations.Action.ChangeTag:
					{
						if (!Entity.cache[entityID].isAlive) continue;

						var index  = operation.arg;
						var groups = HelperTags.inUseGroups.groupStorage[index];

						for (int l = 0; l < groups.len; l++)
						{
							var group = groups.storage[l];

							var composition = group.composition;
							var canBeAdded  = composition.Check(entityID);

							var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch( ref  group.entities, entityID, 0, group.length);

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
						var     length     = components.amount;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation  = Storage.generations[componentID];
							var mask        = Storage.masks[componentID];
							var storage     = Storage.all[operation.arg];
							Entity.generations[entityID, generation] |= mask;
							storage                                  =  Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group       = storage.groups[l];
								var composition = group.composition;
								if (!composition.Check(entityID)) continue;
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