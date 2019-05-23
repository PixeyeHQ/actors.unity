//  Project : ecs
// Contacts : Pix - info@pixeye.games
//     Date : 3/7/2019 

using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Framework
{
	[Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
	sealed unsafe class ProcessorEntities : Processor, ITick
	{

		GroupCore[] groupsChecked = new GroupCore[100];
		int groupsCheckedLen;

		bool AlreadyChecked(GroupCore group)
		{
			for (int i = 0; i < groupsCheckedLen; i++) {
				if (groupsChecked[i].id == group.id) return true;
			}

			return false;
		}

		public void Tick(float delta)
		{
			if (!Starter.initialized) return;

			if (Entity.Delayed.len == 0) return;

			for (int i = 0; i < Entity.Delayed.len; i++) {
				ref var operation = ref Entity.Delayed.operations[i];
				var entityID = operation.entity.id;

				switch (operation.action) {
					case Entity.Delayed.Action.Add:
					{
						var componentID = operation.arg;
						var storage = Storage.all[componentID];

						Entity.components[entityID].Add(componentID);

						for (int l = 0; l < storage.lenOfGroups; l++) {
							var group = storage.groups[l];
							var composition = group.composition;
							if (!composition.Check(entityID)) continue;
							group.Insert(operation.entity);
						}

						for (int l = 0; l < storage.lenOfGroupsToRemove; l++) {
							var group = storage.groupsToRemove[l];
							var composition = group.composition;
							if (!composition.CanProceed(entityID)) continue;
							group.TryRemove(entityID);
//							var inGroup = HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
//							if (inGroup > -1) group.Remove(inGroup);
						}
						break;
					}
					case Entity.Delayed.Action.Kill:
					{
						ref var components = ref Entity.components[entityID];
						var length = components.length;

						for (int j = 0; j < length; j++) {
							var componentID = components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++) {
								var group = storage.groups[l];

								if (!AlreadyChecked(group)) {
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.length; j++) {
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeComponent(entityID);
						}

						components.length = 0;

						if (Entity.transforms.Length > entityID && Entity.transforms[entityID] != null)
							Entity.transforms[entityID].gameObject.Release(Entity.isPooled[entityID] ? Pool.Entities : 0);

						Entity.tags[entityID].Clear();

						Entity.Delayed.Set(operation.entity, 0, Entity.Delayed.Action.KillFinalize);
						break;
					}

					case Entity.Delayed.Action.KillFinalize:
					{
						ent.entityStack.Enqueue(operation.entity);
						ent.entityStackLength++;
						break;
					}

					case Entity.Delayed.Action.Unbind:
					{
						ref var components = ref Entity.components[entityID];
						var length = components.length;

						for (int j = 0; j < length; j++) {
							var componentID = components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							var storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++) {
								var group = storage.groups[l];
								if (!AlreadyChecked(group)) {
									if (group.composition.OverlapComponents(components))
										group.TryRemove(entityID);

									if (groupsCheckedLen == groupsChecked.Length)
										Array.Resize(ref groupsChecked, groupsCheckedLen << 1);

									groupsChecked[groupsCheckedLen++] = group;
								}
							}
						}

						groupsCheckedLen = 0;

						for (int j = 0; j < components.length; j++) {
							var cID = (int) components.ids[j];
							Storage.all[cID].DisposeComponent(entityID);
						}

						components.length = 0;
						Entity.tags[entityID].Clear();

						Entity.Delayed.Set(operation.entity, 0, Entity.Delayed.Action.KillFinalize);
						break;
					}

					case Entity.Delayed.Action.Remove:
					{
						var generation = Storage.generations[operation.arg];
						var mask = Storage.masks[operation.arg];
						var storage = Storage.all[operation.arg];

						Entity.generations[entityID, generation] &= ~mask;

						
						
						for (int l = 0; l < storage.lenOfGroups; l++) {
							var group = storage.groups[l];
							group.TryRemove(entityID);
						}

						for (int l = 0; l < storage.lenOfGroupsToRemove; l++) {
							var group = storage.groupsToRemove[l];

							var composition = group.composition;
							if (composition.Check(entityID)) continue;
 
							var inGroup = HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);
							if (inGroup == -1)
								group.Insert(operation.entity);
						}
						ref var components = ref Entity.components[entityID];
						
						
						components.Remove(operation.arg);
//						if (components.length == 0)
//						{
//							Entity.isAlive[entityID] = false;
//							Entity.Delayed.Set(operation.entity, 0, Entity.Delayed.Action.Kill);
//							Entity.entitiesDebugCount--;
//						}
						break;
					}
					case Entity.Delayed.Action.ChangeTag:
					{
						if (!Entity.isAlive[entityID]) continue;

						var index = operation.arg;
						var groups = HelperTags.inUseGroups.groupStorage[index];

						for (int l = 0; l < groups.len; l++) {
							var group = groups.storage[l];

							var composition = group.composition;
							var canBeAdded = composition.CheckTags(entityID);

							var inGroup = HelperArray.BinarySearch(ref group.entities, entityID, 0, group.length);

							if (inGroup == -1 && canBeAdded) {
								group.Insert(operation.entity);
							}
							else if (inGroup > -1 && !canBeAdded) {
								group.Remove(inGroup);
							}
						}
						break;
					}

					case Entity.Delayed.Action.Activate:
					{
						ref var components = ref Entity.components[entityID];
						var length = components.length;

						for (int j = 0; j < length; j++) {
							ref var componentID = ref components.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];
							var storage = Storage.all[operation.arg];
							Entity.generations[entityID, generation] |= mask;
							storage = Storage.all[componentID];

							for (int l = 0; l < storage.lenOfGroups; l++) {
								var group = storage.groups[l];
								var composition = group.composition;
								if (!composition.Check(entityID)) continue;
								group.Insert(operation.entity);
							}
						}
						break;
					}

					case Entity.Delayed.Action.Deactivate:
					{
						ref var componenets = ref Entity.components[entityID];
						var length = componenets.length;
						var storage = Storage.all[operation.arg];

						for (int j = 0; j < length; j++) {
							ref var componentID = ref componenets.Get(j);
							var generation = Storage.generations[componentID];
							var mask = Storage.masks[componentID];

							Entity.generations[entityID, generation] &= ~mask;

							storage = Storage.all[componentID];
							for (int l = 0; l < storage.lenOfGroups; l++) {
								var group = storage.groups[l];
								group.TryRemove(entityID);
							}
						}
						break;
					}
				}
			}
			Entity.Delayed.len = 0;
		}

		protected override void OnDispose() { }

	}
}