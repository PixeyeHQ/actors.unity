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

			if (CoreEntity.Delayed.len == 0) return;

			for (int i = 0; i < CoreEntity.Delayed.len; i++)
			{
				ref var operation = ref CoreEntity.Delayed.operations[i];
				ref var entity = ref operation.entity;
				var entityID = entity.id;
	 
				var components = Storage.all[operation.arg];

				switch (operation.action)
				{
					case CoreEntity.Delayed.Action.Add:
						if (!CoreEntity.isAlive[entityID]) continue;

						var generationAdd = Storage.generations[operation.arg];
						var maskAdd = Storage.masks[operation.arg];

						CoreEntity.generations[entityID, generationAdd] |= maskAdd;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.groupsOfInterest[l];
							var composition = group.composition;
							bool canBeAdded = true;

							for (int ll = 0; ll < composition.ids.Length; ll++)
							{
								generationAdd = composition.generations[ll];
								maskAdd = composition.ids[ll];

								if ((CoreEntity.generations[entityID, generationAdd] & maskAdd) == maskAdd) continue;

								canBeAdded = false;
								break;
							}

							canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
							canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

							if (canBeAdded)
							{
								group.Insert(entity);
								CoreEntity.components[entityID].Add(operation.arg);
							}
						}

						break;

					case CoreEntity.Delayed.Action.Kill:

						ref var componentsToKill = ref CoreEntity.components[entityID];
						var length = componentsToKill.length;

						for (int j = 0; j < length; j++)
						{
							CoreEntity.Delayed.Set(entity, componentsToKill.GetComponent(j), CoreEntity.Delayed.Action.Remove);
						}

						CoreEntity.components[entityID].Clear();
						CoreEntity.Delayed.Set(entity, 0, CoreEntity.Delayed.Action.KillFinalize);

						break;

					case CoreEntity.Delayed.Action.Remove:

						var generationRemove = Storage.generations[operation.arg];
						var maskRemove = Storage.masks[operation.arg];

						CoreEntity.generations[entityID, generationRemove] &= ~maskRemove;

						for (int l = 0; l < components.lenOfGroups; l++)
						{
							var group = components.groupsOfInterest[l];
							group.TryRemove(entityID);
						}

						if (CoreEntity.isAlive[entityID])
							CoreEntity.components[entityID].Remove(operation.arg);
						break;

					case CoreEntity.Delayed.Action.ChangeTag:
						if (!CoreEntity.isAlive[entityID]) continue;

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

									if ((CoreEntity.generations[entityID, generation] & mask) == mask) continue;
									canBeAdded = false;
									break;
								}

								if (canBeAdded)
									group.Insert(entity);
							}
							else if (inGroup > -1 && !canBeAdded)
							{
								group.Remove(inGroup);
							}
						}

						break;

					case CoreEntity.Delayed.Action.KillFinalize:

						if (entityID < CoreEntity.transforms.Length)
						{
							ref var transform = ref CoreEntity.transforms[entityID];
							if (transform != null)
							{
								transform.gameObject.ReleaseEntity(CoreEntity.isPooled[entityID]);
								transform = null;
							}
						}

						entity.ClearTags();
						ent.entityStack.Enqueue(entity);
						ent.entityStackLength++;

						break;

					case CoreEntity.Delayed.Action.Activate:

						ref var componentsToActivate = ref CoreEntity.components[entityID];
						var lenToActivate = componentsToActivate.length;
						for (int j = 0; j < lenToActivate; j++)
						{
							ref var component = ref componentsToActivate.GetComponent(j);
							var generationActivate = Storage.generations[component];
							var maskActivate = Storage.masks[component];

							CoreEntity.generations[entityID, generationActivate] |= maskActivate;
							components = Storage.all[component];
							for (int l = 0; l < components.lenOfGroups; l++)
							{
								var group = components.groupsOfInterest[l];
								var composition = group.composition;
								bool canBeAdded = true;

								for (int ll = 0; ll < composition.ids.Length; ll++)
								{
									generationActivate = composition.generations[ll];
									maskActivate = composition.ids[ll];

									if ((CoreEntity.generations[entityID, generationActivate] & maskActivate) == maskActivate) continue;

									canBeAdded = false;
									break;
								}

								canBeAdded &= composition.tagsToInclude.Length == 0 || composition.Include(entityID);
								canBeAdded &= composition.tagsToExclude.Length == 0 || composition.Exclude(entityID);

								if (canBeAdded)
								{
									group.Insert(entity);
								}
							}
						}

						break;

					case CoreEntity.Delayed.Action.Deactivate:

						ref var componentsToDeactivate = ref CoreEntity.components[entityID];
						var lenToDeactivate = componentsToDeactivate.length;

						for (int j = 0; j < lenToDeactivate; j++)
						{
							ref var component = ref componentsToDeactivate.GetComponent(j);
							var generationDeactivate = Storage.generations[component];
							var maskDeactivate = Storage.masks[component];

							CoreEntity.generations[entityID, generationDeactivate] &= ~maskDeactivate;
							components = Storage.all[component];
							for (int l = 0; l < components.lenOfGroups; l++)
							{
								var group = components.groupsOfInterest[l];
								group.TryRemove(entityID);
							}
						}

						break;
				}
			}

			CoreEntity.Delayed.len = 0;
		}

	}
}