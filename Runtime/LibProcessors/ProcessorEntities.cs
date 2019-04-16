//  Project : ecs.examples
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	internal sealed class ProcessorEntities : Processor, ITick
	{

		private GroupCore[] groupsToClear = new GroupCore[100];
		private int groupsToClearLen = 0;

		bool CheckIfExists(GroupCore group)
		{
			for (int i = 0; i < groupsToClearLen; i++)
			{
				if (groupsToClear[i].id == group.id) return true;
			}

			return false;
		}

		public void Tick()
		{
			if (!Starter.initialized) return;

			if (Entity.Delayed.len == 0) return;

			for (int i = 0; i < Entity.Delayed.len; i++)
			{
				ref var operation = ref Entity.Delayed.operations[i];

				var entityID = operation.entity.id;

				var components = Storage.all[operation.arg];

				switch (operation.action)
				{
					case Entity.Delayed.Action.Add:
						if (!Entity.isAlive[entityID]) continue;

						var generationAdd = Storage.generations[operation.arg];
						var maskAdd = Storage.masks[operation.arg];

						Entity.generations[entityID, generationAdd] |= maskAdd;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.GroupCoreOfInterest[l];
							var composition = group.composition;
							bool canBeAdded = true;

							for (int ll = 0; ll < composition.ids.Length; ll++)
							{
								generationAdd = composition.generations[ll];
								maskAdd = composition.ids[ll];

								if ((Entity.generations[entityID, generationAdd] & maskAdd) == maskAdd) continue;

								canBeAdded = false;
								break;
							}

							canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
							canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

							if (canBeAdded)
							{
								group.Insert(operation.entity);
								Entity.components[entityID].Add(operation.arg);
							}
						}

						break;

					case Entity.Delayed.Action.Kill:

						ref var componentsToKill = ref Entity.components[entityID];
						var length = componentsToKill.Length;

						for (int j = 0; j < length; j++)
						{
							var componentOnKillId = componentsToKill.GetComponent(j);
							var generationRemoveOnKill = Storage.generations[componentOnKillId];
							var maskRemoveOnKill = Storage.masks[componentOnKillId];

							Entity.generations[entityID, generationRemoveOnKill] &= ~maskRemoveOnKill;

							var storageOnKill = Storage.all[componentOnKillId];

							for (int l = 0; l < storageOnKill.lenOfGroups; l++)
							{
								var group = storageOnKill.GroupCoreOfInterest[l];
								if (!CheckIfExists(group))
								{
									if (group.composition.OverlapComponents(componentsToKill))
									{
										group.TryRemove(entityID);
									}

									if (groupsToClearLen == groupsToClear.Length)
										Array.Resize(ref groupsToClear, groupsToClearLen << 1);

									groupsToClear[groupsToClearLen++] = group;
								}
							}
						}

						groupsToClearLen = 0;

						Entity.components[entityID].Clear();
						Entity.Delayed.Set(operation.entity, 0, Entity.Delayed.Action.KillFinalize);

						break;

					case Entity.Delayed.Action.Remove:

						var generationRemove = Storage.generations[operation.arg];
						var maskRemove = Storage.masks[operation.arg];

						Entity.generations[entityID, generationRemove] &= ~maskRemove;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.GroupCoreOfInterest[l];
							group.TryRemove(entityID);
						}

						Entity.components[entityID].Remove(operation.arg);
						break;

					case Entity.Delayed.Action.ChangeTag:
						if (!Entity.isAlive[entityID]) continue;

						var index = operation.arg;
						var groups = HelperTags.inUseGroups.groups[index];

						for (int l = 0; l < groups.len; l++)
						{
							var group = groups.storage[l];

							var composition = group.composition;
							var canBeAdded = true;

							canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
							canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

							var inGroup = HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);

							if (inGroup == -1 && canBeAdded)
							{
								var generation = Storage.generations[operation.arg];
								var mask = Storage.masks[operation.arg];

								for (int ll = 0; ll < composition.ids.Length; ll++)
								{
									generation = composition.generations[ll];
									mask = composition.ids[ll];

									if ((Entity.generations[entityID, generation] & mask) == mask) continue;
									canBeAdded = false;
									break;
								}

								if (canBeAdded)
									group.Insert(operation.entity);
							}
							else if (inGroup > -1 && !canBeAdded)
							{
								group.Remove(inGroup);
							}
						}

						break;

					case Entity.Delayed.Action.KillFinalize:

						if (Entity.transforms.Length > entityID)
							Entity.transforms[entityID].gameObject.Release(Entity.isPooled[entityID] ? Pool.Entities : 0);

						operation.entity.ClearTags();
						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;

						break;

					case Entity.Delayed.Action.Activate:

						ref var componentsToActivate = ref Entity.components[entityID];
						var lenToActivate = componentsToActivate.Length;

						for (int j = 0; j < lenToActivate; j++)
						{
							ref var component = ref componentsToActivate.GetComponent(j);
							var generationActivate = Storage.generations[component];
							var maskActivate = Storage.masks[component];

							Entity.generations[entityID, generationActivate] |= maskActivate;
							components = Storage.all[component];

							for (int l = 0; l < components.lenOfGroups; l++)
							{
								var group = components.GroupCoreOfInterest[l];
								var composition = group.composition;
								bool canBeAdded = true;

								for (int ll = 0; ll < composition.ids.Length; ll++)
								{
									generationActivate = composition.generations[ll];
									maskActivate = composition.ids[ll];

									if ((Entity.generations[entityID, generationActivate] & maskActivate) == maskActivate) continue;

									canBeAdded = false;
									break;
								}

								canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
								canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

								if (canBeAdded)
								{
									group.Insert(operation.entity);
								}
							}
						}

						break;

					case Entity.Delayed.Action.Deactivate:

						ref var componentsToDeactivate = ref Entity.components[entityID];
						var lenToDeactivate = componentsToDeactivate.Length;

						for (int j = 0; j < lenToDeactivate; j++)
						{
							ref var component = ref componentsToDeactivate.GetComponent(j);
							var generationDeactivate = Storage.generations[component];
							var maskDeactivate = Storage.masks[component];

							Entity.generations[entityID, generationDeactivate] &= ~maskDeactivate;
							components = Storage.all[component];
							for (int l = 0; l < components.lenOfGroups; l++)
							{
								var group = components.GroupCoreOfInterest[l];
								group.TryRemove(entityID);
							}
						}

						break;
				}
			}

			Entity.Delayed.len = 0;
		}

	}
}