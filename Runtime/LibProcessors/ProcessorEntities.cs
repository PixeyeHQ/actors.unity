//  Project : ecs.examples
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	internal sealed class ProcessorEntities : Processor, ITick
	{

		public void Tick()
		{
			if (!Starter.initialized) return;

			if (EntityCore.Delayed.len == 0) return;

			for (int i = 0; i < EntityCore.Delayed.len; i++)
			{
				ref var operation = ref EntityCore.Delayed.operations[i];
			 
				var entityID = operation.entity.id;

				var components = Storage.all[operation.arg];

				switch (operation.action)
				{
					case EntityCore.Delayed.Action.Add:
						if (!EntityCore.isAlive[entityID]) continue;

						var generationAdd = Storage.generations[operation.arg];
						var maskAdd = Storage.masks[operation.arg];

						EntityCore.generations[entityID, generationAdd] |= maskAdd;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.GroupCoreOfInterest[l];
							var composition = group.composition;
							bool canBeAdded = true;

							for (int ll = 0; ll < composition.ids.Length; ll++)
							{
								generationAdd = composition.generations[ll];
								maskAdd = composition.ids[ll];

								if ((EntityCore.generations[entityID, generationAdd] & maskAdd) == maskAdd) continue;

								canBeAdded = false;
								break;
							}

							canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
							canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

							if (canBeAdded)
							{
								group.Insert(operation.entity);
								EntityCore.components[entityID].Add(operation.arg);
							}
						}

						break;

					case EntityCore.Delayed.Action.Kill:

						ref var componentsToKill = ref EntityCore.components[entityID];
						var length = componentsToKill.length;

						for (int j = 0; j < length; j++)
						{
							var c = componentsToKill.GetComponent(j);
							var generationRemoveOnKill = Storage.generations[c];
							var maskRemoveOnKill = Storage.masks[c];

							EntityCore.generations[entityID, generationRemoveOnKill] &= ~maskRemoveOnKill;
							var storages = Storage.all[c];

							for (int l = 0; l < storages.lenOfGroups; l++)
							{
								var group = storages.GroupCoreOfInterest[l];
								group.TryRemove(entityID);
							}
						}

						EntityCore.components[entityID].Clear();
						EntityCore.Delayed.Set(operation.entity, 0, EntityCore.Delayed.Action.KillFinalize);

						break;

					case EntityCore.Delayed.Action.Remove:

						var generationRemove = Storage.generations[operation.arg];
						var maskRemove = Storage.masks[operation.arg];

						EntityCore.generations[entityID, generationRemove] &= ~maskRemove;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.GroupCoreOfInterest[l];
							group.TryRemove(entityID);
						}

						EntityCore.components[entityID].Remove(operation.arg);
						break;

					case EntityCore.Delayed.Action.ChangeTag:
						if (!EntityCore.isAlive[entityID]) continue;

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

									if ((EntityCore.generations[entityID, generation] & mask) == mask) continue;
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

					case EntityCore.Delayed.Action.KillFinalize:

						if (entityID < EntityCore.transforms.Length)
						{
							ref var transform = ref EntityCore.transforms[entityID];
							if (transform != null)
							{
								transform.gameObject.ReleaseEntity(EntityCore.isPooled[entityID]);
								transform = null;
							}
						}

						operation.entity.ClearTags();
						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;

						break;

					case EntityCore.Delayed.Action.Activate:

						ref var componentsToActivate = ref EntityCore.components[entityID];
						var lenToActivate = componentsToActivate.length;

						for (int j = 0; j < lenToActivate; j++)
						{
							ref var component = ref componentsToActivate.GetComponent(j);
							var generationActivate = Storage.generations[component];
							var maskActivate = Storage.masks[component];

							EntityCore.generations[entityID, generationActivate] |= maskActivate;
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

									if ((EntityCore.generations[entityID, generationActivate] & maskActivate) == maskActivate) continue;

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

					case EntityCore.Delayed.Action.Deactivate:

						ref var componentsToDeactivate = ref EntityCore.components[entityID];
						var lenToDeactivate = componentsToDeactivate.length;

						for (int j = 0; j < lenToDeactivate; j++)
						{
							ref var component = ref componentsToDeactivate.GetComponent(j);
							var generationDeactivate = Storage.generations[component];
							var maskDeactivate = Storage.masks[component];

							EntityCore.generations[entityID, generationDeactivate] &= ~maskDeactivate;
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

			EntityCore.Delayed.len = 0;
		}

	}
}