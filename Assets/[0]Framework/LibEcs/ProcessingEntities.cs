/*===============================================================
         Product:    Cryoshock
         Developer:  Dimitry Pixeye - pixeye@hbrew.store
         Company:    Homebrew - http://hbrew.store
         Date:       25/01/2018 00:05
         ================================================================*/


using System;
using System.Collections.Generic;
using UnityEngine;

namespace Homebrew
{
    public class ProcessingEntities : IDisposable
    {
        //  public static List<IStorageType> storageTypes = new List<IStorageType>();
        public static ProcessingEntities Default;

        public GroupBase[] GroupsBase = new GroupBase[64];
        public int groupLength;
        public Group[] GroupsActors = new Group[32];
        public int groupLengthActors;


        public static void Kill(int index)
        {
            Actor.prevID.Push(index);
        }

        public static void Unbind<T>(int index) where T : new()
        {
            Storage<T>.Instance.Remove(index);
        }

        public static void Add(Actor monoActor)
        {
            int len = Actor.entites.Length;
            if (Actor.lastID == len)
                Array.Resize(ref Actor.entites, Actor.lastID << 1);

            if (Actor.prevID.Count > 0)
            {
                monoActor.id = Actor.prevID.Pop();
                Actor.entites[monoActor.id] = monoActor;
            }
            else
            {
                monoActor.id = Actor.lastID;
                Actor.entites[Actor.lastID++] = monoActor;
            }
        }

        public static int Add()
        {
            int id;
            if (Actor.prevID.Count > 0)
            {
                id = Actor.prevID.Pop();
            }
            else

                id = Actor.lastID++;

            return id;
        }


        public GroupBase SetupGroupActors(Type groupType, Composition filter)
        {
            int i = groupLengthActors - 1;

            for (; i >= 0; i--)
            {
                if (GroupsActors[i].composition.Equals(filter))
                {
                    break;
                }
            }

            if (i != -1) return GroupsActors[i];


            var group_ = Activator.CreateInstance(groupType, true) as Group;

            group_.composition = filter;
            group_.Populate();

            if (groupLengthActors == GroupsActors.Length)
            {
                Array.Resize(ref GroupsActors, groupLengthActors << 1);
            }

            GroupsActors[groupLengthActors++] = group_;

            return group_;
        }

        public GroupBase SetupGroup(Type groupType, Composition filter)
        {
            if (groupType == typeof(Group))
            {
                return SetupGroupActors(groupType, filter);
            }

            int i = groupLength - 1;
            for (; i >= 0; i--)
            {
                if (GroupsBase[i].GetType() != groupType) continue;
                if (GroupsBase[i].composition.Equals(filter))
                {
                    break;
                }
            }

            if (i != -1) return GroupsBase[i];

            i = groupLength;

            var group = Activator.CreateInstance(groupType, true) as GroupBase;

            group.composition = filter;


            group.Populate();


            if (groupLength == GroupsBase.Length)
            {
                Array.Resize(ref GroupsBase, groupLength << 1);
            }

            GroupsBase[groupLength++] = group;

            return GroupsBase[i];
        }


        public void CheckGroups(int entityID, bool active)
        {
            if (active)
            {
                for (int i = 0; i < groupLengthActors; i++)
                    if (GroupsBase[i].CheckTags(entityID))
                        GroupsActors[i].TryAdd(entityID);


                for (int i = 0; i < groupLength; i++)
                    if (GroupsBase[i].CheckTags(entityID))
                        GroupsBase[i].TryAdd(entityID);
            }
            else
            {
                for (int i = 0; i < groupLength; i++)
                    GroupsBase[i].Remove(entityID);


                for (int i = 0; i < groupLengthActors; i++)
                    GroupsActors[i].Remove(entityID);
            }
        }

        public void Dispose()
        {
        }
    }
}