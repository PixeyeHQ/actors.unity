//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

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
				var entityID = operation.entity.id;

				switch (operation.action)
				{ 
					case EntityOperations.Action.Add:
					{
					 
			 
						var componentID = operation.arg;
						var storage = Storage.all[componentID];
						var generation = Storage.generations[componentID];
						var mask = Storage.masks[componentID];


						if ((Entity.generations[entityID, generation] & mask) == mask) continue;


							Entity.components[entityID].Add(componentID);
							Entity.generations[entityID, generation] |= mask;

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								if (!group.composition.Check(entityID)) continue;

								group.Insert(operation.entity);
							}

					 
						
						for (int l = 0; l < storage.lenOfGroupsToRemove; l++)
						{
							var group = storage.groupsToRemove[l];
							if (!group.composition.CanProceed(entityID)) continue;
							group.TryRemove(entityID);
						}

 
						break;
					}
					case EntityOperations.Action.Kill:
					{
						ref var components = ref Entity.components[entityID];
						var length = components.length;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];

								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.length; j++)
						{
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeComponent(entityID);
						}

						components.length = 0;

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
						var length = components.length;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								if (!AlreadyChecked(group))
								{
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.length; j++)
						{
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeComponent(entityID);
						}

						components.length = 0;
						Entity.tags[entityID].Clear();

						EntityOperations.Set(operation.entity, 0, EntityOperations.Action.KillFinalize);
						break;
					}

					case EntityOperations.Action.Remove:
					{
						var generation = Storage.generations[operation.arg];
						var mask = Storage.masks[operation.arg];
						var storage = Storage.all[operation.arg];

						Entity.generations[entityID, generation] &= ~mask;

						for (int l = 0; l < storage.lenOfGroups; l++)
						{
							var group = storage.groups[l];
							group.TryRemove(entityID);
						}

						for (int l = 0; l < storage.lenOfGroupsToRemove; l++)
						{
							var group = storage.groupsToRemove[l];

							var composition = group.composition;
							if (composition.Check(entityID)) continue;

							var inGroup = group.length == 0 ? -1 : HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
							if (inGroup == -1)
								group.Insert(operation.entity);
						}
						ref var components = ref Entity.components[entityID];

						components.Remove(operation.arg);

						break;
					}
					case EntityOperations.Action.ChangeTag:
					{
						if (!Entity.cache[entityID].isAlive) continue;

						var index = operation.arg;
						var groups = HelperTags.inUseGroups.groupStorage[index];

						for (int l = 0; l < groups.len; l++)
						{
							var group = groups.storage[l];

							var composition = group.composition;
							var canBeAdded = composition.CheckTags(entityID);

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
						break;
					}

					case EntityOperations.Action.Activate:
					{
				  
						ref var components = ref Entity.components[entityID];
						var length = components.length;

						for (int j = 0; j < length; j++)
						{
							var componentID = components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];
							var storage = Storage.all[operation.arg];
							Entity.generations[entityID, generation] |= mask;
							storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								var composition = group.composition;
								if (!composition.Check(entityID)) continue;
								group.Insert(operation.entity);
							}
						}
 
						break;
					}

					case EntityOperations.Action.Deactivate:
					{
						ref var componenets = ref Entity.components[entityID];
						var length = componenets.length;
						var storage = Storage.all[operation.arg];

						for (int j = 0; j < length; j++)
						{
							var componentID = componenets.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							storage = Storage.all[componentID];
							for (int l = 0; l < storage.lenOfGroups; l++)
							{
								var group = storage.groups[l];
								group.TryRemove(entityID);
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